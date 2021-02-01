﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Modelyear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}