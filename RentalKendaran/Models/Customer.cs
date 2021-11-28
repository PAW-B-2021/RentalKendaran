using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaran.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh Kosong")]
        public string NamaCustomer { get; set; }
        [MinLength(10, ErrorMessage = "NO hp min 16 angka")]
        [MaxLength(13, ErrorMessage = "NO hp max 16 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh Kosong")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "NO hp min 10 angka")]
        [MaxLength(13, ErrorMessage = "NO hp max 13 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "hanya boleh diisi oleh angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
