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
    /// Interaction logic for DisplayPage.xaml
    /// </summary>
    public partial class DisplayPage : Page
    {
        Shelter s = new Shelter();

        public DisplayPage()
        {
            InitializeComponent();

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            ShelterView shelterView = new ShelterView(s);
            string Sex = null;
            int AgeInput = 0;
            decimal WeightInput = 0;

            if (AgeTextBox.Text.Length == 0)
                MessageBox.Show("No Age was inputted.");
            else
                AgeInput = Convert.ToInt32(AgeTextBox.Text);

            if (WeightTextBox.Text.Length == 0)
                MessageBox.Show("No Weight was inputted.");
            else
                WeightInput = Convert.ToDecimal(WeightTextBox.Text);

            if (MaleRB.IsChecked == true)
                Sex = (string)MaleRB.Content;
            else if (FemaleRB.IsChecked == true)
                Sex = (string)FemaleRB.Content;
            else
                MessageBox.Show("No sex was inputted.");


            Animal animal = new Animal(PetNameTextbox.Text, SpeciesTextbox.Text, AgeInput, Sex, WeightInput);
            s.Add(animal);

            PetsDisplayLabel.Content = shelterView.Show();
        }

        private void PickUpButton_Click(object sender, RoutedEventArgs e)
        {
            ShelterView shelterView = new ShelterView(s);


            if (s.ContainsName(RemoveNameTextbox.Text) == true)
            {
                s.RemoveByName(RemoveNameTextbox.Text);
                PetsDisplayLabel.Content = shelterView.Show();
            }
            else
                MessageBox.Show("There is no pet by that name.");
        }

        private void SubmitButton_Click_1(object sender, RoutedEventArgs e)
        {
            ShelterView shelterView = new ShelterView(s);
            string Sex = null;
            int AgeInput = 0;
            decimal WeightInput = 0;

            switch (AgeTextBox.Text.Length == 0 || WeightTextBox.Text.Length == 0)
            {
            case 1:
                MessageBox.Show("No Age was inputted.");

            }
            else
                AgeInput = Convert.ToInt32(AgeTextBox.Text);

            if (WeightTextBox.Text.Length == 0)
                MessageBox.Show("No Weight was inputted.");
            else
                WeightInput = Convert.ToDecimal(WeightTextBox.Text);

            if (MaleRB.IsChecked == true)
                Sex = (string)MaleRB.Content;
            else if (FemaleRB.IsChecked == true)
                Sex = (string)FemaleRB.Content;
            else
                MessageBox.Show("No sex was inputted.");


            Animal animal = new Animal(PetNameTextbox.Text, SpeciesTextbox.Text, AgeInput, Sex, WeightInput);
            s.Add(animal);

            PetsDisplayLabel.Content = shelterView.Show();
        }
    }
}
