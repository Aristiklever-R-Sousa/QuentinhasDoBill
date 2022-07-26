﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuentinhasDoBill.Models
{
    [Table("itens_pedido")]
    public class ItemPedido
    {
        [Column("id")]
        private int id;

        private Quentinha quentinha;

        private int quantity;
        
        public ItemPedido() { }
        public ItemPedido(Quentinha quentinha)
        {
            this.quentinha = quentinha;
        }
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public Quentinha Quentinha
        {
            get { return quentinha; }
            set { quentinha = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
