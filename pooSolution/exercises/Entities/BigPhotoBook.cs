using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class BigPhotoBook
    {
        protected int NumPages {  get; set; }
        
        public BigPhotoBook()
        {
            NumPages = 64;
        }


        public int GetTotalPages()
        {
            return NumPages;
        }


    }
}
