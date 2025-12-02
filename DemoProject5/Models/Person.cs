using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace DemoProject5.Models
{
    public class Person
    {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public string Gender { get; private set; }
        public string Color { get; private set; }
        public RelayCommand DeleteCommand { get; set; }

        public Person(string name,string age, string gender, string color) 
        { 
            Name = name;
            Age = age;
            Gender = gender;
            Color = color;
        }
    }
}
