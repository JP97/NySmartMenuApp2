using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuApp
{
    public class Binding
    {
        static void SwitchCase(int caseSwitch)
        {
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("du har valgt nr. 1");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("du har valgt nummer 2");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("du har valgt nummer 3");
                    Console.ReadLine();
                    break;

                default:
                    break;

            }
        }
        
}
}
