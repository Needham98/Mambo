using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Subject
    {
        private Subjects subjects;
        private Abilities[] abilities= new Abilities[9];
        private string description;

        public Subject(Subjects subjects, Abilities[] abilities, string description)
        {
            this.subjects = subjects;
            this.abilities = abilities;
            this.description = description;
        }

    }
}
