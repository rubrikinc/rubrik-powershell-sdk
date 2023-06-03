// RestoreFormConfigurationReplicationTarget.cs
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
    #region RestoreFormConfigurationReplicationTarget
    public class RestoreFormConfigurationReplicationTarget: BaseType
    {
        #region members

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String! (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }


        #endregion

    #region methods

    public RestoreFormConfigurationReplicationTarget Set(
        System.String? TargetClusterAddress = null,
        System.String? TargetClusterName = null
    ) 
    {
        if ( TargetClusterAddress != null ) {
            this.TargetClusterAddress = TargetClusterAddress;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
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
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String! (scalar)
        if (this.TargetClusterAddress != null) {
            s += ind + "targetClusterAddress\n" ;
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String (scalar)
        if (this.TargetClusterName != null) {
            s += ind + "targetClusterName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String! (scalar)
        if (this.TargetClusterAddress == null && Exploration.Includes(parent + ".targetClusterAddress", true))
        {
            this.TargetClusterAddress = new System.String("FETCH");
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String (scalar)
        if (this.TargetClusterName == null && Exploration.Includes(parent + ".targetClusterName", true))
        {
            this.TargetClusterName = new System.String("FETCH");
        }
    }


    #endregion

    } // class RestoreFormConfigurationReplicationTarget
    
    #endregion

    public static class ListRestoreFormConfigurationReplicationTargetExtensions
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
            this List<RestoreFormConfigurationReplicationTarget> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationReplicationTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types