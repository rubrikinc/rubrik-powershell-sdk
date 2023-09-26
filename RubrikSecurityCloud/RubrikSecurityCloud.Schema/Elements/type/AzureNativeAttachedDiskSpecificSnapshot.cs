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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskName\n" ;
            } else {
                s += ind + "diskName\n" ;
            }
        }
        //      C# -> System.String? DiskResourceGroupName
        // GraphQL -> diskResourceGroupName: String! (scalar)
        if (this.DiskResourceGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskResourceGroupName\n" ;
            } else {
                s += ind + "diskResourceGroupName\n" ;
            }
        }
        //      C# -> System.String? DiskStorageTier
        // GraphQL -> diskStorageTier: String! (scalar)
        if (this.DiskStorageTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskStorageTier\n" ;
            } else {
                s += ind + "diskStorageTier\n" ;
            }
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOsDisk\n" ;
            } else {
                s += ind + "isOsDisk\n" ;
            }
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lun\n" ;
            } else {
                s += ind + "lun\n" ;
            }
        }
        //      C# -> System.String? SnapshotNativeId
        // GraphQL -> snapshotNativeId: String! (scalar)
        if (this.SnapshotNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNativeId\n" ;
            } else {
                s += ind + "snapshotNativeId\n" ;
            }
        }
        //      C# -> System.String? SourceDiskUniqueNativeId
        // GraphQL -> sourceDiskUniqueNativeId: String! (scalar)
        if (this.SourceDiskUniqueNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceDiskUniqueNativeId\n" ;
            } else {
                s += ind + "sourceDiskUniqueNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (ec.Includes("diskName",true))
        {
            if(this.DiskName == null) {

                this.DiskName = "FETCH";

            } else {


            }
        }
        else if (this.DiskName != null && ec.Excludes("diskName",true))
        {
            this.DiskName = null;
        }
        //      C# -> System.String? DiskResourceGroupName
        // GraphQL -> diskResourceGroupName: String! (scalar)
        if (ec.Includes("diskResourceGroupName",true))
        {
            if(this.DiskResourceGroupName == null) {

                this.DiskResourceGroupName = "FETCH";

            } else {


            }
        }
        else if (this.DiskResourceGroupName != null && ec.Excludes("diskResourceGroupName",true))
        {
            this.DiskResourceGroupName = null;
        }
        //      C# -> System.String? DiskStorageTier
        // GraphQL -> diskStorageTier: String! (scalar)
        if (ec.Includes("diskStorageTier",true))
        {
            if(this.DiskStorageTier == null) {

                this.DiskStorageTier = "FETCH";

            } else {


            }
        }
        else if (this.DiskStorageTier != null && ec.Excludes("diskStorageTier",true))
        {
            this.DiskStorageTier = null;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (ec.Includes("isOsDisk",true))
        {
            if(this.IsOsDisk == null) {

                this.IsOsDisk = true;

            } else {


            }
        }
        else if (this.IsOsDisk != null && ec.Excludes("isOsDisk",true))
        {
            this.IsOsDisk = null;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (ec.Includes("lun",true))
        {
            if(this.Lun == null) {

                this.Lun = Int32.MinValue;

            } else {


            }
        }
        else if (this.Lun != null && ec.Excludes("lun",true))
        {
            this.Lun = null;
        }
        //      C# -> System.String? SnapshotNativeId
        // GraphQL -> snapshotNativeId: String! (scalar)
        if (ec.Includes("snapshotNativeId",true))
        {
            if(this.SnapshotNativeId == null) {

                this.SnapshotNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotNativeId != null && ec.Excludes("snapshotNativeId",true))
        {
            this.SnapshotNativeId = null;
        }
        //      C# -> System.String? SourceDiskUniqueNativeId
        // GraphQL -> sourceDiskUniqueNativeId: String! (scalar)
        if (ec.Includes("sourceDiskUniqueNativeId",true))
        {
            if(this.SourceDiskUniqueNativeId == null) {

                this.SourceDiskUniqueNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SourceDiskUniqueNativeId != null && ec.Excludes("sourceDiskUniqueNativeId",true))
        {
            this.SourceDiskUniqueNativeId = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeAttachedDiskSpecificSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeAttachedDiskSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeAttachedDiskSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types