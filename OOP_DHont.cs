using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DHont
{
    class politicalParty
    {
        public string partyName { get; set; }
        public int primaryVotes { get; private set; }
        public int secondaryVotes { get; set; }
        public int partySeats { get; set; }

        public politicalParty(string name, int votes)
        {
            partyName = name;
            primaryVotes = votes;
            secondaryVotes = votes;
        }

        public string printParty()
        {
            return $"Party Name: {partyName}  Initial Votes: {initialVotes}";
        }
        

        public void DHontMethod()
        {
            secondaryVotes = primaryVotes / (partySeats + 1);
            primaryVotes = secondaryVotes;
        }


        class DHontCalc : politicalParty
        {
            static void Main(string[] args)
            {

            }
        }

    }



}
