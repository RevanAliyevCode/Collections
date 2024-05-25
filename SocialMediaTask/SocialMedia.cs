using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaTask
{
    public class SocialMedia
    {
        public Dictionary<string, List<string>> Friends { get; } = [];

        public void AddFriend(string name, params string[] friends)
        {
            if (Friends.ContainsKey(name)) Friends[name] = new List<string>(friends);
            else Friends[name].AddRange(friends);
        }

        public void RemoveFriend(string name, params string[] friends)
        {
            if (Friends.ContainsKey(name)) foreach (string i in friends) Friends[name].Remove(i);
            else Console.WriteLine("There is not such a user");
        }

        public void GetAllFriendsByUserName(string name)
        {
            if (Friends.ContainsKey(name))
            {
                Console.WriteLine($"{name}:");
                foreach (string v in Friends[name])
                {
                    Console.WriteLine($" {v}");
                }
            }
            else Console.WriteLine("There is not such a user");
        }
    }
}
