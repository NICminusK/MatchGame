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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();

            TextBlock_MouseDown();
        }

        private void TextBlock_MouseDown()
        {
            throw new NotImplementedException();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐶","🐶",
                "🐙","🐙",
                "🐱","🐱",
                "🦞","🦞",
                "🐍","🐍",
                "🐑","🐑",
                "🦜","🦜",
                "🦈","🦈",
                "🐠","🐠",
                "🦦","🦦",
            };

            Random random = new Random();

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }

        
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

            /* If its the first in the pair being clicked, keep track of which TextBlock was clicked and make the animal disappear. If its the second one, either make it disappear (if its a match)
             * or bring back the first one (if its not a match)
             */


        }
    }
}
