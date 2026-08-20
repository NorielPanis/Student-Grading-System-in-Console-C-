using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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


        string[] LRN = { };
        string[] StudentName = { };
        int[] GradeLevel = { };
        string[] Section = { };
        string[] Adviser = { };




        int[] WW = new int[5];
        int[] WW_TotalPS = new int[5];
        int[] PT = new int[3];
        int[] PT_TotalPS = new int[3];
        int[] ST = new int[2];
        int[] ST_TotalPS = new int[2];
        int TE = 0;
        int TE_TotalPS = 0;


        int Input = 0;
        Thread.Sleep(1000);
        do
        {

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
                    Console.Clear();

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

                    Console.SetCursorPosition(50, 2);
                    Console.WriteLine("--- ADD STUDENT ---");

                    Console.SetCursorPosition(50, 4);
                    Console.Write("Enter Student's LRN: ");
                    Array.Resize(ref LRN, (LRN?.Length ?? 0) + 1);
                    LRN[LRN.Length - 1] = Console.ReadLine();

                    Console.SetCursorPosition(50, 6);
                    Console.Write("Enter Student's Name: ");
                    Array.Resize(ref StudentName, (StudentName?.Length ?? 0) + 1);
                    StudentName[StudentName.Length - 1] = Console.ReadLine();

                    Console.SetCursorPosition(50, 8);
                    Console.Write("Enter Student's Grade Level: ");
                    Array.Resize(ref GradeLevel, (GradeLevel?.Length ?? 0) + 1);
                    int.TryParse(Console.ReadLine(), out int level);
                    GradeLevel[GradeLevel.Length - 1] = level;

                    Console.SetCursorPosition(50, 10);
                    Console.Write("Enter Student's Section: ");
                    Array.Resize(ref Section, (Section?.Length ?? 0) + 1);
                    Section[Section.Length - 1] = Console.ReadLine();

                    Console.SetCursorPosition(50, 12);
                    Console.Write("Enter Student's Adviser: ");
                    Array.Resize(ref Adviser, (Adviser?.Length ?? 0) + 1);
                    Adviser[Adviser.Length - 1] = Console.ReadLine();

                    Console.SetCursorPosition(50, 14);
                    Console.ForegroundColor = ConsoleColor.Green;
                    string Adding_Message_1 = "Adding new student...";
                    foreach (char Adding_Messages_1 in Adding_Message_1)
                    {
                        Console.Write(Adding_Messages_1);
                        Thread.Sleep(60);
                    }
                    Thread.Sleep(3000);
                    Console.ResetColor();

                    Console.SetCursorPosition(50, 16);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string Adding_Message_2 = "Please wait...";
                    foreach (char Adding_Messages_2 in Adding_Message_2)
                    {
                        Console.Write(Adding_Messages_2);
                        Thread.Sleep(60);
                    }
                    Thread.Sleep(2000);
                    Console.ResetColor();

                    Console.SetCursorPosition(50, 18);
                    Console.ForegroundColor = ConsoleColor.Green;
                    string Adding_Message_3 = "Success!";
                    foreach (char Adding_Messages_3 in Adding_Message_3)
                    {
                        Console.Write(Adding_Messages_3);
                        Thread.Sleep(60);
                    }
                    Console.ResetColor();

                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine("1. Add Another Student");

                    Console.SetCursorPosition(50, 22);
                    Console.WriteLine("2. Back to Main Menu");

                    Console.SetCursorPosition(50, 24);
                    Console.Write("Enter choice: ");

                    int StudentInput;

                    if (!int.TryParse(Console.ReadLine(), out StudentInput))
                    {
                        continue;
                    }

                    if (StudentInput == 1)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (StudentInput == 2)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (StudentInput >= 3)
                    {
                        Console.SetCursorPosition(50, 26);
                        Console.WriteLine("INVALID_OPTION");
                        return;
                    }
                }
            }





            else if (Input == 2)
            {
                while (true)
                {
                    Console.Clear();

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


                    Console.SetCursorPosition(50, 3);
                    Console.WriteLine("--- ADD GRADE ---");

                    Console.SetCursorPosition(50, 6);
                    Console.Write("Enter Student's LRN: ");

                    string SearchLRN = Console.ReadLine();

                    int StudentIndex = -1;

                    for (int i = 0; i < LRN.Length; i++)
                    {
                        if (LRN[i] == SearchLRN)
                        {
                            StudentIndex = i;


                            Console.SetCursorPosition(50, 9);
                            Console.ForegroundColor = ConsoleColor.Green;
                            string Adding_Message_4 = "Searching...";
                            foreach (char Adding_Messages_4 in Adding_Message_4)
                            {
                                Console.Write(Adding_Messages_4);
                                Thread.Sleep(60);
                            }
                            Thread.Sleep(3000);
                            Console.ResetColor();

                            Console.SetCursorPosition(50, 11);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            string Adding_Message_5 = "Please wait...";
                            foreach (char Adding_Messages_5 in Adding_Message_5)
                            {
                                Console.Write(Adding_Messages_5);
                                Thread.Sleep(60);
                            }
                            Thread.Sleep(2000);
                            Console.ResetColor();

                            Console.SetCursorPosition(50, 13);
                            Console.ForegroundColor = ConsoleColor.Green;
                            string Adding_Message_6 = "Student Found!";
                            foreach (char Adding_Messages_6 in Adding_Message_6)
                            {
                                Console.Write(Adding_Messages_6);
                                Thread.Sleep(60);
                            }
                            Console.ResetColor();

                            break;
                        }
                    }


                    if (StudentIndex == -1)
                    {
                        Console.SetCursorPosition(50, 9);
                        Console.ForegroundColor = ConsoleColor.Green;
                        string Adding_Message_4 = "Searching...";
                        foreach (char Adding_Messages_4 in Adding_Message_4)
                        {
                            Console.Write(Adding_Messages_4);
                            Thread.Sleep(60);
                        }
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        Console.SetCursorPosition(50, 11);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string Adding_Message_5 = "Please wait...";
                        foreach (char Adding_Messages_5 in Adding_Message_5)
                        {
                            Console.Write(Adding_Messages_5);
                            Thread.Sleep(60);
                        }
                        Thread.Sleep(2000);
                        Console.ResetColor();

                        Console.SetCursorPosition(50, 13);
                        Console.ForegroundColor = ConsoleColor.Red;
                        string Adding_Message_6 = "Student not found!";
                        foreach (char Adding_Messages_6 in Adding_Message_6)
                        {
                            Console.Write(Adding_Messages_6);
                            Thread.Sleep(60);
                        }
                        Console.ResetColor();


                        Console.SetCursorPosition(50, 15);
                        Console.WriteLine("Press any key to return.");

                        Console.ReadKey();
                        continue;
                    }
                    Console.Clear();


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


                    bool W_Done = false;
                    bool P_Done = false;
                    bool E_Done = false;

                    while (true)
                    {
                        Console.SetCursorPosition(50, 3);
                        Console.WriteLine("--- ADD GRADE ---");

                        Console.SetCursorPosition(15, 6);
                        Console.Write("LRN: " + LRN[StudentIndex]);
                        Console.SetCursorPosition(15, 7);
                        Console.Write("Name: " + StudentName[StudentIndex]);
                        Console.SetCursorPosition(15, 8);
                        Console.Write("Grade Level: " + GradeLevel[StudentIndex]);
                        Console.SetCursorPosition(15, 9);
                        Console.Write("Section: " + Section[StudentIndex]);
                        Console.SetCursorPosition(15, 10);
                        Console.Write("Adviser: " + Adviser[StudentIndex]);

                        Console.SetCursorPosition(42, 12);
                        Console.WriteLine("╔════════════════════════════════╗");
                        Console.SetCursorPosition(42, 13);
                        Console.WriteLine("║    W - Written Works           ║");
                        Console.SetCursorPosition(42, 14);
                        Console.WriteLine("║                                ║");
                        Console.SetCursorPosition(42, 15);
                        Console.WriteLine("║    P - Performance Tasks       ║");
                        Console.SetCursorPosition(42, 16);
                        Console.WriteLine("║                                ║");
                        Console.SetCursorPosition(42, 17);
                        Console.WriteLine("║    E - Examinations            ║");
                        Console.SetCursorPosition(42, 18);
                        Console.WriteLine("╠════════════════════════════════╣");
                        Console.SetCursorPosition(42, 19);
                        Console.WriteLine("║ Please choose:                 ║");
                        Console.SetCursorPosition(42, 20);
                        Console.WriteLine("╚════════════════════════════════╝");

                        Console.SetCursorPosition(60, 19);
                        string GradeChoice = Console.ReadLine().ToUpper();


                        if (GradeChoice == "W")
                        {
                            Console.Clear();

                            Console.SetCursorPosition(50, 3);
                            Console.WriteLine("--- WRITTEN WORKS ---");

                            for (int i = 0; i < WW.Length; i++)
                            {
                                Console.Write("Written Work" + (i + 1) + " Score: ");
                                WW[i] = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Written Work" + (i + 1) + " Total Possible Score: ");
                                WW_TotalPS[i] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                            }
                            W_Done = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Written Works successfully entered.");
                            Console.WriteLine("Press any key to return.");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                        }




                        else if (GradeChoice == "P")
                        {
                            Console.Clear();

                            Console.WriteLine("--- PERFORMANCE TASKS ---\n");

                            for (int i = 0; i < PT.Length; i++)
                            {
                                Console.Write("Performance Task" + (i + 1) + " Score: ");
                                PT[i] = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Performance Task" + (i + 1) + " Total Possible Score: ");
                                PT_TotalPS[i] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                            }

                            P_Done = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Performance Tasks successfully entered.");
                            Console.WriteLine("Press any key to return.");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                        }


                        else if (GradeChoice == "E")
                        {
                            Console.Clear();

                            Console.WriteLine("--- EXAMINATIONS ---\n");


                            Console.Clear();

                            Console.WriteLine("--- EXAMINATIONS ---\n");

                            Console.Write("ST1 Score: ");
                            ST[0] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("ST1 Total Possible Score: ");
                            ST_TotalPS[0] = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            Console.Write("ST2 Score: ");
                            ST[1] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("ST2 Total Possible Score: ");
                            ST_TotalPS[1] = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            Console.Write("TE Score: ");
                            TE = Convert.ToInt32(Console.ReadLine());

                            Console.Write("TE Total Possible Score: ");
                            TE_TotalPS = Convert.ToInt32(Console.ReadLine());

                            E_Done = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nExaminations successfully entered.");
                            Console.WriteLine("Press any key to return.");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                        }

                        if (W_Done && P_Done && E_Done)
                        {
                            int TotalWWEarned = 0;
                            int TotalWWPossible = 0;

                            for (int i = 0; i < WW.Length; i++)
                            {
                                TotalWWEarned += WW[i];
                                TotalWWPossible += WW_TotalPS[i];
                            }

                            int TotalPTEarned = 0;
                            int TotalPTPossible = 0;

                            for (int i = 0; i < PT.Length; i++)
                            {
                                TotalPTEarned += PT[i];
                                TotalPTPossible += PT_TotalPS[i];
                            }

                            double WW_Score = ((double)TotalWWEarned / TotalWWPossible * 100) * 0.20;

                            double PT_Score = ((double)TotalPTEarned / TotalPTPossible * 100) * 0.60;

                            double ST1_Percent = ((double)ST[0] / ST_TotalPS[0]) * 100;

                            double ST2_Percent = ((double)ST[1] / ST_TotalPS[1]) * 100;

                            double TE_Percent = ((double)TE / TE_TotalPS) * 100;


                            double Exam_Total =
                                (ST1_Percent * 0.30) +
                                (ST2_Percent * 0.30) +
                                (TE_Percent * 0.40);


                            double Exam_Score =
                                Exam_Total * 0.20;

                            double InitialGrade =
                                WW_Score +
                                PT_Score +
                                Exam_Score;


                            double FinalGrade = TransmuteGrade(InitialGrade);

                            string Remarks;
                            if (FinalGrade >= 75)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Remarks = "Passed";
                                Console.ResetColor();

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Remarks = "Failed";
                                Console.ResetColor();
                            }


                            Console.Clear();

                            Console.SetCursorPosition(50, 2);
                            Console.WriteLine("=== Student Record ===");

                            Console.SetCursorPosition(50, 5);
                            Console.WriteLine("LRN       : " + LRN[StudentIndex]);

                            Console.SetCursorPosition(50, 6);
                            Console.WriteLine("Name      : " + StudentName[StudentIndex]);

                            Console.SetCursorPosition(50, 7);
                            Console.WriteLine("Grade     : " + GradeLevel[StudentIndex]);

                            Console.SetCursorPosition(50, 8);
                            Console.WriteLine("Section   : " + Section[StudentIndex]);

                            Console.SetCursorPosition(50, 9);
                            Console.WriteLine("Adviser   : " + Adviser[StudentIndex]);


                            Console.SetCursorPosition(45, 12);
                            Console.WriteLine("=== GRADING FORMULA CALCULATION ===");

                            Console.SetCursorPosition(20, 14);
                            Console.WriteLine(
                                "WW: " +
                                TotalWWEarned +
                                "/" +
                                TotalWWPossible
                            );

                            Console.SetCursorPosition(20, 15);
                            Console.WriteLine(
                                "WW Score (20%): " +
                                WW_Score.ToString("F2")
                            );


                            Console.SetCursorPosition(20, 17);
                            Console.WriteLine(
                                "PT: " +
                                TotalPTEarned +
                                "/" +
                                TotalPTPossible
                            );

                            Console.SetCursorPosition(20, 18);
                            Console.WriteLine(
                                "PT Score (60%): " +
                                PT_Score.ToString("F2")
                            );


                            Console.SetCursorPosition(20, 20);
                            Console.WriteLine(
                                "ST1: " +
                                ST[0] +
                                "/" +
                                ST_TotalPS[0]
                            );

                            Console.SetCursorPosition(20, 21);
                            Console.WriteLine(
                                "ST2: " +
                                ST[1] +
                                "/" +
                                ST_TotalPS[1]
                            );

                            Console.SetCursorPosition(20, 22);
                            Console.WriteLine(
                                "TE: " +
                                TE +
                                "/" +
                                TE_TotalPS
                            );

                            Console.SetCursorPosition(20, 23);
                            Console.WriteLine(
                                "Exam Total: " +
                                Exam_Total.ToString("F2")
                            );

                            Console.SetCursorPosition(20, 24);
                            Console.WriteLine(
                                "Exam Score (20%): " +
                                Exam_Score.ToString("F2")
                            );


                            Console.SetCursorPosition(75, 14);
                            Console.WriteLine(
                                "INITIAL GRADE: " +
                                InitialGrade.ToString("F2")
                            );

                            Console.SetCursorPosition(75, 15);
                            Console.WriteLine(
                                "FINAL GRADE  : " +
                                FinalGrade.ToString("F0")
                            );


                            Console.SetCursorPosition(75, 16);

                            if (FinalGrade >= 75)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }

                            Console.WriteLine("REMARKS      : " + Remarks);

                            Console.ResetColor();


                            Console.SetCursorPosition(75, 18);
                            Console.WriteLine("Press any key to continue...");

                            Console.ReadKey();

                            break;
                        }
                        static int TransmuteGrade(double grade)
                        {
                            if (grade >= 99.50) return 100;
                            else if (grade >= 98.32) return 99;
                            else if (grade >= 97.14) return 98;
                            else if (grade >= 95.96) return 97;
                            else if (grade >= 94.78) return 96;
                            else if (grade >= 93.60) return 95;
                            else if (grade >= 92.42) return 94;
                            else if (grade >= 91.24) return 93;
                            else if (grade >= 90.06) return 92;
                            else if (grade >= 88.88) return 91;
                            else if (grade >= 87.70) return 90;
                            else if (grade >= 86.52) return 89;
                            else if (grade >= 85.34) return 88;
                            else if (grade >= 84.16) return 87;
                            else if (grade >= 82.98) return 86;
                            else if (grade >= 81.80) return 85;
                            else if (grade >= 80.62) return 84;
                            else if (grade >= 79.44) return 83;
                            else if (grade >= 78.26) return 82;
                            else if (grade >= 77.08) return 81;
                            else if (grade >= 75.90) return 80;
                            else if (grade >= 74.72) return 79;
                            else if (grade >= 73.54) return 78;
                            else if (grade >= 72.36) return 77;
                            else if (grade >= 71.18) return 76;
                            else if (grade >= 70.00) return 75;
                            else if (grade >= 65.34) return 74;
                            else if (grade >= 60.67) return 73;
                            else if (grade >= 56.01) return 72;
                            else if (grade >= 51.34) return 71;
                            else if (grade >= 46.67) return 70;
                            else if (grade >= 42.01) return 69;
                            else if (grade >= 37.34) return 68;
                            else if (grade >= 32.68) return 67;
                            else if (grade >= 28.01) return 66;
                            else if (grade >= 23.35) return 65;
                            else if (grade >= 18.68) return 64;
                            else if (grade >= 14.01) return 63;
                            else if (grade >= 9.35) return 62;
                            else if (grade >= 4.68) return 61;
                            else return 60;
                        }

                    }
                }
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
