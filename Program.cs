namespace _20241203_ConsoleGameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo info = Console.ReadKey();

            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            Direction dir = Direction.No;

            ulong gameTime = 0;
            uint deltaTime = 1;

            do
            {
                // Show
                Console.SetCursorPosition(x, y);
                Console.Write('*');
                System.Threading.Thread.Sleep(40);


                if (Console.KeyAvailable)
                {
                    info = Console.ReadKey();

                    switch (info.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            dir = Direction.Left;
                            break;
                        case ConsoleKey.UpArrow:
                            dir= Direction.Up;
                            break;
                        case ConsoleKey.RightArrow:
                            dir = Direction.Right;
                            break;
                        case ConsoleKey.DownArrow:
                            dir = Direction.Down;
                            break;
                        case ConsoleKey.Spacebar:
                            dir = Direction.No;
                            break;
                        case ConsoleKey.A:
                            deltaTime++;
                            break;
                        case ConsoleKey.Z:
                            if (deltaTime > 1)
                            {
                                deltaTime--;
                            }
                            break;
                        default:
                            break;
                    }
                }
                
                // Hide
                Console.SetCursorPosition(x, y);
                Console.Write(' ');

                if (gameTime % deltaTime == 0)
                {
                    switch (dir)
                    {
                        case Direction.Left:
                            x -= 1;
                            break;
                        case Direction.Up:
                            y -= 1;
                            break;
                        case Direction.Right:
                            x += 1;
                            break;
                        case Direction.Down:
                            y += 1;
                            break;

                        default:
                            break;
                    }
                }

                ++gameTime;
            } while (info.Key != ConsoleKey.Escape);



        }
    }
}