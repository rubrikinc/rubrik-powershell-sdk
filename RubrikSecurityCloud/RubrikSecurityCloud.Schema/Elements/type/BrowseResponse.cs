// BrowseResponse.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    #region BrowseResponse
    public class BrowseResponse: IFragment
    {
        #region members
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        [JsonProperty("fileMode")]
        public System.String? FileMode { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.Int32? Unreadable
        // GraphQL -> unreadable: Int (scalar)
        [JsonProperty("unreadable")]
        public System.Int32? Unreadable { get; set; }

        #endregion

    #region methods

    public BrowseResponse Set(
        System.String? FileMode = null,
        System.String? Filename = null,
        System.String? LastModified = null,
        System.String? Path = null,
        System.Int64? Size = null,
        System.String? StatusMessage = null,
        System.Int32? Unreadable = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Unreadable != null ) {
            this.Unreadable = Unreadable;
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
            //      C# -> System.String? FileMode
            // GraphQL -> fileMode: String (scalar)
            if (this.FileMode != null)
            {
                 s += ind + "fileMode\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String (scalar)
            if (this.StatusMessage != null)
            {
                 s += ind + "statusMessage\n";

            }
            //      C# -> System.Int32? Unreadable
            // GraphQL -> unreadable: Int (scalar)
            if (this.Unreadable != null)
            {
                 s += ind + "unreadable\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FileMode
            // GraphQL -> fileMode: String (scalar)
            if (this.FileMode == null && Exploration.Includes(parent + ".fileMode$"))
            {
                this.FileMode = new System.String("FETCH");
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String (scalar)
            if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage$"))
            {
                this.StatusMessage = new System.String("FETCH");
            }
            //      C# -> System.Int32? Unreadable
            // GraphQL -> unreadable: Int (scalar)
            if (this.Unreadable == null && Exploration.Includes(parent + ".unreadable$"))
            {
                this.Unreadable = new System.Int32();
            }
        }


    #endregion

    } // class BrowseResponse
    #endregion

    public static class ListBrowseResponseExtensions
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
            this List<BrowseResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BrowseResponse> list, 
            String parent = "")
        {
            var item = new BrowseResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types