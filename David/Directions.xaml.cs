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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace David
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Directions : Page
    {
        public Directions()
        {
            InitializeComponent();
            //this.GetCoordinates();
        }

        //private async void GetCoordinates()
        //{
            // Get the phone's current location.
    //        Geolocator MyGeolocator = new Geolocator();
    //        MyGeolocator.DesiredAccuracyInMeters = 5;
    //        Geoposition MyGeoPosition = null;
    //        try
    //        {
    //            MyGeoPosition = await MyGeolocator.GetGeopositionAsync(TimeSpan.FromMinutes(1), TimeSpan.FromSeconds(10));
    //            MyCoordinates.Add(new GeoCoordinate(MyGeoPosition.Coordinate.Latitude, MyGeoPosition.Coordinate.Longitude));
    //        }
    //        catch (UnauthorizedAccessException)
    //        {
    //            MessageBox.Show("Location is disabled in phone settings or capabilities are not checked.");
    //        }
    //        catch (Exception ex)
    //        {
    //            // Something else happened while acquiring the location.
    //            MessageBox.Show(ex.Message);
    //        }
    //    }
    }
}