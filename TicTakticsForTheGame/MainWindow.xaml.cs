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
using DataAccessLayer;

namespace TicTakticsForTheGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Player player1 = new Player();
            Player player2 = new Player();
            player1.IsX = true;
            player2.IsX = false;
            Match match = new Match(player1, player2);
        }

        private void space0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fillSpace(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.IsHitTestVisible)
            {
                btn.Content = Utility.x_or_o();
                btn.IsHitTestVisible = false;
            }
        }

        private void setBackground(object sender, RoutedEventArgs e)
        {
            //Button btn = (Button)sender;
            //gdBoard.Background =  btn.Content;
        }
    }
}
