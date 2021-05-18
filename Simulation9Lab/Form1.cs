using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation9Lab
{
    public partial class Form1 : Form
    {
        static private Team team1 = new Team("Зенит", 5);
        static private Team team2 = new Team("ЦСКА", 5);
        static private Team team3 = new Team("Динамо", 4);
        static private Team team4 = new Team("Краснодар", 4);
        static private Team team5 = new Team("Локомотив", 3);
        static private Team team6 = new Team("Спартак", 3);
        static private Team team7 = new Team("Рубин", 2);
        static private Team team8 = new Team("Кубань", 2);
        private List<Team> teams = new List<Team>() { team1, team2, team3, team4, team5, team6, team7, team8 };
        private BasicSensor rnd = new BasicSensor();
        private List<List<bool>> graph = new List<List<bool>>();
        private const int TOURS = 7;
        private const int MATCHES_IN_TOUR = 4;
        private int currentTour = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                string[] str = { Convert.ToString(teams[i].name), Convert.ToString(teams[i].wins + teams[i].losses + teams[i].draws),
                    Convert.ToString(teams[i].wins), Convert.ToString(teams[i].draws),
                    Convert.ToString(teams[i].losses), Convert.ToString(teams[i].goalsScore),
                    Convert.ToString(teams[i].missedGoalsScore), Convert.ToString(teams[i].score)};
                data.Rows.Add(str);
            }

            for (int i = 0; i < teams.Count; i++)
            {
                List<bool> temp = new List<bool>();
                for (int j = 0; j < teams.Count; j++)
                {
                    bool f = false;
                    temp.Add(f);
                }
                graph.Add(temp);
            }
        }

        private void PlayTour(int amount_of_matches)
        {
            int counter = 0;
            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph.Count; j++)
                {
                    if (i != j)
                    {
                        if (!graph[i][j])
                        {
                            Match(teams[i], teams[j]);
                            graph[i][j] = true;
                            graph[j][i] = true;
                            counter++;
                            if(counter >= 4)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void Match(Team team1, Team team2)
        {
            int x1 = 0, x2 = 0;
            double S1 = 0, S2 = 0, a = rnd.GetRandomNumber();

            S1 += Math.Log10(a);
            while (S1 > -team1.lambda)
            {
                x1 += 1;
                S1 += Math.Log10(a);
            }
            a = rnd.GetRandomNumber();
            S2 += Math.Log10(a);
            while (S2 > -team2.lambda)
            {
                x2 += 1;
                S2 += Math.Log10(a);
            }

            if(x1 > x2)
            {
                team1.wins += 1;
                team2.losses += 1;
            }
            else if(x1 < x2)
            {
                team2.wins += 1;
                team1.losses += 1;
            }
            else
            {
                team2.draws += 1;
                team1.draws += 1;
            }
            team2.goalsScore += x2;
            team2.missedGoalsScore += x1;
            team2.score = team2.wins * 3 + team2.draws;
            team1.goalsScore += x2;
            team1.missedGoalsScore += x1;
            team1.score = team1.wins * 3 + team1.draws;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetData();
            currentTour = 0;
            label_totalTours.Text = Convert.ToString(currentTour) + " / " + TOURS;
            button_playOneTour.Enabled = true;
            button1.Enabled = false;
        }
        private void ResetData()
        {
            team1 = new Team("Зенит", 3.1);
            team2 = new Team("ЦСКА", 3.1);
            team3 = new Team("Динамо", 3);
            team4 = new Team("Краснодар", 2.7);
            team5 = new Team("Локомотив", 2.6);
            team6 = new Team("Спартак", 2.4);
            team7 = new Team("Рубин", 1.6);
            team8 = new Team("Кубань", 1.5);
            teams = new List<Team>() { team1, team2, team3, team4, team5, team6, team7, team8 };

            graph.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                List<bool> temp = new List<bool>();
                for (int j = 0; j < teams.Count; j++)
                {
                    bool f = false;
                    temp.Add(f);
                }
                graph.Add(temp);
            }
            data.Rows.Clear();
        }

        private void button_playOneTour_Click(object sender, EventArgs e)
        {
            if(currentTour < TOURS)
            {
                data.Rows.Clear();
                PlayTour(MATCHES_IN_TOUR);
                currentTour++;
                label_totalTours.Text = Convert.ToString(currentTour) + " / " + TOURS;
                teams.Sort((Team first, Team second) => first.score == second.score
                                                   ? 0
                                                   : first.score > second.score
                                                       ? -1
                                                       : first.score < second.score
                                                           ? 1
                                                           : first.score.CompareTo(second.score));
                for (int i = 0; i < teams.Count; i++)
                {
                    string[] str = { Convert.ToString(teams[i].name), Convert.ToString(teams[i].wins + teams[i].losses + teams[i].draws),
                    Convert.ToString(teams[i].wins), Convert.ToString(teams[i].draws),
                    Convert.ToString(teams[i].losses), Convert.ToString(teams[i].goalsScore),
                    Convert.ToString(teams[i].missedGoalsScore), Convert.ToString(teams[i].score)};
                    data.Rows.Add(str);
                }
            }
            else
            {
                button1.Enabled = true;
                button_playOneTour.Enabled = false;
            }           
        }
    }
}
