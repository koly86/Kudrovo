using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using SupportActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;

namespace App1
{
    public class ActionBarDrawerToggle : SupportActionBarDrawerToggle
    {
        private int mClosedResource;
        private AppCompatActivity mHostActivity;
        private int mOpenedResource;

        public ActionBarDrawerToggle(AppCompatActivity host, DrawerLayout drawerLayout, int opendedResource,
            int closedResource)
            : base(host, drawerLayout, opendedResource, closedResource)
        {
            mHostActivity = host;
            mOpenedResource = opendedResource;
            mClosedResource = closedResource;
        }

        public override void OnDrawerOpened(View drawerView)
        {
            base.OnDrawerOpened(drawerView);
        }

        public override void OnDrawerClosed(View drawerView)
        {
            base.OnDrawerClosed(drawerView);
        }

        public override void OnDrawerSlide(View drawerView, float slideOffset)
        {
            base.OnDrawerSlide(drawerView, slideOffset);
        }
    }
}