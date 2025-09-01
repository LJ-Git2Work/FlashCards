using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlashCards.Models
{
    public class FlashCard 
    {        
        // Flashcard content
        private string _Question;
        private string _Answer;
        private string? _Hint;
        
        // Constructor, creates instance content variables are null
        public FlashCard() { }

        // Constructor, takes 1-3 strings content variables
        public FlashCard(string question, string answer, string? hint)
        {
            Question = question;
            Answer = answer;
            Hint = hint;
        }
        /* Setter and Getters, 
         * Uses additional instance var to enable conditional logic thats checks if the passed value is valid
         */
        public string Question {  
            get => _Question;
            set => _Question = IsValid(value, Limits.QuestionMax) ? value : _Question;
        }
        public string Answer { 
            get => _Answer;
            set => _Answer = IsValid(value, Limits.AnswerMax) ? value : _Answer;
        }
        public string? Hint 
        {
            get => _Hint;
            set => _Hint = IsValid(value, Limits.HintMax) ? value : _Hint;
        }

        // Value is valid if not null or whitespace and less than the max string length defined in Limits.cs
        private bool IsValid(string? text, int max) => 
            !string.IsNullOrWhiteSpace(text) && text.Length <= max;
    }
    
}
