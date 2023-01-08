﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace WebProje1.Models
{
    public class signUpVM
    {
        [Required(ErrorMessage = "İsminizi Giriniz")]
        public string kullaniciAdi { get; set; }

        [Required(ErrorMessage = "Soyadinizi Giriniz")]
        public string kullaniciSoyadi { get; set; }

        [Required(ErrorMessage = "Telefon Numaranızı Giriniz")]
        [Phone(ErrorMessage = "Lütfen telefon numarasını doğru giriniz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Doğum Gününüzü Giriniz")]
        [DataType(DataType.Date)]
        [Column(TypeName ="Date")]
        public DateTime kullaniciDogum { get; set; }


        [Required(ErrorMessage = "Email Adresinizi Giriniz")]
        [StringLength(30)]
        public string kullaniciEmail { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz")]
        [MinLength(6, ErrorMessage = "Şifre uzunluğu 6 karakterden uzun olmalı")]
        [MaxLength(20, ErrorMessage = "Şifre uzunluğu 20 karakterden uzun olmamalı")]
        public string KullaniciSifre { get; set; }

        [Required(ErrorMessage = "Şifre Kontrol Giriniz")]
        [Compare(nameof(KullaniciSifre),ErrorMessage ="Şifreyi kontrol edip tekrar giriniz ")]
        public string KullaniciSifreKontrol { get; set; }
    }
}
