using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;

namespace App1
{
    internal static class FeedService
    {
        internal static List<FeedItem> GetFeedItems(string url)
        {
            var feedItemsList = new List<FeedItem>();
            try
            {
                var webRequest = WebRequest.Create(url);
                var webResponse = webRequest.GetResponse();
                var stream = webResponse.GetResponseStream();
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(stream);
                var nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
                nsmgr.AddNamespace("dc", xmlDocument.DocumentElement.GetNamespaceOfPrefix("dc"));
                nsmgr.AddNamespace("content", xmlDocument.DocumentElement.GetNamespaceOfPrefix("content"));
                var itemNodes = xmlDocument.SelectNodes("rss/channel/item");

                for (var i = 0; i < itemNodes.Count; i++)
                {
                    var feedItem = new FeedItem();

                    if (itemNodes[i].SelectSingleNode("title") != null)
                        feedItem.Title = itemNodes[i].SelectSingleNode("title").InnerText;

                    if (itemNodes[i].SelectSingleNode("link") != null)
                        feedItem.Link = itemNodes[i].SelectSingleNode("link").InnerText;

                    if (itemNodes[i].SelectSingleNode("pubDate") != null)
                        feedItem.PubDate = Convert.ToDateTime(itemNodes[i].SelectSingleNode("pubDate").InnerText);

                    /*  if (itemNodes[i].SelectSingleNode("dc:creator", nsmgr) != null)
                    {
                        feedItem.Creator = itemNodes[i].SelectSingleNode("dc:creator", nsmgr).InnerText;
                    }

                    if (itemNodes[i].SelectSingleNode("category") != null)
                    {
                        feedItem.Category = itemNodes[i].SelectSingleNode("category").InnerText;
                    }

                    if (itemNodes[i].SelectSingleNode("description") != null)
                    {
                        feedItem.Description = itemNodes[i].SelectSingleNode("description").InnerText;
                    }

                    if (itemNodes[i].SelectSingleNode("content:encoded", nsmgr) != null)
                    {
                        feedItem.Content = itemNodes[i].SelectSingleNode("content:encoded", nsmgr).InnerText;
                    }
                    else
                    {
                        feedItem.Content = feedItem.Description;
                    }*/

                    feedItemsList.Add(feedItem);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return feedItemsList;
        }
    }
}