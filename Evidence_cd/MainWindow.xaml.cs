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

namespace Evidence_cd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tempSelectedIndex;
        public MainWindow()
        {
            InitializeComponent();
            Display();
            buttonCart.IsEnabled = false;
            buttonRemove.IsEnabled = false;
            buttonBuy.IsEnabled = false;
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                var tempObject = listBox.SelectedItem as TodoItem;
                tempSelectedIndex = listBox.SelectedIndex;
                buttonCart.IsEnabled = true;
            }
        }
        void Display() // funkce pro vypis dat z databaze
        {
            listBox.ItemsSource = App.Database.GetItemsAsync().Result;
        }
        void Display_Alphabet()
        {
            listBox.ItemsSource = App.Database.GetItemsNotDoneAsyncOrderByAlphabet().Result;
        }
        void Display_Price()
        {
            listBox.ItemsSource = App.Database.GetItemsNotDoneAsyncOrderByPrice().Result;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addwindow = new AddWindow();
            addwindow.Show();
            this.Close();
        }

        private async void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            listBox.SelectedIndex = tempSelectedIndex;
            var tempObject = listBox.SelectedItem as TodoItem;

            buttonDelete.IsEnabled = false;
            await App.Database.DeleteItemAsync(tempObject);
            buttonDelete.IsEnabled = true;
            echo.Text = "Data deleted";
            Display();
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            listBox.SelectedIndex = tempSelectedIndex;
            var tempObject = listBox.SelectedItem as TodoItem;
            /*UpdateWindow update = new UpdateWindow(tempObject.Album, tempObject.Artist, tempObject.Genre, tempObject.Year);
            update.Show();
            this.Close();*/
        }

        private void buttonCart_Click(object sender, RoutedEventArgs e)
        {
            listBoxCart.ItemsSource = App.Database.GetItemsAsync().Result;
            buttonBuy.IsEnabled = true;
        }

        private void sortName_Checked(object sender, RoutedEventArgs e)
        {
            Display_Alphabet();
            sortPrice.IsEnabled = false;
        }

        private void sortPrice_Checked(object sender, RoutedEventArgs e)
        {
            Display_Price();
            sortName.IsEnabled = false;
        }

        private void listBoxCart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxCart.SelectedItem != null)
            {
                var tempObject = listBoxCart.SelectedItem as TodoItem;
                tempSelectedIndex = listBoxCart.SelectedIndex;
                buttonRemove.IsEnabled = true;
            }
        }
    }
}
