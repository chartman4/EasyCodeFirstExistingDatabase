using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EasyDBFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AdventureWorksEntities())
            {


                foreach (var person in context.People)
                {
                    Console.WriteLine(person.LastName + ", " + person.FirstName);
                }

                Console.ReadLine();
            };
        }
    }
}
