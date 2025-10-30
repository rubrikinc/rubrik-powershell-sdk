// CheckAzureMarketplaceTermsReply.cs
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
    #region CheckAzureMarketplaceTermsReply
    public class CheckAzureMarketplaceTermsReply: BaseType
    {
        #region members

        //      C# -> System.String? MarketplaceSku
        // GraphQL -> marketplaceSku: String! (scalar)
        [JsonProperty("marketplaceSku")]
        public System.String? MarketplaceSku { get; set; }

        //      C# -> System.String? MarketplaceTermsLink
        // GraphQL -> marketplaceTermsLink: String! (scalar)
        [JsonProperty("marketplaceTermsLink")]
        public System.String? MarketplaceTermsLink { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? Offer
        // GraphQL -> offer: String! (scalar)
        [JsonProperty("offer")]
        public System.String? Offer { get; set; }

        //      C# -> System.String? Publisher
        // GraphQL -> publisher: String! (scalar)
        [JsonProperty("publisher")]
        public System.String? Publisher { get; set; }

        //      C# -> System.Boolean? TermsAccepted
        // GraphQL -> termsAccepted: Boolean! (scalar)
        [JsonProperty("termsAccepted")]
        public System.Boolean? TermsAccepted { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckAzureMarketplaceTermsReply";
    }

    public CheckAzureMarketplaceTermsReply Set(
        System.String? MarketplaceSku = null,
        System.String? MarketplaceTermsLink = null,
        System.String? Message = null,
        System.String? Offer = null,
        System.String? Publisher = null,
        System.Boolean? TermsAccepted = null
    ) 
    {
        if ( MarketplaceSku != null ) {
            this.MarketplaceSku = MarketplaceSku;
        }
        if ( MarketplaceTermsLink != null ) {
            this.MarketplaceTermsLink = MarketplaceTermsLink;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Offer != null ) {
            this.Offer = Offer;
        }
        if ( Publisher != null ) {
            this.Publisher = Publisher;
        }
        if ( TermsAccepted != null ) {
            this.TermsAccepted = TermsAccepted;
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
        //      C# -> System.String? MarketplaceSku
        // GraphQL -> marketplaceSku: String! (scalar)
        if (this.MarketplaceSku != null) {
            if (conf.Flat) {
                s += conf.Prefix + "marketplaceSku\n" ;
            } else {
                s += ind + "marketplaceSku\n" ;
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
        //      C# -> System.String? Offer
        // GraphQL -> offer: String! (scalar)
        if (this.Offer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "offer\n" ;
            } else {
                s += ind + "offer\n" ;
            }
        }
        //      C# -> System.String? Publisher
        // GraphQL -> publisher: String! (scalar)
        if (this.Publisher != null) {
            if (conf.Flat) {
                s += conf.Prefix + "publisher\n" ;
            } else {
                s += ind + "publisher\n" ;
            }
        }
        //      C# -> System.Boolean? TermsAccepted
        // GraphQL -> termsAccepted: Boolean! (scalar)
        if (this.TermsAccepted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "termsAccepted\n" ;
            } else {
                s += ind + "termsAccepted\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MarketplaceSku
        // GraphQL -> marketplaceSku: String! (scalar)
        if (ec.Includes("marketplaceSku",true))
        {
            if(this.MarketplaceSku == null) {

                this.MarketplaceSku = "FETCH";

            } else {


            }
        }
        else if (this.MarketplaceSku != null && ec.Excludes("marketplaceSku",true))
        {
            this.MarketplaceSku = null;
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
        //      C# -> System.String? Offer
        // GraphQL -> offer: String! (scalar)
        if (ec.Includes("offer",true))
        {
            if(this.Offer == null) {

                this.Offer = "FETCH";

            } else {


            }
        }
        else if (this.Offer != null && ec.Excludes("offer",true))
        {
            this.Offer = null;
        }
        //      C# -> System.String? Publisher
        // GraphQL -> publisher: String! (scalar)
        if (ec.Includes("publisher",true))
        {
            if(this.Publisher == null) {

                this.Publisher = "FETCH";

            } else {


            }
        }
        else if (this.Publisher != null && ec.Excludes("publisher",true))
        {
            this.Publisher = null;
        }
        //      C# -> System.Boolean? TermsAccepted
        // GraphQL -> termsAccepted: Boolean! (scalar)
        if (ec.Includes("termsAccepted",true))
        {
            if(this.TermsAccepted == null) {

                this.TermsAccepted = true;

            } else {


            }
        }
        else if (this.TermsAccepted != null && ec.Excludes("termsAccepted",true))
        {
            this.TermsAccepted = null;
        }
    }


    #endregion

    } // class CheckAzureMarketplaceTermsReply
    
    #endregion

    public static class ListCheckAzureMarketplaceTermsReplyExtensions
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
            this List<CheckAzureMarketplaceTermsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckAzureMarketplaceTermsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckAzureMarketplaceTermsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckAzureMarketplaceTermsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckAzureMarketplaceTermsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types