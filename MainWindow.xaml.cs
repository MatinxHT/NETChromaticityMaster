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
using static NETChromaticityMaster.Models.DataGrid;
using static NETChromaticityMaster.Models.PlotCIE1931Graph;

namespace NETChromaticityMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Graph
        public static List<DataGridValue> ScatterPointValueStructList;
        private CIE1931ViewModel? _1931viewModel;
        public MainWindow()
        {
            InitializeComponent();

            Plot1931();
        }

        private void Plot1931()
        {

            _1931viewModel = new CIE1931ViewModel(ScatterPointValueStructList);
            CIE1931Chart.DataContext = _1931viewModel;

        }
    }
}