// AzureNativeAttachedDiskSpecificSnapshot.cs
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
    #region AzureNativeAttachedDiskSpecificSnapshot
    public class AzureNativeAttachedDiskSpecificSnapshot: BaseType
    {
        #region members

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? DiskResourceGroupName
        // GraphQL -> diskResourceGroupName: String! (scalar)
        [JsonProperty("diskResourceGroupName")]
        public System.String? DiskResourceGroupName { get; set; }

        //      C# -> System.String? DiskStorageTier
        // GraphQL -> diskStorageTier: String! (scalar)
        [JsonProperty("diskStorageTier")]
        public System.String? DiskStorageTier { get; set; }

        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        [JsonProperty("isOsDisk")]
        public System.Boolean? IsOsDisk { get; set; }

        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        [JsonProperty("lun")]
        public System.Int32? Lun { get; set; }

        //      C# -> System.String? SnapshotNativeId
        // GraphQL -> snapshotNativeId: String! (scalar)
        [JsonProperty("snapshotNativeId")]
        public System.String? SnapshotNativeId { get; set; }

        //      C# -> System.String? SourceDiskUniqueNativeId
        // GraphQL -> sourceDiskUniqueNativeId: String! (scalar)
        [JsonProperty("sourceDiskUniqueNativeId")]
        public System.String? SourceDiskUniqueNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeAttachedDiskSpecificSnapshot";
    }

    public AzureNativeAttachedDiskSpecificSnapshot Set(
        System.String? DiskName = null,
        System.String? DiskResourceGroupName = null,
        System.String? DiskStorageTier = null,
        System.Boolean? IsOsDisk = null,
        System.Int32? Lun = null,
        System.String? SnapshotNativeId = null,
        System.String? SourceDiskUniqueNativeId = null
    ) 
    {
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( DiskResourceGroupName != null ) {
            this.DiskResourceGroupName = DiskResourceGroupName;
        }
        if ( DiskStorageTier != null ) {
            this.DiskStorageTier = DiskStorageTier;
        }
        if ( IsOsDisk != null ) {
            this.IsOsDisk = IsOsDisk;
        }
        if ( Lun != null ) {
            this.Lun = Lun;
        }
        if ( SnapshotNativeId != null ) {
            this.SnapshotNativeId = SnapshotNativeId;
        }
        if ( SourceDiskUniqueNativeId != null ) {
            this.SourceDiskUniqueNativeId = SourceDiskUniqueNativeId;
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
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            s += ind + "diskName\n" ;
        }
        //      C# -> System.String? DiskResourceGroupName
        // GraphQL -> diskResourceGroupName: String! (scalar)
        if (this.DiskResourceGroupName != null) {
            s += ind + "diskResourceGroupName\n" ;
        }
        //      C# -> System.String? DiskStorageTier
        // GraphQL -> diskStorageTier: String! (scalar)
        if (this.DiskStorageTier != null) {
            s += ind + "diskStorageTier\n" ;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk != null) {
            s += ind + "isOsDisk\n" ;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun != null) {
            s += ind + "lun\n" ;
        }
        //      C# -> System.String? SnapshotNativeId
        // GraphQL -> snapshotNativeId: String! (scalar)
        if (this.SnapshotNativeId != null) {
            s += ind + "snapshotNativeId\n" ;
        }
        //      C# -> System.String? SourceDiskUniqueNativeId
        // GraphQL -> sourceDiskUniqueNativeId: String! (scalar)
        if (this.SourceDiskUniqueNativeId != null) {
            s += ind + "sourceDiskUniqueNativeId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName == null && Exploration.Includes(parent + ".diskName", true))
        {
            this.DiskName = "FETCH";
        }
        //      C# -> System.String? DiskResourceGroupName
        // GraphQL -> diskResourceGroupName: String! (scalar)
        if (this.DiskResourceGroupName == null && Exploration.Includes(parent + ".diskResourceGroupName", true))
        {
            this.DiskResourceGroupName = "FETCH";
        }
        //      C# -> System.String? DiskStorageTier
        // GraphQL -> diskStorageTier: String! (scalar)
        if (this.DiskStorageTier == null && Exploration.Includes(parent + ".diskStorageTier", true))
        {
            this.DiskStorageTier = "FETCH";
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk == null && Exploration.Includes(parent + ".isOsDisk", true))
        {
            this.IsOsDisk = true;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun == null && Exploration.Includes(parent + ".lun", true))
        {
            this.Lun = Int32.MinValue;
        }
        //      C# -> System.String? SnapshotNativeId
        // GraphQL -> snapshotNativeId: String! (scalar)
        if (this.SnapshotNativeId == null && Exploration.Includes(parent + ".snapshotNativeId", true))
        {
            this.SnapshotNativeId = "FETCH";
        }
        //      C# -> System.String? SourceDiskUniqueNativeId
        // GraphQL -> sourceDiskUniqueNativeId: String! (scalar)
        if (this.SourceDiskUniqueNativeId == null && Exploration.Includes(parent + ".sourceDiskUniqueNativeId", true))
        {
            this.SourceDiskUniqueNativeId = "FETCH";
        }
    }


    #endregion

    } // class AzureNativeAttachedDiskSpecificSnapshot
    
    #endregion

    public static class ListAzureNativeAttachedDiskSpecificSnapshotExtensions
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
            this List<AzureNativeAttachedDiskSpecificSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeAttachedDiskSpecificSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeAttachedDiskSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types