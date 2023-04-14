// MssqlRestoreFile.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlRestoreFile
    public class MssqlRestoreFile: IFragment
    {
        #region members
        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        [JsonProperty("fileId")]
        public System.Int64? FileId { get; set; }

        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        [JsonProperty("logicalName")]
        public System.String? LogicalName { get; set; }

        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        [JsonProperty("originalName")]
        public System.String? OriginalName { get; set; }

        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        [JsonProperty("originalPath")]
        public System.String? OriginalPath { get; set; }

        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        [JsonProperty("fileType")]
        public MssqlDatabaseFileType? FileType { get; set; }

        #endregion

    #region methods

    public MssqlRestoreFile Set(
        System.Int64? FileId = null,
        System.String? LogicalName = null,
        System.String? OriginalName = null,
        System.String? OriginalPath = null,
        MssqlDatabaseFileType? FileType = null
    ) 
    {
        if ( FileId != null ) {
            this.FileId = FileId;
        }
        if ( LogicalName != null ) {
            this.LogicalName = LogicalName;
        }
        if ( OriginalName != null ) {
            this.OriginalName = OriginalName;
        }
        if ( OriginalPath != null ) {
            this.OriginalPath = OriginalPath;
        }
        if ( FileType != null ) {
            this.FileType = FileType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? FileId
            // GraphQL -> fileId: Long! (scalar)
            if (this.FileId != null)
            {
                 s += ind + "fileId\n";

            }
            //      C# -> System.String? LogicalName
            // GraphQL -> logicalName: String! (scalar)
            if (this.LogicalName != null)
            {
                 s += ind + "logicalName\n";

            }
            //      C# -> System.String? OriginalName
            // GraphQL -> originalName: String! (scalar)
            if (this.OriginalName != null)
            {
                 s += ind + "originalName\n";

            }
            //      C# -> System.String? OriginalPath
            // GraphQL -> originalPath: String! (scalar)
            if (this.OriginalPath != null)
            {
                 s += ind + "originalPath\n";

            }
            //      C# -> MssqlDatabaseFileType? FileType
            // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
            if (this.FileType != null)
            {
                 s += ind + "fileType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? FileId
            // GraphQL -> fileId: Long! (scalar)
            if (this.FileId == null && Exploration.Includes(parent + ".fileId$"))
            {
                this.FileId = new System.Int64();
            }
            //      C# -> System.String? LogicalName
            // GraphQL -> logicalName: String! (scalar)
            if (this.LogicalName == null && Exploration.Includes(parent + ".logicalName$"))
            {
                this.LogicalName = new System.String("FETCH");
            }
            //      C# -> System.String? OriginalName
            // GraphQL -> originalName: String! (scalar)
            if (this.OriginalName == null && Exploration.Includes(parent + ".originalName$"))
            {
                this.OriginalName = new System.String("FETCH");
            }
            //      C# -> System.String? OriginalPath
            // GraphQL -> originalPath: String! (scalar)
            if (this.OriginalPath == null && Exploration.Includes(parent + ".originalPath$"))
            {
                this.OriginalPath = new System.String("FETCH");
            }
            //      C# -> MssqlDatabaseFileType? FileType
            // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
            if (this.FileType == null && Exploration.Includes(parent + ".fileType$"))
            {
                this.FileType = new MssqlDatabaseFileType();
            }
        }


    #endregion

    } // class MssqlRestoreFile
    #endregion

    public static class ListMssqlRestoreFileExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<MssqlRestoreFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlRestoreFile> list, 
            String parent = "")
        {
            var item = new MssqlRestoreFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types