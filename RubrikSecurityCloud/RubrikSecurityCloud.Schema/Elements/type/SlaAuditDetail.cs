// SlaAuditDetail.cs
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
    #region SlaAuditDetail
    public class SlaAuditDetail: BaseType
    {
        #region members

        //      C# -> SlaDomain? CurrentSlaSummary
        // GraphQL -> currentSlaSummary: SlaDomain (interface)
        [JsonProperty("currentSlaSummary")]
        public SlaDomain? CurrentSlaSummary { get; set; }

        //      C# -> SlaDomain? PreviousSlaSummary
        // GraphQL -> previousSlaSummary: SlaDomain (interface)
        [JsonProperty("previousSlaSummary")]
        public SlaDomain? PreviousSlaSummary { get; set; }

        //      C# -> System.Boolean? ApplyToExistingSnapshots
        // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
        [JsonProperty("applyToExistingSnapshots")]
        public System.Boolean? ApplyToExistingSnapshots { get; set; }

        //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
        // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
        [JsonProperty("applyToOndemandAndDownloadedSnapshots")]
        public System.Boolean? ApplyToOndemandAndDownloadedSnapshots { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> System.String? UserAction
        // GraphQL -> userAction: String! (scalar)
        [JsonProperty("userAction")]
        public System.String? UserAction { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaAuditDetail";
    }

    public SlaAuditDetail Set(
        SlaDomain? CurrentSlaSummary = null,
        SlaDomain? PreviousSlaSummary = null,
        System.Boolean? ApplyToExistingSnapshots = null,
        System.Boolean? ApplyToOndemandAndDownloadedSnapshots = null,
        DateTime? Timestamp = null,
        System.String? UserAction = null,
        System.String? UserName = null,
        Cluster? Cluster = null
    ) 
    {
        if ( CurrentSlaSummary != null ) {
            this.CurrentSlaSummary = CurrentSlaSummary;
        }
        if ( PreviousSlaSummary != null ) {
            this.PreviousSlaSummary = PreviousSlaSummary;
        }
        if ( ApplyToExistingSnapshots != null ) {
            this.ApplyToExistingSnapshots = ApplyToExistingSnapshots;
        }
        if ( ApplyToOndemandAndDownloadedSnapshots != null ) {
            this.ApplyToOndemandAndDownloadedSnapshots = ApplyToOndemandAndDownloadedSnapshots;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( UserAction != null ) {
            this.UserAction = UserAction;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> SlaDomain? CurrentSlaSummary
        // GraphQL -> currentSlaSummary: SlaDomain (interface)
        if (this.CurrentSlaSummary != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CurrentSlaSummary).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentSlaSummary {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? PreviousSlaSummary
        // GraphQL -> previousSlaSummary: SlaDomain (interface)
        if (this.PreviousSlaSummary != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PreviousSlaSummary).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "previousSlaSummary {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Boolean? ApplyToExistingSnapshots
        // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
        if (this.ApplyToExistingSnapshots != null) {
            s += ind + "applyToExistingSnapshots\n" ;
        }
        //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
        // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
        if (this.ApplyToOndemandAndDownloadedSnapshots != null) {
            s += ind + "applyToOndemandAndDownloadedSnapshots\n" ;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        //      C# -> System.String? UserAction
        // GraphQL -> userAction: String! (scalar)
        if (this.UserAction != null) {
            s += ind + "userAction\n" ;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (this.UserName != null) {
            s += ind + "userName\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaDomain? CurrentSlaSummary
        // GraphQL -> currentSlaSummary: SlaDomain (interface)
        if (this.CurrentSlaSummary == null && ec.Includes("currentSlaSummary",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("currentSlaSummary"));
            this.CurrentSlaSummary = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PreviousSlaSummary
        // GraphQL -> previousSlaSummary: SlaDomain (interface)
        if (this.PreviousSlaSummary == null && ec.Includes("previousSlaSummary",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("previousSlaSummary"));
            this.PreviousSlaSummary = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Boolean? ApplyToExistingSnapshots
        // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
        if (this.ApplyToExistingSnapshots == null && ec.Includes("applyToExistingSnapshots",true))
        {
            this.ApplyToExistingSnapshots = true;
        }
        //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
        // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
        if (this.ApplyToOndemandAndDownloadedSnapshots == null && ec.Includes("applyToOndemandAndDownloadedSnapshots",true))
        {
            this.ApplyToOndemandAndDownloadedSnapshots = true;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && ec.Includes("timestamp",true))
        {
            this.Timestamp = new DateTime();
        }
        //      C# -> System.String? UserAction
        // GraphQL -> userAction: String! (scalar)
        if (this.UserAction == null && ec.Includes("userAction",true))
        {
            this.UserAction = "FETCH";
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (this.UserName == null && ec.Includes("userName",true))
        {
            this.UserName = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class SlaAuditDetail
    
    #endregion

    public static class ListSlaAuditDetailExtensions
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
            this List<SlaAuditDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaAuditDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaAuditDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaAuditDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types