using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    // TODO: Genel değil de entity'ye özgü metot tanımlanması gerekirse burada doldurulacak.
    public class EfCargoCustomerDal : GenericRepository<CargoCustomer>,ICargoCustomerDal
    {
        public EfCargoCustomerDal(CargoContext context) : base(context)
        {
            
        }
    }
}
