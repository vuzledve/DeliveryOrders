using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrders_3.Models
{
    public class CreateOrderViewModel
    {
        

        [Required]
        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }
        [Required]
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }

        [Required]
        [Display(Name = "Город получателя")]
        public string RecipientCity { get; set; }

        [Required]
        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }

        [Required]
        [Display(Name = "Вес груза")]
        public decimal CargoWeight { get; set; }

        //[Required]
        //[Display(Name = "Дата забора груза")]
        //public DateTime DatePickup { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата забора груза")]

        public DateTime DatePickup { get; set; } = DateTime.Now;



    }
}
