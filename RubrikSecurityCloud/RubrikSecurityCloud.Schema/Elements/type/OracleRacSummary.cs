// OracleRacSummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OracleRacSummary
    public class OracleRacSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        [JsonProperty("shouldDistributeBackupsAutomatically")]
        public System.Boolean? ShouldDistributeBackupsAutomatically { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        [JsonProperty("nodeOrder")]
        public List<OracleNodeOrder>? NodeOrder { get; set; }

        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        [JsonProperty("nodes")]
        public List<OracleNodeProperties>? Nodes { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public OracleRacSummary Set(
        System.Boolean? HasLogConfigFromSla = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumDbs = null,
        System.Int32? NumNodes = null,
        System.String? PrimaryClusterId = null,
        System.Boolean? ShouldDistributeBackupsAutomatically = null,
        System.String? Status = null,
        List<OracleNodeOrder>? NodeOrder = null,
        List<OracleNodeProperties>? Nodes = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( NumNodes != null ) {
            this.NumNodes = NumNodes;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( ShouldDistributeBackupsAutomatically != null ) {
            this.ShouldDistributeBackupsAutomatically = ShouldDistributeBackupsAutomatically;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( NodeOrder != null ) {
            this.NodeOrder = NodeOrder;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            s += ind + "hasLogConfigFromSla\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs != null) {
            s += ind + "numDbs\n" ;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes != null) {
            s += ind + "numNodes\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        if (this.ShouldDistributeBackupsAutomatically != null) {
            s += ind + "shouldDistributeBackupsAutomatically\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        if (this.NodeOrder != null) {
            var fspec = this.NodeOrder.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodeOrder {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla", true))
        {
            this.HasLogConfigFromSla = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs == null && Exploration.Includes(parent + ".numDbs", true))
        {
            this.NumDbs = Int32.MinValue;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes == null && Exploration.Includes(parent + ".numNodes", true))
        {
            this.NumNodes = Int32.MinValue;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        if (this.ShouldDistributeBackupsAutomatically == null && Exploration.Includes(parent + ".shouldDistributeBackupsAutomatically", true))
        {
            this.ShouldDistributeBackupsAutomatically = true;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        if (this.NodeOrder == null && Exploration.Includes(parent + ".nodeOrder"))
        {
            this.NodeOrder = new List<OracleNodeOrder>();
            this.NodeOrder.ApplyExploratoryFieldSpec(parent + ".nodeOrder");
        }
        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<OracleNodeProperties>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class OracleRacSummary
    
    #endregion

    public static class ListOracleRacSummaryExtensions
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
            this List<OracleRacSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleRacSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRacSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types