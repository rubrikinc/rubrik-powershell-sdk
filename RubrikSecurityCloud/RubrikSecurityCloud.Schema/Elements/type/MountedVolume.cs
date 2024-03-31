// MountedVolume.cs
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
    #region MountedVolume
    public class MountedVolume: BaseType
    {
        #region members

        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        [JsonProperty("fileSystemType")]
        public System.String? FileSystemType { get; set; }

        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        [JsonProperty("hostMountPath")]
        public System.String? HostMountPath { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        [JsonProperty("originalMountPoints")]
        public List<System.String>? OriginalMountPoints { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        [JsonProperty("smbPath")]
        public System.String? SmbPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MountedVolume";
    }

    public MountedVolume Set(
        System.String? FileSystemType = null,
        System.String? HostMountPath = null,
        System.String? Id = null,
        List<System.String>? OriginalMountPoints = null,
        System.Int64? Size = null,
        System.String? SmbPath = null
    ) 
    {
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( HostMountPath != null ) {
            this.HostMountPath = HostMountPath;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OriginalMountPoints != null ) {
            this.OriginalMountPoints = OriginalMountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SmbPath != null ) {
            this.SmbPath = SmbPath;
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
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSystemType\n" ;
            } else {
                s += ind + "fileSystemType\n" ;
            }
        }
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        if (this.HostMountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostMountPath\n" ;
            } else {
                s += ind + "hostMountPath\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        if (this.OriginalMountPoints != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originalMountPoints\n" ;
            } else {
                s += ind + "originalMountPoints\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        if (this.SmbPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbPath\n" ;
            } else {
                s += ind + "smbPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (ec.Includes("fileSystemType",true))
        {
            if(this.FileSystemType == null) {

                this.FileSystemType = "FETCH";

            } else {


            }
        }
        else if (this.FileSystemType != null && ec.Excludes("fileSystemType",true))
        {
            this.FileSystemType = null;
        }
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        if (ec.Includes("hostMountPath",true))
        {
            if(this.HostMountPath == null) {

                this.HostMountPath = "FETCH";

            } else {


            }
        }
        else if (this.HostMountPath != null && ec.Excludes("hostMountPath",true))
        {
            this.HostMountPath = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        if (ec.Includes("originalMountPoints",true))
        {
            if(this.OriginalMountPoints == null) {

                this.OriginalMountPoints = new List<System.String>();

            } else {


            }
        }
        else if (this.OriginalMountPoints != null && ec.Excludes("originalMountPoints",true))
        {
            this.OriginalMountPoints = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        if (ec.Includes("smbPath",true))
        {
            if(this.SmbPath == null) {

                this.SmbPath = "FETCH";

            } else {


            }
        }
        else if (this.SmbPath != null && ec.Excludes("smbPath",true))
        {
            this.SmbPath = null;
        }
    }


    #endregion

    } // class MountedVolume
    
    #endregion

    public static class ListMountedVolumeExtensions
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
            this List<MountedVolume> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MountedVolume> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MountedVolume> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MountedVolume());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MountedVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types