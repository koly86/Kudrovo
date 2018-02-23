using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;
using Uri = Android.Net.Uri;

namespace App1
{
    [Activity(Label = "Транспорт", Theme = "@style/MyTheme")]
    public class a_Transport : AppCompatActivity
    {
        private Button _button1;
        private Button _button2;
        private DrawerLayout _mDrawerLayout;

        private ActionBarDrawerToggle _mDrawerToggle;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;
        private SupportToolBar _mToolBar;

        private ScrollView _scrollView1;
        private ScrollView _scrollView2;
        private TextView _telBus1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.l_Transport);
            _mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _mToolBar = FindViewById<SupportToolBar>(Resource.Id.toolbar);
            _mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            _mListViewl = FindViewById<ListView>(Resource.Id.left_drawer);
            _button1 = FindViewById<Button>(Resource.Id.button1);
            _button2 = FindViewById<Button>(Resource.Id.button2);
            _scrollView1 = FindViewById<ScrollView>(Resource.Id.scrollView1);
            _scrollView2 = FindViewById<ScrollView>(Resource.Id.scrollView2);

            _telBus1 = FindViewById<TextView>(Resource.Id.telBus1);


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


            _telBus1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telBus1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _button1.Click += _button_Click;
            _button2.Click += _button2_Click;
        }

        private void _button2_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scrollView2.LayoutParameters = linearLayoutParams;
        }

        private void _button_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scrollView1.LayoutParameters = linearLayoutParams;
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