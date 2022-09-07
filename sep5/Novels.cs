using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Novels : Book
    {
        int _numberofp;
		

		public int  NumberofPages 
		{
			get { return _numberofp; }
			set { _numberofp = value; }
		}
        public void InsertData(int _bookid, string _author, double _price)
        {
            this._bookid = BookId;
            this._bookname = BookName;
            this._price = Price;
            this._numberofp = NumberofPages;

        }
        public void InsertData(int _bookid, string _author, double _price)
        {
            this._bookid = BookId;
            this._bookname = BookName;
            this._price = Price;

        }
}
