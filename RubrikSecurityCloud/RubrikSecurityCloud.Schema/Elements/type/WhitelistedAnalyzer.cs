// WhitelistedAnalyzer.cs
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
    #region WhitelistedAnalyzer
    public class WhitelistedAnalyzer: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsExplicit
        // GraphQL -> isExplicit: Boolean! (scalar)
        [JsonProperty("isExplicit")]
        public System.Boolean? IsExplicit { get; set; }

        //      C# -> System.String? WhitelistedAnalyzerId
        // GraphQL -> whitelistedAnalyzerId: String! (scalar)
        [JsonProperty("whitelistedAnalyzerId")]
        public System.String? WhitelistedAnalyzerId { get; set; }

        //      C# -> System.String? WhitelistedPath
        // GraphQL -> whitelistedPath: String! (scalar)
        [JsonProperty("whitelistedPath")]
        public System.String? WhitelistedPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WhitelistedAnalyzer";
    }

    public WhitelistedAnalyzer Set(
        System.Boolean? IsExplicit = null,
        System.String? WhitelistedAnalyzerId = null,
        System.String? WhitelistedPath = null
    ) 
    {
        if ( IsExplicit != null ) {
            this.IsExplicit = IsExplicit;
        }
        if ( WhitelistedAnalyzerId != null ) {
            this.WhitelistedAnalyzerId = WhitelistedAnalyzerId;
        }
        if ( WhitelistedPath != null ) {
            this.WhitelistedPath = WhitelistedPath;
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
        //      C# -> System.Boolean? IsExplicit
        // GraphQL -> isExplicit: Boolean! (scalar)
        if (this.IsExplicit != null) {
            s += ind + "isExplicit\n" ;
        }
        //      C# -> System.String? WhitelistedAnalyzerId
        // GraphQL -> whitelistedAnalyzerId: String! (scalar)
        if (this.WhitelistedAnalyzerId != null) {
            s += ind + "whitelistedAnalyzerId\n" ;
        }
        //      C# -> System.String? WhitelistedPath
        // GraphQL -> whitelistedPath: String! (scalar)
        if (this.WhitelistedPath != null) {
            s += ind + "whitelistedPath\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsExplicit
        // GraphQL -> isExplicit: Boolean! (scalar)
        if (this.IsExplicit == null && ec.Includes("isExplicit",true))
        {
            this.IsExplicit = true;
        }
        //      C# -> System.String? WhitelistedAnalyzerId
        // GraphQL -> whitelistedAnalyzerId: String! (scalar)
        if (this.WhitelistedAnalyzerId == null && ec.Includes("whitelistedAnalyzerId",true))
        {
            this.WhitelistedAnalyzerId = "FETCH";
        }
        //      C# -> System.String? WhitelistedPath
        // GraphQL -> whitelistedPath: String! (scalar)
        if (this.WhitelistedPath == null && ec.Includes("whitelistedPath",true))
        {
            this.WhitelistedPath = "FETCH";
        }
    }


    #endregion

    } // class WhitelistedAnalyzer
    
    #endregion

    public static class ListWhitelistedAnalyzerExtensions
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
            this List<WhitelistedAnalyzer> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WhitelistedAnalyzer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WhitelistedAnalyzer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<WhitelistedAnalyzer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types