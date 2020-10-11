using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using VotesCounting.Entities;

namespace VotesCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "c:/temp/in.txt";
            Dictionary<string, int> list = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] prov = sr.ReadLine().Split(',');
                        string candidate = prov[0];
                        int votes = int.Parse(prov[1]);

                       if (list.ContainsKey(candidate)){
                            list[candidate] += votes;
                        }
                        else
                        {
                            list[candidate] = votes;
                        }
                    }
                }

                
                foreach(var cand in list)
                {
                    Console.WriteLine(cand.Key + ", " + cand.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error found" + e.Message);
            }

        }
    }
}
