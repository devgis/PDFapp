using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFApp.Entities
{
    public class Page
    {
        public string PAGEID
        {
            get;
            set;
        }
        public string BOOKID
        {
            get;
            set;
        }
        public string FILENAME
        {
            get;
            set;
        }
        public int PAGEINDEX
        {
            get;
            set;
        }
        public string REMARKS
        {
            get;
            set;
        }
    }
}
