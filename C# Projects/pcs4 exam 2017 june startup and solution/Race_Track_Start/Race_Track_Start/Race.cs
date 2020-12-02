using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class Race 
    {
        #region This code is implemented for you
        
        private List<Participant> participants;

        public Race()
        {
            participants = new List<Participant>();
        }

        public void AddParticipant(Participant p)
        {
            participants.Add(p);
        }

        public void ChangeSpeedOfAllParticipants()
        {
            Random r = new Random();
            foreach (Participant p in participants)
            {
                p.ChangeSpeed(r.Next(3, 35));
            }
        }

        public List<Participant> GetParticipants()
        {
            return participants;
        }

        public void ResetParticipants()
        {
            foreach (Participant p in participants)
            {
                p.Reset();
            }
        }



        #endregion

        public void sortByName()
        {
            this.participants.Sort();
        }

        public void sortByAgeAndHobby()
        {
            this.participants.Sort(new Comparison<Participant>(this.CompareByAgeAndHobby));
        }

        public int CompareByAgeAndHobby(Participant first, Participant second)
        {
            int ageComparer =  first.Age.CompareTo(second.Age);
            if(ageComparer != 0)
            {
                return ageComparer;
            }
            else
            {
                return first.Hobby.CompareTo(second.Hobby);
            }
        }

        public Participant YoungestParticipant()
        {
            if(this.participants.Count == 0)
            {
                return null;
            }
            else
            {
                return YoungestParticipant(this.participants.Count);
            }
        }

        public Participant YoungestParticipant(int i)
        {
            if(i == 1)
            {
                return this.participants[0];
            }
            else
            {
                Participant youngestExceptLast = this.YoungestParticipant(i - 1);
                if(this.participants[i - 1].Age < youngestExceptLast.Age)
                {
                    return this.participants[i - 1];
                }
                else
                {
                    return youngestExceptLast;
                }
            }
        }

        /// <summary>
        /// This method updates all participants.
        /// </summary>
        /// <param name="finishLocation">The distance from the start on which the finish-line is located.</param>
        public void Update(int finishLocation)
        {
            foreach (Participant p in participants)
            {
                p.Update(finishLocation);
            }
        }
    }
}
