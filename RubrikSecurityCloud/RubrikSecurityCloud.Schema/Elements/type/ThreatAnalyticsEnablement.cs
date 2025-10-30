// ThreatAnalyticsEnablement.cs
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
    #region ThreatAnalyticsEnablement
    public class ThreatAnalyticsEnablement: BaseType
    {
        #region members

        //      C# -> List<ThreatAnalyticsEnablementItem>? AllEnablementItems
        // GraphQL -> allEnablementItems: [ThreatAnalyticsEnablementItem!]! (type)
        [JsonProperty("allEnablementItems")]
        public List<ThreatAnalyticsEnablementItem>? AllEnablementItems { get; set; }

        //      C# -> List<AwsAccountThreatAnalyticsEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatAnalyticsEnablement!]! (type)
        [JsonProperty("awsAccounts")]
        public List<AwsAccountThreatAnalyticsEnablement>? AwsAccounts { get; set; }

        //      C# -> List<AzureSubscriptionThreatAnalyticsEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatAnalyticsEnablement!]! (type)
        [JsonProperty("azureSubscriptions")]
        public List<AzureSubscriptionThreatAnalyticsEnablement>? AzureSubscriptions { get; set; }

        //      C# -> List<CloudDirectClusterThreatAnalyticsEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterThreatAnalyticsEnablement!]! (type)
        [JsonProperty("cloudDirectClusters")]
        public List<CloudDirectClusterThreatAnalyticsEnablement>? CloudDirectClusters { get; set; }

        //      C# -> List<GcpProjectThreatAnalyticsEnablement>? GcpProjects
        // GraphQL -> gcpProjects: [GcpProjectThreatAnalyticsEnablement!]! (type)
        [JsonProperty("gcpProjects")]
        public List<GcpProjectThreatAnalyticsEnablement>? GcpProjects { get; set; }

        //      C# -> List<M365SubscriptionThreatAnalyticsEnablement>? M365Subscriptions
        // GraphQL -> m365Subscriptions: [M365SubscriptionThreatAnalyticsEnablement!]! (type)
        [JsonProperty("m365Subscriptions")]
        public List<M365SubscriptionThreatAnalyticsEnablement>? M365Subscriptions { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars AllEnablementItems { get; set; }


        public InlineVars() {
            Tuple<string, string>[] allEnablementItemsArgs = {
                    Tuple.Create("type", "ThreatHuntRootObjectType!"),
                };
            this.AllEnablementItems =
                new RscGqlVars(null, allEnablementItemsArgs, null, true);
        }
    }

    public ThreatAnalyticsEnablement()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "ThreatAnalyticsEnablement";
    }

    public ThreatAnalyticsEnablement Set(
        List<ThreatAnalyticsEnablementItem>? AllEnablementItems = null,
        List<AwsAccountThreatAnalyticsEnablement>? AwsAccounts = null,
        List<AzureSubscriptionThreatAnalyticsEnablement>? AzureSubscriptions = null,
        List<CloudDirectClusterThreatAnalyticsEnablement>? CloudDirectClusters = null,
        List<GcpProjectThreatAnalyticsEnablement>? GcpProjects = null,
        List<M365SubscriptionThreatAnalyticsEnablement>? M365Subscriptions = null
    ) 
    {
        if ( AllEnablementItems != null ) {
            this.AllEnablementItems = AllEnablementItems;
        }
        if ( AwsAccounts != null ) {
            this.AwsAccounts = AwsAccounts;
        }
        if ( AzureSubscriptions != null ) {
            this.AzureSubscriptions = AzureSubscriptions;
        }
        if ( CloudDirectClusters != null ) {
            this.CloudDirectClusters = CloudDirectClusters;
        }
        if ( GcpProjects != null ) {
            this.GcpProjects = GcpProjects;
        }
        if ( M365Subscriptions != null ) {
            this.M365Subscriptions = M365Subscriptions;
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
        //      C# -> List<ThreatAnalyticsEnablementItem>? AllEnablementItems
        // GraphQL -> allEnablementItems: [ThreatAnalyticsEnablementItem!]! (type)
        if (this.AllEnablementItems != null) {
            var fspec = this.AllEnablementItems.AsFieldSpec(conf.Child("allEnablementItems"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allEnablementItems" + "\n(" + this.Vars.AllEnablementItems.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsAccountThreatAnalyticsEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatAnalyticsEnablement!]! (type)
        if (this.AwsAccounts != null) {
            var fspec = this.AwsAccounts.AsFieldSpec(conf.Child("awsAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureSubscriptionThreatAnalyticsEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatAnalyticsEnablement!]! (type)
        if (this.AzureSubscriptions != null) {
            var fspec = this.AzureSubscriptions.AsFieldSpec(conf.Child("azureSubscriptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSubscriptions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CloudDirectClusterThreatAnalyticsEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterThreatAnalyticsEnablement!]! (type)
        if (this.CloudDirectClusters != null) {
            var fspec = this.CloudDirectClusters.AsFieldSpec(conf.Child("cloudDirectClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudDirectClusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<GcpProjectThreatAnalyticsEnablement>? GcpProjects
        // GraphQL -> gcpProjects: [GcpProjectThreatAnalyticsEnablement!]! (type)
        if (this.GcpProjects != null) {
            var fspec = this.GcpProjects.AsFieldSpec(conf.Child("gcpProjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "gcpProjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<M365SubscriptionThreatAnalyticsEnablement>? M365Subscriptions
        // GraphQL -> m365Subscriptions: [M365SubscriptionThreatAnalyticsEnablement!]! (type)
        if (this.M365Subscriptions != null) {
            var fspec = this.M365Subscriptions.AsFieldSpec(conf.Child("m365Subscriptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "m365Subscriptions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ThreatAnalyticsEnablementItem>? AllEnablementItems
        // GraphQL -> allEnablementItems: [ThreatAnalyticsEnablementItem!]! (type)
        if (ec.Includes("allEnablementItems",false))
        {
            if(this.AllEnablementItems == null) {

                this.AllEnablementItems = new List<ThreatAnalyticsEnablementItem>();
                this.AllEnablementItems.ApplyExploratoryFieldSpec(ec.NewChild("allEnablementItems"));

            } else {

                this.AllEnablementItems.ApplyExploratoryFieldSpec(ec.NewChild("allEnablementItems"));

            }
        }
        else if (this.AllEnablementItems != null && ec.Excludes("allEnablementItems",false))
        {
            this.AllEnablementItems = null;
        }
        //      C# -> List<AwsAccountThreatAnalyticsEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatAnalyticsEnablement!]! (type)
        if (ec.Includes("awsAccounts",false))
        {
            if(this.AwsAccounts == null) {

                this.AwsAccounts = new List<AwsAccountThreatAnalyticsEnablement>();
                this.AwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsAccounts"));

            } else {

                this.AwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsAccounts"));

            }
        }
        else if (this.AwsAccounts != null && ec.Excludes("awsAccounts",false))
        {
            this.AwsAccounts = null;
        }
        //      C# -> List<AzureSubscriptionThreatAnalyticsEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatAnalyticsEnablement!]! (type)
        if (ec.Includes("azureSubscriptions",false))
        {
            if(this.AzureSubscriptions == null) {

                this.AzureSubscriptions = new List<AzureSubscriptionThreatAnalyticsEnablement>();
                this.AzureSubscriptions.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptions"));

            } else {

                this.AzureSubscriptions.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptions"));

            }
        }
        else if (this.AzureSubscriptions != null && ec.Excludes("azureSubscriptions",false))
        {
            this.AzureSubscriptions = null;
        }
        //      C# -> List<CloudDirectClusterThreatAnalyticsEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterThreatAnalyticsEnablement!]! (type)
        if (ec.Includes("cloudDirectClusters",false))
        {
            if(this.CloudDirectClusters == null) {

                this.CloudDirectClusters = new List<CloudDirectClusterThreatAnalyticsEnablement>();
                this.CloudDirectClusters.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectClusters"));

            } else {

                this.CloudDirectClusters.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectClusters"));

            }
        }
        else if (this.CloudDirectClusters != null && ec.Excludes("cloudDirectClusters",false))
        {
            this.CloudDirectClusters = null;
        }
        //      C# -> List<GcpProjectThreatAnalyticsEnablement>? GcpProjects
        // GraphQL -> gcpProjects: [GcpProjectThreatAnalyticsEnablement!]! (type)
        if (ec.Includes("gcpProjects",false))
        {
            if(this.GcpProjects == null) {

                this.GcpProjects = new List<GcpProjectThreatAnalyticsEnablement>();
                this.GcpProjects.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjects"));

            } else {

                this.GcpProjects.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjects"));

            }
        }
        else if (this.GcpProjects != null && ec.Excludes("gcpProjects",false))
        {
            this.GcpProjects = null;
        }
        //      C# -> List<M365SubscriptionThreatAnalyticsEnablement>? M365Subscriptions
        // GraphQL -> m365Subscriptions: [M365SubscriptionThreatAnalyticsEnablement!]! (type)
        if (ec.Includes("m365Subscriptions",false))
        {
            if(this.M365Subscriptions == null) {

                this.M365Subscriptions = new List<M365SubscriptionThreatAnalyticsEnablement>();
                this.M365Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("m365Subscriptions"));

            } else {

                this.M365Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("m365Subscriptions"));

            }
        }
        else if (this.M365Subscriptions != null && ec.Excludes("m365Subscriptions",false))
        {
            this.M365Subscriptions = null;
        }
    }


    #endregion

    } // class ThreatAnalyticsEnablement
    
    #endregion

    public static class ListThreatAnalyticsEnablementExtensions
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
            this List<ThreatAnalyticsEnablement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatAnalyticsEnablement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatAnalyticsEnablement> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatAnalyticsEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatAnalyticsEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types