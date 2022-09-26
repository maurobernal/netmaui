using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.DTO
{
    public class ListDTO
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ItemDTO> results { get; set; }
    }

}
