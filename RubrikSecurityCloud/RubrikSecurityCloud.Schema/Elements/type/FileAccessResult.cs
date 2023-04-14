// FileAccessResult.cs
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
    #region FileAccessResult
    public class FileAccessResult: IFragment
    {
        #region members
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        [JsonProperty("directory")]
        public System.String? Directory { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        [JsonProperty("numAccesses")]
        public System.Int32? NumAccesses { get; set; }

        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        [JsonProperty("accessType")]
        public ActivityAccessType? AccessType { get; set; }

        #endregion

    #region methods

    public FileAccessResult Set(
        System.String? Directory = null,
        System.String? Filename = null,
        System.String? NativePath = null,
        System.Int32? NumAccesses = null,
        ActivityAccessType? AccessType = null
    ) 
    {
        if ( Directory != null ) {
            this.Directory = Directory;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( NumAccesses != null ) {
            this.NumAccesses = NumAccesses;
        }
        if ( AccessType != null ) {
            this.AccessType = AccessType;
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
            //      C# -> System.String? Directory
            // GraphQL -> directory: String! (scalar)
            if (this.Directory != null)
            {
                 s += ind + "directory\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath != null)
            {
                 s += ind + "nativePath\n";

            }
            //      C# -> System.Int32? NumAccesses
            // GraphQL -> numAccesses: Int! (scalar)
            if (this.NumAccesses != null)
            {
                 s += ind + "numAccesses\n";

            }
            //      C# -> ActivityAccessType? AccessType
            // GraphQL -> accessType: ActivityAccessType! (enum)
            if (this.AccessType != null)
            {
                 s += ind + "accessType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Directory
            // GraphQL -> directory: String! (scalar)
            if (this.Directory == null && Exploration.Includes(parent + ".directory$"))
            {
                this.Directory = new System.String("FETCH");
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath == null && Exploration.Includes(parent + ".nativePath$"))
            {
                this.NativePath = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumAccesses
            // GraphQL -> numAccesses: Int! (scalar)
            if (this.NumAccesses == null && Exploration.Includes(parent + ".numAccesses$"))
            {
                this.NumAccesses = new System.Int32();
            }
            //      C# -> ActivityAccessType? AccessType
            // GraphQL -> accessType: ActivityAccessType! (enum)
            if (this.AccessType == null && Exploration.Includes(parent + ".accessType$"))
            {
                this.AccessType = new ActivityAccessType();
            }
        }


    #endregion

    } // class FileAccessResult
    #endregion

    public static class ListFileAccessResultExtensions
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
            this List<FileAccessResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FileAccessResult> list, 
            String parent = "")
        {
            var item = new FileAccessResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types