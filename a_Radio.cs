using System.Collections.Generic;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;

namespace App1
{
    [Activity(Label = "Радио", Theme = "@style/MyTheme")]
    public class a_Radio : AppCompatActivity
    {
        private ListView _listView;
        private DrawerLayout _mDrawerLayout;
        private ActionBarDrawerToggle _mDrawerToggle;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;
        private SupportToolBar _mToolBar;
        private ListView feedItemsListView;
        private bool isStarted = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.I_Radio);
            Radio();
            _mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _mToolBar = FindViewById<SupportToolBar>(Resource.Id.toolbar);
            _mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            _mListViewl = FindViewById<ListView>(Resource.Id.left_drawer);
            _listView = FindViewById<ListView>(Resource.Id.listView1);

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
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            _mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }


        public void Radio()
        {
            var player = new MediaPlayer();
            player.SetAudioStreamType(Stream.Music);
            player.SetDataSource("http://eu3.radioboss.fm:8207/stream");
            player.Prepare();
            player.Start();
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