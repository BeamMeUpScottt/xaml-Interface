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
    /// Interaction logic for BoardInfo.xaml
    /// </summary>
    public partial class BoardInfo : Page
    {
        public BoardInfo()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage displayPage = new DisplayPage();
            this.NavigationService.Navigate(displayPage);
        }
    }
}
