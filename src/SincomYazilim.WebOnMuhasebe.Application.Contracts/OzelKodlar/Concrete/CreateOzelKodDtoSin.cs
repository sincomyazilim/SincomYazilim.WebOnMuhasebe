﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;//83
public class CreateOzelKodDtoSin : IEntityDto
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru? KodTuru { get; set; }
    public KartTuru? KartTuru { get; set; }

    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
