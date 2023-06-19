// DataDiscoveryObjectsCount.cs
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
    #region DataDiscoveryObjectsCount
    public class DataDiscoveryObjectsCount: BaseType
    {
        #region members

        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryAssignedCount")]
        public System.Int64? DataDiscoveryAssignedCount { get; set; }

        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryNotAssignedCount")]
        public System.Int64? DataDiscoveryNotAssignedCount { get; set; }

        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryNotSupportedCount")]
        public System.Int64? DataDiscoveryNotSupportedCount { get; set; }


        #endregion

    #region methods

    public DataDiscoveryObjectsCount Set(
        System.Int64? DataDiscoveryAssignedCount = null,
        System.Int64? DataDiscoveryNotAssignedCount = null,
        System.Int64? DataDiscoveryNotSupportedCount = null
    ) 
    {
        if ( DataDiscoveryAssignedCount != null ) {
            this.DataDiscoveryAssignedCount = DataDiscoveryAssignedCount;
        }
        if ( DataDiscoveryNotAssignedCount != null ) {
            this.DataDiscoveryNotAssignedCount = DataDiscoveryNotAssignedCount;
        }
        if ( DataDiscoveryNotSupportedCount != null ) {
            this.DataDiscoveryNotSupportedCount = DataDiscoveryNotSupportedCount;
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
        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        if (this.DataDiscoveryAssignedCount != null) {
            s += ind + "dataDiscoveryAssignedCount\n" ;
        }
        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        if (this.DataDiscoveryNotAssignedCount != null) {
            s += ind + "dataDiscoveryNotAssignedCount\n" ;
        }
        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        if (this.DataDiscoveryNotSupportedCount != null) {
            s += ind + "dataDiscoveryNotSupportedCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        if (this.DataDiscoveryAssignedCount == null && Exploration.Includes(parent + ".dataDiscoveryAssignedCount", true))
        {
            this.DataDiscoveryAssignedCount = new System.Int64();
        }
        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        if (this.DataDiscoveryNotAssignedCount == null && Exploration.Includes(parent + ".dataDiscoveryNotAssignedCount", true))
        {
            this.DataDiscoveryNotAssignedCount = new System.Int64();
        }
        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        if (this.DataDiscoveryNotSupportedCount == null && Exploration.Includes(parent + ".dataDiscoveryNotSupportedCount", true))
        {
            this.DataDiscoveryNotSupportedCount = new System.Int64();
        }
    }


    #endregion

    } // class DataDiscoveryObjectsCount
    
    #endregion

    public static class ListDataDiscoveryObjectsCountExtensions
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
            this List<DataDiscoveryObjectsCount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DataDiscoveryObjectsCount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DataDiscoveryObjectsCount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types