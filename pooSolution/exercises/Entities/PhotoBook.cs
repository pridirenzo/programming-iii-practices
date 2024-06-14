using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class PhotoBook
    {

        protected int NumPages { get; set; }


        // constructor
        public PhotoBook()
        {
            NumPages = 16;
        }

        // constructor adicional para personalizar
        public PhotoBook(int pages)
        {
            NumPages = pages; 
        }




        public int GetTotalPages()
        {
            return NumPages;
        }





    }
}
