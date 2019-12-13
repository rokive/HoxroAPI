using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ShoppingItem :Base
    {
        public long ShoppingId { get; set; }

        public virtual Shopping Shopping { get; set; }

        public long ItemId { get; set; }

        public virtual Item Item { get; set; }

    }
}
