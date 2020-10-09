using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        private const int WIDTH = 21;
        private const int HIEGHT = 11;
        private const char character = '@';

        private Coordinates coordinates = new Coordinates();

        private Blocks block = Blocks.DIRT;
        private Faces dir = Faces.UP;

        /*
         * aaaaaaaaa
         * a       a
         * aaaaaaaaa
         */
        private char[,] gameField = new char[HIEGHT, WIDTH]; 

        public GameManager()
        {
            FillGameField();

            Console.WriteLine("A játék elkezdéséhez nyomjon meg egy gombot...");
            ConsoleKeyInfo cki = Console.ReadKey();
            do
            {
                if (cki != null && !(cki.Key.Equals(ConsoleKey.Escape)))
                {
                    CharacterMovement(cki);

                    Console.Write("Irányítás (WASD): ");
                    cki = Console.ReadKey();

                    DrawGameField();
                }
            } while (!cki.Key.Equals(ConsoleKey.Escape));
        }

        private void CheckBorder(int x = 0, int y = 0)
        {
            Coordinates _coords = new Coordinates();
            _coords.X = coordinates.X + x;
            _coords.Y = coordinates.Y + y;

            if (_coords.X > 0 && _coords.X < WIDTH - 1)
            {
                coordinates.X = _coords.X;
            }

            if (_coords.Y > 0 && _coords.Y < HIEGHT - 1)
            {
                coordinates.Y = _coords.Y;
            }
        }

        private void CharacterMovement(ConsoleKeyInfo cki)
        {
            #region Character Movement
            gameField[coordinates.Y, coordinates.X] = ' ';
            switch (cki.Key)
            {
                case ConsoleKey.A:
                    {
                        CheckBorder(x: -1);
                        break;
                    }case ConsoleKey.D:
                    {
                        CheckBorder(x: +1);
                        break;
                    }case ConsoleKey.W:
                    {
                        CheckBorder(y: -1);
                        break;
                    }case ConsoleKey.S:
                    {
                        CheckBorder(y: +1);
                        break;
                    }
                default:
                    {break;}
            }
            gameField[coordinates.Y, coordinates.X] = '@';
            #endregion

            #region Block Placement
            if (cki.Key.Equals(ConsoleKey.Spacebar))
            {
                Coordinates _block = new Coordinates();

                switch (dir)
                {
                    default:
                    case Faces.UP:
                        {
                            _block.X = coordinates.X - 1;
                            _block.Y = coordinates.Y;
                            break;
                        }
                }

                switch (block)
                {
                    default:
                    case Blocks.DIRT:
                        {
                            gameField[_block.Y, _block.X] = 'D';
                            break;
                        }
                }
            }
            #endregion
        }

        private void FillGameField()
        {
            for (int y = 0; y < HIEGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if ((x == 0) || (y == 0) ||
                        (x == WIDTH - 1) || (y == HIEGHT - 1))
                    {
                        gameField[y,x] = '#';
                    }
                    else
                    {
                        gameField[y, x] = ' ';
                    }
                }
            }

            coordinates.X = WIDTH / 2;
            coordinates.Y = HIEGHT / 2;

            gameField[coordinates.Y, coordinates.X] = character;
        }

        private void DrawGameField()
        {
            Console.Clear();
            for (int y = 0; y < HIEGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    Console.Write(gameField[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
