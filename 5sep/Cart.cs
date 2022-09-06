using System;
		public int Customerid
		{
			get { return _customerid; }
			set { _customerid = value; }
		}
		private  int _bookingid;

		public  int  Bookingid
		{
			get { return _bookingid; }
			set { _bookingid = value; }
		}
        
           List<Books> mybooks  =new List<Books>		

        public void AddToCart(Book b)
        {
            BookCount++;
            mybooks.Add(b);
        }
        public void Display()
        {
            foreach (var item in mybook)
            {
                Console.WriteLine("Book Id : \nBook Name :\nPrice : \n");
            }
            Console.WriteLine("Number of Books in the Cart : " + BookCount);
        
        }

    }
}
