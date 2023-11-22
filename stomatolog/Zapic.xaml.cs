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
    /// Логика взаимодействия для Zapic.xaml
    /// </summary>
    public partial class Zapic : Window
    {
        private stom2Entities _context = new stom2Entities();
        private List<Servises> _serv = new List<Servises>();
        private List<Doctors> _doc = new List<Doctors>();
        private string _selectedServ;

        //public IObservable<>
        public Zapic()
        {
            InitializeComponent();
            //List<Servises> list = new List<Servises>();
            //list.AddRange(_context.Servises.OrderBy(s => s.Name_serv).ToList());
            //combserv.ItemsSource = list;
            //this._serv = _context.Servises.ToList();
            //combserv.SelectedItem = list.FirstOrDefault();


        }
        public void SetText(string text)
        {
            t6.Text = text;
        }
        private void RefreshDoc()
        {
            //if (combserv.SelectedItem != null)
            //{
            //    Servises servises = combserv.SelectedItem as Servises;
            //    _selectedServ = servises.Name_serv;
            //    _doc = (from d in _doc from sv in d.Services where d.Services == _selectedServ select d).ToList();
            //}
            //combdoc.ItemsSource = _doc;
            ////this._serv = _context.Servises.ToList();
            //combdoc.SelectedItem = _doc.FirstOrDefault();
        }

        private void combdoc_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            //_doc = _context.Doctors.OrderBy(d => d.Surname).ToList(); 
            //RefreshDoc();
        }
    }
}
