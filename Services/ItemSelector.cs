using PriorityApp.Models;

namespace PriorityApp.Services
{
    public interface IItemSelector
    {
        Item Select(List<Item> items, List<PriorityWeight> weights);
    }
}
