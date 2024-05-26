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
    /// Interaction logic for profilePage.xaml
    /// </summary>
    public partial class profilePage : Page
    {
        public profilePage(user user)
        {
            InitializeComponent();
            userName.Content = user.username;
            Password.Password = user.passwordd;
            Age.Content = user.age;
            gender.Content = user.gender;
            phoneNumber.Content = user.phoneNumber;
            city.Content = user.city;
        }
    }
}
