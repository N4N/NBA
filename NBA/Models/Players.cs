using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NBA.Models
{
    public class Player
    {
        public int playerId { get; set; }
        public string PlayerName { get; set; }

        public int altura { get; set; }

        public int peso { get; set; }

        public virtual ICollection<Stat> Stats { get; set; }

    }
}