using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NovintItemEditor.Structure.Items;
using NovintItemEditor.Utils;

namespace NovintItemEditor.Structure.JsonParsing
{
    public static class ItemsParser
    {
        public static ItemCollection ParseItems()
        {
            var json = ParseJson();
            var items = (JArray)json["Items"];
            return GetParsedItemsCollection(items);
        }

        private static ItemCollection GetParsedItemsCollection(JArray items)
        {
            var itemCollection = new ItemCollection();
            foreach (var itemToken in items)
            {
                var item = ParseItem(itemToken);
                itemCollection.AddItem(item);
            }

            return itemCollection;
        }

        private static Item ParseItem(JToken itemToken)
        {
            var itemId = int.Parse(itemToken["ItemId"].ToString());
            var name = itemToken["Name"].ToString();
            var iconFilename = itemToken["IconFilename"].ToString();
            var isUnique = bool.Parse(itemToken["IsUnique"].ToString());
            var bypassesRequirements = bool.Parse(itemToken["BypassesRequirements"].ToString());
            var item = new Item
            {
                ItemId = itemId,
                Name = name,
                IconFilename = iconFilename,
                IsUnique = isUnique,
                BypassesRequirements = bypassesRequirements
            };
            return item;
        }

        public static void SerializeItems(ItemCollection itemsCollection)
        {
            var json = JsonConvert.SerializeObject(itemsCollection, Formatting.Indented);
            using (StreamWriter outputFile = new StreamWriter(FileUtils.ItemsJsonPath))
            {
                outputFile.Write(json);
            }
            itemsCollection.Items.ForEach(item =>
            {

            });
        }

        private static JObject ParseJson()
        {
            var result = File.Exists(FileUtils.ItemsJsonPath)
                ? File.ReadAllText(FileUtils.ItemsJsonPath)
                : BookmarkTemplate;
            return (JObject) JsonConvert.DeserializeObject(result);
        }

        private static string BookmarkTemplate =>
            "{\r\n  \"Items\": [\r\n    {\r\n      \"ItemId\": 0,\r\n      \"Name\": \"Bookmark\",\r\n      \"IconFilename\": \"" +
            RandomUtil.RandomString() +
            ".png\",\r\n      \"IsUnique\": true,\r\n      \"BypassesRequirements\": true\r\n    }\r\n  ]\r\n}";
    }
}