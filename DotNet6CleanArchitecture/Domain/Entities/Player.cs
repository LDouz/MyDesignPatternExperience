using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Player: BaseEntity<string>
    {
        public string UserName { get; set; }
        public int Trophy { get; set; }

    }
}
