﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingFedApp
{
    public class Racer : IComparable<Racer>
    {
        private static int nextFreeRacerId; // keeps track of nr of racers objects created
                                            // used to assign the next free nr
        private int id;                     // a unique number value for a racer

        private int nr;                     // racer (competition) nr
        private string name;                // name of racer
        private int rank;                   // rank of racer
        private string type;                // field that indicates if racer is a pro or (recreational) amateur 
        private int nrOfWins;

        // properties
        public int Id { get { return this.id; } }
        public int Nr { get { return this.nr; } }
        public string Name { get { return this.name; } }
        public int Rank { get { return this.rank; } }
        public string Type { get { return this.type ; } }
        public int NrOfWins { get { return this.nrOfWins; } }

        // todo assignment 2 
        public delegate void RankChangedHandler(Racer r);
        public event RankChangedHandler rankChanged;

        // constructor
        public Racer(int nr, string name, int rank, string type, int nrOfWins)
        {
            this.id = nextFreeRacerId;
            nextFreeRacerId++;
            this.nr = nr;
            this.name = name;
            this.rank = rank;
            this.type = type;
            this.nrOfWins = nrOfWins;
        }

        // methods
        public void setRank(int rank)
        {
            this.rank = rank;
            //to do assignment 2
            if(rankChanged != null)
            {
                rankChanged(this);
            }
        }


        public override string ToString()
        {
            string holder = this.id.ToString() + " : " + this.nr + " " + this.name +
                " rank: " + this.rank.ToString() +
                " type: " + this.type.ToString() +
                " nr of wins: " + this.nrOfWins.ToString();
            return holder;
        }

        public int CompareTo(Racer other)
        {
            return this.Rank - other.Rank;
        }
    }
}
