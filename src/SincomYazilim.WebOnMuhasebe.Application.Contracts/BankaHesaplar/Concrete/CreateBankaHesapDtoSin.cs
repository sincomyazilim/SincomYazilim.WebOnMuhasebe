using System;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;//71
public class CreateBankaHesapDtoSin : IEntityDto
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public BankaHesapTuru? HesapTuru { get; set; } = BankaHesapTuru.VadesizMevduatHesabi;
    public string HesapNo { get; set; }
    public string IbanNo { get; set; }
    public Guid? BankaSubeId { get; set; }//"00000000-0000-0000-000000000000" var sayılan defaul halı
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid? SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
