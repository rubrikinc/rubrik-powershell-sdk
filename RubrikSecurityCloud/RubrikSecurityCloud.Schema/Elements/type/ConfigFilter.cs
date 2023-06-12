// ConfigFilter.cs
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
    #region ConfigFilter
    public class ConfigFilter: BaseType
    {
        #region members

        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        [JsonProperty("filterHeader")]
        public List<System.String>? FilterHeader { get; set; }

        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        [JsonProperty("filter")]
        public ReportFilter? Filter { get; set; }


        #endregion

    #region methods

    public ConfigFilter Set(
        List<System.String>? FilterHeader = null,
        ReportFilter? Filter = null
    ) 
    {
        if ( FilterHeader != null ) {
            this.FilterHeader = FilterHeader;
        }
        if ( Filter != null ) {
            this.Filter = Filter;
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
        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        if (this.FilterHeader != null) {
            s += ind + "filterHeader\n" ;
        }
        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        if (this.Filter != null) {
            var fspec = this.Filter.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filter {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        if (this.FilterHeader == null && Exploration.Includes(parent + ".filterHeader", true))
        {
            this.FilterHeader = new List<System.String>();
        }
        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        if (this.Filter == null && Exploration.Includes(parent + ".filter"))
        {
            this.Filter = new ReportFilter();
            this.Filter.ApplyExploratoryFieldSpec(parent + ".filter");
        }
    }


    #endregion

    } // class ConfigFilter
    
    #endregion

    public static class ListConfigFilterExtensions
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
            this List<ConfigFilter> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConfigFilter> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigFilter());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types