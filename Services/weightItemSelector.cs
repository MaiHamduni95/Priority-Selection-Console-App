
using PriorityApp.Utils;
using PriorityApp.Models;

namespace PriorityApp.Services
{
    // implements the weight random algorithm , works with dynamic number of items
    // removes the selected item from the list
    public class weightItemSelector : IItemSelector
    {
      public Item Select(List<Item> items, List<PriorityWeight> weights)
        {
            int totalWeight = 0; //calculate the total weight only for priorities that still exist

            for(int i=0; i< weights.Count; i++)
            {
                int priority = weights[i].Priority;
                //count only priorities that actually still exist
                if(items.Any(x=> x.priority == priority))
                {
                    totalWeight += weights[i].Weight;
                }
            }
            if (totalWeight == 0)
                throw new Exception("No items Left");
            // random number within 0.. totalweight
            int random = randomGenerator.Instance.Next(totalWeight);
            int progressive = 0;
            //determine which priority is selected
            for(int i=0; weights.Count>i; i++)
            {
                int priority = weights[i].Priority;
                var candidates = items.Where(x=> x.priority == priority).ToList();

                if (candidates.Count == 0)
                    continue;
                progressive += weights[i].Weight;
                // selected priority found
                if(random < progressive)
                {
                    // choose one item randomly inside that priority
                    int index = randomGenerator.Instance.Next(candidates.Count);
                    return candidates[index];
                }
              
            }
            //should never reach here
            throw new Exception("selection faild");

        }
    }
}
