using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Xml.Linq;

namespace WpfApp10
{
    public partial class add_page : Page
    {
        ylahweeeeEntities d = new ylahweeeeEntities();
        

        public add_page(string namess)
        {
            InitializeComponent();
            string Namee;
            this.Name = namess;
            loadata();
        }
        public void loadata()
        {
             student ss = new student();
            ss = d.students.First(x => x.names == Name);
            n_tx.Text = ss.names;
            p_tx.Text = ss.passwordd;
            em_tx.Text = ss.Email;
            ad_tx.Text = ss.addresss;
            ss.department =new department();
            sb_tx.Text = ss.department.specilaztion;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            student s = new student();
            s = d.students.First(x => x.names == Name);
            s.names = n_tx.Text;
            s.passwordd = p_tx.Text;
            s.Email = em_tx.Text;
            s.addresss = ad_tx.Text;
            s.department = new department();    
            s.department.specilaztion = sb_tx.Text;
            d.students.AddOrUpdate(s);  
            d.SaveChanges();
            MessageBox.Show("data saved");
            log_in  lo=new log_in();
            NavigationService.Navigate(lo);

        }
    }
}
