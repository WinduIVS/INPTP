using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv02HraPismen
{
    class Stats
    {
        public int Correct = 0;
        public int Missed = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {

            if (correctKey)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }

            Accuracy = 100 * Correct / (Correct + Missed);

        }

    }
}
