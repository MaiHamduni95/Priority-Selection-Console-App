namespace PriorityApp.Models
{
    public class PriorityWeight
    {
        // defines the weight it's a percentage change , assigned to specific priority category
        public int Priority { get; set; } // lecel of priority (1, 2, or 3 ) 
        public int Weight { get; set; } // weight( 30 , 60, 10)

    }
}
