using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kædet_list_Datastruktur
{
    public class Element
    {
        public object Data { get; set; }
        public Element? Next { get; set; }

        public Element(object data, Element? next = null) 
        {
            Data = data;     
            Next = next;   
        }
    }
}
