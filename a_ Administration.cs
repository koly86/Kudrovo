using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;

namespace App1
{
    [Activity(Label = "Администрация", Theme = "@style/MyTheme")]
    public class a_Administration : AppCompatActivity
    {
        private DrawerLayout _mDrawerLayout;
        private ActionBarDrawerToggle _mDrawerToggle;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;
        private SupportToolBar _mToolBar;
        private TextView adres;
        private TextView email;

        private TextView tel1;
        private TextView tel2;
        private TextView tel3;
        private TextView tel4;
        private TextView tel5;
        private TextView tel6;
        private TextView tel7;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.l_Administration);

            _mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _mToolBar = FindViewById<SupportToolBar>(Resource.Id.toolbar);
            _mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            _mListViewl = FindViewById<ListView>(Resource.Id.left_drawer);


            SetSupportActionBar(_mToolBar);
            _mDrawerToggle = new ActionBarDrawerToggle(
                this, _mDrawerLayout, Resource.String.openDrawer,
                Resource.String.closeDrawer
            );

            _mDrawerLayout.AddDrawerListener(_mDrawerToggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            _mDrawerToggle.SyncState();


            _mItems = new List<string>();
            _mItems.Add("Школы");
            _mItems.Add("Почта, Банк");
            _mItems.Add("Транспорт");
            _mItems.Add("радио город Кудрово");
            _mItems.Add("Управляющие компании");
            _mItems.Add("Администрация Кудрово");
            _mItems.Add("Новости");

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, _mItems);
            _mListViewl.Adapter = adapter;
            _mListViewl.ItemClick += mListViewl_ItemClick;


            tel1 = FindViewById<TextView>(Resource.Id.tel1);
            tel2 = FindViewById<TextView>(Resource.Id.tel2);
            tel3 = FindViewById<TextView>(Resource.Id.tel3);
            tel4 = FindViewById<TextView>(Resource.Id.tel4);
            tel5 = FindViewById<TextView>(Resource.Id.tel5);
            tel6 = FindViewById<TextView>(Resource.Id.tel6);
            tel7 = FindViewById<TextView>(Resource.Id.tel7);

            adres = FindViewById<TextView>(Resource.Id.adres);
            email = FindViewById<TextView>(Resource.Id.email);

            tel1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel2.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin2));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel3.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin3));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel4.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin4));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel5.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin5));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel6.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin6));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            tel7.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.admin7));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            adres.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.936759, 30.519555");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            email.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.adminEmail)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            _mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }

        private void mListViewl_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    StartActivity(typeof(a_Schools));
                    break;
                case 1:
                    StartActivity(typeof(a_PostBank));
                    break;
                case 2:
                    StartActivity(typeof(a_Transport));
                    break;
                case 3:
                    StartActivity(typeof(a_Radio));
                    break;
                case 4:
                    StartActivity(typeof(a_ManagedCompany));
                    break;
                case 5:
                    StartActivity(typeof(a_Administration));
                    break;
                case 6:
                    StartActivity(typeof(MainActivity));
                    break;
            }
        }
    }
}