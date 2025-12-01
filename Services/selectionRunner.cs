
using PriorityApp.Models;


namespace PriorityApp.Services
{
    public class selectionRunner
    {
        private readonly IItemSelector _itemSelector;

        public selectionRunner(IItemSelector itemSelector)
        {
            _itemSelector = itemSelector;
        }
        private List<Item> CreateItems()
        {
            var items = new List<Item>();
            int id = 1;
            for(int i=0;i<5;i++)
            {
                // five items with priority 1
                items.Add(new Item
                {
                    Id = id,
                    Name = $"Item-{id}-priority1",
                    priority = i,
                });
                id++;
            }
            for (int i = 0; i < 5; i++)
            {
                // five items with priority 2
                items.Add(new Item
                {
                    Id = id,
                    Name = $"Item-{id}-priority2",
                    priority = i,
                });
                id++;
            }
            for (int i = 0; i < 5; i++)
            {
                // five items with priority 3
                items.Add(new Item
                {
                    Id = id,
                    Name = $"Item-{id}-priority3",
                    priority = i,
                });
                id++;
            }
            return items;
        }
        private List<PriorityWeight> CreatePriorityweights()
        {
            return new List<PriorityWeight>
            {
                new PriorityWeight { Priority = 1 , Weight= 60 },
                 new PriorityWeight { Priority =2 , Weight= 30 },
                 new PriorityWeight { Priority = 3 , Weight= 10 },
            };
        }

        public void run()
        {
            var items = CreateItems();
            var weights = CreatePriorityweights();

            Console.WriteLine("initial items");
            foreach (var item in items)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("selection");
            int numberofSelection = 7;

            for (int i = 0; i < numberofSelection && items.Count > 0 ; i++)
            {
                var selected = _itemSelector.Select(items,weights);
                Console.WriteLine($"{i}: { selected} { selected.priority}" );
            }
            Console.WriteLine();
            Console.WriteLine("remain items : ");
            foreach(var item in items)
                Console.WriteLine(item);
        }
    }
}
