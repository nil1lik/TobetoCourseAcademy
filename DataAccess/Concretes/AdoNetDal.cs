using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetDal : IEntities
    {
        public void Add(IEntities entity,string name)
        {
            Console.WriteLine("Ado.net kullanılarak " + name + "veritabanına eklendi");
        }
    }
}
