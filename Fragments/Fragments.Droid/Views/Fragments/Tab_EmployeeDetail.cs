using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;

namespace Fragments.Droid.Views
{
    [Register("fragments.droid.views.Tab_EmployeeDetail")]
    public class Tab_EmployeeDetail : MvxFragment
    {

        public override View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.tab_EmployeeDetail, null);
            
            return view;
        }
    }
}