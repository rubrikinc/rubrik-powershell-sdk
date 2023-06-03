// VmwareSnapshotVmConfig.cs
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
    #region VmwareSnapshotVmConfig
    public class VmwareSnapshotVmConfig: BaseType
    {
        #region members

        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        [JsonProperty("networkConfig")]
        public VmwareNetworkConfig? NetworkConfig { get; set; }


        #endregion

    #region methods

    public VmwareSnapshotVmConfig Set(
        VmwareNetworkConfig? NetworkConfig = null
    ) 
    {
        if ( NetworkConfig != null ) {
            this.NetworkConfig = NetworkConfig;
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
        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        if (this.NetworkConfig != null) {
            s += ind + "networkConfig {\n" + this.NetworkConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        if (this.NetworkConfig == null && Exploration.Includes(parent + ".networkConfig"))
        {
            this.NetworkConfig = new VmwareNetworkConfig();
            this.NetworkConfig.ApplyExploratoryFieldSpec(parent + ".networkConfig");
        }
    }


    #endregion

    } // class VmwareSnapshotVmConfig
    
    #endregion

    public static class ListVmwareSnapshotVmConfigExtensions
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
            this List<VmwareSnapshotVmConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareSnapshotVmConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareSnapshotVmConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types