using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcepts
{
    public class Scoreboard
    {
        public delegate void SpeedLimitExceededEventHandler(object source, EventArgs e);
        public event SpeedLimitExceededEventHandler SpeedLimitExceeded;

        // Target hit message
        public void TargetHit()
        {
            Console.WriteLine("Target hit!");
        }

        // Points awarded message
        public void PointsAwarded()
        {
            Console.WriteLine("Points awarded!");
        }

        public void AnotherMethodAdded()
        {
            Console.WriteLine("Printing another method result !!");
        }

    }
}
