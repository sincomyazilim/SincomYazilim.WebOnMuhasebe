﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;//84
public class CreateFirmaParametreDtoSin : IEntityDto
{
    public Guid UserId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid DepoId { get; set; }
}
