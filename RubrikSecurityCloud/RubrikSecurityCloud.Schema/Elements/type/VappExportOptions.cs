// VappExportOptions.cs
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
    #region VappExportOptions
    public class VappExportOptions: BaseType
    {
        #region members

        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        [JsonProperty("allChildVmsWithDefaultNetworkConnections")]
        public List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections { get; set; }

        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        [JsonProperty("availableStoragePolicies")]
        public List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies { get; set; }

        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        [JsonProperty("restorableNetworks")]
        public List<CreateVappNetworkParams>? RestorableNetworks { get; set; }

        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        [JsonProperty("targetVappNetworks")]
        public List<VappNetworkSummary>? TargetVappNetworks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappExportOptions";
    }

    public VappExportOptions Set(
        List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections = null,
        List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies = null,
        List<CreateVappNetworkParams>? RestorableNetworks = null,
        List<VappNetworkSummary>? TargetVappNetworks = null
    ) 
    {
        if ( AllChildVmsWithDefaultNetworkConnections != null ) {
            this.AllChildVmsWithDefaultNetworkConnections = AllChildVmsWithDefaultNetworkConnections;
        }
        if ( AvailableStoragePolicies != null ) {
            this.AvailableStoragePolicies = AvailableStoragePolicies;
        }
        if ( RestorableNetworks != null ) {
            this.RestorableNetworks = RestorableNetworks;
        }
        if ( TargetVappNetworks != null ) {
            this.TargetVappNetworks = TargetVappNetworks;
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
        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        if (this.AllChildVmsWithDefaultNetworkConnections != null) {
            var fspec = this.AllChildVmsWithDefaultNetworkConnections.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allChildVmsWithDefaultNetworkConnections {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            var fspec = this.AvailableStoragePolicies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "availableStoragePolicies {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (this.RestorableNetworks != null) {
            var fspec = this.RestorableNetworks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "restorableNetworks {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (this.TargetVappNetworks != null) {
            var fspec = this.TargetVappNetworks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetVappNetworks {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        if (this.AllChildVmsWithDefaultNetworkConnections == null && ec.Includes("allChildVmsWithDefaultNetworkConnections",false))
        {
            this.AllChildVmsWithDefaultNetworkConnections = new List<VappVmRestoreSpec>();
            this.AllChildVmsWithDefaultNetworkConnections.ApplyExploratoryFieldSpec(ec.NewChild("allChildVmsWithDefaultNetworkConnections"));
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies == null && ec.Includes("availableStoragePolicies",false))
        {
            this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
            this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (this.RestorableNetworks == null && ec.Includes("restorableNetworks",false))
        {
            this.RestorableNetworks = new List<CreateVappNetworkParams>();
            this.RestorableNetworks.ApplyExploratoryFieldSpec(ec.NewChild("restorableNetworks"));
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (this.TargetVappNetworks == null && ec.Includes("targetVappNetworks",false))
        {
            this.TargetVappNetworks = new List<VappNetworkSummary>();
            this.TargetVappNetworks.ApplyExploratoryFieldSpec(ec.NewChild("targetVappNetworks"));
        }
    }


    #endregion

    } // class VappExportOptions
    
    #endregion

    public static class ListVappExportOptionsExtensions
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
            this List<VappExportOptions> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappExportOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VappExportOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types