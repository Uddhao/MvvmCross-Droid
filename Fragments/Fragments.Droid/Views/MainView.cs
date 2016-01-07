using Android.App;
using Android.OS;
using Fragments.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Fragments.Droid.Views
{
    [Activity(Label = "Employee List", Theme = "@style/HoloTheme")]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}