using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Data.Entity.Migrations;

namespace Demo
{
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
