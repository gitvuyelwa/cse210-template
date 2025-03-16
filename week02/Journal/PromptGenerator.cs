using System;

class PromptGenerator
{
    public List<string>_prompts = new List<string>();
    
    void GetRandomPrompt()

    {   
        Random int random = new Random();
        {
            Console.WriteLine("Pick a number between 1 and 7" );
            random = Convert.ToInt32(Console.ReadLine());

            if (random.Next(1, 8) == 1)
            {
                entry1.Display();
            }
            else if (random.Next(1, 8) == 2)
            {
                entry2.Display();
            }
            else if (random.Next(1, 8) == 3)
            {
                entry3.Display();
            }
            else if (random.Next(1, 8) == 4)
            {
                entry4.Display();
            }
            else if (random.Next(1, 8) == 5)
            {
                entry5.Display();
            }
            else if (random.Next(1, 8) == 6)
            {
                entry6.Display();
            }
            else if (random.Next(1, 8) == 7)
            {
                entry7.Display();
            }
        
        }
    }

    
    
}