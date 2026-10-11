// IrisdbVolume.cs
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
    #region IrisdbVolume
    public class IrisdbVolume: BaseType
    {
        #region members

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        [JsonProperty("volumeId")]
        public System.String? VolumeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IrisdbVolume";
    }

    public IrisdbVolume Set(
        System.String? MountPath = null,
        System.String? Name = null,
        System.Int64? SizeInBytes = null,
        System.String? VolumeId = null
    ) 
    {
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( VolumeId != null ) {
            this.VolumeId = VolumeId;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeId\n" ;
            } else {
                s += ind + "volumeId\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (ec.Includes("volumeId",true))
        {
            if(this.VolumeId == null) {

                this.VolumeId = "FETCH";

            } else {


            }
        }
        else if (this.VolumeId != null && ec.Excludes("volumeId",true))
        {
            this.VolumeId = null;
        }
    }


    #endregion

    } // class IrisdbVolume
    
    #endregion

    public static class ListIrisdbVolumeExtensions
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
            this List<IrisdbVolume> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IrisdbVolume> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IrisdbVolume> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IrisdbVolume());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IrisdbVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types