﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;//73
public class CreateBankaSubeDtoSin : IEntityDto
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? BankaId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
