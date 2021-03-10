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
        public int initialVotes { get; private set; }
        public int subsequentVotes { get; set; }
        public int partySeats { get; set; }

        public politicalParty(string name, int votes)
        {
            partyName = name;
            initialVotes = votes;
            subsequentVotes = votes;
        }

        public string printParty()
        {
            return $"Party Name: {partyName}  Initial Votes: {initialVotes}";
        }
        

        public void DHontMethod()
        {
            subsequentVotes = initialVotes / (partySeats + 1);
        }


    }



}
