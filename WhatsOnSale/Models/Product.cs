using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//kroger item: "name"=>"30 Inch Round Kiwi Casual Laces", "buyable"=>true, "catentryId"=>nil, "fullImageAltDescription"=>nil, "imageUrl"=>"https://www.kroger.com/product/images/medium/front/0003160066116", "regularPrice"=>"1.69", "salePrice"=>"", "offerDescription"=>nil, "offerQuantity"=>nil, "offerPrice"=>"", "offerType"=>nil, "offerEndDate"=>nil, "sizing"=>"2 Pair", "thumbnail"=>nil, "wcsProductId"=>nil, "upc"=>"0003160066116", "soldBy"=>"UNIT", "orderBy"=>"UNIT", "serviceCenter"=>nil, "imageUrls"=>["https://www.kroger.com/product/images/medium/front/0003160066116"], "thumbnails"=>nil, "priceSizingDescription"=>"2 Pair", "specialInstruction"=>nil, "currentPrice"=>"1.69", "currentPriceIsYellowTag"=>false}
namespace WhatsOnSale
{
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public int upc { get; set; }

    }
}