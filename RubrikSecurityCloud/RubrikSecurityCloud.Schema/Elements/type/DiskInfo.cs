// DiskInfo.cs
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
    #region DiskInfo
    public class DiskInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }

        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        [JsonProperty("diskStatus")]
        public DiskStatus? DiskStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DiskInfo";
    }

    public DiskInfo Set(
        System.Int64? CapacityBytes = null,
        System.Boolean? IsResizable = null,
        System.String? Path = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null,
        DiskStatus? DiskStatus = null
    ) 
    {
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
        }
        if ( DiskStatus != null ) {
            this.DiskStatus = DiskStatus;
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
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes != null) {
            s += ind + "capacityBytes\n" ;
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        if (this.IsResizable != null) {
            s += ind + "isResizable\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes != null) {
            s += ind + "unallocatedBytes\n" ;
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes != null) {
            s += ind + "usableBytes\n" ;
        }
        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        if (this.DiskStatus != null) {
            var fspec = this.DiskStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "diskStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes == null && ec.Includes("capacityBytes",true))
        {
            this.CapacityBytes = new System.Int64();
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        if (this.IsResizable == null && ec.Includes("isResizable",true))
        {
            this.IsResizable = true;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && ec.Includes("path",true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes == null && ec.Includes("unallocatedBytes",true))
        {
            this.UnallocatedBytes = new System.Int64();
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes == null && ec.Includes("usableBytes",true))
        {
            this.UsableBytes = new System.Int64();
        }
        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        if (this.DiskStatus == null && ec.Includes("diskStatus",false))
        {
            this.DiskStatus = new DiskStatus();
            this.DiskStatus.ApplyExploratoryFieldSpec(ec.NewChild("diskStatus"));
        }
    }


    #endregion

    } // class DiskInfo
    
    #endregion

    public static class ListDiskInfoExtensions
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
            this List<DiskInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DiskInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DiskInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DiskInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types