// CheckAwsMarketplaceSubscriptionReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CheckAwsMarketplaceSubscriptionReply
    public class CheckAwsMarketplaceSubscriptionReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSubscribed
        // GraphQL -> isSubscribed: Boolean! (scalar)
        [JsonProperty("isSubscribed")]
        public System.Boolean? IsSubscribed { get; set; }

        //      C# -> System.String? MarketplaceTermsLink
        // GraphQL -> marketplaceTermsLink: String! (scalar)
        [JsonProperty("marketplaceTermsLink")]
        public System.String? MarketplaceTermsLink { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? ProductCode
        // GraphQL -> productCode: String! (scalar)
        [JsonProperty("productCode")]
        public System.String? ProductCode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckAwsMarketplaceSubscriptionReply";
    }

    public CheckAwsMarketplaceSubscriptionReply Set(
        System.Boolean? IsSubscribed = null,
        System.String? MarketplaceTermsLink = null,
        System.String? Message = null,
        System.String? ProductCode = null
    ) 
    {
        if ( IsSubscribed != null ) {
            this.IsSubscribed = IsSubscribed;
        }
        if ( MarketplaceTermsLink != null ) {
            this.MarketplaceTermsLink = MarketplaceTermsLink;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ProductCode != null ) {
            this.ProductCode = ProductCode;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsSubscribed
        // GraphQL -> isSubscribed: Boolean! (scalar)
        if (this.IsSubscribed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribed\n" ;
            } else {
                s += ind + "isSubscribed\n" ;
            }
        }
        //      C# -> System.String? MarketplaceTermsLink
        // GraphQL -> marketplaceTermsLink: String! (scalar)
        if (this.MarketplaceTermsLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "marketplaceTermsLink\n" ;
            } else {
                s += ind + "marketplaceTermsLink\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.String? ProductCode
        // GraphQL -> productCode: String! (scalar)
        if (this.ProductCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productCode\n" ;
            } else {
                s += ind + "productCode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsSubscribed
        // GraphQL -> isSubscribed: Boolean! (scalar)
        if (ec.Includes("isSubscribed",true))
        {
            if(this.IsSubscribed == null) {

                this.IsSubscribed = true;

            } else {


            }
        }
        else if (this.IsSubscribed != null && ec.Excludes("isSubscribed",true))
        {
            this.IsSubscribed = null;
        }
        //      C# -> System.String? MarketplaceTermsLink
        // GraphQL -> marketplaceTermsLink: String! (scalar)
        if (ec.Includes("marketplaceTermsLink",true))
        {
            if(this.MarketplaceTermsLink == null) {

                this.MarketplaceTermsLink = "FETCH";

            } else {


            }
        }
        else if (this.MarketplaceTermsLink != null && ec.Excludes("marketplaceTermsLink",true))
        {
            this.MarketplaceTermsLink = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.String? ProductCode
        // GraphQL -> productCode: String! (scalar)
        if (ec.Includes("productCode",true))
        {
            if(this.ProductCode == null) {

                this.ProductCode = "FETCH";

            } else {


            }
        }
        else if (this.ProductCode != null && ec.Excludes("productCode",true))
        {
            this.ProductCode = null;
        }
    }


    #endregion

    } // class CheckAwsMarketplaceSubscriptionReply
    
    #endregion

    public static class ListCheckAwsMarketplaceSubscriptionReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CheckAwsMarketplaceSubscriptionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckAwsMarketplaceSubscriptionReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckAwsMarketplaceSubscriptionReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckAwsMarketplaceSubscriptionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckAwsMarketplaceSubscriptionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types