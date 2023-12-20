using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatERS.Model
{
    public class Block
    {
        public Guid Id { get; set; }

        public double num { get; set; }
        public Guid? PreviousBlockId { get; set; }

        public Podatak Vrednost { get; set; }

        public DateTime Datum { get; set; }

        public Block(Podatak vrednost)
        {
            Id = Guid.NewGuid();
            Vrednost = vrednost;
            num = 0.00001;
            PreviousBlockId = null;
        }
    }
}
