// ClusterVisibilityConfig.cs
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
    #region ClusterVisibilityConfig
    public class ClusterVisibilityConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        [JsonProperty("hostGroupFilter")]
        public List<System.String>? HostGroupFilter { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        [JsonProperty("isVmwareMetroStorageCluster")]
        public System.Boolean? IsVmwareMetroStorageCluster { get; set; }


        #endregion

    #region methods

    public ClusterVisibilityConfig Set(
        List<System.String>? HostGroupFilter = null,
        System.String? Id = null,
        System.Boolean? IsVmwareMetroStorageCluster = null
    ) 
    {
        if ( HostGroupFilter != null ) {
            this.HostGroupFilter = HostGroupFilter;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVmwareMetroStorageCluster != null ) {
            this.IsVmwareMetroStorageCluster = IsVmwareMetroStorageCluster;
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
        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        if (this.HostGroupFilter != null) {
            s += ind + "hostGroupFilter\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        if (this.IsVmwareMetroStorageCluster != null) {
            s += ind + "isVmwareMetroStorageCluster\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        if (this.HostGroupFilter == null && Exploration.Includes(parent + ".hostGroupFilter", true))
        {
            this.HostGroupFilter = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        if (this.IsVmwareMetroStorageCluster == null && Exploration.Includes(parent + ".isVmwareMetroStorageCluster", true))
        {
            this.IsVmwareMetroStorageCluster = true;
        }
    }


    #endregion

    } // class ClusterVisibilityConfig
    
    #endregion

    public static class ListClusterVisibilityConfigExtensions
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
            this List<ClusterVisibilityConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types