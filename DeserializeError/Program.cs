using System;

namespace DeserializeError
{
    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            #region st

            var str = @"{
    ""InvoiceId"": 214,
    ""InvoiceNumber"": ""INV-214"",
    ""InvoiceIssuedStatus"": ""PaymentSuccess"",
    ""InvoiceStatus"": ""Paid"",
    ""Order"": {
        ""Id"": 238,
        ""CustomerId"": ""***************"",
        ""TotalPrice"": 538,
        ""TotalDiscount"": 117,
        ""BillingAddress"": {
            ""Id"": 0,
            ""ApartmentNumber"": ""***************"",
            ""Street"": ""***************"",
            ""Locality"": ""*************** restaurant"",
            ""City"": ""***************"",
            ""State"": ""***************"",
            ""Country"": ""***************"",
            ""ISOCountryCode"": null,
            ""ZipCode"": ""***************""
        },
        ""ShippingAddress"": {
            ""Id"": 0,
            ""ApartmentNumber"": ""***************"",
            ""Street"": ""***************"",
            ""Locality"": ""*************** restaurant"",
            ""City"": ""***************"",
            ""State"": ""***************"",
            ""Country"": ""***************"",
            ""ISOCountryCode"": null,
            ""ZipCode"": ""***************""
        },
        ""Items"": [
            {
                ""Id"": 268,
                ""ProductId"": 4653,
                ""SkuId"": ""***************840050338308"",
                ""SellerId"": ""***************"",
                ""ActualPrice"": 195,
                ""ActualPriceWithoutTax"": 185.48,
                ""DiscountedPrice"": 156,
                ""TotalDiscount"": 39,
                ""Qty"": 1,
                ""Tax"": 0,
                ""BundleId"": null,
                ""ShipmentId"": 264,
                ""IsSelfPickup"": false,
                ""ProductSnapshot"": {
                    ""ProductName"": ""***************"",
                    ""ProductGroup"": null,
                    ""ProductType"": ""Configurable"",
                    ""Images"": [
                        ""G1 FV _Pink dark_thumbnail.jpg"",
                        ""G1 SV _Pink dark rani.jpg"",
                        ""G1 BV _Pink dark.jpg"",
                        ""G1 FV _BLUE DARK_thumbnail.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 FV _Black_thumbnail.jpg"",
                        ""G1 SV _Black.jpg"",
                        ""G1 BV _Black.jpg""
                    ],
                    ""AttributeValues"": [
                        {
                            ""AttributeId"": 85,
                            ""ValueId"": 227,
                            ""AttributeName"": ""Size"",
                            ""Value"": ""B36\\90""
                        },
                        {
                            ""AttributeId"": 84,
                            ""ValueId"": 188,
                            ""AttributeName"": ""Color"",
                            ""Value"": ""Pink dark""
                        }
                    ],
                    ""DiscountSplit"": {
                        ""PartnerDiscount"": 0,
                        ""SpecialDiscount"": 39
                    },
                    ""BundleSnapshot"": null,
                    ""ExternalId"": null
                },
                ""CreatedDateTime"": ""2020-08-01T10:33:31.129825"",
                ""OrderItemStatusHistories"": [
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Created"",
                        ""CreatedDateTime"": ""2020-08-01T10:33:31.129883""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""PaymentSuccess"",
                        ""CreatedDateTime"": ""2020-08-02T10:24:12.525215""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""SellerProcessing"",
                        ""CreatedDateTime"": ""2020-08-03T05:29:52.006403""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Shipping"",
                        ""CreatedDateTime"": ""2020-08-03T09:51:07.530111""
                    }
                ],
                ""OrderItemStatus"": ""Shipping"",
                ""SelfPickUpOptions"": null,
                ""OrderReturnDetails"": null,
                ""OrderCancelDetails"": null,
                ""TaxDetails"": {
                    ""TotalTaxPaid"": 9.52,
                    ""TaxGroupId"": 3,
                    ""TaxGroupName"": ""GST-5"",
                    ""TaxSplits"": [
                        {
                            ""TaxId"": 5,
                            ""TaxName"": ""CGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        },
                        {
                            ""TaxId"": 6,
                            ""TaxName"": ""SGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        }
                    ]
                },
                ""LoanDetail"": null,
                ""Shipment"": {
                    ""Id"": 264,
                    ""ProviderName"": ""***************"",
                    ""ShipmentFee"": 70,
                    ""ExpectedDeliveryDate"": ""2020-08-05T10:33:21.693771"",
                    ""TrackingCode"": null,
                    ""ShiprocketResponse"": {
                        ""pickup_location_added"": 0,
                        ""order_created"": 1,
                        ""awb_generated"": 1,
                        ""label_generated"": 1,
                        ""pickup_generated"": 1,
                        ""manifest_generated"": 1,
                        ""pickup_scheduled_date"": ""2020-08-04T09:00:00"",
                        ""order_id"": 50016171,
                        ""shipment_id"": 234234,
                        ""awb_code"": ""***************"",
                        ""courier_company_id"": 1,
                        ""courier_name"": null,
                        ""assigned_date_time"": null,
                        ""applied_weight"": 5.4,
                        ""cod"": false,
                        ""label_url"": ""https://kr-******************************.pdf"",
                        ""manifest_url"": ""https://******************************.pdf"",
                        ""routing_code"": ""TGD/TGD"",
                        ""pickup_token_number"": ""Reference No:***************""
                    }
                },
                ""SellerName"": ""******************************"",
                ""Metadata"": {
                    ""QuoteSnapshot"": null,
                    ""IsSelfPickup"": false,
                    ""DeliveryCode"": null,
                    ""SelfPickupOptions"": null,
                    ""LoanDetailSnapShot"": null,
                    ""ShipmentFeePerSeller"": 70,
                    ""PartnerDiscountDetails"": null
                },
                ""ActualUnitPrice"": 195
            },
            {
                ""Id"": 269,
                ""ProductId"": 4653,
                ""SkuId"": ""***************840050338353"",
                ""SellerId"": ""***************"",
                ""ActualPrice"": 195,
                ""ActualPriceWithoutTax"": 185.48,
                ""DiscountedPrice"": 156,
                ""TotalDiscount"": 39,
                ""Qty"": 1,
                ""Tax"": 0,
                ""BundleId"": null,
                ""ShipmentId"": 264,
                ""IsSelfPickup"": false,
                ""ProductSnapshot"": {
                    ""ProductName"": ""KNITTED - ***************"",
                    ""ProductGroup"": null,
                    ""ProductType"": ""Configurable"",
                    ""Images"": [
                        ""G1 FV _Pink dark_thumbnail.jpg"",
                        ""G1 SV _Pink dark rani.jpg"",
                        ""G1 BV _Pink dark.jpg"",
                        ""G1 FV _BLUE DARK_thumbnail.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 FV _Black_thumbnail.jpg"",
                        ""G1 SV _Black.jpg"",
                        ""G1 BV _Black.jpg""
                    ],
                    ""AttributeValues"": [
                        {
                            ""AttributeId"": 84,
                            ""ValueId"": 189,
                            ""AttributeName"": ""Color"",
                            ""Value"": ""Blue dark""
                        },
                        {
                            ""AttributeId"": 85,
                            ""ValueId"": 227,
                            ""AttributeName"": ""Size"",
                            ""Value"": ""B36\\90""
                        }
                    ],
                    ""DiscountSplit"": {
                        ""PartnerDiscount"": 0,
                        ""SpecialDiscount"": 39
                    },
                    ""BundleSnapshot"": null,
                    ""ExternalId"": null
                },
                ""CreatedDateTime"": ""2020-08-01T10:33:31.129825"",
                ""OrderItemStatusHistories"": [
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Created"",
                        ""CreatedDateTime"": ""2020-08-01T10:33:31.129898""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""PaymentSuccess"",
                        ""CreatedDateTime"": ""2020-08-02T10:24:12.525324""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""SellerProcessing"",
                        ""CreatedDateTime"": ""2020-08-03T05:29:54.97333""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Shipping"",
                        ""CreatedDateTime"": ""2020-08-03T09:51:07.530112""
                    }
                ],
                ""OrderItemStatus"": ""Shipping"",
                ""SelfPickUpOptions"": null,
                ""OrderReturnDetails"": null,
                ""OrderCancelDetails"": null,
                ""TaxDetails"": {
                    ""TotalTaxPaid"": 9.52,
                    ""TaxGroupId"": 3,
                    ""TaxGroupName"": ""GST-5"",
                    ""TaxSplits"": [
                        {
                            ""TaxId"": 5,
                            ""TaxName"": ""CGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        },
                        {
                            ""TaxId"": 6,
                            ""TaxName"": ""SGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        }
                    ]
                },
                ""LoanDetail"": null,
                ""Shipment"": {
                    ""Id"": 264,
                    ""ProviderName"": ""***************"",
                    ""ShipmentFee"": 70,
                    ""ExpectedDeliveryDate"": ""2020-08-05T10:33:21.693771"",
                    ""TrackingCode"": null,
                    ""ShiprocketResponse"": {
                        ""pickup_location_added"": 0,
                        ""order_created"": 1,
                        ""awb_generated"": 1,
                        ""label_generated"": 1,
                        ""pickup_generated"": 1,
                        ""manifest_generated"": 1,
                        ""pickup_scheduled_date"": ""2020-08-04T09:00:00"",
                        ""order_id"": 50016171,
                        ""shipment_id"": 49713763,
                        ""awb_code"": ""***************"",
                        ""courier_company_id"": 1,
                        ""courier_name"": null,
                        ""assigned_date_time"": null,
                        ""applied_weight"": 5.4,
                        ""cod"": false,
                        ""label_url"": ""https://******************************9713763-***************.pdf"",
                        ""manifest_url"": ""h******************************.pdf"",
                        ""routing_code"": ""TGD/TGD"",
                        ""pickup_token_number"": ""Reference No: ***************""
                    }
                },
                ""SellerName"": ""***************"",
                ""Metadata"": {
                    ""QuoteSnapshot"": null,
                    ""IsSelfPickup"": false,
                    ""DeliveryCode"": null,
                    ""SelfPickupOptions"": null,
                    ""LoanDetailSnapShot"": null,
                    ""ShipmentFeePerSeller"": 70,
                    ""PartnerDiscountDetails"": null
                },
                ""ActualUnitPrice"": 195
            },
            {
                ""Id"": 270,
                ""ProductId"": 4653,
                ""SkuId"": ""***************840050338278"",
                ""SellerId"": ""***************"",
                ""ActualPrice"": 195,
                ""ActualPriceWithoutTax"": 23448,
                ""DiscountedPrice"": 234,
                ""TotalDiscount"": 39,
                ""Qty"": 1,
                ""Tax"": 0,
                ""BundleId"": null,
                ""ShipmentId"": 264,
                ""IsSelfPickup"": false,
                ""ProductSnapshot"": {
                    ""ProductName"": ""***************"",
                    ""ProductGroup"": null,
                    ""ProductType"": ""Configurable"",
                    ""Images"": [
                        ""G1 FV _Pink dark_thumbnail.jpg"",
                        ""G1 SV _Pink dark rani.jpg"",
                        ""G1 BV _Pink dark.jpg"",
                        ""G1 FV _BLUE DARK_thumbnail.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 SV _ navy Blue.jpg"",
                        ""G1 FV _Black_thumbnail.jpg"",
                        ""G1 SV _Black.jpg"",
                        ""G1 BV _Black.jpg""
                    ],
                    ""AttributeValues"": [
                        {
                            ""AttributeId"": 85,
                            ""ValueId"": 227,
                            ""AttributeName"": ""Size"",
                            ""Value"": ""B36\\90""
                        },
                        {
                            ""AttributeId"": 84,
                            ""ValueId"": 194,
                            ""AttributeName"": ""Color"",
                            ""Value"": ""Black""
                        }
                    ],
                    ""DiscountSplit"": {
                        ""PartnerDiscount"": 0,
                        ""SpecialDiscount"": 39
                    },
                    ""BundleSnapshot"": null,
                    ""ExternalId"": null
                },
                ""CreatedDateTime"": ""2020-08-01T10:33:31.129825"",
                ""OrderItemStatusHistories"": [
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Created"",
                        ""CreatedDateTime"": ""2020-08-01T10:33:31.129902""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""PaymentSuccess"",
                        ""CreatedDateTime"": ""2020-08-02T10:24:12.525336""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""SellerProcessing"",
                        ""CreatedDateTime"": ""2020-08-03T05:29:59.6706""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Shipping"",
                        ""CreatedDateTime"": ""2020-08-03T09:51:07.529963""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""SellerProcessing"",
                        ""CreatedDateTime"": ""2020-08-03T09:51:07.530096""
                    },
                    {
                        ""Id"": 0,
                        ""OrderId"": 0,
                        ""OrderStatus"": ""Shipping"",
                        ""CreatedDateTime"": ""2020-08-03T09:51:07.53011""
                    }
                ],
                ""OrderItemStatus"": ""Shipping"",
                ""SelfPickUpOptions"": null,
                ""OrderReturnDetails"": null,
                ""OrderCancelDetails"": null,
                ""TaxDetails"": {
                    ""TotalTaxPaid"": 9.52,
                    ""TaxGroupId"": 3,
                    ""TaxGroupName"": ""GST-5"",
                    ""TaxSplits"": [
                        {
                            ""TaxId"": 5,
                            ""TaxName"": ""CGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        },
                        {
                            ""TaxId"": 6,
                            ""TaxName"": ""SGST"",
                            ""TaxPercentage"": 2.5,
                            ""TaxAmount"": 0,
                            ""TaxAmountPaid"": 4.76,
                            ""TaxType"": ""TaxPercentage""
                        }
                    ]
                },
                ""LoanDetail"": null,
                ""Shipment"": {
                    ""Id"": 264,
                    ""ProviderName"": ""***************"",
                    ""ShipmentFee"": 70,
                    ""ExpectedDeliveryDate"": ""2020-08-05T10:33:21.693771"",
                    ""TrackingCode"": null,
                    ""ShiprocketResponse"": {
                        ""pickup_location_added"": 0,
                        ""order_created"": 1,
                        ""awb_generated"": 1,
                        ""label_generated"": 1,
                        ""pickup_generated"": 1,
                        ""manifest_generated"": 1,
                        ""pickup_scheduled_date"": ""2020-08-04T09:00:00"",
                        ""order_id"": 234234,
                        ""shipment_id"": 234234,
                        ""awb_code"": ""***************"",
                        ""courier_company_id"": 1,
                        ""courier_name"": null,
                        ""assigned_date_time"": null,
                        ""applied_weight"": 5.4,
                        ""cod"": false,
                        ""label_url"": ""https://kr-shipmult***************6448260_shipp***************.pdf"",
                        ""manifest_url"": ""https://s3-ap-s***************IFEST-0012.pdf"",
                        ""routing_code"": ""TGD/TGD"",
                        ""pickup_token_number"": ""***************""
                    }
                },
                ""SellerName"": ""***************"",
                ""Metadata"": {
                    ""QuoteSnapshot"": null,
                    ""IsSelfPickup"": false,
                    ""DeliveryCode"": null,
                    ""SelfPickupOptions"": null,
                    ""LoanDetailSnapShot"": null,
                    ""ShipmentFeePerSeller"": 70,
                    ""PartnerDiscountDetails"": null
                },
                ""ActualUnitPrice"": 234234
            }
        ],
        ""PaymentSplits"": [
            {
                ""Id"": 0,
                ""PaymentMode"": ""Online"",
                ""Price"": 23423423
            }
        ],
        ""OrderStatus"": ""SellerProcessing"",
        ""OrderStatusHistories"": [
            {
                ""Id"": 0,
                ""OrderId"": 0,
                ""OrderStatus"": ""Created"",
                ""CreatedDateTime"": ""2020-08-01T10:33:31.129905""
            },
            {
                ""Id"": 0,
                ""OrderId"": 0,
                ""OrderStatus"": ""PaymentSuccess"",
                ""CreatedDateTime"": ""2020-08-02T10:24:12.525043""
            },
            {
                ""Id"": 0,
                ""OrderId"": 0,
                ""OrderStatus"": ""SellerProcessing"",
                ""CreatedDateTime"": ""2020-08-03T05:29:59.670581""
            }
        ],
        ""CreatedDateTime"": ""2020-08-01T10:33:31.129825"",
        ""CustomerName"": ""***************"",
        ""Metadata"": {
            ""QuoteId"": 0,
            ""ShipmentFee"": 70
        },
        ""CustomerPhone"": ""***************"",
        ""DiscountSplits"": []
    },
    ""BusinessDetails"": {
        ""Name"": ""***************"",
        ""Gstin"": ""***************"",
        ""Cin"": ""***************"",
        ""Tan"": null,
        ""Pan"": ""***************"",
        ""Phone"": """",
        ""Mobile"": ""***************"",
        ""Email"": ""online@***************.com""
    },
    ""BusinessAddress"": {
        ""Id"": 0,
        ""ApartmentNumber"": ""No 6"",
        ""Street"": ""******************************"",
        ""Locality"": ""***************, ***************"",
        ""City"": ""*************** "",
        ""State"": ""***************"",
        ""Country"": ""***************"",
        ""ISOCountryCode"": null,
        ""ZipCode"": ""***************""
    }
}";
          #endregion
          
          var ob = JsonConvert.DeserializeObject<Model.GetInvoiceDto>(str);
          
          
        }
    }
}