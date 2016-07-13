using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.InheritanceHierarchy.BusinessEntity;
namespace Artech.InheritanceHierarchy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleWhetherForecastClient client = new SimpleWhetherForecastClient();
            BasicWhetherInfo info =client.GetBasicWhetherInfo("252660");
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
