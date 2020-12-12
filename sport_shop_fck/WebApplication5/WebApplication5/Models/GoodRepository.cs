using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class GoodRepository : IGoodRepository
    {
        private readonly AppDbContext _appDbContext;
        public GoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Good> AllGoods
        {
            get
            {
                return _appDbContext.Goods.Include(c => c.Category);
            }
        }

        public IEnumerable<Good> GoodsOfTheWeek
        {

            get
            {
                return _appDbContext.Goods.Include(c => c.Category).Where(p => p.IsGoodOfTheWeek);
            }
        }

        public Good GetGoodById(int goodId)
        {
            return _appDbContext.Goods.FirstOrDefault(p => p.GoodId == goodId);
        }
    }
}
