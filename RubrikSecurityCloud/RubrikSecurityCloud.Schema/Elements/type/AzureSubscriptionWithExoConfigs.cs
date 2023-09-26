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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionNativeId\n" ;
            } else {
                s += ind + "azureSubscriptionNativeId\n" ;
            }
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionRubrikId\n" ;
            } else {
                s += ind + "azureSubscriptionRubrikId\n" ;
            }
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedCloudAccountIds\n" ;
            } else {
                s += ind + "mappedCloudAccountIds\n" ;
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
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(conf.Child("exocomputeConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(conf.Child("featureDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts != null) {
            var fspec = this.MappedCloudAccounts.AsFieldSpec(conf.Child("mappedCloudAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedCloudAccounts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.MappedExocomputeConfigs != null) {
            var fspec = this.MappedExocomputeConfigs.AsFieldSpec(conf.Child("mappedExocomputeConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeConfigs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription != null) {
            var fspec = this.MappedExocomputeSubscription.AsFieldSpec(conf.Child("mappedExocomputeSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeSubscription {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (ec.Includes("azureSubscriptionNativeId",true))
        {
            if(this.AzureSubscriptionNativeId == null) {

                this.AzureSubscriptionNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionNativeId != null && ec.Excludes("azureSubscriptionNativeId",true))
        {
            this.AzureSubscriptionNativeId = null;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (ec.Includes("azureSubscriptionRubrikId",true))
        {
            if(this.AzureSubscriptionRubrikId == null) {

                this.AzureSubscriptionRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionRubrikId != null && ec.Excludes("azureSubscriptionRubrikId",true))
        {
            this.AzureSubscriptionRubrikId = null;
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (ec.Includes("mappedCloudAccountIds",true))
        {
            if(this.MappedCloudAccountIds == null) {

                this.MappedCloudAccountIds = new List<System.String>();

            } else {


            }
        }
        else if (this.MappedCloudAccountIds != null && ec.Excludes("mappedCloudAccountIds",true))
        {
            this.MappedCloudAccountIds = null;
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
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                this.ExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            } else {

                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            }
        }
        else if (this.ExocomputeConfigs != null && ec.Excludes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = null;
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (ec.Includes("featureDetail",false))
        {
            if(this.FeatureDetail == null) {

                this.FeatureDetail = new AzureCloudAccountFeatureDetail();
                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            } else {

                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            }
        }
        else if (this.FeatureDetail != null && ec.Excludes("featureDetail",false))
        {
            this.FeatureDetail = null;
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (ec.Includes("mappedCloudAccounts",false))
        {
            if(this.MappedCloudAccounts == null) {

                this.MappedCloudAccounts = new List<CloudAccountDetails>();
                this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));

            } else {

                this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));

            }
        }
        else if (this.MappedCloudAccounts != null && ec.Excludes("mappedCloudAccounts",false))
        {
            this.MappedCloudAccounts = null;
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (ec.Includes("mappedExocomputeConfigs",false))
        {
            if(this.MappedExocomputeConfigs == null) {

                this.MappedExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
                this.MappedExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeConfigs"));

            } else {

                this.MappedExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeConfigs"));

            }
        }
        else if (this.MappedExocomputeConfigs != null && ec.Excludes("mappedExocomputeConfigs",false))
        {
            this.MappedExocomputeConfigs = null;
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (ec.Includes("mappedExocomputeSubscription",false))
        {
            if(this.MappedExocomputeSubscription == null) {

                this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
                this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));

            } else {

                this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));

            }
        }
        else if (this.MappedExocomputeSubscription != null && ec.Excludes("mappedExocomputeSubscription",false))
        {
            this.MappedExocomputeSubscription = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<AzureSubscriptionWithExoConfigs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types