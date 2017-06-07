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
    /// Interakční logika pro RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        TodoItemUser user;
        public RegistrationPage()
        {
            InitializeComponent();
            //App.Database.Truncate();
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        { 
            User();
            checkUser();
            var count = App.Database.GetItemsNotDoneAsyncUser().Result.Count;
            MessageBox.Show(count.ToString());
        }
        public void User()
        {
            user = new TodoItemUser();
            string admin = "admin";
            user.Username = inputName.Text;
            user.Password = inputPassword.Text;

            if (user.Username == admin)
            {
                user.Level = 1;
            }
            else
            {
                user.Level = 0;
            }
        }
        public async void checkUser()
        {
            var result = await App.Database.GetItemsNotDoneAsyncUser();
            foreach (TodoItemUser todoItemUser in result)
            {
                if (user.Username != todoItemUser.Username)
                {
                    await App.Database.SaveItemAsyncUser(user);
                    echo.Text = "Registration succesful";
                }
                else
                {
                    echo.Text = "User already exists";
                }
            }

            //App.Database.SaveItemAsyncUser(user);
            MessageBox.Show("" + user.Level);
        }
    }
}
