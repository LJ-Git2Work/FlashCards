using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class Topic
    {
        private string _Name;
        private int _Week;        
        public List<FlashCard> Cards { get; set; } 
        public string Name 
        {
            get => _Name; 
            set => _Name = value;
        }
        public int Week 
        { 
            get => _Week;
            set => _Week = value;  
        }
        public Topic(string name)
        {
            Name = name;
            Cards = new List<FlashCard>();
        }
        public Topic(string name, int week) : this(name)
        {
            Week = week;
        }

        public void AddCard(FlashCard flashcard)
        {
            Cards.Add(flashcard);
        }
    }
}
