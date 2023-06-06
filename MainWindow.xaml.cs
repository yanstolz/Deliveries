using Deliveries.DataBase;
using Deliveries.Model;
using Deliveries.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Deliveries
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<Suppliers> Suppliers { get; set; } = Data.GetSuppliers();

        public List<Delivery> Delivery { get; set; } = Data.GetDelivery();
        public List<DeliverySuppliers> DeliverySuppliers { get; set; } = Data.GetDeliverySuppliers();

        public List<Products> Products
        {
            get
            {
                if (SelectedSupplier != null)
                {
                    DateTime today = DateTime.Today;
                    return Data.GetProducts()
                        .Where(p => p.SupplierID == SelectedSupplier.SupplierID && p.StartDate <= today && p.EndDate >= today)
                        .ToList();
                }
                else
                {
                    return Data.GetProducts();
                }
            }
            set { }
        }

        private List<(int, int, int)> savedValues; // Список для сохранения значений

        public MainWindow()
        {
            InitializeComponent();
            savedValues = new List<(int, int, int)>();
        }

        private Suppliers _selectedSupplier;
        public Suppliers SelectedSupplier
        {
            get { return _selectedSupplier; }
            set
            {
                if (_selectedSupplier != value)
                {
                    _selectedSupplier = value;
                    OnPropertyChanged(nameof(SelectedSupplier));
                    OnPropertyChanged(nameof(Products)); // Обновить список продуктов при изменении выбранного поставщика
                }
            }
        }

        private Products _selectedProduct;
        public Products SelectedProducts
        {
            get { return _selectedProduct; }
            set
            {
                if (_selectedProduct != value)
                {
                    _selectedProduct = value;
                    OnPropertyChanged(nameof(SelectedProducts));
                }
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void btnOneMoreSupplier_Click(object sender, RoutedEventArgs e)
        {
            AddListsavedValues();
            ClearElement();
        }

        private void btnComplite_Click(object sender, RoutedEventArgs e)
        {
            AddListsavedValues();
            int lastDelivery = Delivery.Count()+1;
            Data.InsertDelivery();
            foreach (var item in savedValues)
            {
                int supplierID = item.Item1;
                int productID = item.Item2;
                int count = item.Item3;
                int deliveryID = lastDelivery;
                Data.InsertDeliverySuppliers(supplierID, count, productID, deliveryID);
            }
            savedValues.Clear();
            ClearElement();
        }

        private void AddListsavedValues()
        {
            // Получите выбранные значения из ComboBox'ов и текст из TextBox'а
            int selectedSupplier = Convert.ToInt32((cbSupply.SelectedItem as Model.Suppliers)?.SupplierID);
            int selectedProduct = Convert.ToInt32((cbProduct.SelectedItem as Model.Products)?.ProductID);
            int quantity = Convert.ToInt32(tbName.Text);
            if (selectedSupplier==0 || selectedProduct==0 || quantity == 0)
            {
                MessageBox.Show("Не забывайте вводить данные");
                return;
            }
            // Сохраните значения в список
            var values = (selectedSupplier, selectedProduct, quantity);
            savedValues.Add(values);
            ClearElement();
        }

        private void ClearElement()
        {
            // Очистите элементы
            cbSupply.SelectedItem = null;
            cbProduct.SelectedItem = null;
            tbName.Text = "0";
        }

        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            savedValues.Clear();
        }

        private void btnOpenReport_Click(object sender, RoutedEventArgs e)
        {
            Report window = new Report();
            window.Show();
        }
    }
}
