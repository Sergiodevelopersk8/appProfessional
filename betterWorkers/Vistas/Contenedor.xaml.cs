using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using betterWorkers.VistasModelo;

namespace betterWorkers.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contenedor : Xamarin.Forms.TabbedPage
    {
        public Contenedor()
        {
            InitializeComponent();
            DependencyService.Get<VMstatusbar>().MostrarStatusBar();

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}