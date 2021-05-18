using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation9Lab
{
    class BasicSensor
    {
        private ulong M = 9223372036854775808;
        private double BETA = 4294967299;
        public double current_result;
        public BasicSensor()
        {
            current_result = BETA;
            for(int i = 0; i < 30; i++)
            {
                current_result = (BETA * current_result) % M;
            }
        }
        public double GetRandomNumber()
        {
            current_result = (BETA * current_result) % M;
            return current_result / M;
        }

        public int Next(int start, int end)
        {
            double size = end - start + 1;
            double randNum = GetRandomNumber();
            for(int i = 0; i < size; i++)
            {
                double prob = (1 / size) * (i + 1);
                if (prob > randNum)
                {
                    return (start + i);
                }
            }
            return 0;
        }
    }
}
