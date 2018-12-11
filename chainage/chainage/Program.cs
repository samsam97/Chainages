using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace chainage
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] regle1 = new[] {"A","B","C"};
            string[] regle2 = new[] {"I","H"};
            string[] regle3 = new[] {"H","H"};
            string[] regle4 = new[] {"A"};
            string[] regle5 = new[] {"E","F"};
            string[] regle6 = new[] {"A"};
            string[] regle7 = new[] {"K","L"};
            string[] regle8 = new[] {"A"};

            Dictionary<string,string[]> baseDeRegle = new Dictionary<string, string[]>();

            foreach (KeyValuePair<string, string[]> kvp in baseDeRegle)
            {
                if(kvp.Value.Contains(kvp.Key))
                
            }
            
        }

        public bool checkIfKeyIsInArray(KeyValuePair key, string[] array)
        {
            var result = false;
            foreach (var value in array)
            {
                if (value == key)
                    result = true;
            }
            return result;

        }
    }
}

