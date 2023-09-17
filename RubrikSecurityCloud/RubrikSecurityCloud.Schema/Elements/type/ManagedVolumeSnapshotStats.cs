// ManagedVolumeSnapshotStats.cs
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
    #region ManagedVolumeSnapshotStats
    public class ManagedVolumeSnapshotStats: BaseType
    {
        #region members

        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        [JsonProperty("totalInodes")]
        public System.Int64? TotalInodes { get; set; }

        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        [JsonProperty("usedInodes")]
        public System.Int64? UsedInodes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSnapshotStats";
    }

    public ManagedVolumeSnapshotStats Set(
        System.Int64? LogicalBytes = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? TotalInodes = null,
        System.Int64? UsedInodes = null
    ) 
    {
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( TotalInodes != null ) {
            this.TotalInodes = TotalInodes;
        }
        if ( UsedInodes != null ) {
            this.UsedInodes = UsedInodes;
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
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes != null) {
            s += ind + "logicalBytes\n" ;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes != null) {
            s += ind + "physicalBytes\n" ;
        }
        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        if (this.TotalInodes != null) {
            s += ind + "totalInodes\n" ;
        }
        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        if (this.UsedInodes != null) {
            s += ind + "usedInodes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes == null && ec.Includes("logicalBytes",true))
        {
            this.LogicalBytes = new System.Int64();
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes == null && ec.Includes("physicalBytes",true))
        {
            this.PhysicalBytes = new System.Int64();
        }
        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        if (this.TotalInodes == null && ec.Includes("totalInodes",true))
        {
            this.TotalInodes = new System.Int64();
        }
        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        if (this.UsedInodes == null && ec.Includes("usedInodes",true))
        {
            this.UsedInodes = new System.Int64();
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotStats
    
    #endregion

    public static class ListManagedVolumeSnapshotStatsExtensions
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
            this List<ManagedVolumeSnapshotStats> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSnapshotStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types