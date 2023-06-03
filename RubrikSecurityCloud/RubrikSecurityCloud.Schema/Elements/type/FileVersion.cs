// FileVersion.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FileVersion
    public class FileVersion: BaseType
    {
        #region members

        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        [JsonProperty("fileMode")]
        public System.String? FileMode { get; set; }

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }


        #endregion

    #region methods

    public FileVersion Set(
        System.String? FileMode = null,
        System.String? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        System.String? Source = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Source != null ) {
            this.Source = Source;
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
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (this.FileMode != null) {
            s += ind + "fileMode\n" ;
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        if (this.Source != null) {
            s += ind + "source\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (this.FileMode == null && Exploration.Includes(parent + ".fileMode", true))
        {
            this.FileMode = new System.String("FETCH");
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new System.String("FETCH");
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = new System.String("FETCH");
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        if (this.Source == null && Exploration.Includes(parent + ".source", true))
        {
            this.Source = new System.String("FETCH");
        }
    }


    #endregion

    } // class FileVersion
    
    #endregion

    public static class ListFileVersionExtensions
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
            this List<FileVersion> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types