using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathSoftModelLib
{
    public class UIModelData<T>
    {
        public T Data { get; set; }
        public string remark { get; set; }
        public bool suc { get; set; }
        public int status { get; set; }
    }
}
