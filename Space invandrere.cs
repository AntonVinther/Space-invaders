using System.Collections;
using System.Runtime.CompilerServices;
using static System.Console;
const char ship = 'H'; // Character to write on-screen.
const char shot = '*';
        int x = 50, y = 12; // Contains current cursor position.
        Write(ship); // Write the character on the default location (50,12).

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var command = Console.ReadKey().Key;

                switch (command)
                {
                    case ConsoleKey.A:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (x <= 100)
                        {
                            x++;
                        }
                        break;


                    case ConsoleKey.Spacebar:
                    int Yshot = 11;
                    int Ymax = 2;
                    while (Yshot >= Ymax)
                    {
                        SetCursorPosition(x, Yshot);
                        Yshot--;
                        Thread.Sleep(100);
                        WriteLine(shot);
                    }
                    break;
                }

                Write(ship, x, y);
                }
            else
            {
                Thread.Sleep(100);
            }


        }


    static void Write(char ship, int x = 0, int y = 0)
    {
        try
        {
            if (x >= 50 && y >= 12) // 0-based
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(ship);
            }
        }
        catch (Exception)
        {
        }

    }