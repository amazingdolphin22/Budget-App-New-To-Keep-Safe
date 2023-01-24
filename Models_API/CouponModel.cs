using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public class CouponModel
    {
        public string Title { get; set; }
        public string CouponURL { get; set; }
        public string Price { get; set; }
        public string Value { get; set; }
        public string DiscountAmt { get; set; }
        public string DiscountPct { get; set; }
        public string Category { get; set; }
        public string ImageURL { get; set; }

        public CouponModel()
        {
            //any initialization that needs to take place when this class is being instantiated.
        }
    }
}
