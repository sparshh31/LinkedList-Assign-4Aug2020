using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLListAssign
{
    public class Person
    {
        public int age
        {
            get;
            set;
        }

        public string fname
        {
            get;
            set;
        }
        public string lname
        {
            get;
            set;
        }
        public string city
        {
            get;
            set;
        }
        public Person()
        {

        }
        public Person(int _age, string _fanme, string _lname, string _city)
        {
            age = _age;
            fname = _fanme;
            lname = _lname;
            city = _city;


        }
        public void Display()
        {

            Console.WriteLine("Name :{0} ", fname + lname);
            Console.WriteLine("Age :{0}", age);
            Console.WriteLine("City :{0}", city);
        }
    }
    class ListAssign
    {
        static void Main()
        {
            List<Person> li = new List<Person>()
            {

                new Person(){ age=21, fname="Sparsh",lname=" Singh",city="Punjab"},
                new Person(){ age=22, fname="Ritika",lname=" Chandel",city="Delhi"},
                new Person(){ age=18, fname="Riya",lname=" Sharma",city="Mumbai"},
                new Person(){ age=40, fname="Priya",lname=" Bir",city="Jammu"},
                new Person(){ age=35, fname="Aayush",lname=" Verma",city="Himachal"}

            };
            Console.WriteLine("Details of the 5 Person:");
            foreach (var p in li)
            {
                p.Display();

            }

        }

    }
}

