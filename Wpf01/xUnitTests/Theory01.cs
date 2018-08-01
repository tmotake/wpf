using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTests
{
    public class Theory01
    {
        public Theory01()
        {

        }

        public int Kakunin()
        {
            var people = new List<Person>()
            {
                new Person() { Id = 1, Name = "Bob", Age = 17, State = "New York" }
                , new Person() { Id = 2, Name = "Nancy", Age = 18, State = "California" }
                , new Person() { Id = 3, Name = "Robert", Age = 18, State = "California" }
                , new Person() { Id = 4, Name = "Lisa", Age = 18, State = "California" }
                , new Person() { Id = 5, Name = "Saya", Age = 17, State = "New York" }
                , new Person() { Id = 6, Name = "Alice", Age = 17, State = "California" }
                , new Person() { Id = 7, Name = "Masa", Age = 18, State = "California" }
            };

            ////var ageGroup = people.GroupBy(c => c.Age)
            ////    ////.Where(d => d.Sum() > 0)
            ////    .Select(c =>
            ////    {
            ////        if (c.Sum(x => x.Age) > 0)
            ////        {
            ////            return new { Age = c.Key, Count = c.Count() };
            ////        }
            ////        return new { Age = c.Key, Count = c.Count() };
            ////    }); //.Sum(x => x.Age);
            ////    ////.OrderBy(c => c.Age);

            //////var ageGroup = people.GroupBy(c => c.Age)
            //////    .Select(c => c )
            //////    .OrderBy(c => c.Key).Where(x => x. == 18).Select(y => new { Age = y.Age, Count = y.Count });

            ////foreach (var item in ageGroup)
            ////{
            ////    Console.WriteLine(item.Age);
            ////}

            Console.ReadKey();


            return 1;
        }

    }
}
