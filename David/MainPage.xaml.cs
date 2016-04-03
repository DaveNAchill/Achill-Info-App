using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Phone.UI.Input; // For the back button
using Windows.Devices.Geolocation;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace David
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {
            this.InitializeComponent();
            //this.GetCoordinates();
        }

        




        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), null);
        }

        private void btnDirections_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Directions), null);

        }
    }
}
