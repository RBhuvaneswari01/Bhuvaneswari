using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library
{
    public class Borrower
    {
        [Key]
        [Required]
        public int borrowerid { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string borr_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public virtual ICollection<Loan> loans { get; set; }

    }
    public class Loan
    {
        [Key]
        [Required]
        public int LoanID { get; set; }
        public string loantype { get; set; }
        public int amount { get; set; }
        public int duration { get; set; }
        public int rateofintrest { get; set; }


    }
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
        }

        public virtual DbSet<Borrower> BorrowerTable { get; set; }
        public virtual DbSet<Loan> LoanTable { get; set; }
       
    }


}
