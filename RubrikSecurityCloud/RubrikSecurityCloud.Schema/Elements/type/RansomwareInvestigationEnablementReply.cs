// RansomwareInvestigationEnablementReply.cs
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
    #region RansomwareInvestigationEnablementReply
    public class RansomwareInvestigationEnablementReply: BaseType
    {
        #region members

        //      C# -> List<CloudDirectClusterRansomwareInvestigationEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterRansomwareInvestigationEnablement!] (type)
        [JsonProperty("cloudDirectClusters")]
        public List<CloudDirectClusterRansomwareInvestigationEnablement>? CloudDirectClusters { get; set; }

        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        [JsonProperty("microsoft365Subscriptions")]
        public List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions { get; set; }

        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        [JsonProperty("rubrikCloudVaultLocations")]
        public List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareInvestigationEnablementReply";
    }

    public RansomwareInvestigationEnablementReply Set(
        List<CloudDirectClusterRansomwareInvestigationEnablement>? CloudDirectClusters = null,
        List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions = null,
        List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations = null
    ) 
    {
        if ( CloudDirectClusters != null ) {
            this.CloudDirectClusters = CloudDirectClusters;
        }
        if ( Microsoft365Subscriptions != null ) {
            this.Microsoft365Subscriptions = Microsoft365Subscriptions;
        }
        if ( RubrikCloudVaultLocations != null ) {
            this.RubrikCloudVaultLocations = RubrikCloudVaultLocations;
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
        //      C# -> List<CloudDirectClusterRansomwareInvestigationEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterRansomwareInvestigationEnablement!] (type)
        if (this.CloudDirectClusters != null) {
            var fspec = this.CloudDirectClusters.AsFieldSpec(conf.Child("cloudDirectClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudDirectClusters {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        if (this.Microsoft365Subscriptions != null) {
            var fspec = this.Microsoft365Subscriptions.AsFieldSpec(conf.Child("microsoft365Subscriptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "microsoft365Subscriptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        if (this.RubrikCloudVaultLocations != null) {
            var fspec = this.RubrikCloudVaultLocations.AsFieldSpec(conf.Child("rubrikCloudVaultLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikCloudVaultLocations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudDirectClusterRansomwareInvestigationEnablement>? CloudDirectClusters
        // GraphQL -> cloudDirectClusters: [CloudDirectClusterRansomwareInvestigationEnablement!] (type)
        if (ec.Includes("cloudDirectClusters",false))
        {
            if(this.CloudDirectClusters == null) {

                this.CloudDirectClusters = new List<CloudDirectClusterRansomwareInvestigationEnablement>();
                this.CloudDirectClusters.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectClusters"));

            } else {

                this.CloudDirectClusters.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectClusters"));

            }
        }
        else if (this.CloudDirectClusters != null && ec.Excludes("cloudDirectClusters",false))
        {
            this.CloudDirectClusters = null;
        }
        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        if (ec.Includes("microsoft365Subscriptions",false))
        {
            if(this.Microsoft365Subscriptions == null) {

                this.Microsoft365Subscriptions = new List<Microsoft365RansomwareInvestigationEnablement>();
                this.Microsoft365Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("microsoft365Subscriptions"));

            } else {

                this.Microsoft365Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("microsoft365Subscriptions"));

            }
        }
        else if (this.Microsoft365Subscriptions != null && ec.Excludes("microsoft365Subscriptions",false))
        {
            this.Microsoft365Subscriptions = null;
        }
        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        if (ec.Includes("rubrikCloudVaultLocations",false))
        {
            if(this.RubrikCloudVaultLocations == null) {

                this.RubrikCloudVaultLocations = new List<RubrikCloudVaultRansomwareInvestigationEnablement>();
                this.RubrikCloudVaultLocations.ApplyExploratoryFieldSpec(ec.NewChild("rubrikCloudVaultLocations"));

            } else {

                this.RubrikCloudVaultLocations.ApplyExploratoryFieldSpec(ec.NewChild("rubrikCloudVaultLocations"));

            }
        }
        else if (this.RubrikCloudVaultLocations != null && ec.Excludes("rubrikCloudVaultLocations",false))
        {
            this.RubrikCloudVaultLocations = null;
        }
    }


    #endregion

    } // class RansomwareInvestigationEnablementReply
    
    #endregion

    public static class ListRansomwareInvestigationEnablementReplyExtensions
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
            this List<RansomwareInvestigationEnablementReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RansomwareInvestigationEnablementReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareInvestigationEnablementReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareInvestigationEnablementReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RansomwareInvestigationEnablementReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types