using CubeAlgs.Data.Models;
using System;
using System.Collections.Generic;

namespace CubeAlgs.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CubeAlgsDbContext())
            {
                var newSet = new Set();

                // Create group for set
                var groups = new List<Group>();
                var group = new Group
                {
                    Name = "Sample group 2",
                    Set = newSet,
                    SetId = newSet.Id
                };
                groups.Add(group);
                newSet.Groups = groups;
                newSet.Name = "Sample set 2";

                db.Sets.Add(newSet);
                db.SaveChanges();

                foreach (var set in db.Sets)
                {
                    Console.WriteLine(set.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
