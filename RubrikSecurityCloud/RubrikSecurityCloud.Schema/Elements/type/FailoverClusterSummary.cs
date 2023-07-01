// FailoverClusterSummary.cs
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
    #region FailoverClusterSummary
    public class FailoverClusterSummary: BaseType
    {
        #region members

        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        [JsonProperty("operatingSystemType")]
        public FailoverClusterOsType? OperatingSystemType { get; set; }

        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignment? SlaAssignment { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
        [JsonProperty("nodes")]
        public List<FailoverClusterNode>? Nodes { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterSummary";
    }

    public FailoverClusterSummary Set(
        FailoverClusterConnectionStatus? ConnectionStatus = null,
        FailoverClusterOsType? OperatingSystemType = null,
        SlaAssignment? SlaAssignment = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        List<FailoverClusterNode>? Nodes = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
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
        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            var fspec = this.EffectiveSlaHolder.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaHolder {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
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
        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new FailoverClusterConnectionStatus();
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType", true))
        {
            this.OperatingSystemType = new FailoverClusterOsType();
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignment();
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
        {
            this.EffectiveSlaHolder = new EffectiveSlaHolder();
            this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(parent + ".effectiveSlaHolder");
        }
        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<FailoverClusterNode>();
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

    } // class FailoverClusterSummary
    
    #endregion

    public static class ListFailoverClusterSummaryExtensions
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
            this List<FailoverClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types