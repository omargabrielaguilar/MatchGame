using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MainWindow() -> constructor
        public MainWindow()
        {
            InitializeComponent();

            // Code behind
            // Addc# code to this files that defines the behavior of the game
            // Emoji in the grid
            // handle mouse clicks
            // the countdown timer work


            //Generate methods

            SetUpGame();
        }

        // List is a collection that stores a set of values in order
        // Use "new" keyword to create your List 
        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            // Create a List of eight pairs of emoji
            {
            "🐖","🐖",
            "🦘","🦘",
            "🦒","🦒",
            "🐀","🐀",
            "🦙","🦙",
            "🐸","🐸",
            "🐙","🐙",
            "🦑","🦑",
            };
            
            Random random = new Random();
            // Create a new random number generator

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            // Find every TextBlock in the main grid and repeat the following statement for each of them
            {
                int index = random.Next(animalEmoji.Count);
                // Pick a random number bettween 0 and the number of emojis left in the list and call it "index"
                string nextEmoji = animalEmoji[index];
                // Use the random number called "index" to get a random emoji from the list 
                textBlock.Text = nextEmoji;
                // Update the TextBlock with the random emoji from the list
                animalEmoji.RemoveAt(index);
                // Remove the random emoji from the list
            }
        }
    }
}
