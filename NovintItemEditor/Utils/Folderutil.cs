using NovintItemEditor.Structure.Items;
using NovintItemEditor.Structure.Stories;
using System;
using System.IO;

namespace NovintItemEditor.Utils
{
    public static class FolderUtil
    {
        public static void CreateFolders()
        {
            FileUtils.CreateDirectory(FileUtils.BaseArchiveFolderPath);
            FileUtils.CreateDirectory(FileUtils.IconsFolderPath);
            FileUtils.CreateDirectory(FileUtils.OutputFolderPath);
        }
    }
}