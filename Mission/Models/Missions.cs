using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mission.Models
{
    public class Missions
    {
        public string Name { get; set; }
        public string President { get; set; }
        public string Address { get; set; }
        public string Languages { get; set; }
        public string Weather { get; set; }
        public string DominateReligion { get; set; }
        public string FlagUrl { get; set; }

        public Missions()
        {

        }

        public Missions(string name, string president, string address, string languages, string weather, string religion, string flagUrl)
        {
            this.Name = name;
            this.President = president;
            this.Address = address;
            this.Languages = languages;
            this.Weather = weather;
            this.DominateReligion = religion;
            this.FlagUrl = flagUrl;
        }
    }
}