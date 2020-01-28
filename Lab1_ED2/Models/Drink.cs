using System;

namespace Lab1_ED2.Models
{
    public class Drink : IComparable
    {
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Volume { get; set; }
        public string Price { get; set; }
        public string Producer { get; set; }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
