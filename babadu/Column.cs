using System;


namespace babadu
{
    internal class Column
    {
        public string Name { get; set; }
        public List<string> Cards { get; set; }
        public Column(string name, List<string> cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}
