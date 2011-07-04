using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Data;

namespace MeetupLibrary
{
    public class Members
    {
        public Members(IEnumerable<int> groupIds)
        {
            // OK that just gets MY group. I want all of L.I
            //Make the list of groupids into a comma delimited string
            string[] array = groupIds.Where(n => true).Select(n => n.ToString()).ToArray();
            string groupString =  string.Join(",", array);

            //Get the feed in a string
            var url = new Uri("https://api.meetup.com/members?key=" + Static.ApiKey + "&format=xml&sign=true&group_id=" + groupString);
            string xmlString = Static.GetPageAsString(url);
            //Make it XML
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(new StringReader(xmlString));
             
            //Make it a dataset??
            var ds = new DataSet();
            ds.ReadXml(new XmlNodeReader(xmlDoc));

            //Populate a collection of member objects
            Items = new List<Member>();
            foreach (DataRow row in ds.Tables["item"].Rows)
            {
                Items.Add(new Member(row["bio"].ToString(),row["city"].ToString(),row["id"].ToString(),row["lang"].ToString(), row["joined"].ToString(), row["link"].ToString(),row["name"].ToString(), row["photo_url"].ToString()));
            }
        }

        public List<Member> Items { get; set; }

    }
}
