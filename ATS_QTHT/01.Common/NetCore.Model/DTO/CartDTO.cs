using System;
using System.Collections.Generic;

namespace NetCore.Models.DTO
{
    public class CartDTO
    {
        public Guid id;
        public Guid customerId;
        public string phone;
        public string name;
        public decimal subTotalNetAmount;
        public decimal subTotalGrossAmount;
        public decimal totalNetAmount;
        public decimal totalGrossAmount;
        public string note;
        public decimal extraChargeAmount;
        public List<CartItemDTO> cartItems;
    }

    public class CartItemDTO
    {
        public Guid id;
        public Guid productMenuId;
        public Guid productMenuComboId;
        public Guid productId;
        public string avatar;
        public string note;
        public string productName;
        public string description;
        public string shortDescription;
        public decimal basePrice;
        public decimal priceOverride;
        public decimal cartItem;
        public decimal totalPriceGrossAmount;
        public decimal totalPriceNetAmount;
        public int version;
        public decimal quantity;
    }
}