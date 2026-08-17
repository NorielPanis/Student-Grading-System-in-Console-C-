using System;
using System.ComponentModel;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {

        int width = Console.WindowWidth;
        int height = Console.WindowHeight;
        char HorizontalBar = '\u2550';

        for (int x = 0; x < width; x++)
        {
            Console.SetCursorPosition(x, 0);
            Console.Write(HorizontalBar);
        }

        for (int y = 0; y < height; y++)
        {
            Console.SetCursorPosition(width - 2, y);
            Console.Write("||");
        }

        for (int x = width - 2; x >= 0; x--)
        {
            Console.SetCursorPosition(x, height - 1);
            Console.Write(HorizontalBar);
        }

        for (int y = height - 1; y >= 0; y--)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("||");
        }


        string Titles = " === Student Grading System ===";
        Console.SetCursorPosition(45, 2);

        foreach (char Title in Titles)
        {
            Console.Write(Title);
            Thread.Sleep(60);
        }

        string Greetings = "Welcome Teacher!";
        Console.SetCursorPosition(53, 4);

        Thread.Sleep(1000);
        foreach (char Greeting in Greetings)
        {
            Console.Write(Greeting);
            Thread.Sleep(60);
        }


        string[] LRN = {  };
        string[] StudentName = {  };
        int[] GradeLevel = { };
        string[] Section = {  };
        string[] Adviser = {  };

        int Input = 0;
        Thread.Sleep(1000);
        do {
            Console.SetCursorPosition(49, 7);
            Console.Write("1. Add Student");
            
            Console.SetCursorPosition(49, 10);
            Console.Write("2. Add Grade");

            Console.SetCursorPosition(49, 13);
            Console.Write("3. View Class Table");

            Console.SetCursorPosition(49, 16);
            Console.Write("4. View Individual Grades (Form View)");

            Console.SetCursorPosition(49, 19);
            Console.Write("5. Exit");

            Console.SetCursorPosition(49, 22);
            Console.Write("Please enter a number (1 - 5): ");

            if (!int.TryParse(Console.ReadLine(), out Input))
            {
                Console.SetCursorPosition(49, 24);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("INVALID_INPUT");
                Console.ResetColor();
                continue;
            }

            if (Input == 1)
            {
                while (true)
                {
                    Console.WriteLine("\n--- ADD STUDENT ---\n");

                    Console.Write("Enter Student's LRN: ");
                    Array.Resize(ref LRN, (LRN?.Length ?? 0) + 1);
                    LRN[LRN.Length - 1] = Console.ReadLine();

                    Console.Write("Enter Student's Name: ");
                    Array.Resize(ref StudentName, (StudentName?.Length ?? 0) + 1);
                    StudentName[StudentName.Length - 1] = Console.ReadLine();

                    Console.Write("Enter Student's Grade Level: ");
                    Array.Resize(ref GradeLevel, (GradeLevel?.Length ?? 0) + 1);
                    int.TryParse(Console.ReadLine(), out int level);
                    GradeLevel[GradeLevel.Length - 1] = level;

                    Console.Write("Enter Student's Section: ");
                    Array.Resize(ref Section, (Section?.Length ?? 0) + 1);
                    Section[Section.Length - 1] = Console.ReadLine();

                    Console.Write("Enter Student's Adviser: ");
                    Array.Resize(ref Adviser, (Adviser?.Length ?? 0) + 1);
                    Adviser[Adviser.Length - 1] = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    string Adding_Message_1 = "Adding new student...";
                    foreach(char Adding_Messages_1 in Adding_Message_1)
                    {
                        Console.Write(Adding_Messages_1);
                        Thread.Sleep(60);
                    }
                    Thread.Sleep(3000);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string Adding_Message_2 = "Please wait...";
                    foreach (char Adding_Messages_2 in Adding_Message_2)
                    {
                        Console.Write(Adding_Messages_2);
                        Thread.Sleep(60);
                    }
                    Thread.Sleep(2000);
                    Console.ResetColor();


                    Console.ForegroundColor = ConsoleColor.Green;
                    string Adding_Message_3 = "Success!";
                    foreach (char Adding_Messages_3 in Adding_Message_3)
                    {
                        Console.Write(Adding_Messages_3);
                        Thread.Sleep(60);
                    }
                    Console.ResetColor();
                    break;
                }
            }
            else if (Input == 2)
            {

            }
            else if (Input == 3)
            {

            }
            else if (Input == 4)
            {

            }
            else if (Input == 5)
            {
                return;
            }

        } while (Input != 5);




        Console.ReadKey();
    }
}
