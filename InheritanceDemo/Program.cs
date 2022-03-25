using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IRun> obj = new List<IRun>();

            obj.Add(new Person());
            obj.Add(new Animal());

        }

    }

    public interface IRun
    {
        void Run();
    }

    public class Person : IRun
    {
        public void Run()
        {

        }
    }

    public class Animal : IRun
    {
        public void Run()
        {

        }
    }


}
