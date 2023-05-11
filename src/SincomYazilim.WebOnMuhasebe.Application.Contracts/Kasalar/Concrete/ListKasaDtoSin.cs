using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;//80
public class ListKasaDtoSin : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string OzelKod1Adi { get; set; }
    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    public decimal BorcBakiye => Borc - Alacak > 0 ? Borc - Alacak : 0;
    public decimal AlacakBakiye => Alacak - Borc > 0 ? Alacak - Borc : 0;
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }

}
