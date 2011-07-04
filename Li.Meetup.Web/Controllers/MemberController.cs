using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Li.Meetup.Web.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/

        public ActionResult Index()
        {
            var groups = new List<int>  {1785311, 1709751, 1700830, 1685221, 1632078, 1632066, 1630743};
            var liMembershipLibrary = new MeetupLibrary.Members(groups);
            var memberList = liMembershipLibrary.Items;

            return View("Index", memberList);
        }

    }
}
