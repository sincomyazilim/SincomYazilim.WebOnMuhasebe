using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Cariler.Concrete;//75
public class SelectCariDtoSin : EntityDto<Guid>, IOzelKodSin
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string VergiDairesi { get; set; }
    public string VergiNo { get; set; }
    public string TcNo { get; set; }
    public string Telefon { get; set; }
    public string Adres { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
