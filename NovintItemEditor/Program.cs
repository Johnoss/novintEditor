using NovintItemEditor.Utils;
using System;
using System.Windows.Forms;

namespace NovintItemEditor
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FolderUtil.CreateFolders();
            Application.Run(new ItemEditorForm());
        }
    }
}