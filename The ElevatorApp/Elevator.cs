using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheElevatorApp
{
    public enum Direction
    {
        None,
        Up,
        Down
    }
    public class Elevator
    {
        public int CurrentFloor { get; set; }
        public Direction CurrentDirection { get; set; }

        public Elevator()
        {
            CurrentFloor = 1;
            CurrentDirection = Direction.None;
        }

        public void MoveTo1or5(int calledFrom)
        {
            CurrentFloor = calledFrom;
        }

        public void UpAndDown(int targetFloor)
        {
            CurrentDirection = targetFloor > CurrentFloor ? Direction.Up : Direction.Down;

            while (CurrentFloor != targetFloor)
            {
                CurrentFloor += CurrentDirection == Direction.Up ? 1 : -1;
            }
        }
        

    }
}
