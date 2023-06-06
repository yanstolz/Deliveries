using Deliveries.DataBase;
using Deliveries.Model;
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

namespace Deliveries.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, RoutedEventArgs e)
        {
            if (dpDateFrom.SelectedDate.HasValue && dpDateTo.SelectedDate.HasValue)
            {
                DateTime startDate = dpDateFrom.SelectedDate.Value;
                DateTime endDate = dpDateTo.SelectedDate.Value;

                List<DeliverySummary> deliverySummary = Data.GetDeliverySummary(startDate, endDate);

                deliverySummaryGrid.ItemsSource = deliverySummary;
            }
            else
            {
                MessageBox.Show("Введите даты");
            }
        }
    }
}
