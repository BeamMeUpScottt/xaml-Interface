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

namespace PetShelterProject
{
    /// <summary>
    /// Interaction logic for BoardingPage.xaml
    /// </summary>
    public partial class BoardingPage : Page
    {
        public BoardingPage()
        {
            InitializeComponent();
        }

        private void BoardButton_Click(object sender, RoutedEventArgs e)
        {
            BoardInfo boardInfo = new BoardInfo();
            this.NavigationService.Navigate(boardInfo);
        }

        private void PickUpButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage displayPage = new DisplayPage();
            this.NavigationService.Navigate(displayPage);
        }
    }
}
