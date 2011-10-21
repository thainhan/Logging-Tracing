using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LogTrace
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string nhom()
        {
            return "Lai Dai Loc - 093535\nThai Duc Thanh Nhan - 093553\nCung cap thong tin bai hat";
        }

    }
}
