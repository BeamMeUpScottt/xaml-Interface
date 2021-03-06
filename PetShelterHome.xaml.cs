﻿using System;
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
    /// Interaction logic for PetShelterHome.xaml
    /// </summary>
    public partial class PetShelterHome : Page
    {
        public PetShelterHome()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, RoutedEventArgs e)
        {
            BoardingPage boardingPage = new BoardingPage();
            this.NavigationService.Navigate(boardingPage);
        }
    }
}
