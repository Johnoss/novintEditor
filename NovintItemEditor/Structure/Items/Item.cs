namespace NovintItemEditor.Structure.Items
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string IconFilename { get; set; }
        public bool IsUnique { get; set; }
        public bool BypassesRequirements { get; set; }
    }
}
