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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "allChildVmsWithDefaultNetworkConnections {\n" + this.AllChildVmsWithDefaultNetworkConnections.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            s += ind + "availableStoragePolicies {\n" + this.AvailableStoragePolicies.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (this.RestorableNetworks != null) {
            s += ind + "restorableNetworks {\n" + this.RestorableNetworks.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (this.TargetVappNetworks != null) {
            s += ind + "targetVappNetworks {\n" + this.TargetVappNetworks.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        if (this.AllChildVmsWithDefaultNetworkConnections == null && Exploration.Includes(parent + ".allChildVmsWithDefaultNetworkConnections"))
        {
            this.AllChildVmsWithDefaultNetworkConnections = new List<VappVmRestoreSpec>();
            this.AllChildVmsWithDefaultNetworkConnections.ApplyExploratoryFieldSpec(parent + ".allChildVmsWithDefaultNetworkConnections");
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies == null && Exploration.Includes(parent + ".availableStoragePolicies"))
        {
            this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
            this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(parent + ".availableStoragePolicies");
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (this.RestorableNetworks == null && Exploration.Includes(parent + ".restorableNetworks"))
        {
            this.RestorableNetworks = new List<CreateVappNetworkParams>();
            this.RestorableNetworks.ApplyExploratoryFieldSpec(parent + ".restorableNetworks");
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (this.TargetVappNetworks == null && Exploration.Includes(parent + ".targetVappNetworks"))
        {
            this.TargetVappNetworks = new List<VappNetworkSummary>();
            this.TargetVappNetworks.ApplyExploratoryFieldSpec(parent + ".targetVappNetworks");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappExportOptions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types