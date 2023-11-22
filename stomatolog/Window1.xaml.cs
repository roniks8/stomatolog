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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private stomatologyEntities2 _context = new stomatologyEntities2(); 
        private List<Servises> _serv=new List<Servises>();
        private List<Doctors> _doc = new List<Doctors>();
        private string _selectedServ;
        private string _findname;
        public Window1()
        {
            InitializeComponent();
            ListDoctors.ItemsSource = _context.Doctors.OrderBy(d=>d.Surname).ToList();


            List<Servises> list = new List<Servises>();
            list.AddRange(_context.Servises.OrderBy(s => s.Name_serv).ToList());
            servicesComboBox.ItemsSource = list;
            this._serv=_context.Servises.ToList();
            servicesComboBox.SelectedItem=list.FirstOrDefault();

            
        }

        private void RefreshDoc()
        {
            RefreshDoc(_selectedServ);
        }

        private void RefreshDoc(string _selectedServ)
        {
            if (servicesComboBox.SelectedItem!= null)
            {
                Servises servises = servicesComboBox.SelectedItem as Servises;
                _selectedServ = servises.Name_serv;

                _doc = (from d in _doc
                        where d.Servises.Equals(_selectedServ)
                        select d).Distinct().ToList();
                //_doc = (from n in 
                //        d in _doc
                //        where d.Servises.Equals(_selectedServ)
                //        select d).Distinct().ToList();
            }
            ListDoctors.ItemsSource = _doc;
        }
        private void servicesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _doc = _context.Doctors.OrderBy(d => d.Surname).ToList();
            RefreshDoc();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddDoc addoc = new AddDoc();
            addoc.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          Patientsxaml patientsxaml = new Patientsxaml();
            patientsxaml.Show();
        }

        private void TextBlock_GotFocus(object sender, RoutedEventArgs e)
        {
            Zapic z = new Zapic();
            z.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Zapic zapic    = new Zapic();
            zapic.Show();
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Zapic zapic = new Zapic();
            zapic.Show();
        }

        private void vrach_MouseDown(object sender, MouseButtonEventArgs e)
        {
             
        }
    }
}
