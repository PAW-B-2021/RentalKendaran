using System;
using System.Collections.Generic;

#nullable disable

namespace RentalKendaran.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }

        public int IdKondisi { get; set; }
        public string NamaKondisi { get; set; }

        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
