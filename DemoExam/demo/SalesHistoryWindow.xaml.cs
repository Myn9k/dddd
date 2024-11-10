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

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для SalesHistoryWindow.xaml
    /// </summary>
    public partial class SalesHistoryWindow : Window
    {
        public ObservableCollection<Partner> SalesHistory { get; set; }

        public SalesHistoryWindow(Partner partner)
        {
            InitializeComponent();
            DataContext = this;

            var bd = new ApplicationContext();


            using (var context = new ApplicationContext())
            {
                SalesHistory = new ObservableCollection<Partner>(
                    context.Partners.Where(history => history == partner).ToList()
                );
            }
        }
    }
}
