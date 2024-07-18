// ClusterWithCapacityQuota.cs
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
    #region ClusterWithCapacityQuota
    public class ClusterWithCapacityQuota: BaseType
    {
        #region members

        //      C# -> System.Int64? CurrentUsageGb
        // GraphQL -> currentUsageGb: Long! (scalar)
        [JsonProperty("currentUsageGb")]
        public System.Int64? CurrentUsageGb { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ClusterCapacityQuota? QuotaOpt
        // GraphQL -> quotaOpt: ClusterCapacityQuota (type)
        [JsonProperty("quotaOpt")]
        public ClusterCapacityQuota? QuotaOpt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterWithCapacityQuota";
    }

    public ClusterWithCapacityQuota Set(
        System.Int64? CurrentUsageGb = null,
        Cluster? Cluster = null,
        ClusterCapacityQuota? QuotaOpt = null
    ) 
    {
        if ( CurrentUsageGb != null ) {
            this.CurrentUsageGb = CurrentUsageGb;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( QuotaOpt != null ) {
            this.QuotaOpt = QuotaOpt;
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
        //      C# -> System.Int64? CurrentUsageGb
        // GraphQL -> currentUsageGb: Long! (scalar)
        if (this.CurrentUsageGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentUsageGb\n" ;
            } else {
                s += ind + "currentUsageGb\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterCapacityQuota? QuotaOpt
        // GraphQL -> quotaOpt: ClusterCapacityQuota (type)
        if (this.QuotaOpt != null) {
            var fspec = this.QuotaOpt.AsFieldSpec(conf.Child("quotaOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "quotaOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CurrentUsageGb
        // GraphQL -> currentUsageGb: Long! (scalar)
        if (ec.Includes("currentUsageGb",true))
        {
            if(this.CurrentUsageGb == null) {

                this.CurrentUsageGb = new System.Int64();

            } else {


            }
        }
        else if (this.CurrentUsageGb != null && ec.Excludes("currentUsageGb",true))
        {
            this.CurrentUsageGb = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> ClusterCapacityQuota? QuotaOpt
        // GraphQL -> quotaOpt: ClusterCapacityQuota (type)
        if (ec.Includes("quotaOpt",false))
        {
            if(this.QuotaOpt == null) {

                this.QuotaOpt = new ClusterCapacityQuota();
                this.QuotaOpt.ApplyExploratoryFieldSpec(ec.NewChild("quotaOpt"));

            } else {

                this.QuotaOpt.ApplyExploratoryFieldSpec(ec.NewChild("quotaOpt"));

            }
        }
        else if (this.QuotaOpt != null && ec.Excludes("quotaOpt",false))
        {
            this.QuotaOpt = null;
        }
    }


    #endregion

    } // class ClusterWithCapacityQuota
    
    #endregion

    public static class ListClusterWithCapacityQuotaExtensions
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
            this List<ClusterWithCapacityQuota> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterWithCapacityQuota> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWithCapacityQuota> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWithCapacityQuota());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterWithCapacityQuota> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types