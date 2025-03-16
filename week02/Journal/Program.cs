using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        Console.WriteLine("What is the date? ");
        entry1._date = Console.ReadLine();
        Console.WriteLine("What was the best part of my day? ");
        entry1._entryText = Console.ReadLine();
        entry1._promptText ="What was the best part of my day? ";
        

        Entry entry2 = new Entry();
        Console.WriteLine("What is the date? ");
        entry2._date = Console.ReadLine();
        Console.WriteLine("How did I see the hand of the Lord in my life today? ");
        entry2._entryText = Console.ReadLine();
        entry2._promptText = "How did I see the hand of the Lord in my life today? ";

        Entry entry3 = new Entry();
        Console.WriteLine("What is the date? ");
        entry3._date = Console.ReadLine();
        Console.WriteLine("What was the strongest emotion I felt today? ");
        entry3._entryText = Console.ReadLine();
        entry3._promptText = "What was the strongest emotion I felt today? ";

        Entry entry4 = new Entry();
        Console.WriteLine("What is the date? ");
        entry4._date = Console.ReadLine();
        Console.WriteLine("If I had one thing I could do over today, what would it be? ");
        entry4._entryText = Console.ReadLine();
        entry4._promptText = "If I had one thing I could do over today, what would it be? ";

        Entry entry5 = new Entry();
        Console.WriteLine("What is the date? ");
        entry5._date = Console.ReadLine();
        Console.WriteLine("What are you going to do differently tomorrow? ");
        entry5._entryText = Console.ReadLine();
        entry5._promptText = "What are you going to do differently tomorrow? ";

        Entry entry6 = new Entry();
        Console.WriteLine("What is the date? ");
        entry6._date = Console.ReadLine();
        Console.WriteLine("What is somthing you wish you did today? ");  
        entry6._entryText = Console.ReadLine();
        entry6._promptText = "What is somthing you wish you did today? ";
        
        Entry entry7 = new Entry();
        Console.WriteLine("What is the date? ");
        entry7._date = Console.ReadLine();
        Console.WriteLine("What did you learn about yourself today? ");
        entry7._entryText = Console.ReadLine();
        entry7._promptText = "What did you learn about yourself today? ";

        
}