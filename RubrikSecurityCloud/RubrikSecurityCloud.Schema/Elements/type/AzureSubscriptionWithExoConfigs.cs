// AzureSubscriptionWithExoConfigs.cs
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
    #region AzureSubscriptionWithExoConfigs
    public class AzureSubscriptionWithExoConfigs: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        [JsonProperty("mappedCloudAccountIds")]
        public List<System.String>? MappedCloudAccountIds { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? ExocomputeConfigs { get; set; }

        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public AzureCloudAccountFeatureDetail? FeatureDetail { get; set; }

        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        [JsonProperty("mappedCloudAccounts")]
        public List<CloudAccountDetails>? MappedCloudAccounts { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("mappedExocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs { get; set; }

        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        [JsonProperty("mappedExocomputeSubscription")]
        public AzureMappedExocomputeSubscription? MappedExocomputeSubscription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSubscriptionWithExoConfigs";
    }

    public AzureSubscriptionWithExoConfigs Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? AzureSubscriptionRubrikId = null,
        List<System.String>? MappedCloudAccountIds = null,
        System.String? SubscriptionName = null,
        List<AzureExocomputeConfigDetails>? ExocomputeConfigs = null,
        AzureCloudAccountFeatureDetail? FeatureDetail = null,
        List<CloudAccountDetails>? MappedCloudAccounts = null,
        List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs = null,
        AzureMappedExocomputeSubscription? MappedExocomputeSubscription = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( MappedCloudAccountIds != null ) {
            this.MappedCloudAccountIds = MappedCloudAccountIds;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedCloudAccounts != null ) {
            this.MappedCloudAccounts = MappedCloudAccounts;
        }
        if ( MappedExocomputeConfigs != null ) {
            this.MappedExocomputeConfigs = MappedExocomputeConfigs;
        }
        if ( MappedExocomputeSubscription != null ) {
            this.MappedExocomputeSubscription = MappedExocomputeSubscription;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            s += ind + "azureSubscriptionNativeId\n" ;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            s += ind + "azureSubscriptionRubrikId\n" ;
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds != null) {
            s += ind + "mappedCloudAccountIds\n" ;
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName != null) {
            s += ind + "subscriptionName\n" ;
        }
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exocomputeConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts != null) {
            var fspec = this.MappedCloudAccounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedCloudAccounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.MappedExocomputeConfigs != null) {
            var fspec = this.MappedExocomputeConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedExocomputeConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription != null) {
            var fspec = this.MappedExocomputeSubscription.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedExocomputeSubscription {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId == null && ec.Includes("azureSubscriptionNativeId",true))
        {
            this.AzureSubscriptionNativeId = "FETCH";
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId == null && ec.Includes("azureSubscriptionRubrikId",true))
        {
            this.AzureSubscriptionRubrikId = "FETCH";
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds == null && ec.Includes("mappedCloudAccountIds",true))
        {
            this.MappedCloudAccountIds = new List<System.String>();
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName == null && ec.Includes("subscriptionName",true))
        {
            this.SubscriptionName = "FETCH";
        }
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.ExocomputeConfigs == null && ec.Includes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
            this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetail == null && ec.Includes("featureDetail",false))
        {
            this.FeatureDetail = new AzureCloudAccountFeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts == null && ec.Includes("mappedCloudAccounts",false))
        {
            this.MappedCloudAccounts = new List<CloudAccountDetails>();
            this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.MappedExocomputeConfigs == null && ec.Includes("mappedExocomputeConfigs",false))
        {
            this.MappedExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
            this.MappedExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeConfigs"));
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription == null && ec.Includes("mappedExocomputeSubscription",false))
        {
            this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
            this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));
        }
    }


    #endregion

    } // class AzureSubscriptionWithExoConfigs
    
    #endregion

    public static class ListAzureSubscriptionWithExoConfigsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureSubscriptionWithExoConfigs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSubscriptionWithExoConfigs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSubscriptionWithExoConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureSubscriptionWithExoConfigs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types