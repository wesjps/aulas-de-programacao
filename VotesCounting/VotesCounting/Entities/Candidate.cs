using System;
using System.Collections.Generic;
using System.Text;

namespace VotesCounting.Entities
{
    class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

    }
}
