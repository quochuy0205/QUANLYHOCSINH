using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public  class USERS
    {
        QUANLYHOCSINHEntities db;
        public USERS()  
        {
            db = new QUANLYHOCSINHEntities();
        }
        public tb_User getItem(string username)
        {
            return db.tb_User.FirstOrDefault(x=>x.USERNAME== username);
        }
        public int Login(string username, string pass)
        {
            var us = db.tb_User.FirstOrDefault(x=>x.USERNAME==username && x.PASS==pass);
            if (us != null)
                return 1;
            else
                return 0;
        }
    }
}
