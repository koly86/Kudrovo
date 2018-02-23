using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace App1
{
    public class FeedItemsListAdapter : BaseAdapter<FeedItem>
    {
        protected Activity _context;
        protected List<FeedItem> _feedList = new List<FeedItem>();


        public FeedItemsListAdapter(Activity context, List<FeedItem> feedItems)
        {
            _context = context;
            _feedList = feedItems;
        }


        public override FeedItem this[int position] => _feedList[position];

        public override int Count => _feedList.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var feedItem = _feedList[position];

            var view =
                (convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.FeedItemListItemLayout, parent, false))
                as LinearLayout;

            view.FindViewById<TextView>(Resource.Id.title).Text = feedItem.Title;
            //feedItem.Title.Length < 70 ? feedItem.Title : feedItem.Title.Substring(0, 70) + "...";
            view.FindViewById<TextView>(Resource.Id.creator).Text = feedItem.Creator;
            view.FindViewById<TextView>(Resource.Id.pubDate).Text = feedItem.PubDate.ToString("dd/MM/yyyy HH:mm");
            return view;
        }
    }
}