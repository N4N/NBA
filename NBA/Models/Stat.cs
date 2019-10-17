using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NBA.Models
{
    public class Stat
    {
        public int statId { get; set; }
        public int year { get; set; }
        public string pos { get; set; }
        public int age { get; set; }
        public int team { get; set; }
        public int FG { get; set; }
        public int FGA { get; set; }
        public decimal FGApct {get;set;}
        public int playerId { get; set; }
        public virtual Player player { get; set; }
    }
}