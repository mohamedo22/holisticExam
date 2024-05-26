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

namespace holisticExam
{
    /// <summary>
    /// Interaction logic for signUpPage.xaml
    /// </summary>
    public partial class signUpPage : Page
    {
        holisticExamEntities entitie = new holisticExamEntities();
        public signUpPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
            user = entitie.users.FirstOrDefault(s=> s.username == userNameTextBox.Text);
            if (user == null)
            {
                if (userNameTextBox != null && PasswordTextBox != null && AgeTextBox != null && PhoneNumberTextBox != null && (male.IsChecked == true || female.IsChecked == true) && cityes != null)
                {
                    user NewUser = new user();
                    NewUser.username = userNameTextBox.Text;
                    NewUser.passwordd = PasswordTextBox.Password;
                    NewUser.age = Convert.ToInt16(AgeTextBox.Text);
                    NewUser.phoneNumber = PhoneNumberTextBox.Text;
                    if (male.IsChecked == true)
                    {
                        NewUser.gender = "Male";
                    }
                    else
                    {
                        NewUser.gender = "Female";
                    }
                    NewUser.city = cityes.Text;
                    entitie.users.Add(NewUser);
                    entitie.SaveChanges();
                    MessageBox.Show("The user has been added");
                }
                else
                {
                    MessageBox.Show("There is an empty Field");
                }
            }
            else
            {
                MessageBox.Show("this user name has tooken");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signInPage signInPage = new signInPage();
            this.NavigationService.Navigate(signInPage);
        }
    }
}
