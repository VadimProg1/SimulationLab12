using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation9Lab
{
    class Team
    {
        public int score, wins = 0, losses = 0, goalsScore = 0, missedGoalsScore = 0, draws = 0;
        public string name;
        public double lambda;
        public Team(string name, double lambda)
        {
            this.name = name;
            this.lambda = lambda;
        }
    }
}
