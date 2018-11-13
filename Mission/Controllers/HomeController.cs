using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mission.Models;

namespace Mission.Controllers
{
    public class HomeController : Controller
    {
        static List<Missions> Missions = new List<Missions>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mission()
        {
            if (Missions.Count == 0)
            {
                Missions.Add(new Missions("Temple Square Mission",
                    "David E. Poulsen",
                    "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3021.5854723479165!2d-111.8914388844367!3d40.77114114193186!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8752f507c72c8039%3A0xe67a34043a62cb5e!2sThe+Church+of+Jesus+Christ+of+Latter-day+Saints+-+Church+Office+Building!5e0!3m2!1sen!2sus!4v1541976469609\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>",
                    "English, Spanish, Mandarin, and 42 others",
                    "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/en/40d76n111d89/salt-lake-city/?unit=us\" data-label_1=\"SALT LAKE CITY\" data-label_2=\"WEATHER\" data-icons=\"Climacons Animated\" data-days=\"3\" data-theme=\"beige\" >SALT LAKE CITY WEATHER</a>",
                    "The Church of Jesus Christ of Latter-day Saints: 51%",
                    "/Content/Images/temple_square_mission_icon.jpg"));
                Missions.Add(new Missions("Taiwan Taipei Mission",
                    "Michael L. Peterson",
                    "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3615.086074225274!2d121.52502931526683!3d25.03115284455894!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442a98314d3d0a9%3A0xab86da463cb003ca!2sFloor+4%2C+No%2C+No.+24%2C+Lane+183%2C+Jinhua+Street%2C+Da%E2%80%99an+District%2C+Taipei+City%2C+Taiwan+106!5e0!3m2!1sen!2sus!4v1541975823502\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>",
                    "Mandarin, Taiwanese, and English",
                    "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/en/25d03121d57/taipei/?unit=us\" data-label_1=\"TAIPEI\" data-label_2=\"WEATHER\" data-icons=\"Climacons Animated\" data-days=\"3\" data-theme=\"beige\" >TAIPEI WEATHER</a>",
                    "Buddhism",
                    "/Content/Images/taiwan_taipei_mission_icon.jpg"));
                Missions.Add(new Missions("Italy Rome Mission",
                    "Michael D. Pickerd",
                    "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2968.0794564245975!2d12.537491315591058!3d41.9341439698837!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x132f63fa42d995cf%3A0xe85a0cd31360cf17!2sPiazza+Monte+Gemma%2C+9%2C+00141+Roma+RM%2C+Italy!5e0!3m2!1sen!2sus!4v1541975573970\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>",
                    "Italian",
                    "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/en/41d9012d50/metropolitan-city-of-rome/?unit=us\" data-label_1=\"ROME\" data-label_2=\"WEATHER\" data-icons=\"Climacons Animated\" data-days=\"3\" data-theme=\"beige\" >ROME WEATHER</a>",
                    "Roman Catholic",
                    "/Content/Images/italy_rome_mission_icon.jpg"));
            }
            ViewBag.Missions = Missions;
            return View();
        }

        public ActionResult MissionFAQ(string Name)
        {
            ViewBag.Name = Name;
            if (Missions.Count > 0)
            {
                for (int i = 0; i < Missions.Count; i++)
                {
                    if (Name == Missions[i].Name)
                    {
                        ViewBag.President = Missions[i].President;
                        ViewBag.Address = Missions[i].Address;
                        ViewBag.Language = Missions[i].Languages;
                        ViewBag.Weather = Missions[i].Weather;
                        ViewBag.Religion = Missions[i].DominateReligion;
                        ViewBag.FlagUrl = Missions[i].FlagUrl;
                        break;
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult MissionFAQ(QA question)
        {
            return View("Thanks");
        }
    }
}