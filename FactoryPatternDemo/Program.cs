using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mobile name");
            Console.WriteLine("Enter Father Name");
            string result=Console.ReadLine();
            IMobileDetail type=MobileInformation.MobileType(result);
            Console.WriteLine(type.Name());
            Console.WriteLine(type.OperatingSystem());
        }
    }
    class MobileInformation
    {
        public static IMobileDetail MobileType(string name)
        {
            IMobileDetail value = null;
            if(name=="Nokia")
            {
                value=new Nokia();
            }
            else
            {
                value = new Apple();
            }
            return value;
        }
    }
    interface IMobileDetail
    {
        string Name();
        string OperatingSystem();
    }
    public class Nokia:IMobileDetail
    {
        public string Name()
        {
            return "Nokia6";
        }
        public string OperatingSystem()
        {
            return "nokia 6 uses 424 qualcum processor";
        }
    }

    public class Apple:IMobileDetail
    {
        public string Name()
        {
            return "Apple5";
        }
        public string OperatingSystem()
        {
            return "Apple5 uses 424 qualcum processor";
        }
    }
}
