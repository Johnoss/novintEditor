using NovintItemEditor.Properties;
using NovintItemEditor.Structure.Items;
using NovintItemEditor.Structure.JsonParsing;
using NovintItemEditor.Structure.Stories;
using NovintItemEditor.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace NovintItemEditor
{
    public partial class ItemEditorForm : Form
    {
        private readonly ItemCollection _items;
        private Story _story;

        private List<Item> Items => _items.Items;

        private int _lastSelected = 0;

        private Item SelectedItem => Items[_lastSelected];
        private int LastListIndex => Items.Count() - 1;
        private int SelectedItemId => _lastSelected + 1;
        private bool StoryExists => _story != null;
        private bool SelectedItemLocked => _items.LockedItems.Contains(_lastSelected);

        public ItemEditorForm()
        {
            _items = ItemsParser.ParseItems();

            InitializeComponent();

            RefreshListView();

            RenderStory();
            RefreshSelectedIndex();
            SerializeEntries();

            UpdateSaveButton();
        }

        #region Items List

        private void RefreshListView()
        {
            ListBoxItems.BeginUpdate();
            ListBoxItems.Items.Clear();
            foreach (var item in Items)
            {
                ListBoxItems.Items.Add($"[{item.ItemId}] {item.Name}");
            }
            ListBoxItems.EndUpdate();
            RefreshSelectedIndex();
            RefreshButtons();
            RenderEditItem();
        }

        private void RefreshSelectedIndex()
        {
            ListBoxItems.SelectedIndex = Math.Min(Math.Max(0, _lastSelected), LastListIndex);
        }

        private void RefreshButtons()
        {
            ButtonDeleteEntry.Enabled = !SelectedItemLocked;
        }

        private void SerializeEntries()
        {
            ItemsParser.SerializeItems(_items);
            RefreshListView();
        }

        private void AddEntry()
        {
            var item = new Item
            {
                ItemId = 0,
                Name = "New Item",
                IconFilename = $"{RandomUtil.RandomString()}.png",
                IsUnique = false,
                BypassesRequirements = false
            };
            _items.AddItem(item);
            RefreshListView();
        }

        private void DeleteEntry()
        {
            _items.RemoveItem(SelectedItemId);
            RefreshListView();
        }

        private void UpdateSelectedIndex()
        {
            _lastSelected = Math.Max(0, ListBoxItems.SelectedIndex);
            RenderEditItem();
        }

        #endregion

        #region Selected Item

        private void RenderEditItem()
        {
            CheckBoxBypassesRequirements.Enabled = !SelectedItemLocked;
            CheckBoxIsUnique.Enabled = !SelectedItemLocked;

            LabelID.Text = $"Item ID: {SelectedItem.ItemId}";

            TextBoxName.Text = SelectedItem.Name;

            CheckBoxIsUnique.CheckedChanged -= CheckBoxIsUnique_CheckedChanged;

            CheckBoxIsUnique.Checked = SelectedItem.IsUnique;
            CheckBoxBypassesRequirements.Checked = SelectedItem.BypassesRequirements;
            if (File.Exists(FileUtils.GetIconPath(SelectedItem)))
            {
                var image = Image.FromFile(FileUtils.GetIconPath(SelectedItem));
                PictureBoxIcon.Image = image;
            }
            else
            {
                PictureBoxIcon.Image = null;
            }

            CheckBoxIsUnique.CheckedChanged += CheckBoxIsUnique_CheckedChanged;
        }

        private void OpenIcon()
        {
            OpenImageFileDialog.Filter = "PNG Files(*.png;)|*.png;";
            if (OpenImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = OpenImageFileDialog.FileName;

                    if (!Directory.Exists(FileUtils.IconsFolderPath))
                    {
                        Directory.CreateDirectory(FileUtils.IconsFolderPath);
                    }

                    File.Copy(filePath, FileUtils.GetIconPath(SelectedItem), true);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to open file " + exception.Message);
                }

                RenderEditItem();
            }
        }

        private void UpdateText()
        {
            SelectedItem.Name = TextBoxName.Text;
            SerializeEntries();
        }

        private void UpdateIsUnique()
        {
            SelectedItem.IsUnique = CheckBoxIsUnique.Checked;
            SerializeEntries();
        }

        private void UpdateBypassesRequirements()
        {
            SelectedItem.BypassesRequirements = CheckBoxBypassesRequirements.Checked;
            SerializeEntries();
        }

        #endregion

        #region Images

        private static void OpenImagesFolder()
        {
            var directoryPath = FileUtils.ImagesFolderPath;
            Process.Start(directoryPath);
        }

        #endregion

        #region Story


        private void OpenStory()
        {
            OpenStoryFileDialog.Filter = "JSON Files(*.json;)|*.json;";
            if (OpenStoryFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var filePath = OpenStoryFileDialog.FileName;

                if (!Directory.Exists(FileUtils.BaseArchiveFolderPath))
                {
                    Directory.CreateDirectory(FileUtils.BaseArchiveFolderPath);
                }

                File.Copy(filePath, FileUtils.StoryJsonPath, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to open file " + exception.Message);
            }

            RenderStory();
            UpdateSaveButton();
        }

        private void UpdateSaveButton()
        {
            ButtonSaveArchive.Enabled = _story != null;
        }

        private void RenderStory()
        {
            _story = StoryParser.ParseStory();
            var storyExists = _story != null;
            PictureBoxStoryValid.Image = storyExists
                ? Resources.Checkmark
                : Resources.RedCross;

            PanelStoryDetails.Visible = storyExists;

            if (storyExists)
            {
                LabelStoryName.Text = $"Name: {_story.Name}";
                LabelPassagesCount.Text = $"Passages: {_story.PassagesAmount}";
                LabelFirstPassage.Text = $"First Passage: {_story.FirstPassage}";
            }
        }

        #endregion

        #region Output

        private void SaveArchive()
        {
            if(!StoryExists)
            {
                throw new Exception("Story doesn't exist");
            }

            var filePath = FileUtils.GetArchiveFilePath(_story);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            ZipFile.CreateFromDirectory(FileUtils.BaseArchiveFolderPath, filePath);

            string argument = "/select, \"" + filePath + "\"";
            Process.Start("explorer.exe", argument);
        }

        #endregion

        #region Events

        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void ButtonDeleteEntry_Click(object sender, EventArgs e)
        {
            DeleteEntry();
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedIndex();
        }

        private void ButtonOpenIcon_Click(object sender, EventArgs e)
        {
            OpenIcon();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void CheckBoxIsUnique_CheckedChanged(object sender, EventArgs e)
        {
            UpdateIsUnique();
        }

        private void CheckBoxBypassesRequirements_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBypassesRequirements();
        }

        private void ButtonOpenImagesFolder_Click(object sender, EventArgs e)
        {
            OpenImagesFolder();
        }

        private void ButtonUploadStory_Click(object sender, EventArgs e)
        {
            OpenStory();
        }

        private void ButtonSaveArchive_Click(object sender, EventArgs e)
        {
            SaveArchive();
        }
        #endregion
    }
}
