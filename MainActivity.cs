using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;
using Uri = Android.Net.Uri;


namespace App1
{
    [Activity(Label = "Kудрово", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        private ListView _listView;
        private DrawerLayout _mDrawerLayout;
        private ActionBarDrawerToggle _mDrawerToggle;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;
        private SupportToolBar _mToolBar;
        private ListView feedItemsListView;

        private List<FeedItem> lista;
        private ProgressDialog progressDialog;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
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


            feedItemsListView = FindViewById<ListView>(Resource.Id.listView1);

            progressDialog = new ProgressDialog(this);
            progressDialog.SetMessage("Загружается...");

            GetFeedItemsList();
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            _mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }


        private void GetFeedItemsList()
        {
            progressDialog.Show();

            var task1 = Task.Factory.StartNew(() => FeedService.GetFeedItems("https://lenta.ru/rss"));

            var task2 = task1.ContinueWith(antecedent =>
                {
                    try
                    {
                        progressDialog.Dismiss();
                        lista = antecedent.Result;

                        PopulateListView(lista);
                    }
                    catch (AggregateException aex)
                    {
                        Toast.MakeText(this, aex.InnerException.Message, ToastLength.Short).Show();
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext()
            );
        }

        private void PopulateListView(List<FeedItem> feedItemsList)
        {
            var adapter = new FeedItemsListAdapter(this, feedItemsList);
            feedItemsListView.Adapter = adapter;
            feedItemsListView.ItemClick += OnListViewItemClick;
        }

        protected void OnListViewItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var t = lista[e.Position];
            // Toast.MakeText(this, t.Link, ToastLength.Short).Show();
            var uri = Uri.Parse(t.Link);
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
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


        public void ShowAlert(string str)
        {
            var alert = new AlertDialog.Builder(this);
            alert.SetTitle(str);
            alert.SetPositiveButton("OK", (senderAlert, args) => { StartActivity(typeof(a_Schools)); });

            //run the alert in UI thread to display in the screen
            RunOnUiThread(() => { alert.Show(); });
        }
    }
}