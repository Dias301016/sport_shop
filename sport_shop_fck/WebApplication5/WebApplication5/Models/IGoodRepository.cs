using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public interface IGoodRepository
    {
        IEnumerable<Good> AllGoods { get; }

        IEnumerable<Good> GoodsOfTheWeek { get; }

        Good GetGoodById(int goodId);
    }
}
