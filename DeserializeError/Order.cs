namespace DeserializeError
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    public class GetOrderByIdDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal TotalDiscount { get; set; }

        public AddressDto BillingAddress { get; set; }
        
        public AddressDto ShippingAddress { get; set; }
        
        public List<OrderItemDto> Items { get; set; }
        
        public List<OrderPaymentSplitDto> PaymentSplits { get; set; }
        
        public OrderStatusDto OrderStatus { get; set; }
        
        public List<OrderStatusHistoryDto> OrderStatusHistories { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CustomerName { get; set; }
        public OrderMetadata Metadata { get; set; }
        public string CustomerPhone { get; set; }
        
        public List<OrderDiscounts> DiscountSplits { get; set; }
        
        [JsonIgnore]
        public List<OrderDiscountsSplit> DiscountSplitsDb { get; set; }
    }
    
    public class OrderDiscountsSplit
    {
        public DiscountType DiscountType { get; set; }
        
        public decimal DiscountAmount { get; set; }
        
        public string CouponCode { get; set; }
        
        public string SellerId { get; set; }
    }
    
    public enum DiscountType
    {
        None = 0,
        TierPrice = 1,
        PartnerDiscount = 2,
        QuoteDiscount = 3,
        SellerCoupon = 4,
        SpecialDiscount = 5,
        LoanDiscount = 6,
        CreditAmount = 7,
        PazaToken = 8
    }
    public class OrderDiscounts
    {
        [Required]
        public DiscountTypeDto DiscountType { get; set; }
        
        [Range(0, Double.PositiveInfinity)]
        public decimal DiscountAmount { get; set; }
        
        public string CouponCode { get; set; }
        
        public string SellerId { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DiscountTypeDto
    {
        [EnumMember(Value ="None")]
        None = 0,
        [EnumMember(Value ="TierPrice")]
        TierPrice = 1,
        [EnumMember(Value ="PartnerDiscount")]
        PartnerDiscount = 2,
        [EnumMember(Value ="QuoteDiscount")]
        QuoteDiscount = 3,
        [EnumMember(Value ="SellerCoupon")]
        SellerCoupon = 4,
        [EnumMember(Value ="SpecialDiscount")]
        SpecialDiscount = 5,
        [EnumMember(Value ="LoanDiscount")]
        LoanDiscount = 6,
        [EnumMember(Value ="CreditAmount")]
        CreditAmount = 7,
        [EnumMember(Value ="PazaToken")]
        PazaToken = 8
    }

    public class OrderMetadata
    {
        public int QuoteId { get; set; }
        public decimal ShipmentFee { get; set; }
    }
    public class TaxDetailsDto
    {
        public decimal TotalTaxPaid { get; set; }
        
        public int TaxGroupId { get; set; }
        
        public string TaxGroupName{ get; set; }
        
        public List<TaxSplitDto> TaxSplits { get; set; }
    }

    public class AddressDto
    {
        public int Id { get; set; }
        
        [StringLength(150)]
        public string ApartmentNumber { get; set; }
        
        [StringLength(150)]
        public string Street { get; set; }
        
        [StringLength(150)]
        public string Locality { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string State { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        public string ISOCountryCode { get; set; }
        
        [Required]
        public string ZipCode { get; set; }
    }
    public class TaxSplitDto
    {
        public int TaxId { get; set; }
        
        public string TaxName { get; set; }
        
        public decimal TaxPercentage { get; set; }
        
        public decimal TaxAmount { get; set; }
        
        public decimal TaxAmountPaid { get; set; }
        public TaxTypeDto TaxType
        {
            get
            {
                if (this.TaxAmount > 0)
                    return TaxTypeDto.TaxAmount;
                else
                    return TaxTypeDto.TaxPercentage;
            }
            set
            {
                this.TaxType = value;
            }
        }
    }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaxTypeDto
    {
        [EnumMember(Value = "TaxAmount")]
        TaxAmount = 1,
        [EnumMember(Value = "TaxPercentage")]
        TaxPercentage = 2,
        [EnumMember(Value = "Both")]
        Both = 10
    }

    public class OrderItemDto
    {
        private ProductSnapshotDto _productSnapshot;
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        
        public string SkuId { get; set; }
        
        public string SellerId { get; set; }
        
        public decimal ActualPrice { get; set; }
        public decimal ActualPriceWithoutTax { get; set; }
        
        public decimal DiscountedPrice { get; set; }
        
        public decimal TotalDiscount { get; set; }
        
        public int Qty { get; set; }
        
        public decimal Tax { get; set; }
        
        public int? BundleId { get; set; }
        
        public int? ShipmentId { get; set; }
        
        public bool IsSelfPickup { get; set; }

        public ProductSnapshotDto ProductSnapshot { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public List<OrderItemStatusHistoryDto> OrderItemStatusHistories { get; set; }
        
        public OrderStatusDto OrderItemStatus { get; set; }
        
        public CreateSelfPickUpOptions SelfPickUpOptions { get; set; }
        
        public TaxDetailsDto TaxDetails { get; set; }
        
        public LoanDetailSnapShot LoanDetail { get; set; }
        
        public ShipmentDto Shipment { get; set; }
        public string SellerName { get; set; }
        public OrderItemMetadata Metadata { get; set; }
        public decimal ActualUnitPrice { get; set; }
    }
    
    public class CreateSelfPickUpOptions
    {
        public AddressDto Address { get; set; }
    }

    public class OrderItemMetadata
    {
        public QuoteUpdate QuoteSnapshot { get; set; }
        public bool IsSelfPickup { get; set; }
        
        public string DeliveryCode { get; set; }
        public LoanDetailSnapShot LoanDetailSnapShot { get; set; }
        public decimal ShipmentFeePerSeller { get; set; }
        
        public PartnerDiscountDetails PartnerDiscountDetails { get; set; }
    }
    
    public class PartnerDiscountDetails
    {
        public List<string> ContractIds { get; set; }
    }
    public class QuoteUpdate
    {
        public decimal UnitPrice { get; set; }
        
        public decimal TotalDiscountedPrice { get; set; }
    }
    public class LoanDetailSnapShot
    {
        public int LoanOptionId { get; set; }
        
        public int LoanTenureInMonths { get; set; }
        
        public decimal LoanAmountChosen { get; set; }
        
        public decimal InterestRatePerYear { get; set; }
        
        public string ProviderName { get; set; }
        public string ProviderId { get; set; }
        public decimal LoanProcessingFee { get; set; }
        public decimal PreOrderLoanAmount { get; set; }
        public string PreOrderLoanStatus { get; set; }
        public string PreOrderLoanAssetId { get; set; }
    }
    public class ShipmentDto
    {
        public int Id { get; set; }
        
        public string ProviderName { get; set; }
        
        public decimal ShipmentFee { get; set; }
        
        public DateTime ExpectedDeliveryDate { get; set; }
        public string TrackingCode { get; set; }
        public ShiprocketResponse ShiprocketResponse { get; set; }
    }
    
    public class ShiprocketResponse {
        public int pickup_location_added { get; set; } 
        public int order_created { get; set; } 
        public int awb_generated { get; set; } 
        public int label_generated { get; set; } 
        public int pickup_generated { get; set; } 
        public int manifest_generated { get; set; } 
        public string pickup_scheduled_date { get; set; } 
        public int order_id { get; set; } 
        public int shipment_id { get; set; } 
        public string awb_code { get; set; } 
        public int courier_company_id { get; set; } 
        public string courier_name { get; set; } 
        public AssignedDateTime assigned_date_time { get; set; } 
        public double applied_weight { get; set; } 
        public bool cod { get; set; } 
        public string label_url { get; set; } 
        public string manifest_url { get; set; } 
        public string routing_code { get; set; } 
        public string pickup_token_number { get; set; } 
    }
    
    public class AssignedDateTime    {
        public string date { get; set; } 
        public int timezone_type { get; set; } 
        public string timezone { get; set; } 

    }

   

    public class ProductSnapshotDto
    {
        public string ProductName { get; set; }
        
        public string ProductGroup { get; set; }
        
        public ProductTypeDto ProductType { get; set; }
        
        public List<string> Images { get; set; }
        
        public List<AttributeValueSnapshot> AttributeValues { get; set; }
        
        public Dictionary<string, decimal> DiscountSplit { get; set; }
        
        public BundleSnapshotDto BundleSnapshot { get; set; }
        public string ExternalId { get; set; }
    }
    
    public class AttributeValueSnapshot
    {
        public int AttributeId { get; set; }
        public int ValueId { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
    }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProductTypeDto
    {
        [EnumMember(Value ="Simple")]
        Simple = 0,
        [EnumMember(Value ="Configurable")]
        Configurable = 1,
        [EnumMember(Value ="Virtual")]
        Virtual = 2,
        [EnumMember(Value ="Bundle")]
        Bundle = 3,
    }
    
    

    public class OrderPaymentSplitDto
    {
        public int Id { get; set; }
        
        public PaymentModeDto PaymentMode { get; set; }
        
        public decimal Price { get; set; }
    }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]    
    public enum PaymentModeDto
    {
        [EnumMember(Value ="Cash")]
        Cash = 1,
        [EnumMember(Value ="Online")]
        Online = 2,
        [EnumMember(Value ="PazaWallet")]
        PazaWallet = 3,
    }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderStatusDto
    {
        [EnumMember(Value = "Created")]
        Created = 1,
        [EnumMember(Value = "PaymentSuccess")]
        PaymentSuccess = 2,
        [EnumMember(Value = "PaymentFail")]
        PaymentFail = 3,
        [EnumMember(Value = "AdminApprovalPending")]
        AdminApprovalPending = 5,
        [EnumMember(Value = "Shipping")]
        Shipping = 6,
        [EnumMember(Value = "ShippingCompleted")]
        ShippingCompleted = 7,
        [EnumMember(Value = "CancelRequested")]
        CancelRequested = 8,
        [EnumMember(Value = "CancelCompleted")]
        CancelCompleted = 9,
        [EnumMember(Value = "ReturnRequested")]
        ReturnRequested = 10,
        [EnumMember(Value = "ReturnCompleted")]
        ReturnCompleted = 11,
        [EnumMember(Value = "PartialCancelRequested")]
        PartialCancelRequested = 12,
        [EnumMember(Value = "PartialCancelCompleted")]
        PartialCancelCompleted = 13,
        [EnumMember(Value = "Completed")]
        Completed = 14,
        [EnumMember(Value = "PaymentOnDelivery")]
        PaymentOnDelivery = 15,
        [EnumMember(Value = "CancelAutoApproved")]
        CancelAutoApproved = 16,
        [EnumMember(Value = "PartialReturnRequested")]
        PartialReturnRequested = 17,
        [EnumMember(Value = "PartialReturnCompleted")]
        PartialReturnCompleted = 18,
        [EnumMember(Value = "CancelRejected")]
        CancelRejected = 19,
        [EnumMember(Value = "ReturnRejected")]
        ReturnRejected = 20,
        [EnumMember(Value = "PackageReadyForCollection")]
        PackageReadyForCollection = 21,
        [EnumMember(Value = "SellerProcessing")]
        SellerProcessing = 4,
        [EnumMember(Value = "Abandoned")]
        Abandoned = 100
    }
    
    public class OrderStatusHistoryDto
    {
        public int Id { get; set; }
        
        public int OrderId { get; set; }
        
        public OrderStatusDto OrderStatus { get; set; }
        
        public DateTime CreatedDateTime { get; set; }
    }
    
    public class OrderItemStatusHistoryDto
    {
        public int Id { get; set; }
        
        public int OrderId { get; set; }
        
        public OrderStatusDto OrderStatus { get; set; }
        
        public DateTime CreatedDateTime { get; set; }
    }
    
    public class BundleSnapshotDto
    {
        public string Name { get; set; }
        
        public int Id { get; set; }
        
        public string SellerId { get; set; }
        
        public string SkuId { get; set; }
    }
}