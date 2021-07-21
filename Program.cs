using System;
using System.Collections.Generic;
using Multi_Value_Dictionary.Extensions;

namespace Multi_Value_Dictionary
{
    class Program
    {
        public static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public static void Main(string[] args)
        {
            do
            {

                var inputs = Console.ReadLine().Split("");
                string command = "";
                string key = "";
                string member = "";
                switch (inputs.Length)
                {
                    case 1:
                        command = inputs[0].ToUpper();
                        break;
                    case 2:
                        command = inputs[0].ToUpper();
                        key = inputs[1];
                        break;
                    case 3:
                        command = inputs[0].ToUpper();
                        key = inputs[1];
                        member = inputs[2];
                        break;
                    default:
                        break;

                }

                switch(command)
                {
                    case "ADD":
                        dict.Add(key, member);
                        break;
                    case "MEMBERS":
                        dict.Members(key);
                        break;
                    case "ALLMEMBERS":
                        dict.AllMembers();
                        break;
                    case "MEMBEREXISTS":
                        dict.MemberExists(key, member);
                        break;
                    case "KEYS":
                        dict.Keys();
                        break;
                    case "KEYEXISTS":
                        dict.KeyExists(key);
                        break;
                    case "REMOVE":
                        dict.Remove(key, member);
                        break;
                    case "CLEAR":
                        dict.ClearItems();
                        break;
                    case "ITEMS":
                        dict.Items();
                        break;                    
                    case "REMOVEALL":
                        dict.RemoveAll(key);
                        break;
                    default:
                        Console.WriteLine("ERROR, Invalid Command.");
                        break;
                }

            }
            while (Console.ReadLine().ToUpper() != "EXIT");
            Console.WriteLine("Hello World!");
        }
    }
}
