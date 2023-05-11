using System;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;//71
public class SelectBankaHesapDtoSin : EntityDto<Guid>, IOzelKodSin
{
    public string Kod { get; set; }
    public string Ad { get; set; }

    public BankaHesapTuru HesapTuru { get; set; }
    public string HesapTuruAdi { get; set; }

    public string HesapNo { get; set; }
    public string IbanNo { get; set; }

    public Guid BankaId { get; set; }
    public string BankaAdi { get; set; }

    public Guid BankaSubeId { get; set; }
    public string BankaSubeAdi { get; set; }

    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }

    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }

    public Guid SubeId { get; set; }
    public string SubeAdi { get; set; }//hoca burayı eklemdı ebn ekledim

    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
