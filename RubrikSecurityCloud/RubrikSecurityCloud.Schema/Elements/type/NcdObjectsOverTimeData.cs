// NcdObjectsOverTimeData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:12.
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
    #region NcdObjectsOverTimeData
    public class NcdObjectsOverTimeData: IFragment
    {
        #region members
        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        [JsonProperty("directories")]
        public System.Int32? Directories { get; set; }

        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        [JsonProperty("files")]
        public System.Int32? Files { get; set; }

        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        [JsonProperty("links")]
        public System.Int32? Links { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        #endregion

    #region methods

    public NcdObjectsOverTimeData Set(
        System.Int32? Directories = null,
        System.Int32? Files = null,
        System.Int32? Links = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( Directories != null ) {
            this.Directories = Directories;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
            //      C# -> System.Int32? Directories
            // GraphQL -> directories: Int! (scalar)
            if (this.Directories != null)
            {
                 s += ind + "directories\n";

            }
            //      C# -> System.Int32? Files
            // GraphQL -> files: Int! (scalar)
            if (this.Files != null)
            {
                 s += ind + "files\n";

            }
            //      C# -> System.Int32? Links
            // GraphQL -> links: Int! (scalar)
            if (this.Links != null)
            {
                 s += ind + "links\n";

            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Directories
            // GraphQL -> directories: Int! (scalar)
            if (this.Directories == null && Exploration.Includes(parent + ".directories$"))
            {
                this.Directories = new System.Int32();
            }
            //      C# -> System.Int32? Files
            // GraphQL -> files: Int! (scalar)
            if (this.Files == null && Exploration.Includes(parent + ".files$"))
            {
                this.Files = new System.Int32();
            }
            //      C# -> System.Int32? Links
            // GraphQL -> links: Int! (scalar)
            if (this.Links == null && Exploration.Includes(parent + ".links$"))
            {
                this.Links = new System.Int32();
            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new DateTime();
            }
        }


    #endregion

    } // class NcdObjectsOverTimeData
    #endregion

    public static class ListNcdObjectsOverTimeDataExtensions
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
            this List<NcdObjectsOverTimeData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdObjectsOverTimeData> list, 
            String parent = "")
        {
            var item = new NcdObjectsOverTimeData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types