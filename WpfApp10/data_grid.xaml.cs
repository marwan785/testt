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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for data_grid.xaml
    /// </summary>
    public partial class data_grid : Page
    {
        ylahweeeeEntities dbd = new ylahweeeeEntities();
        public data_grid()
        {
            InitializeComponent();
            d_grid.ItemsSource=dbd.students.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           List< student> s =new List< student>();
            if(!string.IsNullOrWhiteSpace(search_tx.Text)) 
            {
            s= dbd.students.Where(x=>x.names==search_tx.Text).ToList();
            d_grid.ItemsSource = s.ToList();
            }
          
            else 
            {
                MessageBox.Show("no data fe el data_base");
            
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          student su=new student();
            int id=int.Parse(st_id.Text);
            dbd.students.First(x => x.id == id);
            su.department=new department();
            su.department.specilaztion = debart.Text;
            dbd.students.AddOrUpdate(su);
            dbd.SaveChanges();

            d_grid.ItemsSource = dbd.students.ToList();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            student st=new student();
            int id=int.Parse(st_id.Text);
            st = dbd.students.Remove(dbd.students.First(x => x.id == id));
            dbd.students.Remove(st);
            dbd.SaveChanges();
            d_grid.ItemsSource = dbd.students.ToList();
        }
    }
}
