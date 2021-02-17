using System;
using Core.Entities;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDTO
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public int DailyPrice { get; set; }
    }
}
