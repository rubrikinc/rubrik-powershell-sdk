// VappInstantRecoveryOptions.cs
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
    #region VappInstantRecoveryOptions
    public class VappInstantRecoveryOptions: BaseType
    {
        #region members

        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        [JsonProperty("availableVappNetworks")]
        public List<VappNetworkSummary>? AvailableVappNetworks { get; set; }

        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        [JsonProperty("restorableVms")]
        public List<VappVmRestoreSpec>? RestorableVms { get; set; }


        #endregion

    #region methods

    public VappInstantRecoveryOptions Set(
        List<VappNetworkSummary>? AvailableVappNetworks = null,
        List<VappVmRestoreSpec>? RestorableVms = null
    ) 
    {
        if ( AvailableVappNetworks != null ) {
            this.AvailableVappNetworks = AvailableVappNetworks;
        }
        if ( RestorableVms != null ) {
            this.RestorableVms = RestorableVms;
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
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        if (this.AvailableVappNetworks != null) {
            var fspec = this.AvailableVappNetworks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "availableVappNetworks {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        if (this.RestorableVms != null) {
            var fspec = this.RestorableVms.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "restorableVms {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        if (this.AvailableVappNetworks == null && Exploration.Includes(parent + ".availableVappNetworks"))
        {
            this.AvailableVappNetworks = new List<VappNetworkSummary>();
            this.AvailableVappNetworks.ApplyExploratoryFieldSpec(parent + ".availableVappNetworks");
        }
        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        if (this.RestorableVms == null && Exploration.Includes(parent + ".restorableVms"))
        {
            this.RestorableVms = new List<VappVmRestoreSpec>();
            this.RestorableVms.ApplyExploratoryFieldSpec(parent + ".restorableVms");
        }
    }


    #endregion

    } // class VappInstantRecoveryOptions
    
    #endregion

    public static class ListVappInstantRecoveryOptionsExtensions
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
            this List<VappInstantRecoveryOptions> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappInstantRecoveryOptions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappInstantRecoveryOptions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types