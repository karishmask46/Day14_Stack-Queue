﻿using Day14_StackQueue;
Console.WriteLine("Welcome to the Queue problem");
CreatingQueue linkedlistQueue = new CreatingQueue();
linkedlistQueue.Enqueue(56);
linkedlistQueue.Enqueue(30);
linkedlistQueue.Enqueue(70);
linkedlistQueue.Dequeue(56);
linkedlistQueue.Dequeue(30);
linkedlistQueue.Dequeue(70);
linkedlistQueue.Display();
