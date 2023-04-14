// Row.cs
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
    #region Row
    public class Row: IFragment
    {
        #region members
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> List<CellData>? Values
        // GraphQL -> values: [CellData!]! (type)
        [JsonProperty("values")]
        public List<CellData>? Values { get; set; }

        #endregion

    #region methods

    public Row Set(
        List<Metadata>? Metadata = null,
        List<CellData>? Values = null
    ) 
    {
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( Values != null ) {
            this.Values = Values;
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
            //      C# -> List<Metadata>? Metadata
            // GraphQL -> metadata: [Metadata!]! (type)
            if (this.Metadata != null)
            {
                 s += ind + "metadata\n";

                 s += ind + "{\n" + 
                 this.Metadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<CellData>? Values
            // GraphQL -> values: [CellData!]! (type)
            if (this.Values != null)
            {
                 s += ind + "values\n";

                 s += ind + "{\n" + 
                 this.Values.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<Metadata>? Metadata
            // GraphQL -> metadata: [Metadata!]! (type)
            if (this.Metadata == null && Exploration.Includes(parent + ".metadata"))
            {
                this.Metadata = new List<Metadata>();
                this.Metadata.ApplyExploratoryFragment(parent + ".metadata");
            }
            //      C# -> List<CellData>? Values
            // GraphQL -> values: [CellData!]! (type)
            if (this.Values == null && Exploration.Includes(parent + ".values"))
            {
                this.Values = new List<CellData>();
                this.Values.ApplyExploratoryFragment(parent + ".values");
            }
        }


    #endregion

    } // class Row
    #endregion

    public static class ListRowExtensions
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
            this List<Row> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Row> list, 
            String parent = "")
        {
            var item = new Row();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types