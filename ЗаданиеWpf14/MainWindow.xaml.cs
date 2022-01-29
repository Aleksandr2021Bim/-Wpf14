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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ЗаданиеWpf14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Гречка",
                Cost = 100,
                Image = "Data/grecha.png",
                Category = ProductsTypes.Food

            });
            products.Add(new Product()
            {
                Name = "Макароны",
                Cost = 50,
                Image = "Data/makaron.png",
                Category = ProductsTypes.Food

            });
            products.Add(new Product()
            {
                Name = "Мыло",
                Cost = 40,
                Image = "Data/milo.png",
                Category = ProductsTypes.Tech

            });
            lstBox.ItemsSource = products;
        }
    }
}
