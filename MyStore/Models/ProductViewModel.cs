using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Views
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string CurrentCategory { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<string> Images { get; set; }
    }


    public class ProductAddViewModel
    {
        public int Id; 

        [Required(ErrorMessage = "Введіть назву  категорії"), Display(Name = "Назва")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введіть опис  категорії"), Display(Name = "Опис")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Введіть значення знижки"), Display(Name = "Знижка")]
        public decimal Discount { get; set; }

        [Required(ErrorMessage = "Введіть ціну товару"), Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Введіть кількість товару"), Display(Name = "Кількість")]
        public int Quantity { get; set; }

      
    }
}
