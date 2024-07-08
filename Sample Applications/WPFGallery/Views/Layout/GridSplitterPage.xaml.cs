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
using WPFGallery.Models;
using WPFGallery.ViewModels.Layout;

namespace WPFGallery.Views.Layout
{
    /// <summary>
    /// Interaction logic for GridSplitterPage.xaml
    /// </summary>
    public partial class GridSplitterPage : Page
    {
        public GridSplitterPageViewModel gridSplitterPageViewModel1 { get; }
        public GridSplitterPage(GridSplitterPageViewModel gridSplitterPageViewModel)
        {
            gridSplitterPageViewModel1 = gridSplitterPageViewModel;
            DataContext = gridSplitterPageViewModel;
            InitializeComponent();
        }
      
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // for .NET Core you need to add UseShellExecute = true
            // see https://learn.microsoft.com/dotnet/api/system.diagnostics.processstartinfo.useshellexecute#property-value
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://learn.microsoft.com",
                UseShellExecute = true
            });
            e.Handled = true;
        }
    }
}
