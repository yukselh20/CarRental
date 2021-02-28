﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto :IDto
    {
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public short DailyPrice { get; set; }

    }
}
