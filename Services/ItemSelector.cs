using PriorityApp.Models;

namespace PriorityApp.Services
{
    // interface defining the selection behavior , allows replacing weights item selector with another algorithm if needed
    public interface IItemSelector
    {
        //selects 1 item from the list based on weighted priority , the selected item will be removed from the list
        Item Select(List<Item> items, List<PriorityWeight> weights);
    }
}
