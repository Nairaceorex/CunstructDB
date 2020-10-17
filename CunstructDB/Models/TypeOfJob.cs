using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructDB.Models
{
    public class TypeOfJob
    {
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "ID_Материал1")]
        public DbSet<Material> Material1ID { get; set; }
        [Display(Name = "ID_Материал2")]
        public DbSet<Material> Material2ID { get; set; }
        [Display(Name = "ID_Материал3")]
        public DbSet<Material> Material3ID { get; set; }
    }
}
