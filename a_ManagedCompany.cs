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
    [Activity(Label = "Управляюшие компании", Theme = "@style/MyTheme")]
    public class a_ManagedCompany : AppCompatActivity
    {
        private TextView _adres4;
        private TextView _adres7Stolic;
        private TextView _adresComfort;
        private TextView _adresFlagman;
        private TextView _adresGrad;
        private TextView _adresNachdom;
        private TextView _adresService;
        private TextView _adresSodruzestvo;
        private TextView _adresUut;





        private TextView _testEmail;
        private Button _btnTest;
        private ScrollView _testScrollView;


        private Button _btn1;
        private Button _btn2;
        private Button _btn3;
        private Button _btn4;
        private Button _btn5;
        private Button _btn6;
        private Button _btn7;
        private Button _btn8;
        private Button _btn9;
        private TextView _email4;
        private TextView _email7Stolic;
        private TextView _emailComfort;
        private TextView _emailFlagman;
        private TextView _emailGrad;
        private TextView _emailNachdom;
        private TextView _emailSodruzestvo;
        private TextView _emalUut;
        private DrawerLayout _mDrawerLayout;
        private ActionBarDrawerToggle _mDrawerToggle;
        private List<string> _mItems;
        private ListView _mLeftDrawer;
        private ListView _mListViewl;
        private SupportToolBar _mToolBar;
        private TextView _paySodruzestvo;
        private TextView _payUut;
        private TextView _privateComfort;
        private TextView _privateService;
        private TextView _privateUut;
        private ScrollView _scroll1;
        private ScrollView _scroll2;
        private ScrollView _scroll3;
        private ScrollView _scroll4;
        private ScrollView _scroll5;
        private ScrollView _scroll6;
        private ScrollView _scroll7;
        private ScrollView _scroll8;
        private ScrollView _scroll9;
        private TextView _tel14;
        private TextView _tel24;
        private TextView _tel7Stolic;
        private TextView _telComfort;

        private TextView _telFlagman1;
        private TextView _telFlagman2;
        private TextView _telGrad1;
        private TextView _telGrad2;
        private TextView _telGrad3;
        private TextView _telNachdom;
        private TextView _telService1;
        private TextView _telService2;
        private TextView _telSodruzestvo;
        private TextView _telUut;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.l_ManagedCompany);


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

            _btn1 = FindViewById<Button>(Resource.Id.btn1);
            _btn2 = FindViewById<Button>(Resource.Id.btn2);
            _btn3 = FindViewById<Button>(Resource.Id.btn3);
            _btn4 = FindViewById<Button>(Resource.Id.btn4);
            _btn5 = FindViewById<Button>(Resource.Id.btn5);
            _btn6 = FindViewById<Button>(Resource.Id.btn6);
            _btn7 = FindViewById<Button>(Resource.Id.btn7);
            _btn8 = FindViewById<Button>(Resource.Id.btn8);
            _btn9 = FindViewById<Button>(Resource.Id.btn9);


            _btnTest = FindViewById<Button>(Resource.Id.btnTest);
            _testEmail = FindViewById<TextView>(Resource.Id.testEmail);
            _testScrollView = FindViewById<ScrollView>(Resource.Id.testScrollView);

            _scroll1 = FindViewById<ScrollView>(Resource.Id.scrol1);
            _scroll2 = FindViewById<ScrollView>(Resource.Id.scrol2);
            _scroll3 = FindViewById<ScrollView>(Resource.Id.scrol3);
            _scroll4 = FindViewById<ScrollView>(Resource.Id.scrol4);
            _scroll5 = FindViewById<ScrollView>(Resource.Id.scrol5);
            _scroll6 = FindViewById<ScrollView>(Resource.Id.scrol6);
            _scroll7 = FindViewById<ScrollView>(Resource.Id.scrol7);
            _scroll8 = FindViewById<ScrollView>(Resource.Id.scrol8);
            _scroll9 = FindViewById<ScrollView>(Resource.Id.scrol9);

            _telFlagman1 = FindViewById<TextView>(Resource.Id.telFlagman1);
            _telFlagman2 = FindViewById<TextView>(Resource.Id.telFlagman2);
            _emailFlagman = FindViewById<TextView>(Resource.Id.emailFlagman);
            _adresFlagman = FindViewById<TextView>(Resource.Id.adresFlagman);

            _tel7Stolic = FindViewById<TextView>(Resource.Id.tel7Stolic);
            _email7Stolic = FindViewById<TextView>(Resource.Id.email7Stolic);
            _adres7Stolic = FindViewById<TextView>(Resource.Id.adres7Stolic);

            _telNachdom = FindViewById<TextView>(Resource.Id.telNachdom);
            _emailNachdom = FindViewById<TextView>(Resource.Id.emailNachdom);
            _adresNachdom = FindViewById<TextView>(Resource.Id.adresNachdom);

            _telSodruzestvo = FindViewById<TextView>(Resource.Id.telSodruzestvo);
            _emailSodruzestvo = FindViewById<TextView>(Resource.Id.emailSodruzestvo);
            _adresSodruzestvo = FindViewById<TextView>(Resource.Id.adresSodruzestvo);
            _paySodruzestvo = FindViewById<TextView>(Resource.Id.paySodruzestvo);

            _tel14 = FindViewById<TextView>(Resource.Id.tel14);
            _tel24 = FindViewById<TextView>(Resource.Id.tel24);
            _adres4 = FindViewById<TextView>(Resource.Id.adres4);
            _email4 = FindViewById<TextView>(Resource.Id.email4);

            _telUut = FindViewById<TextView>(Resource.Id.telUut);
            _emalUut = FindViewById<TextView>(Resource.Id.emalUut);
            _adresUut = FindViewById<TextView>(Resource.Id.adresUut);
            _privateUut = FindViewById<TextView>(Resource.Id.privateUut);
            _payUut = FindViewById<TextView>(Resource.Id.payUut);

            _telService1 = FindViewById<TextView>(Resource.Id.telService1);
            _telService2 = FindViewById<TextView>(Resource.Id.telService2);
            _adresService = FindViewById<TextView>(Resource.Id.adresService);
            _privateService = FindViewById<TextView>(Resource.Id.privateService);

            _telGrad1 = FindViewById<TextView>(Resource.Id.telGrad1);
            _telGrad2 = FindViewById<TextView>(Resource.Id.telGrad2);
            _telGrad3 = FindViewById<TextView>(Resource.Id.telGrad3);
            _adresGrad = FindViewById<TextView>(Resource.Id.adresGrad);
            _emailGrad = FindViewById<TextView>(Resource.Id.emailGrad);

            _telComfort = FindViewById<TextView>(Resource.Id.telComfort);
            _adresComfort = FindViewById<TextView>(Resource.Id.adresComfort);
            _emailComfort = FindViewById<TextView>(Resource.Id.emailComfort);
            _privateComfort = FindViewById<TextView>(Resource.Id.privateComfort);


            _btn1.Click += _btn1_Click1;
            _btn2.Click += _btn2_Click2;
            _btn3.Click += _btn3_Click3;
            _btn4.Click += _btn4_Click4;
            _btn5.Click += _btn5_Click5;
            _btn6.Click += _btn6_Click6;
            _btn7.Click += _btn7_Click7;
            _btn8.Click += _btn8_Click8;
            _btn9.Click += _btn9_Click9;

            _btnTest.Click += _btnTest_Click;

            _telFlagman1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.StroylinkTel1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _telFlagman2.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.StroylinkTel2));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };


            _testEmail.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new string[]{ "Upravdom@gmail.com"});

                email.SetType("message/rfc822");
                StartActivity(email);
            };


            _emailFlagman.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.StroylinkEmail)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _adresFlagman.Click += delegate
            {
                var geoUri = Uri.Parse("geo:60.013529, 30.312802");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _tel7Stolic.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel7Stolic));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _email7Stolic.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.email7Stolic)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _adres7Stolic.Click += delegate
            {
                var geoUri = Uri.Parse("geo:60.025740, 30.621812");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _telNachdom.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telNachdom));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _emailNachdom.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.emailNachdom)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };


            _adresNachdom.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.970140, 30.394220");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _telSodruzestvo.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telSodruzestvo));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _emailSodruzestvo.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.emailSodruzestvo)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _adresSodruzestvo.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.831827, 30.194503");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _paySodruzestvo.Click += delegate
            {
                var uri = Uri.Parse("https://pay.pscb.ru/list/?lf=uks");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            _tel14.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel14));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _tel24.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.tel24));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _adres4.Click += delegate
            {
                var geoUri = Uri.Parse("geo:60.068014, 30.403911");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _email4.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.email4)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _telUut.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telUut));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _emalUut.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.emalUut)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _adresUut.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.903213, 30.398065");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _privateUut.Click += delegate
            {
                var uri = Uri.Parse("http://ae-comfort.ru/User/LogOn");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            _payUut.Click += delegate
            {
                var uri = Uri.Parse("https://pay.mcplat.ru/article/ukUyut");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            _telService1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telService1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _telService2.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telService2));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _adresService.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.905274, 30.511037");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _privateService.Click += delegate
            {
                var uri = Uri.Parse("https://lkabinet.online/login.aspx");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            _telGrad1.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telGrad1));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            _telGrad2.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telGrad2));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _telGrad3.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telGrad3));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            _emailGrad.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.emailGrad)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _adresGrad.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.915261, 30.519678");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _adresComfort.Click += delegate
            {
                var geoUri = Uri.Parse("geo:59.906701, 30.307844");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            _emailComfort.Click += delegate
            {
                var email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new[] {GetString(Resource.String.emailComfort)});

                email.SetType("message/rfc822");
                StartActivity(email);
            };

            _privateComfort.Click += delegate
            {
                var uri = Uri.Parse("http://lk.uprkom.ru/");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            _telComfort.Click += delegate
            {
                var uri = Uri.Parse("tel:" + GetString(Resource.String.telComfort));
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
        }

        private void _btnTest_Click(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
               ViewGroup.LayoutParams.WrapContent);

            _testScrollView.LayoutParameters = linearLayoutParams;
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


        private void _btn9_Click9(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll9.LayoutParameters = linearLayoutParams;
        }

        private void _btn8_Click8(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll8.LayoutParameters = linearLayoutParams;
        }

        private void _btn7_Click7(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll7.LayoutParameters = linearLayoutParams;
        }

        private void _btn6_Click6(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll6.LayoutParameters = linearLayoutParams;
        }

        private void _btn5_Click5(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll5.LayoutParameters = linearLayoutParams;
        }

        private void _btn4_Click4(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll4.LayoutParameters = linearLayoutParams;
        }

        private void _btn3_Click3(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll3.LayoutParameters = linearLayoutParams;
        }

        private void _btn2_Click2(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll2.LayoutParameters = linearLayoutParams;
        }

        private void _btn1_Click1(object sender, EventArgs e)
        {
            var linearLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            _scroll1.LayoutParameters = linearLayoutParams;
        }
    }
}