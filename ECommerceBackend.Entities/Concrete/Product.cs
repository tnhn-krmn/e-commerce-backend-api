using ECommerceBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public string Color { get; set; }
        public string? Size { get; set; }
        public int Star { get; set; }
        public int CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public int BrandId { get; set; }
        public string Sku { get; set; }
        public string? CommentId { get; set; }
    }
}
