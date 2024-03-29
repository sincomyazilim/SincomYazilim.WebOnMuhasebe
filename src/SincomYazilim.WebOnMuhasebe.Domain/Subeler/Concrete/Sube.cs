﻿using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;
using SincomYazilim.WebOnMuhasebe.Depolar.Concrete;
using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Subeler.Concrete;

public class Sube : FullAuditedAggregateRoot<Guid>
{// video 23
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public ICollection<BankaHesap> BankaHesaplar { get; set; }// video 27
    public ICollection<Depo> Depolar { get; set; }// video 32
    public ICollection<Fatura> Faturalar { get; set; }// video 33
    public ICollection<Kasa> Kasalar { get; set; }// video 35
    public ICollection<Makbuz> Makbuzlar { get; set; }// video 36
    public ICollection<FirmaParemetre> FirmaParemetreler { get; set; }// video 37
}
