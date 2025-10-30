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

        //      C# -> System.String? HyperVgeneration
        // GraphQL -> hyperVGeneration: String (scalar)
        [JsonProperty("hyperVGeneration")]
        public System.String? HyperVgeneration { get; set; }

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
        System.String? HyperVgeneration = null,
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
        if ( HyperVgeneration != null ) {
            this.HyperVgeneration = HyperVgeneration;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> System.String? HyperVgeneration
        // GraphQL -> hyperVGeneration: String (scalar)
        if (this.HyperVgeneration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hyperVGeneration\n" ;
            } else {
                s += ind + "hyperVGeneration\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.String? HyperVgeneration
        // GraphQL -> hyperVGeneration: String (scalar)
        if (ec.Includes("hyperVGeneration",true))
        {
            if(this.HyperVgeneration == null) {

                this.HyperVgeneration = "FETCH";

            } else {


            }
        }
        else if (this.HyperVgeneration != null && ec.Excludes("hyperVGeneration",true))
        {
            this.HyperVgeneration = null;
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureNativeAttachedDiskSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeAttachedDiskSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeAttachedDiskSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeAttachedDiskSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeAttachedDiskSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types