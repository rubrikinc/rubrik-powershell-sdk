// ManagedVolumeExportChannelStats.cs
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
    #region ManagedVolumeExportChannelStats
    public class ManagedVolumeExportChannelStats: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        [JsonProperty("totalSize")]
        public System.Int64? TotalSize { get; set; }

        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        [JsonProperty("usedSize")]
        public System.Int64? UsedSize { get; set; }


        #endregion

    #region methods

    public ManagedVolumeExportChannelStats Set(
        System.Int64? TotalSize = null,
        System.Int64? UsedSize = null
    ) 
    {
        if ( TotalSize != null ) {
            this.TotalSize = TotalSize;
        }
        if ( UsedSize != null ) {
            this.UsedSize = UsedSize;
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
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize != null) {
            s += ind + "totalSize\n" ;
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize != null) {
            s += ind + "usedSize\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize == null && Exploration.Includes(parent + ".totalSize", true))
        {
            this.TotalSize = new System.Int64();
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize == null && Exploration.Includes(parent + ".usedSize", true))
        {
            this.UsedSize = new System.Int64();
        }
    }


    #endregion

    } // class ManagedVolumeExportChannelStats
    
    #endregion

    public static class ListManagedVolumeExportChannelStatsExtensions
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
            this List<ManagedVolumeExportChannelStats> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExportChannelStats> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExportChannelStats());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types