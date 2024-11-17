using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        ylahweeeeEntities db = new ylahweeeeEntities();

        public sign_up()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string userr = txtFirstName.Text;
            string email = e_tx.Text;
            string password = pas_tx.Text;
            string address = add_tx.Text;

            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(pas_tx.Text))
            {
                student stu = new student();
                stu.names = userr;
                stu.Email = email; 
                stu.passwordd = password;  
                stu.addresss = address;
                stu.department = new department();
                stu.department.specilaztion = de_tx.Text;
                db.students.Add(stu);
                db.SaveChanges();
                    MessageBox.Show("account created");
                    log_in lo = new log_in();
                   NavigationService.Navigate(lo);
       
            }
            else
            {
                MessageBox.Show("Please enter the required data.");
            }
        }
    }
}
