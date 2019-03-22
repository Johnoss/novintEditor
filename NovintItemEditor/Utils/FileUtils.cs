using NovintItemEditor.Structure.Items;
using NovintItemEditor.Structure.Stories;
using System;
using System.IO;

namespace NovintItemEditor.Utils
{
    public static class FileUtils
    {
        private const string FileExtention = "nov";
        private const string ItemsJsonFileName = "items.json";
        private const string StoryJsonFileName = "story.json";
        private const string IconFileNameTemplate = "icon_{0}";

        private const string BaseArchiveFolder = "Archive";
        private const string ImagesRelativeFolder = "Images";
        private const string IconsRelativeFolder = "Icons";
        private const string OutputRelativeFolder = "Output";

        public static string ImagesFolderPath => Path.Combine(BaseArchiveFolderPath, ImagesRelativeFolder);
        public static string IconsFolderPath => Path.Combine(ImagesFolderPath, IconsRelativeFolder);
        public static string ItemsJsonPath => Path.Combine(BaseArchiveFolderPath, ItemsJsonFileName);
        public static string StoryJsonPath => Path.Combine(BaseArchiveFolderPath, StoryJsonFileName);

        public static string BaseArchiveFolderPath
        {
            get
            {
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                return Path.Combine(baseDirectory, BaseArchiveFolder);
            }
        }

        public static string OutputFolderPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, OutputRelativeFolder);

        public static string GetIconPath(Item item)
        {
            var filename = string.Format(IconFileNameTemplate, item.IconFilename);
            return Path.Combine(IconsFolderPath, filename);
        }

        public static string GetArchiveFilePath(Story story)
        {
            var name = $"{GetValidFileName(story.Name)}.{FileExtention}";
            return Path.Combine(OutputFolderPath, name);
        }

        private static string GetValidFileName(string name)
        {
            var invalidsString = new string(Path.GetInvalidFileNameChars());
            var invalidChars = System.Text.RegularExpressions.Regex.Escape(invalidsString);
            var invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            var result = System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
            result = result.Replace(" ", string.Empty);
            return result;
        }

        public static void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}