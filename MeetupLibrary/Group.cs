using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetupLibrary
{
    class Group
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Member> Members { get; set; }
        public Group() { }
        public Group(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
    class GroupFactory
    {
        public GroupFactory(Group group)
        {
            //Dim me up a new Group!
        }
    }
}