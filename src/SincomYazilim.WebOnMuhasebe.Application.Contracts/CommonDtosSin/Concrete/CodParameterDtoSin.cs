using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
public class CodParameterDtoSin : IEntityDto, IDurumSin
{
    public bool Durum { get; set; }
}
