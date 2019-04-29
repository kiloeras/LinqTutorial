using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{

    public class Params : IEnumerable<int>
    {
        private int a, b, c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Persona
    {
        private string FirstName, MiddleName, LastName;

        public Persona(string fristName, string middleName, string lastName)
        {
            FirstName = fristName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public IEnumerable<string> Names
        {
            get
            {
                yield return FirstName;
                yield return MiddleName;
                yield return LastName;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Params = new Params(1,2,3);
            var persona = new Persona("Miguel", "Angel", "Morales");

            foreach (var param in Params)
                Console.WriteLine(param);

            foreach (var name in persona.Names)
                Console.WriteLine(name);

            Console.ReadLine();

        }
    }
}
