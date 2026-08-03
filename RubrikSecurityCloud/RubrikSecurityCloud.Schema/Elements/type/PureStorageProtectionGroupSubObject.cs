// PureStorageProtectionGroupSubObject.cs
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
    #region PureStorageProtectionGroupSubObject
    public class PureStorageProtectionGroupSubObject: BaseType
    {
        #region members

        //      C# -> System.String? CdmVolumeId
        // GraphQL -> cdmVolumeId: String! (scalar)
        [JsonProperty("cdmVolumeId")]
        public System.String? CdmVolumeId { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.Int64? ProvisionedSizeBytes
        // GraphQL -> provisionedSizeBytes: Long! (scalar)
        [JsonProperty("provisionedSizeBytes")]
        public System.Int64? ProvisionedSizeBytes { get; set; }

        //      C# -> System.String? PureSnapshotId
        // GraphQL -> pureSnapshotId: String! (scalar)
        [JsonProperty("pureSnapshotId")]
        public System.String? PureSnapshotId { get; set; }

        //      C# -> System.String? SnapshotVolumeId
        // GraphQL -> snapshotVolumeId: String! (scalar)
        [JsonProperty("snapshotVolumeId")]
        public System.String? SnapshotVolumeId { get; set; }

        //      C# -> System.String? SnapshotVolumeSerialId
        // GraphQL -> snapshotVolumeSerialId: String! (scalar)
        [JsonProperty("snapshotVolumeSerialId")]
        public System.String? SnapshotVolumeSerialId { get; set; }

        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        [JsonProperty("volumeName")]
        public System.String? VolumeName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PureStorageProtectionGroupSubObject";
    }

    public PureStorageProtectionGroupSubObject Set(
        System.String? CdmVolumeId = null,
        System.Int64? FileSizeInBytes = null,
        System.Int64? ProvisionedSizeBytes = null,
        System.String? PureSnapshotId = null,
        System.String? SnapshotVolumeId = null,
        System.String? SnapshotVolumeSerialId = null,
        System.String? VolumeName = null
    ) 
    {
        if ( CdmVolumeId != null ) {
            this.CdmVolumeId = CdmVolumeId;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( ProvisionedSizeBytes != null ) {
            this.ProvisionedSizeBytes = ProvisionedSizeBytes;
        }
        if ( PureSnapshotId != null ) {
            this.PureSnapshotId = PureSnapshotId;
        }
        if ( SnapshotVolumeId != null ) {
            this.SnapshotVolumeId = SnapshotVolumeId;
        }
        if ( SnapshotVolumeSerialId != null ) {
            this.SnapshotVolumeSerialId = SnapshotVolumeSerialId;
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
        //      C# -> System.String? CdmVolumeId
        // GraphQL -> cdmVolumeId: String! (scalar)
        if (this.CdmVolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVolumeId\n" ;
            } else {
                s += ind + "cdmVolumeId\n" ;
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
        //      C# -> System.Int64? ProvisionedSizeBytes
        // GraphQL -> provisionedSizeBytes: Long! (scalar)
        if (this.ProvisionedSizeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisionedSizeBytes\n" ;
            } else {
                s += ind + "provisionedSizeBytes\n" ;
            }
        }
        //      C# -> System.String? PureSnapshotId
        // GraphQL -> pureSnapshotId: String! (scalar)
        if (this.PureSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pureSnapshotId\n" ;
            } else {
                s += ind + "pureSnapshotId\n" ;
            }
        }
        //      C# -> System.String? SnapshotVolumeId
        // GraphQL -> snapshotVolumeId: String! (scalar)
        if (this.SnapshotVolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotVolumeId\n" ;
            } else {
                s += ind + "snapshotVolumeId\n" ;
            }
        }
        //      C# -> System.String? SnapshotVolumeSerialId
        // GraphQL -> snapshotVolumeSerialId: String! (scalar)
        if (this.SnapshotVolumeSerialId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotVolumeSerialId\n" ;
            } else {
                s += ind + "snapshotVolumeSerialId\n" ;
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
        //      C# -> System.String? CdmVolumeId
        // GraphQL -> cdmVolumeId: String! (scalar)
        if (ec.Includes("cdmVolumeId",true))
        {
            if(this.CdmVolumeId == null) {

                this.CdmVolumeId = "FETCH";

            } else {


            }
        }
        else if (this.CdmVolumeId != null && ec.Excludes("cdmVolumeId",true))
        {
            this.CdmVolumeId = null;
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
        //      C# -> System.Int64? ProvisionedSizeBytes
        // GraphQL -> provisionedSizeBytes: Long! (scalar)
        if (ec.Includes("provisionedSizeBytes",true))
        {
            if(this.ProvisionedSizeBytes == null) {

                this.ProvisionedSizeBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ProvisionedSizeBytes != null && ec.Excludes("provisionedSizeBytes",true))
        {
            this.ProvisionedSizeBytes = null;
        }
        //      C# -> System.String? PureSnapshotId
        // GraphQL -> pureSnapshotId: String! (scalar)
        if (ec.Includes("pureSnapshotId",true))
        {
            if(this.PureSnapshotId == null) {

                this.PureSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.PureSnapshotId != null && ec.Excludes("pureSnapshotId",true))
        {
            this.PureSnapshotId = null;
        }
        //      C# -> System.String? SnapshotVolumeId
        // GraphQL -> snapshotVolumeId: String! (scalar)
        if (ec.Includes("snapshotVolumeId",true))
        {
            if(this.SnapshotVolumeId == null) {

                this.SnapshotVolumeId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotVolumeId != null && ec.Excludes("snapshotVolumeId",true))
        {
            this.SnapshotVolumeId = null;
        }
        //      C# -> System.String? SnapshotVolumeSerialId
        // GraphQL -> snapshotVolumeSerialId: String! (scalar)
        if (ec.Includes("snapshotVolumeSerialId",true))
        {
            if(this.SnapshotVolumeSerialId == null) {

                this.SnapshotVolumeSerialId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotVolumeSerialId != null && ec.Excludes("snapshotVolumeSerialId",true))
        {
            this.SnapshotVolumeSerialId = null;
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

    } // class PureStorageProtectionGroupSubObject
    
    #endregion

    public static class ListPureStorageProtectionGroupSubObjectExtensions
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
            this List<PureStorageProtectionGroupSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PureStorageProtectionGroupSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PureStorageProtectionGroupSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PureStorageProtectionGroupSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PureStorageProtectionGroupSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types