using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    [Table("carrinho")]
    public class Carrinho
    {
        [Column("id")]
        private int id;

        private ICollection<Quentinha>? quentinhas;

        public Carrinho() { }
        public Carrinho(Quentinha value)
        {
            this.quentinhas.Add(value);
        }

        public int Id {
            get { return id; }
            set { id = value; }
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
