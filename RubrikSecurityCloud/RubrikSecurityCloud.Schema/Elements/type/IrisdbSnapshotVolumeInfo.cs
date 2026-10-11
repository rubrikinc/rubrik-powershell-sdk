// IrisdbSnapshotVolumeInfo.cs
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
    #region IrisdbSnapshotVolumeInfo
    public class IrisdbSnapshotVolumeInfo: BaseType
    {
        #region members

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        [JsonProperty("volumeName")]
        public System.String? VolumeName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IrisdbSnapshotVolumeInfo";
    }

    public IrisdbSnapshotVolumeInfo Set(
        System.String? MountPath = null,
        System.Int64? SizeInBytes = null,
        System.String? VolumeName = null
    ) 
    {
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
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
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (this.MountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPath\n" ;
            } else {
                s += ind + "mountPath\n" ;
            }
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInBytes\n" ;
            } else {
                s += ind + "sizeInBytes\n" ;
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
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (ec.Includes("mountPath",true))
        {
            if(this.MountPath == null) {

                this.MountPath = "FETCH";

            } else {


            }
        }
        else if (this.MountPath != null && ec.Excludes("mountPath",true))
        {
            this.MountPath = null;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (ec.Includes("sizeInBytes",true))
        {
            if(this.SizeInBytes == null) {

                this.SizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SizeInBytes != null && ec.Excludes("sizeInBytes",true))
        {
            this.SizeInBytes = null;
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

    } // class IrisdbSnapshotVolumeInfo
    
    #endregion

    public static class ListIrisdbSnapshotVolumeInfoExtensions
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
            this List<IrisdbSnapshotVolumeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IrisdbSnapshotVolumeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IrisdbSnapshotVolumeInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IrisdbSnapshotVolumeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IrisdbSnapshotVolumeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types