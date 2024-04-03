// ClusterCapacityQuota.cs
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
    #region ClusterCapacityQuota
    public class ClusterCapacityQuota: BaseType
    {
        #region members

        //      C# -> ClusterCapacityQuotaType? ClusterCapacityQuotaType
        // GraphQL -> clusterCapacityQuotaType: ClusterCapacityQuotaType! (enum)
        [JsonProperty("clusterCapacityQuotaType")]
        public ClusterCapacityQuotaType? ClusterCapacityQuotaType { get; set; }

        //      C# -> System.Int64? CurrentUsageGb
        // GraphQL -> currentUsageGb: Long! (scalar)
        [JsonProperty("currentUsageGb")]
        public System.Int64? CurrentUsageGb { get; set; }

        //      C# -> System.Int64? HardLimitGb
        // GraphQL -> hardLimitGb: Long! (scalar)
        [JsonProperty("hardLimitGb")]
        public System.Int64? HardLimitGb { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.Int64? SoftLimitGb
        // GraphQL -> softLimitGb: Long! (scalar)
        [JsonProperty("softLimitGb")]
        public System.Int64? SoftLimitGb { get; set; }

        //      C# -> DateTime? UsageComputedAt
        // GraphQL -> usageComputedAt: DateTime (scalar)
        [JsonProperty("usageComputedAt")]
        public DateTime? UsageComputedAt { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterCapacityQuota";
    }

    public ClusterCapacityQuota Set(
        ClusterCapacityQuotaType? ClusterCapacityQuotaType = null,
        System.Int64? CurrentUsageGb = null,
        System.Int64? HardLimitGb = null,
        System.String? OrgId = null,
        System.Int64? SoftLimitGb = null,
        DateTime? UsageComputedAt = null,
        Cluster? Cluster = null
    ) 
    {
        if ( ClusterCapacityQuotaType != null ) {
            this.ClusterCapacityQuotaType = ClusterCapacityQuotaType;
        }
        if ( CurrentUsageGb != null ) {
            this.CurrentUsageGb = CurrentUsageGb;
        }
        if ( HardLimitGb != null ) {
            this.HardLimitGb = HardLimitGb;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( SoftLimitGb != null ) {
            this.SoftLimitGb = SoftLimitGb;
        }
        if ( UsageComputedAt != null ) {
            this.UsageComputedAt = UsageComputedAt;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> ClusterCapacityQuotaType? ClusterCapacityQuotaType
        // GraphQL -> clusterCapacityQuotaType: ClusterCapacityQuotaType! (enum)
        if (this.ClusterCapacityQuotaType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterCapacityQuotaType\n" ;
            } else {
                s += ind + "clusterCapacityQuotaType\n" ;
            }
        }
        //      C# -> System.Int64? CurrentUsageGb
        // GraphQL -> currentUsageGb: Long! (scalar)
        if (this.CurrentUsageGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentUsageGb\n" ;
            } else {
                s += ind + "currentUsageGb\n" ;
            }
        }
        //      C# -> System.Int64? HardLimitGb
        // GraphQL -> hardLimitGb: Long! (scalar)
        if (this.HardLimitGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hardLimitGb\n" ;
            } else {
                s += ind + "hardLimitGb\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.Int64? SoftLimitGb
        // GraphQL -> softLimitGb: Long! (scalar)
        if (this.SoftLimitGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "softLimitGb\n" ;
            } else {
                s += ind + "softLimitGb\n" ;
            }
        }
        //      C# -> DateTime? UsageComputedAt
        // GraphQL -> usageComputedAt: DateTime (scalar)
        if (this.UsageComputedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usageComputedAt\n" ;
            } else {
                s += ind + "usageComputedAt\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterCapacityQuotaType? ClusterCapacityQuotaType
        // GraphQL -> clusterCapacityQuotaType: ClusterCapacityQuotaType! (enum)
        if (ec.Includes("clusterCapacityQuotaType",true))
        {
            if(this.ClusterCapacityQuotaType == null) {

                this.ClusterCapacityQuotaType = new ClusterCapacityQuotaType();

            } else {


            }
        }
        else if (this.ClusterCapacityQuotaType != null && ec.Excludes("clusterCapacityQuotaType",true))
        {
            this.ClusterCapacityQuotaType = null;
        }
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
        //      C# -> System.Int64? HardLimitGb
        // GraphQL -> hardLimitGb: Long! (scalar)
        if (ec.Includes("hardLimitGb",true))
        {
            if(this.HardLimitGb == null) {

                this.HardLimitGb = new System.Int64();

            } else {


            }
        }
        else if (this.HardLimitGb != null && ec.Excludes("hardLimitGb",true))
        {
            this.HardLimitGb = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.Int64? SoftLimitGb
        // GraphQL -> softLimitGb: Long! (scalar)
        if (ec.Includes("softLimitGb",true))
        {
            if(this.SoftLimitGb == null) {

                this.SoftLimitGb = new System.Int64();

            } else {


            }
        }
        else if (this.SoftLimitGb != null && ec.Excludes("softLimitGb",true))
        {
            this.SoftLimitGb = null;
        }
        //      C# -> DateTime? UsageComputedAt
        // GraphQL -> usageComputedAt: DateTime (scalar)
        if (ec.Includes("usageComputedAt",true))
        {
            if(this.UsageComputedAt == null) {

                this.UsageComputedAt = new DateTime();

            } else {


            }
        }
        else if (this.UsageComputedAt != null && ec.Excludes("usageComputedAt",true))
        {
            this.UsageComputedAt = null;
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
    }


    #endregion

    } // class ClusterCapacityQuota
    
    #endregion

    public static class ListClusterCapacityQuotaExtensions
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
            this List<ClusterCapacityQuota> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterCapacityQuota> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterCapacityQuota> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterCapacityQuota());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterCapacityQuota> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types