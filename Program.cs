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
            
        }
    }
}
