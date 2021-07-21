using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Value_Dictionary.Extensions
{
    public static class DictionaryExtension
    {

        /// <summary>
        /// Adds a member to a collection for a given key. Displays an error if the member already exists for the key.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="member"></param>
        public static void Add(this Dictionary<string, List<string>> dict, string key, string member)
        {
            if(dict.ContainsKey(key))
            {
                var members = dict[key];

                if(!members.Contains(member))
                {
                    members.Add(member);
                    Console.WriteLine("Added");
                }
                else
                {
                    Console.WriteLine("ERROR, member already exists for key");
                }
            }
            else
            {
                dict.Add(key, member);
                Console.WriteLine("Added");
            }
        }

        /// <summary>
        /// Returns all the keys in the dictionary.
        /// </summary>
        /// <param name="dict"></param>
        public static void Keys(this Dictionary<string, List<string>> dict)
        {
            if(dict.Any())
            {
                foreach(var item in dict.Select((s,i) => new { Value = s, Index = i }))
                {
                    Console.WriteLine($"{item.Index}) {item.Value.Key}");
                }
            }
            else
            {
                Console.WriteLine("There are no keys in the dictionary.");
            }
        }

        /// <summary>
        /// Returns the collection of strings for the given key. Returns an error if the key does not exists.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        public static void Members(this Dictionary<string, List<string>> dict, string key)
        {
            if(dict.ContainsKey(key))
            {
                var members = dict[key];
                foreach (var member in members.Select((m, i) => new { Value = m, Index = i }))
                {
                    Console.WriteLine($"{member.Index}) {member.Value}");
                }
            }
            else
            {
                Console.WriteLine("ERROR, key does not exist");
            }
        }

        /// <summary>
        /// Returns all the members in the dictionary. Returns nothing if there are none.
        /// </summary>
        /// <param name="dict"></param>
        public static void AllMembers(this Dictionary<string, List<string>> dict)
        {
            int index = 1;
            if (dict.Any())
            {
                foreach (var entry in dict)
                {
                    foreach (var item in entry.Value)
                    {
                        Console.WriteLine($"{index}) {item}");
                        index++;
                    }
                }
            }
        }

        /// <summary>
        /// Removes a member from a key.  If the last member is removed from the key, the key is removed from the dictionary. If the key or member does not exist, displays an error.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="member"></param>
        public static void Remove(this Dictionary<string, List<string>> dict, string key, string member)
        {
            if(dict.ContainsKey(key))
            {
                var members = dict[key];
                if(members.Contains(member))
                {
                    members.Remove(member);
                    Console.WriteLine("Removed");
                }
                else
                {
                    Console.WriteLine("ERROR, member does not exist");
                }
            }
            else
            {
                Console.WriteLine("ERROR, key does not exist");
            }
        }

        /// <summary>
        /// Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        public static void RemoveAll(this Dictionary<string, List<string>> dict, string key)
        {
            if(dict.ContainsKey(key))
            {
                dict.Remove(key);
                Console.WriteLine("Removed");
            }
            else
            {
                Console.WriteLine("ERROR, key does not exist");
            }
        }

        /// <summary>
        /// Removes all keys and all members from the dictionary.
        /// </summary>
        /// <param name="dict"></param>
        public static void ClearItems(this Dictionary<string, List<string>> dict)
        {
            dict.Clear();
            Console.WriteLine("Cleared");
        }

        /// <summary>
        /// Returns whether a key exists or not.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        public static void KeyExists(this Dictionary<string, List<string>> dict, string key)
        {
            Console.WriteLine($"{dict.ContainsKey(key)}");
        }

        /// <summary>
        /// Returns whether a member exists within a key.  Returns false if the key does not exist.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="member"></param>
        public static void MemberExists(this Dictionary<string, List<string>> dict, string key, string member)
        {
            if(dict.ContainsKey(key))
            {
                var members = dict[key];
                Console.WriteLine($"{members.Contains(member)}");
            }
            else
            {
                Console.WriteLine($"false");
            }
        }

        /// <summary>
        /// Returns all keys in the dictionary and all of their members.  Returns nothing if there are none.
        /// </summary>
        /// <param name="dict"></param>
        public static void Items(this Dictionary<string, List<string>> dict)
        {
            int index = 1;
            if (dict.Any())
            {
                foreach (var entry in dict)
                {
                    foreach(var item in entry.Value)
                    {
                        Console.WriteLine($"{index}) {entry.Key}: {item}");
                        index++;
                    }
                }
            }
        }
    }
}
