using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    public class Carrinho
    {
        [Column("id")]
        private int Id;

        [Required]
        private ICollection<Quentinha>? quentinhas;

        public Carrinho() { }
        public Carrinho(Quentinha value)
        {
            this.quentinhas.Add(value);
        }

        public ICollection<Quentinha> Quentinhas
        {
            get { return quentinhas; }
        }

        public void SetQuentinha(Quentinha value)
        {
            quentinhas.Add(value);
        }
    }
}
