// CustomAnalyzerMatch.cs
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
    #region CustomAnalyzerMatch
    public class CustomAnalyzerMatch: BaseType
    {
        #region members

        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        [JsonProperty("endIndex")]
        public System.Int32? EndIndex { get; set; }

        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        [JsonProperty("startIndex")]
        public System.Int32? StartIndex { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomAnalyzerMatch";
    }

    public CustomAnalyzerMatch Set(
        System.Int32? EndIndex = null,
        System.Int32? StartIndex = null
    ) 
    {
        if ( EndIndex != null ) {
            this.EndIndex = EndIndex;
        }
        if ( StartIndex != null ) {
            this.StartIndex = StartIndex;
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
        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        if (this.EndIndex != null) {
            s += ind + "endIndex\n" ;
        }
        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        if (this.StartIndex != null) {
            s += ind + "startIndex\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        if (this.EndIndex == null && Exploration.Includes(parent + ".endIndex", true))
        {
            this.EndIndex = Int32.MinValue;
        }
        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        if (this.StartIndex == null && Exploration.Includes(parent + ".startIndex", true))
        {
            this.StartIndex = Int32.MinValue;
        }
    }


    #endregion

    } // class CustomAnalyzerMatch
    
    #endregion

    public static class ListCustomAnalyzerMatchExtensions
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
            this List<CustomAnalyzerMatch> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CustomAnalyzerMatch> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomAnalyzerMatch());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types