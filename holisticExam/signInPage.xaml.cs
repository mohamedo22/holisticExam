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
    /// Interaction logic for signInPage.xaml
    /// </summary>
    public partial class signInPage : Page
    {
        holisticExamEntities entities = new holisticExamEntities();
        public signInPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signUpPage signUpPage = new signUpPage();
            this.NavigationService.Navigate(signUpPage);
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            user checkUser = new user();
            checkUser = entities.users.FirstOrDefault(x => x.username == userNameTextBox.Text && x.passwordd == PasswordTextBox.Password);
            if (checkUser != null)
            {
                profilePage profilePage = new profilePage(checkUser);
                this.NavigationService.Navigate(profilePage);
            }
            else
            {
                MessageBox.Show("User Undefinded");
            }
        }
    }
}
