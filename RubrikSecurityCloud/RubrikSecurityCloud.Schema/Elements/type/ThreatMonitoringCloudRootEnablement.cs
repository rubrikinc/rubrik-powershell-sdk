// ThreatMonitoringCloudRootEnablement.cs
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
    #region ThreatMonitoringCloudRootEnablement
    public class ThreatMonitoringCloudRootEnablement: BaseType
    {
        #region members

        //      C# -> List<AwsAccountThreatMonitoringEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatMonitoringEnablement!]! (type)
        [JsonProperty("awsAccounts")]
        public List<AwsAccountThreatMonitoringEnablement>? AwsAccounts { get; set; }

        //      C# -> List<AzureSubscriptionThreatMonitoringEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatMonitoringEnablement!]! (type)
        [JsonProperty("azureSubscriptions")]
        public List<AzureSubscriptionThreatMonitoringEnablement>? AzureSubscriptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringCloudRootEnablement";
    }

    public ThreatMonitoringCloudRootEnablement Set(
        List<AwsAccountThreatMonitoringEnablement>? AwsAccounts = null,
        List<AzureSubscriptionThreatMonitoringEnablement>? AzureSubscriptions = null
    ) 
    {
        if ( AwsAccounts != null ) {
            this.AwsAccounts = AwsAccounts;
        }
        if ( AzureSubscriptions != null ) {
            this.AzureSubscriptions = AzureSubscriptions;
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
        //      C# -> List<AwsAccountThreatMonitoringEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatMonitoringEnablement!]! (type)
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
        //      C# -> List<AzureSubscriptionThreatMonitoringEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatMonitoringEnablement!]! (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsAccountThreatMonitoringEnablement>? AwsAccounts
        // GraphQL -> awsAccounts: [AwsAccountThreatMonitoringEnablement!]! (type)
        if (ec.Includes("awsAccounts",false))
        {
            if(this.AwsAccounts == null) {

                this.AwsAccounts = new List<AwsAccountThreatMonitoringEnablement>();
                this.AwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsAccounts"));

            } else {

                this.AwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsAccounts"));

            }
        }
        else if (this.AwsAccounts != null && ec.Excludes("awsAccounts",false))
        {
            this.AwsAccounts = null;
        }
        //      C# -> List<AzureSubscriptionThreatMonitoringEnablement>? AzureSubscriptions
        // GraphQL -> azureSubscriptions: [AzureSubscriptionThreatMonitoringEnablement!]! (type)
        if (ec.Includes("azureSubscriptions",false))
        {
            if(this.AzureSubscriptions == null) {

                this.AzureSubscriptions = new List<AzureSubscriptionThreatMonitoringEnablement>();
                this.AzureSubscriptions.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptions"));

            } else {

                this.AzureSubscriptions.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptions"));

            }
        }
        else if (this.AzureSubscriptions != null && ec.Excludes("azureSubscriptions",false))
        {
            this.AzureSubscriptions = null;
        }
    }


    #endregion

    } // class ThreatMonitoringCloudRootEnablement
    
    #endregion

    public static class ListThreatMonitoringCloudRootEnablementExtensions
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
            this List<ThreatMonitoringCloudRootEnablement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringCloudRootEnablement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringCloudRootEnablement> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringCloudRootEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringCloudRootEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types