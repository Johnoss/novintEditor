namespace NovintItemEditor
{
    partial class ItemEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TabItemEditor = new System.Windows.Forms.TabPage();
            this.GroupBoxEdit = new System.Windows.Forms.GroupBox();
            this.LabelIcon = new System.Windows.Forms.Label();
            this.ButtonOpenIcon = new System.Windows.Forms.Button();
            this.CheckBoxBypassesRequirements = new System.Windows.Forms.CheckBox();
            this.CheckBoxIsUnique = new System.Windows.Forms.CheckBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.GroupBoxList = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteEntry = new System.Windows.Forms.Button();
            this.ButtonAddEntry = new System.Windows.Forms.Button();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabImages = new System.Windows.Forms.TabPage();
            this.ButtonOpenImagesFolder = new System.Windows.Forms.Button();
            this.LabelImagesInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxStoryValid = new System.Windows.Forms.PictureBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonUploadStory = new System.Windows.Forms.Button();
            this.GroupBoxStory = new System.Windows.Forms.GroupBox();
            this.PanelStoryDetails = new System.Windows.Forms.Panel();
            this.LabelStoryName = new System.Windows.Forms.Label();
            this.LabelFirstPassage = new System.Windows.Forms.Label();
            this.LabelPassagesCount = new System.Windows.Forms.Label();
            this.OpenStoryFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSaveArchive = new System.Windows.Forms.Button();
            this.TabItemEditor.SuspendLayout();
            this.GroupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.GroupBoxList.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.TabImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStoryValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.GroupBoxStory.SuspendLayout();
            this.PanelStoryDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImageFileDialog
            // 
            this.OpenImageFileDialog.FileName = "openFileDialog1";
            // 
            // TabItemEditor
            // 
            this.TabItemEditor.Controls.Add(this.GroupBoxEdit);
            this.TabItemEditor.Controls.Add(this.GroupBoxList);
            this.TabItemEditor.Location = new System.Drawing.Point(4, 22);
            this.TabItemEditor.Name = "TabItemEditor";
            this.TabItemEditor.Padding = new System.Windows.Forms.Padding(3);
            this.TabItemEditor.Size = new System.Drawing.Size(621, 578);
            this.TabItemEditor.TabIndex = 1;
            this.TabItemEditor.Text = "Item Editor";
            this.TabItemEditor.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEdit
            // 
            this.GroupBoxEdit.Controls.Add(this.LabelIcon);
            this.GroupBoxEdit.Controls.Add(this.ButtonOpenIcon);
            this.GroupBoxEdit.Controls.Add(this.CheckBoxBypassesRequirements);
            this.GroupBoxEdit.Controls.Add(this.CheckBoxIsUnique);
            this.GroupBoxEdit.Controls.Add(this.TextBoxName);
            this.GroupBoxEdit.Controls.Add(this.LabelName);
            this.GroupBoxEdit.Controls.Add(this.LabelID);
            this.GroupBoxEdit.Controls.Add(this.PictureBoxIcon);
            this.GroupBoxEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupBoxEdit.Location = new System.Drawing.Point(266, 3);
            this.GroupBoxEdit.Name = "GroupBoxEdit";
            this.GroupBoxEdit.Size = new System.Drawing.Size(352, 572);
            this.GroupBoxEdit.TabIndex = 6;
            this.GroupBoxEdit.TabStop = false;
            this.GroupBoxEdit.Text = "Edit Item";
            // 
            // LabelIcon
            // 
            this.LabelIcon.AutoSize = true;
            this.LabelIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIcon.Location = new System.Drawing.Point(12, 234);
            this.LabelIcon.Name = "LabelIcon";
            this.LabelIcon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelIcon.Size = new System.Drawing.Size(44, 20);
            this.LabelIcon.TabIndex = 13;
            this.LabelIcon.Text = "Icon:";
            this.LabelIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonOpenIcon
            // 
            this.ButtonOpenIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenIcon.Location = new System.Drawing.Point(126, 257);
            this.ButtonOpenIcon.Name = "ButtonOpenIcon";
            this.ButtonOpenIcon.Size = new System.Drawing.Size(96, 85);
            this.ButtonOpenIcon.TabIndex = 12;
            this.ButtonOpenIcon.Text = "Open Image...";
            this.ButtonOpenIcon.UseVisualStyleBackColor = true;
            this.ButtonOpenIcon.Click += new System.EventHandler(this.ButtonOpenIcon_Click);
            // 
            // CheckBoxBypassesRequirements
            // 
            this.CheckBoxBypassesRequirements.AutoSize = true;
            this.CheckBoxBypassesRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxBypassesRequirements.Location = new System.Drawing.Point(16, 172);
            this.CheckBoxBypassesRequirements.Name = "CheckBoxBypassesRequirements";
            this.CheckBoxBypassesRequirements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxBypassesRequirements.Size = new System.Drawing.Size(201, 24);
            this.CheckBoxBypassesRequirements.TabIndex = 11;
            this.CheckBoxBypassesRequirements.Text = "Bypasses Requirements";
            this.CheckBoxBypassesRequirements.UseVisualStyleBackColor = true;
            this.CheckBoxBypassesRequirements.CheckedChanged += new System.EventHandler(this.CheckBoxBypassesRequirements_CheckedChanged);
            // 
            // CheckBoxIsUnique
            // 
            this.CheckBoxIsUnique.AutoSize = true;
            this.CheckBoxIsUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxIsUnique.Location = new System.Drawing.Point(16, 142);
            this.CheckBoxIsUnique.Name = "CheckBoxIsUnique";
            this.CheckBoxIsUnique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxIsUnique.Size = new System.Drawing.Size(96, 24);
            this.CheckBoxIsUnique.TabIndex = 10;
            this.CheckBoxIsUnique.Text = "Is Unique";
            this.CheckBoxIsUnique.UseVisualStyleBackColor = true;
            this.CheckBoxIsUnique.CheckedChanged += new System.EventHandler(this.CheckBoxIsUnique_CheckedChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(16, 111);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(127, 26);
            this.TextBoxName.TabIndex = 9;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(12, 88);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelName.Size = new System.Drawing.Size(55, 20);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name:";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.Location = new System.Drawing.Point(6, 28);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(113, 25);
            this.LabelID.TabIndex = 3;
            this.LabelID.Text = "Item Id: {0}";
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Location = new System.Drawing.Point(16, 257);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(95, 85);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIcon.TabIndex = 5;
            this.PictureBoxIcon.TabStop = false;
            // 
            // GroupBoxList
            // 
            this.GroupBoxList.AutoSize = true;
            this.GroupBoxList.Controls.Add(this.ButtonDeleteEntry);
            this.GroupBoxList.Controls.Add(this.ButtonAddEntry);
            this.GroupBoxList.Controls.Add(this.ListBoxItems);
            this.GroupBoxList.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxList.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxList.Name = "GroupBoxList";
            this.GroupBoxList.Size = new System.Drawing.Size(260, 572);
            this.GroupBoxList.TabIndex = 2;
            this.GroupBoxList.TabStop = false;
            this.GroupBoxList.Text = "Items";
            // 
            // ButtonDeleteEntry
            // 
            this.ButtonDeleteEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteEntry.Location = new System.Drawing.Point(132, 521);
            this.ButtonDeleteEntry.Name = "ButtonDeleteEntry";
            this.ButtonDeleteEntry.Size = new System.Drawing.Size(121, 45);
            this.ButtonDeleteEntry.TabIndex = 7;
            this.ButtonDeleteEntry.Text = "Delete Item";
            this.ButtonDeleteEntry.UseVisualStyleBackColor = true;
            this.ButtonDeleteEntry.Click += new System.EventHandler(this.ButtonDeleteEntry_Click);
            // 
            // ButtonAddEntry
            // 
            this.ButtonAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddEntry.Location = new System.Drawing.Point(6, 521);
            this.ButtonAddEntry.Name = "ButtonAddEntry";
            this.ButtonAddEntry.Size = new System.Drawing.Size(120, 45);
            this.ButtonAddEntry.TabIndex = 6;
            this.ButtonAddEntry.Text = "Add Item";
            this.ButtonAddEntry.UseVisualStyleBackColor = true;
            this.ButtonAddEntry.Click += new System.EventHandler(this.ButtonAddEntry_Click);
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.ItemHeight = 20;
            this.ListBoxItems.Location = new System.Drawing.Point(3, 16);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(254, 484);
            this.ListBoxItems.TabIndex = 5;
            this.ListBoxItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxItems_SelectedIndexChanged);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMain.Controls.Add(this.TabItemEditor);
            this.TabControlMain.Controls.Add(this.TabImages);
            this.TabControlMain.Location = new System.Drawing.Point(12, 12);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(629, 604);
            this.TabControlMain.TabIndex = 7;
            // 
            // TabImages
            // 
            this.TabImages.Controls.Add(this.ButtonOpenImagesFolder);
            this.TabImages.Controls.Add(this.LabelImagesInfo);
            this.TabImages.Location = new System.Drawing.Point(4, 22);
            this.TabImages.Name = "TabImages";
            this.TabImages.Padding = new System.Windows.Forms.Padding(3);
            this.TabImages.Size = new System.Drawing.Size(621, 578);
            this.TabImages.TabIndex = 2;
            this.TabImages.Text = "Images";
            this.TabImages.UseVisualStyleBackColor = true;
            // 
            // ButtonOpenImagesFolder
            // 
            this.ButtonOpenImagesFolder.Location = new System.Drawing.Point(23, 60);
            this.ButtonOpenImagesFolder.Name = "ButtonOpenImagesFolder";
            this.ButtonOpenImagesFolder.Size = new System.Drawing.Size(253, 23);
            this.ButtonOpenImagesFolder.TabIndex = 1;
            this.ButtonOpenImagesFolder.Text = "Open Images Folder...";
            this.ButtonOpenImagesFolder.UseVisualStyleBackColor = true;
            this.ButtonOpenImagesFolder.Click += new System.EventHandler(this.ButtonOpenImagesFolder_Click);
            // 
            // LabelImagesInfo
            // 
            this.LabelImagesInfo.AutoSize = true;
            this.LabelImagesInfo.Location = new System.Drawing.Point(20, 20);
            this.LabelImagesInfo.Name = "LabelImagesInfo";
            this.LabelImagesInfo.Size = new System.Drawing.Size(256, 26);
            this.LabelImagesInfo.TabIndex = 0;
            this.LabelImagesInfo.Text = "Copy all images with an \'img:\' tag in an Images folder.\nMake sure the filename ma" +
    "tch the name in the tag.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Story Uploaded";
            // 
            // PictureBoxStoryValid
            // 
            this.PictureBoxStoryValid.Image = global::NovintItemEditor.Properties.Resources.RedCross;
            this.PictureBoxStoryValid.InitialImage = global::NovintItemEditor.Properties.Resources.RedCross;
            this.PictureBoxStoryValid.Location = new System.Drawing.Point(10, 36);
            this.PictureBoxStoryValid.Name = "PictureBoxStoryValid";
            this.PictureBoxStoryValid.Size = new System.Drawing.Size(23, 20);
            this.PictureBoxStoryValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStoryValid.TabIndex = 8;
            this.PictureBoxStoryValid.TabStop = false;
            // 
            // ButtonUploadStory
            // 
            this.ButtonUploadStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadStory.Location = new System.Drawing.Point(6, 67);
            this.ButtonUploadStory.Name = "ButtonUploadStory";
            this.ButtonUploadStory.Size = new System.Drawing.Size(263, 66);
            this.ButtonUploadStory.TabIndex = 9;
            this.ButtonUploadStory.Text = "Upload Story...";
            this.ButtonUploadStory.UseVisualStyleBackColor = true;
            this.ButtonUploadStory.Click += new System.EventHandler(this.ButtonUploadStory_Click);
            // 
            // GroupBoxStory
            // 
            this.GroupBoxStory.Controls.Add(this.PanelStoryDetails);
            this.GroupBoxStory.Controls.Add(this.label1);
            this.GroupBoxStory.Controls.Add(this.ButtonUploadStory);
            this.GroupBoxStory.Controls.Add(this.PictureBoxStoryValid);
            this.GroupBoxStory.Location = new System.Drawing.Point(647, 34);
            this.GroupBoxStory.Name = "GroupBoxStory";
            this.GroupBoxStory.Size = new System.Drawing.Size(275, 493);
            this.GroupBoxStory.TabIndex = 10;
            this.GroupBoxStory.TabStop = false;
            this.GroupBoxStory.Text = "Story";
            // 
            // PanelStoryDetails
            // 
            this.PanelStoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStoryDetails.Controls.Add(this.LabelStoryName);
            this.PanelStoryDetails.Controls.Add(this.LabelFirstPassage);
            this.PanelStoryDetails.Controls.Add(this.LabelPassagesCount);
            this.PanelStoryDetails.Location = new System.Drawing.Point(6, 146);
            this.PanelStoryDetails.Name = "PanelStoryDetails";
            this.PanelStoryDetails.Size = new System.Drawing.Size(263, 341);
            this.PanelStoryDetails.TabIndex = 11;
            // 
            // LabelStoryName
            // 
            this.LabelStoryName.AutoSize = true;
            this.LabelStoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStoryName.Location = new System.Drawing.Point(3, 11);
            this.LabelStoryName.MaximumSize = new System.Drawing.Size(250, 0);
            this.LabelStoryName.Name = "LabelStoryName";
            this.LabelStoryName.Size = new System.Drawing.Size(78, 20);
            this.LabelStoryName.TabIndex = 0;
            this.LabelStoryName.Text = "Name: {0}";
            // 
            // LabelFirstPassage
            // 
            this.LabelFirstPassage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFirstPassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstPassage.Location = new System.Drawing.Point(3, 71);
            this.LabelFirstPassage.Name = "LabelFirstPassage";
            this.LabelFirstPassage.Size = new System.Drawing.Size(257, 253);
            this.LabelFirstPassage.TabIndex = 10;
            this.LabelFirstPassage.Text = "FirstPassage:";
            // 
            // LabelPassagesCount
            // 
            this.LabelPassagesCount.AutoSize = true;
            this.LabelPassagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassagesCount.Location = new System.Drawing.Point(3, 38);
            this.LabelPassagesCount.MaximumSize = new System.Drawing.Size(250, 0);
            this.LabelPassagesCount.Name = "LabelPassagesCount";
            this.LabelPassagesCount.Size = new System.Drawing.Size(162, 20);
            this.LabelPassagesCount.TabIndex = 1;
            this.LabelPassagesCount.Text = "PassagesAmount: {0}";
            // 
            // OpenStoryFileDialog
            // 
            this.OpenStoryFileDialog.FileName = "OpenStoryFileDIalog";
            // 
            // ButtonSaveArchive
            // 
            this.ButtonSaveArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveArchive.Location = new System.Drawing.Point(647, 533);
            this.ButtonSaveArchive.Name = "ButtonSaveArchive";
            this.ButtonSaveArchive.Size = new System.Drawing.Size(275, 79);
            this.ButtonSaveArchive.TabIndex = 12;
            this.ButtonSaveArchive.Text = "Save .nov Archive";
            this.ButtonSaveArchive.UseVisualStyleBackColor = true;
            this.ButtonSaveArchive.Click += new System.EventHandler(this.ButtonSaveArchive_Click);
            // 
            // ItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 628);
            this.Controls.Add(this.ButtonSaveArchive);
            this.Controls.Add(this.GroupBoxStory);
            this.Controls.Add(this.TabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditorForm";
            this.ShowIcon = false;
            this.Text = "Novint Editor";
            this.TabItemEditor.ResumeLayout(false);
            this.TabItemEditor.PerformLayout();
            this.GroupBoxEdit.ResumeLayout(false);
            this.GroupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.GroupBoxList.ResumeLayout(false);
            this.TabControlMain.ResumeLayout(false);
            this.TabImages.ResumeLayout(false);
            this.TabImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStoryValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.GroupBoxStory.ResumeLayout(false);
            this.GroupBoxStory.PerformLayout();
            this.PanelStoryDetails.ResumeLayout(false);
            this.PanelStoryDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.OpenFileDialog OpenImageFileDialog;
        private System.Windows.Forms.TabPage TabItemEditor;
        private System.Windows.Forms.GroupBox GroupBoxEdit;
        private System.Windows.Forms.Label LabelIcon;
        private System.Windows.Forms.Button ButtonOpenIcon;
        private System.Windows.Forms.CheckBox CheckBoxBypassesRequirements;
        private System.Windows.Forms.CheckBox CheckBoxIsUnique;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.GroupBox GroupBoxList;
        private System.Windows.Forms.Button ButtonDeleteEntry;
        private System.Windows.Forms.Button ButtonAddEntry;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxStoryValid;
        private System.Windows.Forms.TabPage TabImages;
        private System.Windows.Forms.Button ButtonUploadStory;
        private System.Windows.Forms.Label LabelImagesInfo;
        private System.Windows.Forms.Button ButtonOpenImagesFolder;
        private System.Windows.Forms.GroupBox GroupBoxStory;
        private System.Windows.Forms.Label LabelPassagesCount;
        private System.Windows.Forms.Label LabelStoryName;
        private System.Windows.Forms.Label LabelFirstPassage;
        private System.Windows.Forms.Panel PanelStoryDetails;
        private System.Windows.Forms.OpenFileDialog OpenStoryFileDialog;
        private System.Windows.Forms.Button ButtonSaveArchive;
    }
}

