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

namespace TicTacToe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool player1 = true;
        bool endGame = false;

        public MainWindow()
        {
            InitializeComponent();
            ButtonList();
        }
        private void ButtonList()
        {
            List<Button> listButton = new List<Button>
            {
                c0_r0,c0_r1,c0_r2,c1_r0,c1_r1,c1_r2,c2_r0,c2_r1,c2_r2
            };
            foreach(Button b in listButton)
            {
                b.Content = string.Empty;
                b.Background = new SolidColorBrush(Colors.White);
                b.IsHitTestVisible = true;
            }
            endGame = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var clicked = sender as Button;
            clicked.Content = player1 ? "X" : "O";
            player1 ^= true;
            if(player1 == true)
            {
                clicked.Foreground = new SolidColorBrush(Colors.Red);
                clicked.IsHitTestVisible = false;
            }
            else
            {
                clicked.Foreground = new SolidColorBrush(Colors.Blue);
                clicked.IsHitTestVisible = false;
            }
            CheckWin();
            EndGame();

            List<Button> listButton = new List<Button>
            {
                c0_r0,c0_r1,c0_r2,c1_r0,c1_r1,c1_r2,c2_r0,c2_r1,c2_r2
            };
            if (listButton.All(x => (string)x.Content != string.Empty))
            {
                foreach (Button b in listButton)
                {
                    b.Background = new SolidColorBrush(Colors.Orange);
                }
                endGame = true;
                EndGame();
            }
        }
        private void CheckWin()
        {
            //row0
            if(((string)c0_r0.Content == "X") && ((string)c1_r0.Content == "X") && ((string)c2_r0.Content=="X"))
            {
                c0_r0.Background = c1_r0.Background = c2_r0.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r0.Content == "O") && ((string)c1_r0.Content == "O") && ((string)c2_r0.Content == "O"))
            {
                c0_r0.Background = c1_r0.Background = c2_r0.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //row1
            if (((string)c0_r1.Content == "X") && ((string)c1_r1.Content == "X") && ((string)c2_r1.Content == "X"))
            {
                c0_r1.Background = c1_r1.Background = c2_r1.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r1.Content == "O") && ((string)c1_r1.Content == "O") && ((string)c2_r1.Content == "O"))
            {
                c0_r1.Background = c1_r1.Background = c2_r1.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //row2
            if (((string)c0_r2.Content == "X") && ((string)c1_r2.Content == "X") && ((string)c2_r2.Content == "X"))
            {
                c0_r2.Background = c1_r2.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r2.Content == "O") && ((string)c1_r2.Content == "O") && ((string)c2_r2.Content == "O"))
            {
                c0_r2.Background = c1_r2.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //column0
            if (((string)c0_r0.Content == "X") && ((string)c0_r1.Content == "X") && ((string)c0_r2.Content == "X"))
            {
                c0_r0.Background = c0_r1.Background = c0_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r0.Content == "O") && ((string)c0_r1.Content == "O") && ((string)c0_r2.Content == "O"))
            {
                c0_r0.Background = c0_r1.Background = c0_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //column1
            if (((string)c1_r0.Content == "X") && ((string)c1_r1.Content == "X") && ((string)c1_r2.Content == "X"))
            {
                c1_r0.Background = c1_r1.Background = c1_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c1_r0.Content == "O") && ((string)c1_r1.Content == "O") && ((string)c1_r2.Content == "O"))
            {
                c1_r0.Background = c1_r1.Background = c1_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //column2
            if (((string)c2_r0.Content == "X") && ((string)c2_r1.Content == "X") && ((string)c2_r2.Content == "X"))
            {
                c2_r0.Background = c2_r1.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c2_r0.Content == "O") && ((string)c2_r1.Content == "O") && ((string)c2_r2.Content == "O"))
            {
                c2_r0.Background = c2_r1.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            //diagonal
            if (((string)c0_r0.Content == "X") && ((string)c1_r1.Content == "X") && ((string)c2_r2.Content == "X"))
            {
                c0_r0.Background = c1_r1.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r0.Content == "O") && ((string)c1_r1.Content == "O") && ((string)c2_r2.Content == "O"))
            {
                c0_r0.Background = c1_r1.Background = c2_r2.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }

            if (((string)c0_r2.Content == "X") && ((string)c1_r1.Content == "X") && ((string)c2_r0.Content == "X"))
            {
                c0_r2.Background = c1_r1.Background = c2_r0.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
            if (((string)c0_r2.Content == "O") && ((string)c1_r1.Content == "O") && ((string)c2_r0.Content == "O"))
            {
                c0_r2.Background = c1_r1.Background = c2_r0.Background = new SolidColorBrush(Colors.Green);
                endGame = true;
            }
        }
        public void EndGame()
        {
            if(endGame == true)
            {
                MessageBox.Show("Koniec gry!");
                ButtonList();
            }
        }
    }
}
