﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perpustakaan.Models
{
    public class DbInitializer
    {
        public static void Seed(PustakaDbContext context)
        {
            if (!context.Users.Any())
            {

                var users = new List<Users>
                {
                    new Users {Nama = "Administrator",
                        Status = true,
                        Role = "Admin",
                        Username = "Admin",
                        Password = "123"
                    },
                    new Users {Nama = "Junindar",
                        Status = true,
                        Role = "Staff",
                        Username = "jun",
                        Password = "123"
                    },
                    new Users {Nama = "Rian Ardana",
                        Status = true,
                        Role = "General",
                        Username = "rian",
                        Password = "123"
                    },
                };

                users.ForEach(a => context.Users.Add(a));
                context.SaveChanges();
            }


            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { NamaCategory = "Agama" },
                    new Category { NamaCategory = "Bahasa" },

                };
                categories.ForEach(a => context.Categories.Add(a));
                // Sintaks Detail ada pada lampiran project
                var cat1 = new Category
                {
                    NamaCategory = "Teknologi",
                    Books = new List<Book>()
                {
                        new Book { Judul = "XAMARIN ANDROID - Mudah Membangung Aplikasi Mobile",
                            Penulis ="Junindar",
                            Penerbit ="EBOOKUID",Deskripsi="",
                            Status=true,Gambar="xamarin-android.jpg" },
                        new Book { Judul = "XAMARIN.FORMS - Membangun Aplikasi Mobile Cross-Platform",
                            Penulis ="Junindar",Penerbit ="EBOOKUID",Deskripsi="",
                            Status =true,Gambar="xamarin-form.jpg" },
                        new Book { Judul = "VISUAL BASIC 2015 - Cara Cepat Membangun Aplikasi Interaktif",Penulis="Junindar",
                            Penerbit ="EBOOKUID",Deskripsi="",
                            Status =true,Gambar="vb-2015.jpg" },
                        new Book { Judul = "Membangun Aplikasi Point Of Sale (POS) Lebih Mudah Dan Cepat",
                            Penulis ="Junindar",Penerbit="EBOOKUID",Deskripsi="",
                            Status =true,Gambar="c-dapper.jpg" },
                        new Book { Judul = "Visual Studio LightSwitch Learning By Doing",Penulis="Junindar",
                            Penerbit ="EBOOKUID",Deskripsi="",
                            Status=true,Gambar="Ls1.jpg" },
                        new Book { Judul = "Will Code With LightSwitch",Penulis="Junindar",Penerbit="EBOOKUID",Deskripsi="",
                            Status=true,Gambar="Ls2.jpg" },
                        new Book { Judul = "Visual Studio LightSwitch - HTML Client",Penulis="Junindar",Penerbit="EBOOKUID",
                            Deskripsi ="",
                            Status=true,Gambar="Ls3.jpg" },
                        new Book { Judul = "Visual Studio LightSwitch - Edisi Bundling",Penulis="Junindar",
                            Penerbit ="EBOOKUID",Deskripsi="",
                            Status=true,Gambar="Ls4.jpg" }
                }
                };

                var cat2 = new Category()
                {
                    NamaCategory = "Sosial",
                    Books = new List<Book>()
                {
                     new Book { Judul = "Raga Kayu Jiwa Manusia",
                            Penulis ="Sarah Anais Andrieu",
                            Penerbit ="Kepustakaan Populer Gramedia",
                            Deskripsi =@"Wayang golek purwa kini sangat populer di Tanah Sunda, Jawa Barat, Indonesia. 
                            Praktik yang kompleks dalam dimensi sosial dan artistiknya ini diproklamasikan oleh UNESCO 
                            sebagai Karya Agung Warisan Budaya Lisan dan Takbenda Manusia yang merupakan bagian dari pencalonan umum “Wayang Indonesia”, pada tahun 2003.
                            Buku ini menguraikan dan membahas jalur yang dilalui suatu warisan keluarga hingga menjadi suatu warisan bersama, nasional, dan dunia. 
                            Analisis antropologi ini memadukan kajian politik budaya di tingkat-tingkat tersebut dengan 
                            kajian konsep-konsep global dan studi mendalam mengenai tahapan pencalonan pertama Indonesia pada warisan takbenda UNESCO, 
                            serta realitas etnografi wayang golek. Dari proses warisanisasi resmi (yaitu proses menjadi warisan) itu muncul banyak kepentingan, 
                            seperti pembentukan identitas dan budaya nasional, atau pula spektakularisasi dan folklorisasi wayang golek, perubahannya menjadi sebuah produk ekspor, suatu sumber daya untuk digerakkan dan didayagunakan.",
                            Status=true,Gambar="sosial1.jpg" },
                      new Book { Judul = "Generasi Phi",
                            Penulis ="Dr.Muhammad Faizal",
                            Penerbit ="Republika Penerbit",
                            Deskripsi ="",
                            Status=true,Gambar="sosial2.jpg" }
                }
                };

                context.Categories.Add(cat1);
                context.Categories.Add(cat2);


                context.SaveChanges();
            }

            if (!context.Books.Any())
            {
                var _books = new List<Book>()
                            {
                                    new Book { Judul = "XAMARIN ANDROID - Mudah Membangung Aplikasi Mobile",
                                        Penulis ="Junindar",
                                        Penerbit ="EBOOKUID",Deskripsi="",
                                        Status=true,Gambar="/images/xamarin-android.jpg" },
                                    new Book { Judul = "XAMARIN.FORMS - Membangun Aplikasi Mobile Cross-Platform",
                                        Penulis ="Junindar",Penerbit ="EBOOKUID",Deskripsi="",
                                        Status =true,Gambar="/images/xamarin-form.jpg" },
                                    new Book { Judul = "VISUAL BASIC 2015 - Cara Cepat Membangun Aplikasi Interaktif",Penulis="Junindar",
                                        Penerbit ="EBOOKUID",Deskripsi="",
                                        Status =true,Gambar="/images/vb-2015.jpg" },
                                    new Book { Judul = "Membangun Aplikasi Point Of Sale (POS) Lebih Mudah Dan Cepat",
                                        Penulis ="Junindar",Penerbit="EBOOKUID",Deskripsi="",
                                        Status =true,Gambar="/images/c-dapper.jpg" },
                                    new Book { Judul = "Visual Studio LightSwitch Learning By Doing",Penulis="Junindar",
                                        Penerbit ="EBOOKUID",Deskripsi="",
                                        Status=true,Gambar="/images/Ls1.jpg" },
                                    new Book { Judul = "Will Code With LightSwitch",Penulis="Junindar",Penerbit="EBOOKUID",Deskripsi="",
                                        Status=true,Gambar="/images/Ls2.jpg" },
                                    new Book { Judul = "Visual Studio LightSwitch - HTML Client",Penulis="Junindar",Penerbit="EBOOKUID",
                                        Deskripsi ="",
                                        Status=true,Gambar="/images/Ls3.jpg" },
                                    new Book { Judul = "Visual Studio LightSwitch - Edisi Bundling",Penulis="Junindar",
                                        Penerbit ="EBOOKUID",Deskripsi="",
                                        Status=true,Gambar="/images/Ls4.jpg" },
                                new Book { Judul = "Raga Kayu Jiwa Manusia",
                                    Penulis ="Sarah Anais Andrieu",
                                    Penerbit ="Kepustakaan Populer Gramedia",
                                    Deskripsi =@"Wayang golek purwa kini sangat populer di Tanah Sunda, Jawa Barat, Indonesia. 
                                        Praktik yang kompleks dalam dimensi sosial dan artistiknya ini diproklamasikan oleh UNESCO 
                                        sebagai Karya Agung Warisan Budaya Lisan dan Takbenda Manusia yang merupakan bagian dari pencalonan umum “Wayang Indonesia”, pada tahun 2003.
                                        Buku ini menguraikan dan membahas jalur yang dilalui suatu warisan keluarga hingga menjadi suatu warisan bersama, nasional, dan dunia. 
                                        Analisis antropologi ini memadukan kajian politik budaya di tingkat-tingkat tersebut dengan 
                                        kajian konsep-konsep global dan studi mendalam mengenai tahapan pencalonan pertama Indonesia pada warisan takbenda UNESCO, 
                                        serta realitas etnografi wayang golek. Dari proses warisanisasi resmi (yaitu proses menjadi warisan) itu muncul banyak kepentingan, 
                                        seperti pembentukan identitas dan budaya nasional, atau pula spektakularisasi dan folklorisasi wayang golek, perubahannya menjadi sebuah produk ekspor, suatu sumber daya untuk digerakkan dan didayagunakan.",
                                    Status=true,Gambar="/images/sosial1.jpg" },
                                new Book { Judul = "Generasi Phi",
                                    Penulis ="Dr.Muhammad Faizal",
                                    Penerbit ="Republika Penerbit",
                                    Deskripsi ="",
                                    Status=true,Gambar="/images/sosial2.jpg" }

                            };
                context.AddRange(_books);
                context.SaveChanges();
            }


        }
    }
}
