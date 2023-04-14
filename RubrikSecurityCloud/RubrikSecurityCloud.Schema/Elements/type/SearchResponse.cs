// SearchResponse.cs
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
    #region SearchResponse
    public class SearchResponse: IFragment
    {
        #region members
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<FileVersion>? FileVersions
        // GraphQL -> fileVersions: [FileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<FileVersion>? FileVersions { get; set; }

        #endregion

    #region methods

    public SearchResponse Set(
        System.String? Filename = null,
        System.String? Path = null,
        List<FileVersion>? FileVersions = null
    ) 
    {
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
            //      C# -> System.String? Filename
            // GraphQL -> filename: String (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> List<FileVersion>? FileVersions
            // GraphQL -> fileVersions: [FileVersion!]! (type)
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
            //      C# -> System.String? Filename
            // GraphQL -> filename: String (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> List<FileVersion>? FileVersions
            // GraphQL -> fileVersions: [FileVersion!]! (type)
            if (this.FileVersions == null && Exploration.Includes(parent + ".fileVersions"))
            {
                this.FileVersions = new List<FileVersion>();
                this.FileVersions.ApplyExploratoryFragment(parent + ".fileVersions");
            }
        }


    #endregion

    } // class SearchResponse
    #endregion

    public static class ListSearchResponseExtensions
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
            this List<SearchResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SearchResponse> list, 
            String parent = "")
        {
            var item = new SearchResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types