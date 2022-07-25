using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    [Table("quentinhas")]
    public class Quentinha
    {
        [Column("id")]
        private int id;

        [MaxLength(128)]
        private string description;

        private double price;

        public Quentinha(){}
        public Quentinha(string description, double price) {
            this.description = description;
            this.price = price;
        }

        public int Id { get; set; }
        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
    }
}