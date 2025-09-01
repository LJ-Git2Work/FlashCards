using FlashCards.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FlashCards
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Unit unit = new Unit("Principles of Computer Science - ICT167", 2025);
            unit.AddTopic(new Topic("Programming with Classes", 5));
            unit.Topics[0].Cards.Add(new FlashCard("Explain what is meant by a constructor?",
                    "Its called when a new instance of that class is created ans used to set values of that new object",
                    "You should know this, its easy"));

            base.OnStartup(e);
        }
    }

}
