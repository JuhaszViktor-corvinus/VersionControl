﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace taks_week10
{
    
        public partial class Form1 : Form
        {
        Brain winnerBrain = null;
        GameController gc = new GameController();
        GameArea ga;
        private object label1;

        public Form1()
            {
                ga = gc.ActivateDisplay();
                this.Controls.Add(ga);
                gc.AddPlayer();
                gc.Start(true);

                int populationSize = 100;
                int nbrOfSteps = 10;
                int nbrOfStepsIncrement = 10;
                int generation = 1;
                gc.GameOver += Gc_GameOver;

                for (int i = 0; i < populationSize; i++)
                {
                    gc.AddPlayer(nbrOfSteps);
                }
                gc.Start();
                var playerList = from p in gc.GetCurrentPlayers()
                                 orderby p.GetFitness() descending
                                 select p;
                var topPerformers = playerList.Take(populationSize / 2).ToList();

                 void Gc_GameOver(object sender)
                {
                    generation++;
                    label1.Text = string.Format(
                    "{0}. generáció",
                    generation);
                gc.ResetCurrentLevel();

                foreach (var p in topPerformers)
                {
                    var b = p.Brain.Clone();
                    if (generation % 3 == 0)
                        gc.AddPlayer(b.ExpandBrain(nbrOfStepsIncrement));
                    else
                        gc.AddPlayer(b);

                    if (generation % 3 == 0)
                        gc.AddPlayer(b.Mutate().ExpandBrain(nbrOfStepsIncrement));
                    else
                        gc.AddPlayer(b.Mutate());
                }
                var winners = from p in topPerformers
                              where p.IsWinner
                              select p;
                if (winners.Count() > 0)
                {
                    winnerBrain = winners.FirstOrDefault().Brain.Clone();
                    gc.GameOver -= Gc_GameOver;
                    return;
                }
                gc.Start();
            }

        }
    }
}
