using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class BookCategory
    {
		private int _catid;

		public int CatId
		{
			get { return _catid; }
			set { _catid = value; }
		}
		private string _catname;

		public string CatName
		{
			get { return _catname; }
			set { _catname = value; }
		}
		private string _discription;

		public string Discription
		{
			get { return _discription; }
			set { _discription = value; }
		}
        public BookCategory(int _catid, String _discription, string _catname)
        {
            this._catid = CatId;
            this._discription = Discription;
            this._catname = CatName;
        }



    }
}