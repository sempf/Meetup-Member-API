using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetupLibrary
{
    public class Member
    {
        public Member() { }

        public Member(string bio, string city, string id, string language, string joined, string linkToProfile, string name, string photoUrl)
        {
            Bio = bio;
            City = city;
            Id = id;
            Language = language;
            Joined = joined;
            LinkToProfile = linkToProfile;
            Name = name;
            PhotoUrl = photoUrl;
        }
        public string Bio { get; set; }
        public string City { get; set; }
        public string Id { get; set; }
        public string Language { get; set; }
        public string Joined { get; set; }
        public string LinkToProfile { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        
    }
    class MemberFactory
    {
        public MemberFactory(Member member)
        {
            //dim me up a new member
        }
    }
}
