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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {

        ylahweeeeEntities dbs = new ylahweeeeEntities();
        public log_in()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var rec = dbs.students.FirstOrDefault(x => x.names == user.Text && x.passwordd == pass.Password);
           
            if (rec != null)
            {
                MessageBox.Show("da5lt el data sa7");
                add_page eee = new add_page(rec.names);
                NavigationService.Navigate(eee);
            }
            else if(user.Text=="marwan dief" && pass.Password == "maro@123")
            {
                MessageBox.Show("admin is concted");
                data_grid d = new data_grid();
                NavigationService.Navigate(d);
            }
            else
            {
                MessageBox.Show("no data");

            }

        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            sign_up n=new sign_up();
            NavigationService.Navigate(n);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text == "marwan dief" && pass.Password == "maro@123")
            {
                MessageBox.Show("admin is conected");
                data_grid df = new data_grid();
                NavigationService.Navigate(df);
            }
            else
            {
                MessageBox.Show("only admins can go to data grid");
            }
          
        }
    }
}
