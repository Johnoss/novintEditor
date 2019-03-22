using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NovintItemEditor.Structure.Stories;
using NovintItemEditor.Utils;
using System.IO;
using System.Linq;

namespace NovintItemEditor.Structure.JsonParsing
{
    public static class StoryParser
    {
        public static Story ParseStory()
        {
            var json = ParseJson();
            if (json == null)
            {
                return null;
            }
            var passages = (JArray)json["passages"];
            var name = json["name"];
            var passagesAmount = passages.Count();
            var firstPassageIndex = int.Parse(json["startnode"].ToString());
            var firstPassageText = json.SelectToken($"passages[{firstPassageIndex - 1}].text");

            var story = new Story
            {
                PassagesAmount = passagesAmount,
                Name = name.ToString(),
                FirstPassage = firstPassageText.ToString(),
            };

            return story;
        }

        private static JObject ParseJson()
        {
            if (!File.Exists(FileUtils.StoryJsonPath))
                return null;

            var result = File.ReadAllText(FileUtils.StoryJsonPath);
            return (JObject) JsonConvert.DeserializeObject(result);
        }
    }
}