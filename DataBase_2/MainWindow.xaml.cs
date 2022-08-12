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

namespace DataBase_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static RoutedCommand Add { get; set; }
        public static RoutedCommand Delete { get; set; }
        public static RoutedCommand ChangeMode { get; set; }
              
        public static RoutedCommand Load { get; set; }
        public static RoutedCommand Save { get; set; }

        static MainWindow() 
        {
            Add = new RoutedCommand("Add", typeof(MainWindow));
            Delete = new RoutedCommand("Delete", typeof(MainWindow));
            ChangeMode = new RoutedCommand("ChangeMode",typeof(MainWindow));        
            Load = new RoutedCommand("Load", typeof(MainWindow));
            Save = new RoutedCommand("Save", typeof (MainWindow));
        }
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new View();
        }
    }
}
