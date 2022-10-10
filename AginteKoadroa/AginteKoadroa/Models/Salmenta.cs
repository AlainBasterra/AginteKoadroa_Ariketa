using System.ComponentModel.DataAnnotations;
using System;

namespace AginteKoadroa.Models
{
    public class Salmenta
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Zenbatekoa { get; set; }
        public string BezeroaId { get; set; }
        public virtual Bezeroa Bezeroa { get; set; } // 1-1
    }
}