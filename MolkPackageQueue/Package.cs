﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    public class Package : IComparable<Package>
    {
        public Package(Priority priority)
        {
            Priority = priority;
            Payload = new Payload();
        }
        public Priority Priority { get; }
        public Payload Payload { get; }

        public int CompareTo(Package? other)
        {

            if (Priority < other.Priority)
            {
                return -1;
            }
            else if (Priority > other.Priority)
            {
                return 1;
            }
            return 0;
        }
    }

    public enum Priority 
    { 
        Low = 0, 
        Medium = 1, 
        High = 2 
    }

    

    public class Payload 
    {
        String packageName = GetPackageName();

        public String PackageName
        {
            get { return packageName; }
        }

        private static String GetPackageName()
        {
            Random res = new Random();

            // String of alphabets  
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 10;

            // Initializing the empty string 
            String ran = "";

            for (int i = 0; i < size; i++)
            {
                // Selecting a index randomly 
                int x = res.Next(26);

                // Appending the character at the  
                // index to the random string. 
                ran = ran + str[x];  
            }
            return ran;
        }      
    }
}
