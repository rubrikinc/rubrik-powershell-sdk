// SuspiciousFileInfo.cs
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
    #region SuspiciousFileInfo
    public class SuspiciousFileInfo: BaseType
    {
        #region members

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        [JsonProperty("fileSizeBytes")]
        public System.Int64? FileSizeBytes { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }


        #endregion

    #region methods

    public SuspiciousFileInfo Set(
        System.String? FilePath = null,
        System.Int64? FileSizeBytes = null,
        DateTime? LastModified = null
    ) 
    {
        if ( FilePath != null ) {
            this.FilePath = FilePath;
        }
        if ( FileSizeBytes != null ) {
            this.FileSizeBytes = FileSizeBytes;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
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
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath != null) {
            s += ind + "filePath\n" ;
        }
        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        if (this.FileSizeBytes != null) {
            s += ind + "fileSizeBytes\n" ;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath == null && Exploration.Includes(parent + ".filePath", true))
        {
            this.FilePath = new System.String("FETCH");
        }
        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        if (this.FileSizeBytes == null && Exploration.Includes(parent + ".fileSizeBytes", true))
        {
            this.FileSizeBytes = new System.Int64();
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new DateTime();
        }
    }


    #endregion

    } // class SuspiciousFileInfo
    
    #endregion

    public static class ListSuspiciousFileInfoExtensions
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
            this List<SuspiciousFileInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SuspiciousFileInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SuspiciousFileInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types