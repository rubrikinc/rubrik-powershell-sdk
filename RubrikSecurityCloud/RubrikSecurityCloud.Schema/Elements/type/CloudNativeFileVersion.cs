// CloudNativeFileVersion.cs
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
    #region CloudNativeFileVersion
    public class CloudNativeFileVersion: BaseType
    {
        #region members

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        [JsonProperty("snapshot")]
        public CloudNativeSnapshotInfo? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeFileVersion";
    }

    public CloudNativeFileVersion Set(
        FileModeEnum? FileMode = null,
        DateTime? LastModified = null,
        System.Int64? SizeInBytes = null,
        CloudNativeSnapshotInfo? Snapshot = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileMode\n" ;
            } else {
                s += ind + "fileMode\n" ;
            }
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
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
        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(conf.Child("snapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (ec.Includes("fileMode",true))
        {
            if(this.FileMode == null) {

                this.FileMode = new FileModeEnum();

            } else {


            }
        }
        else if (this.FileMode != null && ec.Excludes("fileMode",true))
        {
            this.FileMode = null;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = new DateTime();

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
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
        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        if (ec.Includes("snapshot",false))
        {
            if(this.Snapshot == null) {

                this.Snapshot = new CloudNativeSnapshotInfo();
                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            } else {

                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            }
        }
        else if (this.Snapshot != null && ec.Excludes("snapshot",false))
        {
            this.Snapshot = null;
        }
    }


    #endregion

    } // class CloudNativeFileVersion
    
    #endregion

    public static class ListCloudNativeFileVersionExtensions
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
            this List<CloudNativeFileVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeFileVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeFileVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeFileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeFileVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types