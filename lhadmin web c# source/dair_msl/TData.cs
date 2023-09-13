using System;

namespace cubemesweb.dair_msl
{
    public class TData
    {
        public string tag = "";
        public DateTime dt;
        public double v = 0;
        public Boolean isInit = false;

        public TData(string atag, DateTime adt)
        {
            tag = atag;
            dt = adt;
        }
    }
}