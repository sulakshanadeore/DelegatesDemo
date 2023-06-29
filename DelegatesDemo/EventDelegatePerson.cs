using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;
namespace DelegatesDemo
{
    //This is a event demo 
    //one more change
    
    class EventDelegatePerson
    {
        static void Main(string[] args)
        {
            //Error here
            Person p = new Person();
            p.Walk(100);

            Console.Read();

            

        }
    }
}
