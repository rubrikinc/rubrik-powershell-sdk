// AzureTargetSubscription.cs
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
    #region AzureTargetSubscription
    public class AzureTargetSubscription: BaseType
    {
        #region members

        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        [JsonProperty("customerTenantId")]
        public System.String? CustomerTenantId { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> List<AzureTargetSubscriptionFeatureDetail>? Features
        // GraphQL -> features: [AzureTargetSubscriptionFeatureDetail!]! (type)
        [JsonProperty("features")]
        public List<AzureTargetSubscriptionFeatureDetail>? Features { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureTargetSubscription";
    }

    public AzureTargetSubscription Set(
        System.String? CustomerTenantId = null,
        System.String? SubscriptionId = null,
        System.String? SubscriptionName = null,
        System.String? SubscriptionNativeId = null,
        List<AzureTargetSubscriptionFeatureDetail>? Features = null
    ) 
    {
        if ( CustomerTenantId != null ) {
            this.CustomerTenantId = CustomerTenantId;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
        }
        if ( Features != null ) {
            this.Features = Features;
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
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (this.CustomerTenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customerTenantId\n" ;
            } else {
                s += ind + "customerTenantId\n" ;
            }
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionName\n" ;
            } else {
                s += ind + "subscriptionName\n" ;
            }
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionNativeId\n" ;
            } else {
                s += ind + "subscriptionNativeId\n" ;
            }
        }
        //      C# -> List<AzureTargetSubscriptionFeatureDetail>? Features
        // GraphQL -> features: [AzureTargetSubscriptionFeatureDetail!]! (type)
        if (this.Features != null) {
            var fspec = this.Features.AsFieldSpec(conf.Child("features"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "features" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (ec.Includes("customerTenantId",true))
        {
            if(this.CustomerTenantId == null) {

                this.CustomerTenantId = "FETCH";

            } else {


            }
        }
        else if (this.CustomerTenantId != null && ec.Excludes("customerTenantId",true))
        {
            this.CustomerTenantId = null;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (ec.Includes("subscriptionName",true))
        {
            if(this.SubscriptionName == null) {

                this.SubscriptionName = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionName != null && ec.Excludes("subscriptionName",true))
        {
            this.SubscriptionName = null;
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (ec.Includes("subscriptionNativeId",true))
        {
            if(this.SubscriptionNativeId == null) {

                this.SubscriptionNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionNativeId != null && ec.Excludes("subscriptionNativeId",true))
        {
            this.SubscriptionNativeId = null;
        }
        //      C# -> List<AzureTargetSubscriptionFeatureDetail>? Features
        // GraphQL -> features: [AzureTargetSubscriptionFeatureDetail!]! (type)
        if (ec.Includes("features",false))
        {
            if(this.Features == null) {

                this.Features = new List<AzureTargetSubscriptionFeatureDetail>();
                this.Features.ApplyExploratoryFieldSpec(ec.NewChild("features"));

            } else {

                this.Features.ApplyExploratoryFieldSpec(ec.NewChild("features"));

            }
        }
        else if (this.Features != null && ec.Excludes("features",false))
        {
            this.Features = null;
        }
    }


    #endregion

    } // class AzureTargetSubscription
    
    #endregion

    public static class ListAzureTargetSubscriptionExtensions
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
            this List<AzureTargetSubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureTargetSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureTargetSubscription> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureTargetSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureTargetSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types