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

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            Load();
            db = new ApplicationContext();
            DataContext = this;
        }

        private void Load()
        {
            List<Partner> partner = db.Partners.ToList();
            ListBoxPartners.ItemsSource = partner;
            DataContext = this;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            List<Partner> partners = new List<Partner>();
            var addEditWindow = new EditWindow();
            if (addEditWindow.ShowDialog() == true)
            {
                var bd = new ApplicationContext();

                using (var context = new ApplicationContext())
                {
                    context.Partners.Add(addEditWindow.Partner);
                    context.SaveChanges();
                    partners.Add(addEditWindow.Partner);
                }
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPartner = (Partner)ListBoxPartners.SelectedItem;
            if (selectedPartner == null)
            {
                MessageBox.Show("Пожалуйста, выберите партнера для редактирования.");
                return;
            }

            var addEditWindow = new EditWindow(selectedPartner);
            if (addEditWindow.ShowDialog() == true)
            {

                using (var context = new ApplicationContext())
                {
                    context.Partners.Update(addEditWindow.Partner);
                    context.SaveChanges();
                    Load();
                }
            }
        }
        private void ShowHistoryButton_Click(Object sender, RoutedEventArgs e)
        {
            var selectedPartner = (Partner)ListBoxPartners.SelectedItem;
            if (selectedPartner == null)
            {
                MessageBox.Show("Пожалуйста, выберите партнера для просмотра истории сделок.");
                return;
            }

            var historyWindow = new SalesHistoryWindow(selectedPartner);
            historyWindow.ShowDialog();
        }

    }
}