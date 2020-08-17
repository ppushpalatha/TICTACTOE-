using System;
namespace Assignment2
{
        class TicTacToe
        {
            static char[] array = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static void Main(string[] args)
            {
            TicTacToe obj = new TicTacToe();
                int player = 1, i, choice;
                char mark;
                do
                {
                    obj.board();
                    if (player % 2 == 1)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 2;
                    }
                    Console.WriteLine("Player {0}, enter a number:  ", player);
                    choice = Convert.ToInt32(Console.ReadLine());
                    mark = (player == 1) ? 'X' : 'O';
                    if (choice == 1 && array[0] == '1')
                        array[0] = mark;
                    else if (choice == 2 && array[1] == '2')
                        array[1] = mark;
                    else if (choice == 3 && array[2] == '3')
                        array[2] = mark;
                    else if (choice == 4 && array[3] == '4')
                        array[3] = mark;
                    else if (choice == 5 && array[4] == '5')
                        array[4] = mark;
                    else if (choice == 6 && array[5] == '6')
                        array[5] = mark;
                    else if (choice == 7 && array[6] == '7')
                        array[6] = mark;
                    else if (choice == 8 && array[7] == '8')
                        array[7] = mark;
                    else if (choice == 9 && array[8] == '9')
                        array[8] = mark;
                    else
                    {
                        Console.WriteLine("Invalid move "); 
                        player--;
                    }
                    i = obj.checkwin();
                    player++;
                } 

                    while (i == -1);
                  obj.board();
                   if (i == 1)
                    Console.WriteLine("==>\aPlayer {0} win ", --player);
                else
                    Console.WriteLine("==>\aGame draw");
                Console.ReadKey();
            }


        void board()
        {

            Console.WriteLine("\tTic Tac Toe Game\n");
            Console.WriteLine("Player 1 (X)  -  Player 2 (O)");

            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array[0], array[1], array[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array[3], array[4], array[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", array[6], array[7], array[8]);
            Console.WriteLine("   |   |   \n");
        }
        int checkwin()
            {
                if (array[0] == array[1] && array[1] == array[2])
                    return 1;
                else if (array[3] == array[4] && array[4] == array[5])
                    return 1;
                else if (array[6] == array[7] && array[7] == array[8])
                    return 1;
                else if (array[0] == array[3] && array[3] == array[6])
                    return 1;
                else if (array[1] == array[4] && array[4] == array[7])
                    return 1;
                else if (array[2] == array[5] && array[5] == array[8])
                    return 1;
                else if (array[0] == array[4] && array[4] == array[8])
                    return 1;
                else if (array[2] == array[4] && array[4] == array[6])
                    return 1;
                else if (array[0] != '1' && array[1] != '2' && array[2] != '3' &&
                    array[3] != '4' && array[4] != '5' && array[5] != '6' && array[6]
                    != '7' && array[7] != '8' && array[8] != '9')
                    return 0;
                else
                    return -1;
            }


           

        }
    }
