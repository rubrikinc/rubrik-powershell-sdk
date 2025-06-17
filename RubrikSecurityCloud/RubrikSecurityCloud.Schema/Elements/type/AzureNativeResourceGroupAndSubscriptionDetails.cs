// AzureNativeResourceGroupAndSubscriptionDetails.cs
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
    #region AzureNativeResourceGroupAndSubscriptionDetails
    public class AzureNativeResourceGroupAndSubscriptionDetails: BaseType
    {
        #region members

        //      C# -> System.String? ResourceGroupId
        // GraphQL -> resourceGroupId: String! (scalar)
        [JsonProperty("resourceGroupId")]
        public System.String? ResourceGroupId { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> AzureNativeSubscriptionDetails? SubscriptionDetails
        // GraphQL -> subscriptionDetails: AzureNativeSubscriptionDetails (type)
        [JsonProperty("subscriptionDetails")]
        public AzureNativeSubscriptionDetails? SubscriptionDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeResourceGroupAndSubscriptionDetails";
    }

    public AzureNativeResourceGroupAndSubscriptionDetails Set(
        System.String? ResourceGroupId = null,
        System.String? ResourceGroupName = null,
        AzureNativeSubscriptionDetails? SubscriptionDetails = null
    ) 
    {
        if ( ResourceGroupId != null ) {
            this.ResourceGroupId = ResourceGroupId;
        }
        if ( ResourceGroupName != null ) {
            this.ResourceGroupName = ResourceGroupName;
        }
        if ( SubscriptionDetails != null ) {
            this.SubscriptionDetails = SubscriptionDetails;
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
        //      C# -> System.String? ResourceGroupId
        // GraphQL -> resourceGroupId: String! (scalar)
        if (this.ResourceGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroupId\n" ;
            } else {
                s += ind + "resourceGroupId\n" ;
            }
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroupName\n" ;
            } else {
                s += ind + "resourceGroupName\n" ;
            }
        }
        //      C# -> AzureNativeSubscriptionDetails? SubscriptionDetails
        // GraphQL -> subscriptionDetails: AzureNativeSubscriptionDetails (type)
        if (this.SubscriptionDetails != null) {
            var fspec = this.SubscriptionDetails.AsFieldSpec(conf.Child("subscriptionDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptionDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ResourceGroupId
        // GraphQL -> resourceGroupId: String! (scalar)
        if (ec.Includes("resourceGroupId",true))
        {
            if(this.ResourceGroupId == null) {

                this.ResourceGroupId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroupId != null && ec.Excludes("resourceGroupId",true))
        {
            this.ResourceGroupId = null;
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (ec.Includes("resourceGroupName",true))
        {
            if(this.ResourceGroupName == null) {

                this.ResourceGroupName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroupName != null && ec.Excludes("resourceGroupName",true))
        {
            this.ResourceGroupName = null;
        }
        //      C# -> AzureNativeSubscriptionDetails? SubscriptionDetails
        // GraphQL -> subscriptionDetails: AzureNativeSubscriptionDetails (type)
        if (ec.Includes("subscriptionDetails",false))
        {
            if(this.SubscriptionDetails == null) {

                this.SubscriptionDetails = new AzureNativeSubscriptionDetails();
                this.SubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionDetails"));

            } else {

                this.SubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionDetails"));

            }
        }
        else if (this.SubscriptionDetails != null && ec.Excludes("subscriptionDetails",false))
        {
            this.SubscriptionDetails = null;
        }
    }


    #endregion

    } // class AzureNativeResourceGroupAndSubscriptionDetails
    
    #endregion

    public static class ListAzureNativeResourceGroupAndSubscriptionDetailsExtensions
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
            this List<AzureNativeResourceGroupAndSubscriptionDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeResourceGroupAndSubscriptionDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeResourceGroupAndSubscriptionDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeResourceGroupAndSubscriptionDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeResourceGroupAndSubscriptionDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types