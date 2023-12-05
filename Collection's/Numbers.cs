using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_s
{
    public class Numbers
    {
        public int Id {  get; set; }    
        public string Name { get; set; }
        public Numbers(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
