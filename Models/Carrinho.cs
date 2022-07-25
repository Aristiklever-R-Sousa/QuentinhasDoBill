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

        private ICollection<ItemCarrinho>? itens;

        public Carrinho() { }
        public Carrinho(ItemCarrinho value)
        {
            this.itens.Add(value);
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public ICollection<ItemCarrinho> Itens
        {
            get { return itens; }
        }

        public void SetQuentinha(ItemCarrinho value)
        {
            itens.Add(value);
        }
    }
}
