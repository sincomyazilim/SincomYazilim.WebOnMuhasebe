using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.FaturaHareketler.Concrete;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;//78
public class UpdateFaturaDtoSin : IEntityDto
{
    public string FaturaNO { get; set; }
    public DateTime Tarih { get; set; }
    public Guid CariId { get; set; }
    public decimal BrutTutar { get; set; }
    public decimal IndirimTutar { get; set; }
    public decimal KdvHaricTutar { get; set; }
    public decimal KdvTutar { get; set; }
    public decimal NetTutar { get; set; }
    public int HareketSayisi { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public IList<FaturaHareketDtoSin> FaturaHareketler { get; set; }
}
