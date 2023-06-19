// RunCustomAnalyzerReply.cs
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
    #region RunCustomAnalyzerReply
    public class RunCustomAnalyzerReply: BaseType
    {
        #region members

        //      C# -> List<CustomAnalyzerMatch>? Matches
        // GraphQL -> matches: [CustomAnalyzerMatch!]! (type)
        [JsonProperty("matches")]
        public List<CustomAnalyzerMatch>? Matches { get; set; }


        #endregion

    #region methods

    public RunCustomAnalyzerReply Set(
        List<CustomAnalyzerMatch>? Matches = null
    ) 
    {
        if ( Matches != null ) {
            this.Matches = Matches;
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
        //      C# -> List<CustomAnalyzerMatch>? Matches
        // GraphQL -> matches: [CustomAnalyzerMatch!]! (type)
        if (this.Matches != null) {
            var fspec = this.Matches.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "matches {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<CustomAnalyzerMatch>? Matches
        // GraphQL -> matches: [CustomAnalyzerMatch!]! (type)
        if (this.Matches == null && Exploration.Includes(parent + ".matches"))
        {
            this.Matches = new List<CustomAnalyzerMatch>();
            this.Matches.ApplyExploratoryFieldSpec(parent + ".matches");
        }
    }


    #endregion

    } // class RunCustomAnalyzerReply
    
    #endregion

    public static class ListRunCustomAnalyzerReplyExtensions
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
            this List<RunCustomAnalyzerReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RunCustomAnalyzerReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RunCustomAnalyzerReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types