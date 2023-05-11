using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;//71
public class ListBankaHesapDtoSin : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }

    public BankaHesapTuru HesapTuru { get; set; }
    public string HesapTuruAdi { get; set; }

    public string HesapNo { get; set; }
    public string IbanNo { get; set; }


    public string BankaAdi { get; set; }


    public string BankaSubeAdi { get; set; }


    public string OzelKod1Adi { get; set; }


    public string OzelKod2adi { get; set; }


    public string SubeAdi { get; set; }//hoca burayı eklemdı ebn ekledim

    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    public decimal BorcBakiye => Borc - Alacak > 0 ? Borc - Alacak : 0;
    public decimal AlacakBakiye => Alacak - Borc > 0 ? Alacak - Borc : 0;

    public string Aciklama { get; set; }




}
