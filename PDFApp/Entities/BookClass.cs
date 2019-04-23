using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFApp.Entities
{
    public class BookClass
    {
        public string CLASSID
        {
            get;
            set;
        }

        public string PARENTID
        {
            get;
            set;
        }

        public string CLASSNAME
        {
            get;
            set;
        }

        public int Level
        {
            get;
            set;
        }
    }
}
