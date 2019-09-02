using EfCore.DAL;
using EfCore.Entities;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EfCoreWpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductsDbContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new ProductsDbContext();
            GetCateogriesData();
        }

        private void GetCateogriesData()
        {
            ObservableCollection<Category> list = new ObservableCollection<Category>();

            context.Categories.ToList().ForEach((item)=>
            {
                list.Add(item);
            });
            dgCategories.ItemsSource = list;
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txCategoryName.Text))
            {
                MessageBox.Show("Nombre es requerido");
                return;
            }
            context.Categories.Add(new Category()
            {
                Name = txCategoryName.Text
            });
            context.SaveChanges();
            GetCateogriesData();

        }
    }
}
