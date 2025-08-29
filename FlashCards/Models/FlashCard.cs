using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlashCards.Models
{
    class FlashCard
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid Id => _id;
        private string? _Question;
        private string? _Answer;
        private string? _Hint;
        private State Save { get; } = new State();
        
        FlashCard() { }
        FlashCard(string? question, string? answer, string? hint)
        {
            Question = question;
            Answer = answer;
            Hint = hint;
        }

        public string? Question {  
            get => _Question;
            set => _Question = IsValid(value, Limits.QuestionMax) ? value : null;
        }
        public string? Answer { 
            get => _Answer;
            set => _Answer = IsValid(value, Limits.AnswerMax) ? value : null;
        }
        public string? Hint 
        {
            get => _Hint;
            set => _Hint = IsValid(value, Limits.HintMax) ? value : null;
        }

        private static bool IsValid(string? text, int max) => 
            !string.IsNullOrWhiteSpace(text) && text.Length <= max;
        
    }
    
}
