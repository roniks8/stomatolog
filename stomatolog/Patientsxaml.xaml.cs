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
    /// Логика взаимодействия для Patientsxaml.xaml
    /// </summary>
    public partial class Patientsxaml : Window
    {
        public static stom2Entities _context = new stom2Entities();
        private Patients _pat;
        public Patientsxaml()
        {
            InitializeComponent();
            DataGridPatients.ItemsSource = _context.Patients.ToList();
        }

        private void Удалить_Click(object sender, RoutedEventArgs e)
        {
            var _pat = DataGridPatients.SelectedItems.Cast<Doctors>().ToList();
            if (MessageBox.Show($"Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    _context.Doctors.RemoveRange(_pat);
                    _context.SaveChanges();
                    MessageBox.Show("Удалено!");
                    DataGridPatients.ItemsSource = _context.Doctors.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
