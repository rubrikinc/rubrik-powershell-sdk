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

    public override string GetGqlTypeName() {
        return "RunCustomAnalyzerReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<CustomAnalyzerMatch>? Matches
        // GraphQL -> matches: [CustomAnalyzerMatch!]! (type)
        if (this.Matches != null) {
            var fspec = this.Matches.AsFieldSpec(conf.Child("matches"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matches {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CustomAnalyzerMatch>? Matches
        // GraphQL -> matches: [CustomAnalyzerMatch!]! (type)
        if (ec.Includes("matches",false))
        {
            if(this.Matches == null) {

                this.Matches = new List<CustomAnalyzerMatch>();
                this.Matches.ApplyExploratoryFieldSpec(ec.NewChild("matches"));

            } else {

                this.Matches.ApplyExploratoryFieldSpec(ec.NewChild("matches"));

            }
        }
        else if (this.Matches != null && ec.Excludes("matches",false))
        {
            this.Matches = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RunCustomAnalyzerReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RunCustomAnalyzerReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RunCustomAnalyzerReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types