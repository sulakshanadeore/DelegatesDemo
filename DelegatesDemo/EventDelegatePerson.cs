using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;
namespace DelegatesDemo
{
    class EventDelegatePerson
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Walk(100);

            Console.Read();

            

        }
    }
}
