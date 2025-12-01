namespace PriorityApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int priority { get; set; }


        public override string ToString() { return $"{Name} ({priority})"; }
    }
}
