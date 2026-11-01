// HpeVmeVmSubObject.cs
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
    #region HpeVmeVmSubObject
    public class HpeVmeVmSubObject: BaseType
    {
        #region members

        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        [JsonProperty("datastoreId")]
        public System.String? DatastoreId { get; set; }

        //      C# -> System.String? DiskBus
        // GraphQL -> diskBus: String! (scalar)
        [JsonProperty("diskBus")]
        public System.String? DiskBus { get; set; }

        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        [JsonProperty("diskFormat")]
        public System.String? DiskFormat { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskTarget
        // GraphQL -> diskTarget: String! (scalar)
        [JsonProperty("diskTarget")]
        public System.String? DiskTarget { get; set; }

        //      C# -> System.Int32? DisplayOrder
        // GraphQL -> displayOrder: Int! (scalar)
        [JsonProperty("displayOrder")]
        public System.Int32? DisplayOrder { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        [JsonProperty("isRootVolume")]
        public System.Boolean? IsRootVolume { get; set; }

        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        [JsonProperty("storageType")]
        public System.String? StorageType { get; set; }

        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        [JsonProperty("volumeName")]
        public System.String? VolumeName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HpeVmeVmSubObject";
    }

    public HpeVmeVmSubObject Set(
        System.String? DatastoreId = null,
        System.String? DiskBus = null,
        System.String? DiskFormat = null,
        System.String? DiskId = null,
        System.String? DiskTarget = null,
        System.Int32? DisplayOrder = null,
        System.Int64? FileSizeInBytes = null,
        System.Boolean? IsRootVolume = null,
        System.String? StorageType = null,
        System.String? VolumeName = null
    ) 
    {
        if ( DatastoreId != null ) {
            this.DatastoreId = DatastoreId;
        }
        if ( DiskBus != null ) {
            this.DiskBus = DiskBus;
        }
        if ( DiskFormat != null ) {
            this.DiskFormat = DiskFormat;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskTarget != null ) {
            this.DiskTarget = DiskTarget;
        }
        if ( DisplayOrder != null ) {
            this.DisplayOrder = DisplayOrder;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( IsRootVolume != null ) {
            this.IsRootVolume = IsRootVolume;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
        }
        if ( VolumeName != null ) {
            this.VolumeName = VolumeName;
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
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (this.DatastoreId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreId\n" ;
            } else {
                s += ind + "datastoreId\n" ;
            }
        }
        //      C# -> System.String? DiskBus
        // GraphQL -> diskBus: String! (scalar)
        if (this.DiskBus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskBus\n" ;
            } else {
                s += ind + "diskBus\n" ;
            }
        }
        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        if (this.DiskFormat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskFormat\n" ;
            } else {
                s += ind + "diskFormat\n" ;
            }
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskId\n" ;
            } else {
                s += ind + "diskId\n" ;
            }
        }
        //      C# -> System.String? DiskTarget
        // GraphQL -> diskTarget: String! (scalar)
        if (this.DiskTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskTarget\n" ;
            } else {
                s += ind + "diskTarget\n" ;
            }
        }
        //      C# -> System.Int32? DisplayOrder
        // GraphQL -> displayOrder: Int! (scalar)
        if (this.DisplayOrder != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayOrder\n" ;
            } else {
                s += ind + "displayOrder\n" ;
            }
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSizeInBytes\n" ;
            } else {
                s += ind + "fileSizeInBytes\n" ;
            }
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (this.IsRootVolume != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRootVolume\n" ;
            } else {
                s += ind + "isRootVolume\n" ;
            }
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        if (this.StorageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageType\n" ;
            } else {
                s += ind + "storageType\n" ;
            }
        }
        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        if (this.VolumeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeName\n" ;
            } else {
                s += ind + "volumeName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (ec.Includes("datastoreId",true))
        {
            if(this.DatastoreId == null) {

                this.DatastoreId = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreId != null && ec.Excludes("datastoreId",true))
        {
            this.DatastoreId = null;
        }
        //      C# -> System.String? DiskBus
        // GraphQL -> diskBus: String! (scalar)
        if (ec.Includes("diskBus",true))
        {
            if(this.DiskBus == null) {

                this.DiskBus = "FETCH";

            } else {


            }
        }
        else if (this.DiskBus != null && ec.Excludes("diskBus",true))
        {
            this.DiskBus = null;
        }
        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        if (ec.Includes("diskFormat",true))
        {
            if(this.DiskFormat == null) {

                this.DiskFormat = "FETCH";

            } else {


            }
        }
        else if (this.DiskFormat != null && ec.Excludes("diskFormat",true))
        {
            this.DiskFormat = null;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (ec.Includes("diskId",true))
        {
            if(this.DiskId == null) {

                this.DiskId = "FETCH";

            } else {


            }
        }
        else if (this.DiskId != null && ec.Excludes("diskId",true))
        {
            this.DiskId = null;
        }
        //      C# -> System.String? DiskTarget
        // GraphQL -> diskTarget: String! (scalar)
        if (ec.Includes("diskTarget",true))
        {
            if(this.DiskTarget == null) {

                this.DiskTarget = "FETCH";

            } else {


            }
        }
        else if (this.DiskTarget != null && ec.Excludes("diskTarget",true))
        {
            this.DiskTarget = null;
        }
        //      C# -> System.Int32? DisplayOrder
        // GraphQL -> displayOrder: Int! (scalar)
        if (ec.Includes("displayOrder",true))
        {
            if(this.DisplayOrder == null) {

                this.DisplayOrder = Int32.MinValue;

            } else {


            }
        }
        else if (this.DisplayOrder != null && ec.Excludes("displayOrder",true))
        {
            this.DisplayOrder = null;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (ec.Includes("fileSizeInBytes",true))
        {
            if(this.FileSizeInBytes == null) {

                this.FileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FileSizeInBytes != null && ec.Excludes("fileSizeInBytes",true))
        {
            this.FileSizeInBytes = null;
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (ec.Includes("isRootVolume",true))
        {
            if(this.IsRootVolume == null) {

                this.IsRootVolume = true;

            } else {


            }
        }
        else if (this.IsRootVolume != null && ec.Excludes("isRootVolume",true))
        {
            this.IsRootVolume = null;
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        if (ec.Includes("storageType",true))
        {
            if(this.StorageType == null) {

                this.StorageType = "FETCH";

            } else {


            }
        }
        else if (this.StorageType != null && ec.Excludes("storageType",true))
        {
            this.StorageType = null;
        }
        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        if (ec.Includes("volumeName",true))
        {
            if(this.VolumeName == null) {

                this.VolumeName = "FETCH";

            } else {


            }
        }
        else if (this.VolumeName != null && ec.Excludes("volumeName",true))
        {
            this.VolumeName = null;
        }
    }


    #endregion

    } // class HpeVmeVmSubObject
    
    #endregion

    public static class ListHpeVmeVmSubObjectExtensions
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
            this List<HpeVmeVmSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HpeVmeVmSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HpeVmeVmSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HpeVmeVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HpeVmeVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types