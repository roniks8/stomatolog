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
    /// Логика взаимодействия для AddDoc.xaml
    /// </summary>
    public partial class AddDoc : Window
    {
        public static stom2Entities _context = new stom2Entities();
        private Doctors _doc;
        public AddDoc()
        {
            InitializeComponent();
            DataGridDoctor.ItemsSource = _context.Doctors.ToList();
            //_doc = (o as Button).DataContext as Doctors;
        }

        private void Удалить_Click(object sender, RoutedEventArgs e)
        {
            var _doc=DataGridDoctor.SelectedItems.Cast<Doctors>().ToList();
            if(MessageBox.Show($"Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try 
                {
                    _context.Doctors.RemoveRange(_doc);
                    _context.SaveChanges();
                    MessageBox.Show("Удалено!");
                    DataGridDoctor.ItemsSource=_context.Doctors.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Doctors selectedrow = 
            //_context.Doctors.Remove(sele);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            FormaddDoc add = new FormaddDoc(_context,this);
            add.ShowDialog();
        }
    }
}
