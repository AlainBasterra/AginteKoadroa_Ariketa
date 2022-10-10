using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AginteKoadroa.Models
{
    public class Saltzailea
    {
        
 [Key] // Nahi du esan Nan klabe printzipala dela
        public string Id { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
        public virtual List<Bezeroa> Bezeroa { get; set; } //Saltzaile batek zerrenda da bat ahal du eduki bezeroena

    }
}