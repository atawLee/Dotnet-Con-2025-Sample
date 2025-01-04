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
using BMS.Data;
using BMS.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;


namespace BMS.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = App.MainServiceProvider.GetRequiredService<MainWindowViewModel>();
            this.DataContext = vm;
        }
    }
}