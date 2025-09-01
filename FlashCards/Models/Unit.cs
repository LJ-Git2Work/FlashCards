using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class Unit
    {
        private string _Title;
        private int _Year;
        public List<Topic> Topics { get; set; }
        public string Title 
        {
            get => _Title;
            set => _Title = value;
        }
        public int Year 
        { 
            get => _Year; 
            set => _Year = value;
        }
        public Unit(string title)
        {
            Title = title;
            Topics = new List<Topic>();
        }
        public Unit(string title, int year) : this(title) 
        {
            Year = year;
        }
        public void AddTopic(Topic topic)
        {
            Topics.Add(topic);
        }
    }
}
