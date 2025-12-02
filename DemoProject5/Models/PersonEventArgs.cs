using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject5.Models
{
    public class PersonEventArgs:EventArgs
    {
        public Person NewPerson { get; private set; }
    
        public PersonEventArgs(Person newPerson)
        {
            NewPerson = newPerson;
        }
    }
}
