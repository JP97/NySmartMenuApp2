using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using FunctionLibrary;
using CalculatorLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu("TextFil.txt");
            menu.Activate();
        }
    }
}
