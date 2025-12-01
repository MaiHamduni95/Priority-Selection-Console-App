Priority Selection Console App Assignment
This project is a C# Console Application that selects items randomly from a list but with priority based 
weight probabilities , and removes the selected item after each pick without replacement .
built with clean architecture principles and full modular structure.

project feature 

weight random selection : 
priority 1 -> 60% chance 
priority 2 -> 30% chance 
priority 3 -> 10% chance 

-works dynamically (weight can change)
- no inifnite loops 
-selection safely handles :
empty lists 
missing priorites
xhausted categories

- Removal After Selection 
Once an item chosen -> it is removal from the main list
- clean Architure(highly organized)
PriorityApp
│ Program.cs
│
├── Models
│   ├── Item.cs
│   └── PriorityWeight.cs
│
├── Services
│   ├── IItemSelector.cs
│   ├── WeightedItemSelector.cs
│   └── SelectionRunner.cs
│
└── Utils
    └── RandomGenerator.cs

- support dependency injection - the selector is injected into the runner :
- IItemSelector selector = new WeightedItemSelector();
var runner = new SelectionRunner(selector);

-dynamic items : user enters number of items per priority at runtime
-output example : 
<img width="1323" height="368" alt="image" src="https://github.com/user-attachments/assets/6541099f-dcb1-40e0-852d-5860694af60f" />

how the weighted selection works :
1- calculate the total weight of all priorities that still have items
2- generate a random number between 0 and totalWeight - 1 
3- use a progressive sum of weights to detect which priority was chosen
4- select a random item only from that priority 
5- remove selected item from the main list
6- repeat

this ensures perfect probability behavior 
even after items get removed 

-Technologies Used :
C# (.NET 6+)
LINQ
Dependency Injection
Object-Oriented Design
Weighted Probability Algorithm

