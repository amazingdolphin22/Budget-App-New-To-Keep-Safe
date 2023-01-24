using Coupons.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Coupons.Processes
{
    public static class ParseCouponDataToJSON
    {
        public static decimal totalDiscounts = 0; //used to SUM up the deals
        public const int twoDecimalPlaces = 2;
        public static List<CouponModel> PerformParse(string result)
        {
            //Serialize the result
            JavaScriptSerializer js = new JavaScriptSerializer();
            var obj = js.Deserialize<dynamic>(result);

            //Create CouponModel as a list
            List<CouponModel> coupon = new List<CouponModel>();

            totalDiscounts = 0; //zero this out so it is summed afresh each time this routine is called, saving a new
                                // fresh totalDiscounts summation.
             //use this constant value below to round off Decimal number to 2 places.

            //Loop through the obj to get the data from the API
            //See documentation for JSON example -> https://discountapi.com/apidocs
            foreach (var c in obj["deals"])
            {
                //Sum up the deals.
                totalDiscounts += c["deal"]["discount_amount"];
                totalDiscounts = Math.Round(totalDiscounts, twoDecimalPlaces);

                //Add results to the class
                coupon.Add(new CouponModel
                {
                    Title = c["deal"]["title"].ToString(),
                    CouponURL = c["deal"]["url"].ToString(),
                    Price = c["deal"]["price"].ToString(),
                    Value = c["deal"]["value"].ToString(),
                    DiscountAmt = Math.Round(c["deal"]["discount_amount"], twoDecimalPlaces).ToString(),
                    DiscountPct = Math.Round(c["deal"]["discount_percentage"], twoDecimalPlaces).ToString(),
                    Category = c["deal"]["category_name"].ToString(),
                    ImageURL = c["deal"]["image_url"].ToString()
                });
                //totalDiscounts = coupon.
            }

            //return the list
            return coupon;
        }
    }
}
