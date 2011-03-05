using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulatorClient client = new StringManipulatorClient();

            string value1 = "Hello Hannah, ";
            string value2 = "how are you today";
            string result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            value1 = result;
            value2 = "Hannah";
            string value3 = "Emma";
            result = client.Replace(value1, value2, value3);
            Console.WriteLine("Replace({0},{1}) = {2}", value1, value2, result);

            value1 = result;
            value2 = ", how are you today";
            result = client.Delete(value1, value2);
            Console.WriteLine("Delete({0},{1}) = {2}", value1, value2, result);

            client.Close();

            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();

        }
    }
}
