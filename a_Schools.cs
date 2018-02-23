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
    [Activity(Label = "Школы", Theme = "@style/MyTheme")]
    public class a_Schools : AppCompatActivity
    {
        private TextView _mAddress1;
        private TextView _mAddress2;
        private TextView _mAddress3;
        private Button _mButton1;
        private Button _mButton2;
        private Button _mButton3;
        private DrawerLayout _mDrawerLayout;

        private ActionBarDrawerToggle _mDrawerToggle;
        private TextView _mEmail1;
        private TextView _mEmail2;
        private TextView _mEmail3;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;

        private TextView _mTel1;
        private TextView _mTel2;
        private TextView _mTel3;
        private TextView _mTel4;
        private TextView _mTel5;
        private SupportToolBar _mToolBar;


        private ScrollView _scrollView1;
        private ScrollView _scrollView2;
        private ScrollView _scrollView3;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.l_Schools);

            _mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _mToolBar = FindViewById<SupportToolBar>(Resource.Id.toolbar);
            _mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            _mListViewl = FindViewById<ListView>(Resource.Id.left_drawer);


            _mTel1 = FindViewById<TextView>(Resource.Id.tel1);
            _mTel2 = FindViewById<TextView>(Resource.Id.tel2);
            _mTel3 = FindViewById<TextView>(Resource.Id.tel3);
            _mTel4 = FindViewById<TextView>(Resource.Id.tel4);
            _mTel5 = FindViewById<TextView>(Resource.Id.tel5);

            _mAddress1 = FindViewById<TextView>(Resource.Id.addres1);
            _mAddress2 = FindViewById<TextView>(Resource.Id.addres2);
            _mAddress3 = FindViewById<TextView>(Resource.Id.addres3);
            _mEmail1 = FindViewById<TextView>(Resource.Id.email1);
            _mEmail2 = FindViewById<TextView>(Resource.Id.email2);
            _mEmail3 = FindViewById<TextView>(Resource.Id.email3);


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


            _mTel1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _mTel2.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel2));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _mTel3.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel3));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _mTel4.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel4));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _mTel5.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel5));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };


            _mAddress1.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.898971, 30.506325");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };


            _mAddress2.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.915280, 30.507965");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };
            _mAddress3.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.897564, 30.511756");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };


            _mEmail1.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.email1)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _mEmail2.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.email2)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };
            _mEmail3.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.email3)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _scrollView1 = FindViewById<ScrollView>(Resource.Id.scrollView1);
            _scrollView2 = FindViewById<ScrollView>(Resource.Id.scrollView2);
            _scrollView3 = FindViewById<ScrollView>(Resource.Id.scrollView3);

            _mButton1 = FindViewById<Button>(Resource.Id.button1);
            _mButton2 = FindViewById<Button>(Resource.Id.button2);
            _mButton3 = FindViewById<Button>(Resource.Id.button3);

            _mButton1.Click += MButton1_Click;
            _mButton2.Click += MButton2_Click;
            _mButton3.Click += MButton3_Click;
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

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            _mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }


        private void MButton3_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scrollView3.LayoutParameters = linearLayoutParams;
        }

        private void MButton2_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scrollView2.LayoutParameters = linearLayoutParams;
        }

        private void MButton1_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scrollView1.LayoutParameters = linearLayoutParams;
        }
    }
}