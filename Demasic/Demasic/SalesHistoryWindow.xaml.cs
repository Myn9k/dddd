using Demasic.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Demasic
{
    /// <summary>
    /// Логика взаимодействия для SalesHistoryWindow.xaml
    /// </summary>
    public partial class SalesHistoryWindow : Window
    {
        public ObservableCollection<Sale> Sales { get; set; }

        public SalesHistoryWindow(Partner partner)
        {
            InitializeComponent();
            LoadSales(partner.id);
            DataContext = this;
        }

        private void LoadSales(int partnerId)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=demo.db")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                
                Sales = new ObservableCollection<Sale>(
                    context.Sales.Where(s => s.PartnerId == partnerId).ToList()
                );
            }
        }
    }
}