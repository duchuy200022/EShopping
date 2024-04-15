using Dapper;
using Discount.Core.Entities;
using Discount.Core.Repositories;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Infrastructure.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly IConfiguration _configuration;
        public DiscountRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<Coupon> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public Task<Coupon> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var coupon = await connection
                .QueryFirstOrDefaultAsync<Coupon>("SELECT * FROM Coupon WHERE ProductName = @ProductName", new {ProductName = productName});
            if(coupon == null)
            {
                return new Coupon{ ProductName = "No Discount", Amount = 0, Description = "No Discount Available"};
            }
            return coupon;
        }

        public Task<Coupon> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
