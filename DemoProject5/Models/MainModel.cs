using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject5.Models
{
    public class MainModel
    {
        public event EventHandler<PersonEventArgs> CreatedPerson;
        private Random random;
        private string[] names = {"Jani","Kati","Peti","Anna","Béla","Zsófi"};

        public MainModel()
        {
            random = new Random();

        }
        public void GeneratePeople()
        {
            string name = names[random.Next(names.Length)];
            Person person = new Person(name, string.Empty, string.Empty, string.Empty);
            CreatedPerson.Invoke(this, new PersonEventArgs(person));
        }
    }
}
