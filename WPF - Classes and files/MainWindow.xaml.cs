using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF___Classes_and_files
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for the "Add Toy" button
        private void btnAddToy_Click(object sender, RoutedEventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtImageURL.Text))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            // Create a new Toy object and add it to the ListBox
            Toy newToy = new Toy(txtManufacturer.Text, txtName.Text, price, txtImageURL.Text);
            lstToys.Items.Add(newToy);
        }

        // Event handler for ListBox double-click
        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstToys.SelectedItem is Toy selectedToy)
            {
                // Display the aisle information
                MessageBox.Show($"Aisle: {selectedToy.Aisle}");

                // Update the image with the toy's image URL
                var uri = new Uri(selectedToy.Image);
                var img = new BitmapImage(uri);
                imgToy.Source = img;
            }
        }

    }

}
