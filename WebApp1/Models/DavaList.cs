﻿using System;
using System.Collections.Generic;

namespace WebApp1.Models
{
    public partial class DavaList
    {
        public int DavaKayitNo { get; set; }
        public string EsasNo { get; set; }
        public string DefterSiraNo { get; set; }
        public string YargitayDosyaNo { get; set; }
        public DateTime? DavaTarihi { get; set; }
        public int? DavaTuruKayitNo { get; set; }
        public string DavaKonusu { get; set; }
        public bool? Lehte { get; set; }
        public bool? SonucTahmini { get; set; }
        public string Mahkemesi { get; set; }
        public double? DavaTutari { get; set; }
        public double? IslahDegeri { get; set; }
        public int? ParaBirimiKayitNo { get; set; }
        public string Davaci { get; set; }
        public string Davali { get; set; }
        public string DigerDavacilar { get; set; }
        public string DigerDavalilar { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? DegistirilmeTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public string DegistirenKisi { get; set; }
        public int? DavaFormTipi { get; set; }
        public int? TopluDavaKayitNo { get; set; }
        public bool? TemyizEdildi { get; set; }
        public string DavaTuruTanim { get; set; }
        public string ParaBirimiKodu { get; set; }
        public string KararNo { get; set; }
        public DateTime? KararTarihi { get; set; }
        public bool? KararSonucu { get; set; }
        public string KararOzeti { get; set; }
        public bool? TemyizEdenPetkim { get; set; }
        public DateTime? TemyizTarihi { get; set; }
        public bool? TemyizSonucu { get; set; }
        public string TemyizAciklamasi { get; set; }
        public DateTime? SonucTarihi { get; set; }
        public string KaldirmaNo { get; set; }
        public bool? DavaSonucu { get; set; }
        public string IcraSafhasi { get; set; }
    }
}
