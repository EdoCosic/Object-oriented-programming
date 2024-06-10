using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210181
{
    public class NastavaIB210181
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB210181 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB210181 Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }


        public override string ToString()
        {
            return $"{Predmet.Naziv} :: {Dan} :: {Vrijeme}";
        }
    }
}
