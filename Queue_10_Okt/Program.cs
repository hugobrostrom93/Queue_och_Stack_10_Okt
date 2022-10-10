using System.Collections;
using System.Collections.Generic;

namespace Queue_och_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue instansieras såhär:
            //var queue = new Queue<string>(); // Kan använda vilken typ som helst
                                             // Queue använder sig av funktionen Enqueue för att lägga till saker i listan.
            //queue.Enqueue("Läs mailen");
            // använder sig av funktionen Dequeue för att ta bort saker ur listan.
            //Console.WriteLine(queue.Dequeue());
            // funktionen Peek visar vad som finns närmast i listan
            //Console.WriteLine(queue.Peek());

            var queue1 = new Queue<string>();
            queue1.Enqueue("9:00 Kolla mailen");
            queue1.Enqueue("9:30 Standup");
            queue1.Enqueue("9:45 Kaffe");
            queue1.Enqueue("10:00 programmering");
            queue1.Enqueue("11:15 Möte med kund");
            queue1.Enqueue("12:00 Lunch");
            PrintQueue(queue1);

            // Stack instansieras såhär:
            // var stack = new Stack<string>(); // Kan använda vilken typ som helst
            // Stack använder sig av funktionen Push för att lägga till saker i listan.
            // stack.Push("Läs mailen");
            // använder sig av funktionen Pop för att ta bort saker ur listan.
            // Console.WriteLine(stack.Pop());
            // funktionen Peek visar vad som finns närmast i listan
            // Console.WriteLine(stack.Peek());
            Console.WriteLine("  ");

            var stack = new Stack<string>();
            stack.Push("9:00 Kolla mailen");
            stack.Push("9:30 Standup");
            stack.Push("9:45 Kaffe");
            stack.Push("10:00 programmering");
            stack.Push("11:15 Möte med kund");
            stack.Push("12:00 Lunch");
            PrintStack(stack);
        }

        static void PrintQueue(Queue<string> todoList)
        {
            while (todoList.Count > 0)
            {
                Console.WriteLine(todoList.Dequeue());
            }

        }

        static void PrintStack(Stack<string> todoList)
        {
            while (todoList.Count > 0)
            {
                Console.WriteLine(todoList.Pop());
            }
        }
    }
}