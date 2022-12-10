// SuspiciousFileInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region SuspiciousFileInfo
    public class SuspiciousFileInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? FilePath
            // GraphQL -> filePath: String! (scalar)
            if (this.FilePath != null)
            {
                 s += ind + "filePath\n";

            }
            //      C# -> System.Int64? FileSizeBytes
            // GraphQL -> fileSizeBytes: Long! (scalar)
            if (this.FileSizeBytes != null)
            {
                 s += ind + "fileSizeBytes\n";

            }
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FilePath
            // GraphQL -> filePath: String! (scalar)
            if (this.FilePath == null && Exploration.Includes(parent + ".filePath$"))
            {
                this.FilePath = new System.String("FETCH");
            }
            //      C# -> System.Int64? FileSizeBytes
            // GraphQL -> fileSizeBytes: Long! (scalar)
            if (this.FileSizeBytes == null && Exploration.Includes(parent + ".fileSizeBytes$"))
            {
                this.FileSizeBytes = new System.Int64();
            }
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new DateTime();
            }
        }


    #endregion

    } // class SuspiciousFileInfo
    #endregion

    public static class ListSuspiciousFileInfoExtensions
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
            this List<SuspiciousFileInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SuspiciousFileInfo> list, 
            String parent = "")
        {
            var item = new SuspiciousFileInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types