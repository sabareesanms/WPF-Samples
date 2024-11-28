using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGallery.ViewModels.Layout
{
    public partial class GridSplitterPageViewModel : ObservableObject
    {
        public GridSplitterPageViewModel() { }

        [ObservableProperty]
        private string _pageTitle = "RibbonControl";

        [ObservableProperty]
        private string _pageDescription = "";
    }
}
