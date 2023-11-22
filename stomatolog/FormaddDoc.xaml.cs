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
using System.Windows.Shapes;

namespace stomatolog
{
    /// <summary>
    /// Логика взаимодействия для FormaddDoc.xaml
    /// </summary>
    public partial class FormaddDoc : Window
    {
        private stom2Entities _context;
        private AddDoc _addoctorwindow;

        public FormaddDoc()
        {
        }

        public FormaddDoc(stom2Entities stom2Entities,AddDoc addDoc)
        {
            InitializeComponent();
            this._context = stom2Entities;
            this._addoctorwindow = addDoc;
            combserv.ItemsSource = _context.Servises.ToList();
            combserv.SelectedIndex = 0;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                _context.Doctors.Add(new Doctors() { Name = t1.Text, Surname = t2.Text, Patronymic = t3.Text, Phone = t4.Text, Birthdate = Convert.ToDateTime(t5.Text), Experience = Convert.ToInt16(t6.Text), Services = combserv.SelectedValue.ToString() });
              
                _context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
