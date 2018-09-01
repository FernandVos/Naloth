﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Naloth.DAL.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        
        
    }
}
