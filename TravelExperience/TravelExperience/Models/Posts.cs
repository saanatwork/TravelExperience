using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Xml.Serialization;

namespace TravelExperience.Models
{
    [XmlRoot(ElementName = "img")]
    public class Descimg
    {
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "src")]
        public string Src { get; set; }
        [XmlAttribute(AttributeName = "class")]
        public string Class { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
    }
    [XmlRoot(ElementName = "enclosure")]
    public class Enclosure
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "description")]
        private string Description;
        public string description
        {
            get { return Description; }
            set {
                Description = value;
                int start = Description.IndexOf("src=")+5;
                int end = Description.IndexOf(".jpg") + 4;
                Descimg = Description.Substring(start, end - start);
            } 
        }
        public String Descimg { get; set; }

        [XmlElement(ElementName = "link")]
        public string ItemLink { get; set; }
        //[XmlElement(ElementName = "category")]
        //public ObservableCollection<string> Category { get; set; }
        [XmlElement(ElementName = "pubDate")]
        private string pubDate;
        public string PubDate
        {
            get { return pubDate; }
            set
            {
                pubDate = value;
                PublishedDate = DateTime.ParseExact(pubDate, "ddd, dd MMM yyyy HH:mm:ss GMT", CultureInfo.InvariantCulture);
            }
        }

        public DateTime PublishedDate { get; set; }
        [XmlElement(ElementName = "enclosure")]
        public Enclosure Enclosure { get; set; }
        [XmlElement(ElementName = "creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Creator { get; set; }
    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "lastBuildDate")]
        public string LastBuildDate { get; set; }
        [XmlElement(ElementName = "item")]
        public ObservableCollection<Item> Items { get; set; }
    }

    [XmlRoot(ElementName = "rss")]
    public class Posts
    {
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
    }
}
