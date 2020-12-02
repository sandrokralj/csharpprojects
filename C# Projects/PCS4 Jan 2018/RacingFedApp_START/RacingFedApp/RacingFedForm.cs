using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingFedApp
{
    public partial class RacingFedForm : Form
    {
        private RedScoutForm redScoutFrm;                   // var for red scout window
        private BlueScoutForm blueScoutFrm;                 // var for blue scout window

        private List<Racer> racers = new List<Racer>();     // the list of all racers

        private LinkedListOfTestRides LL;

        public RacingFedForm()
        {
            InitializeComponent();
            this.redScoutFrm = new RedScoutForm();      // the window instance for Red Scout
            this.blueScoutFrm = new BlueScoutForm();    // the window instance for Blue Scout
            addSomeTestingStuff();
            showAllRacers();
            LL = new LinkedListOfTestRides();
        }



        private void showAllRacers()
        {
            lbRacers.Items.Clear();
            foreach (Racer r in racers)
            {
                lbRacers.Items.Add(r);
            }
        }

        // potential
        internal List<Racer> getAllRacers()
        {
            return this.racers;
        }

        private void addRacer(Racer r)
        {
            racers.Add(r);
            this.redScoutFrm.ShowAllProRacers(this.racers);
            this.blueScoutFrm.ShowAllProRacers(this.racers);
            if (r.Type == "pro")
            {
                r.rankChanged += new Racer.RankChangedHandler(redScoutFrm.showRankChanges);
                r.rankChanged += new Racer.RankChangedHandler(blueScoutFrm.showRankChanges);
            }
        }

        // you may assume valid user tb inputs
        private void btnAddRacer_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(tbNr.Text);
            string name = tbName.Text;
            int rank = Convert.ToInt32(tbNrOfWins.Text);
            string type = tbType.Text;
            int nrOfWins = Convert.ToInt32(tbNrOfWins.Text);
            Racer r = new Racer(nr, name, rank, type, nrOfWins);
            addRacer(r);
            showAllRacers();
        }

        private void btnSortRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 1a
            this.racers.Sort();
            showAllRacers();
        }

        private void btnSortTypeNrOfWins_Click(object sender, EventArgs e)
        {
            // to do: assignment 1b
            racers.Sort(new Comparison<Racer>(this.compareByTypeAndNrOfWins));
            showAllRacers();
        }

        private void btnChangeRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 2
            Racer selected = (Racer)(lbRacers.SelectedItem);
            if (selected != null)
            {
                selected.setRank(Convert.ToInt32(this.tbNewRank.Text));
            }
            showAllRacers();
        }


        private void btnAddTestRide_Click(object sender, EventArgs e)
        {
            // to do: assignment 3b
            Racer selected = (Racer)(lbRacers.SelectedItem);
            if (selected != null)
            {
                this.LL.addRacerToList(selected);
            }
            showAllRacers();
        }

        private void btnGetHighestRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 4
            if(this.racers.Count == 0)
            {
                MessageBox.Show("There are no racers, so noone is highest rank.");
            }
            else
            {
                MessageBox.Show("The highest rank is " + getHighestRank(this.racers.Count));
            }
        }

        private int getHighestRank(int n)
        {
            if(n == 0)
            {
                return this.racers[0].Rank;
            }
            else
            {
                int comparer = getHighestRank(n - 1);
                if(comparer < this.racers[n - 1].Rank)
                {
                    return this.racers[n - 1].Rank;
                }
                else
                {
                    return comparer;
                }
            }
        }


        private int compareByTypeAndNrOfWins(Racer first, Racer second)
        {
            int typeComparer = first.Type.CompareTo(second.Type);
            if(typeComparer == 0)
            {
                return second.NrOfWins - first.NrOfWins;
            }
            else
            {
                return typeComparer;
            }
        }


        private void addSomeTestingStuff()
        {
            addRacer(new Racer(45, "Marko", 100, "pro", 5));
            addRacer(new Racer(33, "Alban", 95, "pro", 4));
            addRacer(new Racer(41, "Jack", 100, "pro", 4));
            addRacer(new Racer(37, "Arnaud", 88, "pro", 0));
            addRacer(new Racer(45, "Davide", 83, "pro", 1));
            addRacer(new Racer(11, "Jean", 59, "pro", 0));
            addRacer(new Racer(21, "Eric", 91, "rec", 3));
            addRacer(new Racer(61, "Gary", 91, "pro", 2));
        }


    }
}
