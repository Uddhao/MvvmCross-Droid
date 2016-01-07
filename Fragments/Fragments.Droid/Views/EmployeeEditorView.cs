using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Fragments.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using System.Collections.Generic;

namespace Fragments.Droid.Views
{
    [Activity(Label = "Employee Detail", Theme = "@style/HoloTheme")]
    public class EmployeeEditorView : MvxCachingFragmentCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeEditorView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.myToolbar);

            if(toolbar != null)
            {
                SetSupportActionBar(toolbar);
            }
            // View Pager
            var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                // Add tabs in view pager

                var fragments = new List<MvxFragmentStatePagerAdapter.FragmentInfo>
                {
                    new MvxFragmentStatePagerAdapter.FragmentInfo("EmpDetail", typeof(Tab_EmployeeDetail), typeof(EmployeeEditorViewModel)),
                    new MvxFragmentStatePagerAdapter.FragmentInfo("Address", typeof(Tab_EmployeeAddress),typeof(EmployeeEditorViewModel))
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_LOCATION, typeof(Tab_CustomerLocation),typeof(EmployeeEditorViewModel)),
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_CONTRACT, typeof(Tab_CustomerContract),typeof(EmployeeEditorViewModel))
                };
                viewPager.Adapter = new MvxFragmentStatePagerAdapter(this, SupportFragmentManager, fragments);
            }

            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }
                
    }
}