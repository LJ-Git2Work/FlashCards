using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    class Unit
    {
        private readonly int _id;
        private string title;
        private int year;
        private List<Topic> topics;
        private bool save;
    }
}
