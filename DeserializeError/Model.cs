namespace DeserializeError
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;

    public class Model
    {
        public class GetInvoiceDto
        {
            public int InvoiceId { get; set; }
        
            public string InvoiceNumber { get; set; }
        
            public OrderStatusDto InvoiceIssuedStatus { get; set; }
            public InvoiceStatusDto InvoiceStatus { get; set; }
        
            public GetOrderByIdDto Order { get; set; }
            public BusinessUser BusinessDetails { get; set; }
            public AddressDto BusinessAddress { get; set; }
        }
        
        public class BusinessUser
        {
            [JsonProperty("business_name")]
            public string Name { get; set; }
        
            [JsonProperty("business_gstin")]
            public string Gstin { get; set; }
        
            [JsonProperty("business_cin")]
            public string Cin { get; set; }
        
            [JsonProperty("business_tan")]
            public string Tan { get; set; }
        
            [JsonProperty("business_pan")]
            public string Pan { get; set; }
        
            [JsonProperty("business_phone")]
            public string Phone { get; set; }
        
            [JsonProperty("business_mobile")]
            public string Mobile { get; set; }
        
            [JsonProperty("business_email")]
            public string Email { get; set; }
        }
        
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
        public enum InvoiceStatusDto : Int16
        {
            [EnumMember(Value = "Draft")]
            Draft = 0,
            [EnumMember(Value = "Issued")]
            Issued = 10,
        
            [EnumMember(Value = "Pending")]
            Pending = 20,
            [EnumMember(Value = "Paid")]
            Paid = 30,
            [EnumMember(Value = "Partial")]
            Partial = 40,
            [EnumMember(Value = "Overdue")]
            Overdue = 50,
            [EnumMember(Value = "Cancelled")]
            Cancelled = 60,
        }
    }
}