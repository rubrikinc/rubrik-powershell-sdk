// NcdObjectsOverTimeData.cs
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
    #region NcdObjectsOverTimeData
    public class NcdObjectsOverTimeData: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        if (this.Directories != null) {
            s += ind + "directories\n" ;
        }
        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        if (this.Files != null) {
            s += ind + "files\n" ;
        }
        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        if (this.Links != null) {
            s += ind + "links\n" ;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        if (this.Directories == null && Exploration.Includes(parent + ".directories", true))
        {
            this.Directories = Int32.MinValue;
        }
        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        if (this.Files == null && Exploration.Includes(parent + ".files", true))
        {
            this.Files = Int32.MinValue;
        }
        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        if (this.Links == null && Exploration.Includes(parent + ".links", true))
        {
            this.Links = Int32.MinValue;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = new DateTime();
        }
    }


    #endregion

    } // class NcdObjectsOverTimeData
    
    #endregion

    public static class ListNcdObjectsOverTimeDataExtensions
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
            this List<NcdObjectsOverTimeData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdObjectsOverTimeData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdObjectsOverTimeData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types