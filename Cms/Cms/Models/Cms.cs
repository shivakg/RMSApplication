using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cmsd.Models
{
    public class Cms
    {
        
        public int Id
        {
            get;
            set;
        }

        public DateTime PayDate
        {
            get;
            set;
        }
        public int  VoucherNo
        {
            get;
            set;
        }
        public string ChequeNo
        {
            get;
            set;
        }
        public int CustomerNo
        {
            get;
            set;
        }
        public char CustomerType
        {
            get;
            set;
        }
        public int AccountNo
        {
            get;
            set;
        }
        public char AccountName
        {
            get;
            set;
        }
        public char PayMode
        {
            get;
            set;
        }
        public decimal PayAmount
        {
            get;
            set;
        }


    }


public class CmsDBContext : DbContext 
{
    public DbSet<Cms> Cmss { get; set; }
}
}