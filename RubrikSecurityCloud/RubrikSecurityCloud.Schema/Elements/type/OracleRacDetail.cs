// OracleRacDetail.cs
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
    #region OracleRacDetail
    public class OracleRacDetail: BaseType
    {
        #region members

        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        [JsonProperty("scan")]
        public System.String? Scan { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }

        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        [JsonProperty("oracleRacSummary")]
        public OracleRacSummary? OracleRacSummary { get; set; }


        #endregion

    #region methods

    public OracleRacDetail Set(
        System.String? Scan = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null,
        OracleRacSummary? OracleRacSummary = null
    ) 
    {
        if ( Scan != null ) {
            this.Scan = Scan;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
        }
        if ( OracleRacSummary != null ) {
            this.OracleRacSummary = OracleRacSummary;
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
        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        if (this.Scan != null) {
            s += ind + "scan\n" ;
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleNonSlaProperties {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        if (this.OracleRacSummary != null) {
            var fspec = this.OracleRacSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleRacSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        if (this.Scan == null && Exploration.Includes(parent + ".scan", true))
        {
            this.Scan = "FETCH";
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties == null && Exploration.Includes(parent + ".oracleNonSlaProperties"))
        {
            this.OracleNonSlaProperties = new OracleNonSlaProperties();
            this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(parent + ".oracleNonSlaProperties");
        }
        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        if (this.OracleRacSummary == null && Exploration.Includes(parent + ".oracleRacSummary"))
        {
            this.OracleRacSummary = new OracleRacSummary();
            this.OracleRacSummary.ApplyExploratoryFieldSpec(parent + ".oracleRacSummary");
        }
    }


    #endregion

    } // class OracleRacDetail
    
    #endregion

    public static class ListOracleRacDetailExtensions
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
            this List<OracleRacDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleRacDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRacDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types