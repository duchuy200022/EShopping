using Discount.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Core.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<Coupon> CreateDiscount(Coupon coupon);
        Task<Coupon> UpdateDiscount(Coupon coupon);
        Task<Coupon> DeleteDiscount(string productName);
    }
}
