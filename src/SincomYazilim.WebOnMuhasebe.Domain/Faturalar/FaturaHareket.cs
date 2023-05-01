﻿

namespace SincomYazilim.WebOnMuhasebe.Faturalar;

public class FaturaHareket:FullAuditedEntity<Guid>// daha kısıtlı ozellıklerı var
{// video 24
    public Guid FaturaId { get; set; }
    public  FaturaHareketTuru HareketTuru { get; set; }
    public  Guid? StokId { get; set; }
    public  Guid? HizmetId { get; set; }
    public  Guid? MasrafId { get; set; }
    public  Guid? DepoId { get; set; }
    public  decimal Miktar { get; set; }
    public  decimal BirimFiyat { get; set; }
    public  decimal BrutTutar { get; set; }
    public  decimal IndirimTutar { get; set; }   
    public  int KdvOrani { get; set; }   
    public  decimal KdvHaricTutar { get; set; }
    public  decimal KdvTutar { get; set; }  
 
    public  decimal NetTutar { get; set; }
    public  string Aciklama { get; set; }


    public Stok Stok { get; set; }// video 40
    public Fatura Fatura { get; set; }// video 40
    public Masraf Masraf { get; set; }// video 40
    public Hizmet Hizmet { get; set; }// video 40
    public Depo Depo { get; set; }// video 40

}
