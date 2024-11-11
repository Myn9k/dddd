using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Partner> Partners { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LoadPartners();
            DataContext = this;
        }

        private void LoadPartners()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=demo.db")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                Partners = new ObservableCollection<Partner>(context.Partners.ToList());
            }
            DataContext = this;
        }


        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            var addEditWindow = new EditWindow();
            if (addEditWindow.ShowDialog() == true)
            {
                var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlite("Data Source=demo.db")
                    .Options;

                using (var context = new ApplicationDbContext(options))
                {
                    context.Partners.Add(addEditWindow.Partner);
                    context.SaveChanges();
                    Partners.Add(addEditWindow.Partner);
                }
            }
        }

        private void EditPartnerButton_Click(object sender, RoutedEventArgs e)
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
                var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlite("Data Source=demo.db")
                    .Options;

                using (var context = new ApplicationDbContext(options))
                {
                    context.Partners.Update(addEditWindow.Partner);
                    context.SaveChanges();
                    LoadPartners();
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
