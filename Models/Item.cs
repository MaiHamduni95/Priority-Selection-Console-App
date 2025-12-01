namespace PriorityApp.Models
{
    public class Item
    {

        // represtet a signle item that will be selected from the list , each item have : id , name , priority (1,2,3)
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int priority { get; set; }


        public override string ToString() { return $"{Name} ({priority})"; }


    }
}
