using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructDB.Models
{
    public class Order
    {
        public long ID { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Дата начала")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Дата оканчания")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Отметка завершения")]
        public string CompletionMark { get; set; }
        [Display(Name = "Об оплате")]
        public string AboutPayment { get; set; }
        [Display(Name = "ID_Заказчик")]
        public DbSet<Customer> CustomerID { get; set; }
        [Display(Name = "ID_Вид работы")]
        public DbSet<TypeOfJob> TypeOfJobID { get; set; }
        [Display(Name = "ID_Бригада")]
        public DbSet<Brigade> BrigadeID { get; set; }
        [Display(Name = "ID_Сотрудник")]
        public DbSet<Staff> StaffID { get; set; }
    }
}
