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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        if (this.EndIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endIndex\n" ;
            } else {
                s += ind + "endIndex\n" ;
            }
        }
        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        if (this.StartIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startIndex\n" ;
            } else {
                s += ind + "startIndex\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        if (ec.Includes("endIndex",true))
        {
            if(this.EndIndex == null) {

                this.EndIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.EndIndex != null && ec.Excludes("endIndex",true))
        {
            this.EndIndex = null;
        }
        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        if (ec.Includes("startIndex",true))
        {
            if(this.StartIndex == null) {

                this.StartIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.StartIndex != null && ec.Excludes("startIndex",true))
        {
            this.StartIndex = null;
        }
    }


    #endregion

    } // class CustomAnalyzerMatch
    
    #endregion

    public static class ListCustomAnalyzerMatchExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CustomAnalyzerMatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomAnalyzerMatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomAnalyzerMatch> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomAnalyzerMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomAnalyzerMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types