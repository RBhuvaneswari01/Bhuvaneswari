using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Book
    {
        public Book()
        {

        }
        private int _bookid;

        public int BookId
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        private int _bookname;

        public int BookName
        {
            get { return _bookname; }
            set { _bookname = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _author;

        public int Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public Book(int _bookid, String _author, double _price, string _bookname)
        {
            this._bookid = BookId;
            this._author = Author;
            this._price = Price;
            this._bookname = BookName;
        }






        public void InsertData(int _bookid, string _author, double _price)
        {
            this._bookid = BookId;
            this._bookname = BookName;
            this._price = Price;

        }
        public void InsertData(string _bookname, int _bookid, string _author, double _price)
        {
            this._bookid = BookId;
            this._author = Author;
            this._price = Price;
            this._bookname = BookName;
        }

        public virtual void InsertData(int _bookid, string _bookname)
        {
            this._bookid = BookId;
            this._bookname = BookName;
        }
    }
       
    

}
