using System;

namespace DEU_son
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A1 = new string[15];//Arrays for D,E,U
            string[] A2 = new string[15];
            string[] A3 = new string[15];
            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan", "" };//Names for score table
            string[] letter = { "D", "E", "U" };//For put letters randomly in arrays
            int p1score = 120, p2score = 120, rand_char, array;//nitial scores,randomly chosen letter and randomly choosen array 
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, 120 };//Scores for score table
            int a1 = 0, a2 = 0, a3 = 0;//For adding values in arays in order
            int tour = 0, check = 0;//For determining next player and check if the next player's turn
            int x = 0, y = 0;//For colorizing true patterns
            bool score_table = false;//Checls if the game finished and score table can be shown
            Random rand = new Random();//For randomly assigned  arrays and their values

            Console.WriteLine("\nPlayer1: 120\t\t Player2: 120");
            while (true)
            {
                check = tour + 1;//Will be used to control if the turn changed
                if (tour % 2 == 0)//For determining whose turn
                {
                    names[12] = "Player1";//To determine winner if the game finishes
                    p1score = p1score - 5;//Decreases player's score
                    Console.WriteLine("\n\nPlayer1:\t(P1:" + p1score + "  P2:" + p2score + ")");
                    scores[12] = p1score;//To determine winner's score if the game finishes
                }
                else if (tour % 2 != 0)//For determining whose turn
                {
                    names[12] = "Player2";
                    p2score = p2score - 5;
                    Console.WriteLine("\n\nPlayer2:\t(P1:" + p1score + "  P2:" + p2score + ")");
                    scores[12] = p2score;
                }

                while (tour != check)//Loop for do not changing turn without assignment a value to an array
                {
                    rand_char = rand.Next(0, 3);//Random ly choosen letter
                    array = rand.Next(0, 3);//Randomly choosen array
                    switch (array)//Determines array to value assignment
                    {

                        case 0:
                            if (a1 >= 15)//When an array is not empty turns loop again until appropriate array choosen randomly
                                break;
                            A1[a1] = letter[rand_char];
                            Console.Write("A1 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A1[i] + " ");
                            Console.Write("\nA2 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A2[i] + " ");
                            Console.Write("\nA3 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A3[i] + " ");
                            Console.WriteLine("");

                            a1++;//For assigning value to next empty array box
                            tour++;//Tour increasas only after than assignment so without assignment, player does not change and loop continue
                            break;

                        case 1:
                            if (a2 >= 15)
                                break;

                            A2[a2] = letter[rand_char];
                            Console.Write("A1 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A1[i] + " ");
                            Console.Write("\nA2 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A2[i] + " ");
                            Console.Write("\nA3 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A3[i] + " ");
                            Console.WriteLine("");
                            a2++;
                            tour++;
                            break;

                        case 2:
                            if (a3 >= 15)
                                break;

                            A3[a3] = letter[rand_char];
                            Console.Write("A1 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A1[i] + " ");
                            Console.Write("\nA2 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A2[i] + " ");
                            Console.Write("\nA3 ");
                            for (int i = 0; i < A1.Length; i++)
                                Console.Write(A3[i] + " ");
                            Console.WriteLine("");
                            a3++;
                            tour++;
                            break;
                    }

                }
                for (int i = 0; i < A1.Length; i++)//For determining if the correct patterns come together
                {
                    x = Console.CursorLeft;//For colorizing
                    y = Console.CursorTop;//For colorizing
                    if (i < 13)
                    {
                        //If statements check all possible correct patterns
                        if ((A1[i] == "D" && A1[i + 1] == "E" && A1[i + 2] == "U") || (A1[i] == "U" && A1[i + 1] == "E" && A1[i + 2] == "D"))// horizontal checking for A1
                        {
                            for (int j = 0; j < 3; j++)//In every statement different cursor position adjustments changes the correct pattern's color
                            {
                                Console.SetCursorPosition((2 * i) + 3, y - 3);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(A1[i]);
                                i = i + 1;
                            }
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;//Specifies the game is over and score table can be shown
                            break;
                        }
                        else if ((A2[i] == "D" && A2[i + 1] == "E" && A2[i + 2] == "U" || A2[i] == "U" && A2[i + 1] == "E" && A2[i + 2] == "D"))// horizontal checking for A2
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.SetCursorPosition((2 * i) + 3, y - 2);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(A2[i]);
                                i = i + 1;
                            }
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;
                        }
                        else if ((A3[i] == "D" && A3[i + 1] == "E" && A3[i + 2] == "U" || A3[i] == "U" && A3[i + 1] == "E" && A3[i + 2] == "D"))// horizontal checking for A3
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            for (int j = 0; j < 3; j++)
                            {
                                Console.SetCursorPosition((2 * i) + 3, y - 1);
                                Console.Write(A3[i]);
                                i = i + 1;
                            }
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;
                        }
                        else if ((A1[i] == "D" && A2[i] == "E" && A3[i] == "U") || (A1[i] == "U" && A2[i] == "E" && A3[i] == "D"))//Vertical checking for 1 to 12
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((2 * i) + 3, y - 3);
                            Console.Write(A1[i]);
                            Console.SetCursorPosition((2 * i) + 3, y - 2);
                            Console.Write(A2[i]);
                            Console.SetCursorPosition((2 * i) + 3, y - 1);
                            Console.Write(A3[i]);
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;
                        }
                        else if ((A1[i] == "D" && A2[i + 1] == "E" && A3[i + 2] == "U") || (A1[i] == "U" && A2[i + 1] == "E" && A3[i + 2] == "D"))//Left slopped cross checking
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((2 * i) + 3, y - 3);
                            Console.Write(A1[i]);
                            Console.SetCursorPosition((2 * (i + 1)) + 3, y - 2);
                            Console.Write(A2[i + 1]);
                            Console.SetCursorPosition((2 * (i + 2)) + 3, y - 1);
                            Console.Write(A3[i + 2]);
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;
                        }
                        else if ((A3[i] == "D" && A2[i + 1] == "E" && A1[i + 2] == "U") || (A3[i] == "U" && A2[i + 1] == "E" && A1[i + 2] == "D"))//Right slopped cross checking
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((2 * (i + 2)) + 3, y - 3);
                            Console.Write(A1[i + 2]);
                            Console.SetCursorPosition((2 * (i + 1)) + 3, y - 2);
                            Console.Write(A2[i + 1]);
                            Console.SetCursorPosition((2 * i) + 3, y - 1);
                            Console.Write(A3[i]);
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;

                        }
                    }
                    else if (i == 13 || i == 14)
                    {
                        if ((A1[i] == "D" && A2[i] == "E" && A3[i] == "U") || (A1[i] == "U" && A2[i] == "E" && A3[i] == "D"))//Vertical checking for 13 and 14
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((2 * i) + 3, y - 3);
                            Console.Write(A1[i]);
                            Console.SetCursorPosition((2 * i) + 3, y - 2);
                            Console.Write(A2[i]);
                            Console.SetCursorPosition((2 * i) + 3, y - 1);
                            Console.Write(A3[i]);
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\nGame Is Over! \t" + names[12] + " Won!\n" + names[12] + "'s score is:" + scores[12]);
                            score_table = true;
                            break;
                        }
                    }
                    else if (A1[14] != null && A2[14] != null && A3[14] != null)//Check for if there is a winner
                    {
                        Console.WriteLine("\n\nGame Is Over! There is no winner");
                        score_table = true;
                        scores[12] = 0;//Directly mak the score equal the zero, thus scores is not show in score table
                        break;
                    }
                    System.Threading.Thread.Sleep(20);//Delay for see the game step by step
                }
                if (score_table == true)
                {
                    Console.WriteLine("\nPLAYER\t\tSCORE\n");
                    for (int i = 0; i < 12; i++)//Compares scores
                    {
            
                        if (scores[12] > scores[i])//If the winner's score is greater than other winner's score is written
                        {
                            Console.WriteLine(names[12] + "\t\t" + scores[12]);
                            scores[12] = 0;//winners score's value changed to 0 to dont write it again
                        }
                        Console.WriteLine(names[i] + "\t\t" + scores[i]);
                        if (i == 11 && scores[12] <= scores[i] && scores[12] != 0)//For writing winner's score if the winner's score is the least ore equal to 30
                            Console.WriteLine(names[12] + "\t\t" + scores[12]);
                    }
                    break;//Breaks the loop and finishes the game
                }
            }
            Console.WriteLine("\nThanks For Playing");
        }
    }
}
