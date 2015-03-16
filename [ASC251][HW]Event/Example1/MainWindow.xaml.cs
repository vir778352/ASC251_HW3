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

namespace Example1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        
        GameController game;
        
        public MainWindow()
        {
            InitializeComponent();
            
            game = new GameController();
            firstPersonDataTextBlock.Text = game.personInfomation[0];
            secondPersonDataTextBlock.Text = game.personInfomation[1];
            thirdPersonDataTextBlock.Text = game.personInfomation[2];
            forthPersonDataTextBlock.Text = game.personInfomation[3];
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            attchedTextBlock.Text = "";
            game.PlayGame();
            game.UpdateUI();
            firstPersonDataTextBlock.Text = game.personInfomation[0];
            secondPersonDataTextBlock.Text = game.personInfomation[1];
            thirdPersonDataTextBlock.Text = game.personInfomation[2];
            forthPersonDataTextBlock.Text = game.personInfomation[3];
            attchedTextBlock.Text = game.DisplayMessage;

        }
    }
}
