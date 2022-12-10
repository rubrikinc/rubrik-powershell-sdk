// VersionedFile.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:35.
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
    #region VersionedFile
    public class VersionedFile: IFragment
    {
        #region members
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        [JsonProperty("absolutePath")]
        public System.String? AbsolutePath { get; set; }

        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        [JsonProperty("displayPath")]
        public System.String? DisplayPath { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<HierarchySnappableFileVersion>? FileVersions
        // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<HierarchySnappableFileVersion>? FileVersions { get; set; }

        #endregion

    #region methods

    public VersionedFile Set(
        System.String? AbsolutePath = null,
        System.String? DisplayPath = null,
        System.String? Filename = null,
        System.String? Path = null,
        List<HierarchySnappableFileVersion>? FileVersions = null
    ) 
    {
        if ( AbsolutePath != null ) {
            this.AbsolutePath = AbsolutePath;
        }
        if ( DisplayPath != null ) {
            this.DisplayPath = DisplayPath;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( FileVersions != null ) {
            this.FileVersions = FileVersions;
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
            //      C# -> System.String? AbsolutePath
            // GraphQL -> absolutePath: String! (scalar)
            if (this.AbsolutePath != null)
            {
                 s += ind + "absolutePath\n";

            }
            //      C# -> System.String? DisplayPath
            // GraphQL -> displayPath: String! (scalar)
            if (this.DisplayPath != null)
            {
                 s += ind + "displayPath\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> List<HierarchySnappableFileVersion>? FileVersions
            // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
            if (this.FileVersions != null)
            {
                 s += ind + "fileVersions\n";

                 s += ind + "{\n" + 
                 this.FileVersions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AbsolutePath
            // GraphQL -> absolutePath: String! (scalar)
            if (this.AbsolutePath == null && Exploration.Includes(parent + ".absolutePath$"))
            {
                this.AbsolutePath = new System.String("FETCH");
            }
            //      C# -> System.String? DisplayPath
            // GraphQL -> displayPath: String! (scalar)
            if (this.DisplayPath == null && Exploration.Includes(parent + ".displayPath$"))
            {
                this.DisplayPath = new System.String("FETCH");
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> List<HierarchySnappableFileVersion>? FileVersions
            // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
            if (this.FileVersions == null && Exploration.Includes(parent + ".fileVersions"))
            {
                this.FileVersions = new List<HierarchySnappableFileVersion>();
                this.FileVersions.ApplyExploratoryFragment(parent + ".fileVersions");
            }
        }


    #endregion

    } // class VersionedFile
    #endregion

    public static class ListVersionedFileExtensions
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
            this List<VersionedFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VersionedFile> list, 
            String parent = "")
        {
            var item = new VersionedFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types