using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Perpustakaan.Models
{
    public class Category
    {
        public int Id { get;set; }

        [Required]
        [Display(Name ="Nama Kategori")]
        public string NamaCategory { get;set; }

        // akan terbentuk referensi FK pada table Category\
        // untuk FK nya ada di model Books
        public List<Book> Books { get;set; }
    }
}
