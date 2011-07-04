using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Data;

namespace MeetupLibrary
{
    class Organizer
    {
        public string  Name { get; set; }
        public int Id { get; set; }
        public List<Group> Groups { get; set; }

    }
    class OrganizerFactory
    {
        public Organizer Create()
        {
            //dim me up a new Owner
            var result = new Organizer {Name = "Locksport International", Id = 11377143, Groups = GetGroups(11377143)};
            return result;
        }

        private List<Group> GetGroups(int organizerId)
        {
            var result = new List<Group>();

            //Get the feed in a string
            var url = new Uri("https://api.meetup.com/groups?key=" + Static.ApiKey + "&sign=true&member_id=" + organizerId);
            string xmlString = Static.GetPageAsString(url);
            
            //Make it XML
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(new StringReader(xmlString));

            //Make it a dataset??
            var ds = new DataSet();
            ds.ReadXml(new XmlNodeReader(xmlDoc));

            //Populate a collection of member objects
            return (from DataRow row in ds.Tables["item"].Rows
                    select new Group(row["name"].ToString(), Int32.Parse((row["id"]).ToString()))).ToList();
        }
    }
}
