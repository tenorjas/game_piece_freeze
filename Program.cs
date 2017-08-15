using System;

namespace game_piece_freeze
{
    class Program
    {
        public class GamePiece
        {
            public int PositionX {get; set;}
            public int PositionY {get; set;}
            public bool Frozen {get; set;}
            public string Name {get; set;}
            public string Color {get; set;}

            public void InitialConditions()
            {
                PositionX = 0;
                PositionY = 0;
                Frozen = false;
            }

            public void Move(int newX, int newY)
            {
                if (!Frozen)
                {
                    PositionX = newX;
                    PositionY = newY;
                }
            }

            public void Freeze()
            {
                Frozen = true;
            }

            public void Unfreeze()
            {
                Frozen = false;
            }
        }
        static void Main(string[] args)
        {
            var gamePiece = new GamePiece();
            gamePiece.Name = "Queen";
            gamePiece.Color = "Black";

            Console.WriteLine($"The {gamePiece.Name} is at X = {gamePiece.PositionX}, Y = {gamePiece.PositionY}.");

            gamePiece.Move(10,8);

            Console.WriteLine($"The {gamePiece.Name} is at X = {gamePiece.PositionX}, Y = {gamePiece.PositionY}.");

            gamePiece.Freeze();
            gamePiece.Move(5,4);
            Console.WriteLine($"The {gamePiece.Name} is at X = {gamePiece.PositionX}, Y = {gamePiece.PositionY}.");

            gamePiece.Unfreeze();
            gamePiece.Move(5,4);
            Console.WriteLine($"The {gamePiece.Name} is at X = {gamePiece.PositionX}, Y = {gamePiece.PositionY}.");
        }
    }
}
