using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    class Topic
    {
        private readonly int _id;
        private string topicName;
        private int week;
        private List<FlashCard> cards;
        private bool save;

        public bool setName(string name)
        {
            if (!string.IsNullOrEmpty(name) && name.Length <= Limits.TopicNameMax)
            {
                this.topicName = name;
                return true;
            }
            return false;
        }

        public void setWeek(int week)
        {
            this.week = week;
        }


    }
}
