namespace anash_prakt1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Motorbike
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Brand { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Price { get; set; }

        public int? Horsepower { get; set; }

        public int? Mileage { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
    }
}
