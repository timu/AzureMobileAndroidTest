using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace AzureMobileAndroidTest
{
    [Activity(Label = "AzureMobileAndroidTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            MobileCenter.Start("3a1e37bf-edf2-47be-bd62-abd0b85765ef",
                    typeof(Analytics), typeof(Crashes));

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

