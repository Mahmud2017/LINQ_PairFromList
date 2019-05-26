using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    class Program
    {
        public enum TestEnum
        {
            n1,
            n2,
            n3,
            n4,
            n5,
            n6,
            n7,
            n8
        }

        static void Main(string[] args)
        {
            //Creating list from Enum
            var theList = Enum.GetValues(typeof(TestEnum)).Cast<TestEnum>();

            //Selecting pairs from the list without repeating the same pair
            var combo = (
                from l1 in theList
                from l2 in theList.Except(new List<TestEnum>() { l1 })
                where l1<l2
                select new List<TestEnum>() { l1, l2 }
                ).ToList();
        }
    }
}
