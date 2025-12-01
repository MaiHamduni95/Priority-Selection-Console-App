
using PriorityApp.Utils;
using PriorityApp.Models;

namespace PriorityApp.Services
{
    public class weightItemSelector : IItemSelector
    {
      public Item Select(List<Item> items, List<PriorityWeight> weights)
        {
            int totalWeight = 0; //calculate the total weight only for priorities that still exist

            for(int i=0; i< weights.Count; i++)
            {
                int priority = weights[i].Priority;
                if(items.Any(x=> x.priority == priority))
                {
                    totalWeight += weights[i].Weight;
                }
            }
            if (totalWeight == 0)
                throw new Exception("No items Left");
            int random = randomGenerator.Instance.Next(totalWeight);
            int progressive = 0;

            for(int i=0; weights.Count>i; i++)
            {
                int priority = weights[i].Priority;
                var candidates = items.Where(x=> x.priority == priority).ToList();

                if (candidates.Count == 0)
                    continue;
                progressive += weights[i].Weight;

                if(random < progressive)
                {
                    int index = randomGenerator.Instance.Next(candidates.Count);
                    return candidates[index];
                }
              
            }
            throw new Exception("selection faild");

        }
    }
}
