using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryOrders_3.Models
{
    public class DeliveryOrder
    {
        [Required]
        public Guid Id { get; set; } //номер заказа, он же его id

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
        [Column(TypeName = "decimal(18,2)")]
        public decimal CargoWeight { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата забора груза")]
        public DateTime DatePickup { get; set; } = DateTime.Now;

    }
}
