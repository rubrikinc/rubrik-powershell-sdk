// OracleHostDetail.cs
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
    #region OracleHostDetail
    public class OracleHostDetail: BaseType
    {
        #region members

        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        [JsonProperty("oracleHostSummary")]
        public OracleHostSummary? OracleHostSummary { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }


        #endregion

    #region methods

    public OracleHostDetail Set(
        OracleHostSummary? OracleHostSummary = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null
    ) 
    {
        if ( OracleHostSummary != null ) {
            this.OracleHostSummary = OracleHostSummary;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
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
        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        if (this.OracleHostSummary != null) {
            var fspec = this.OracleHostSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleHostSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleNonSlaProperties {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        if (this.OracleHostSummary == null && Exploration.Includes(parent + ".oracleHostSummary"))
        {
            this.OracleHostSummary = new OracleHostSummary();
            this.OracleHostSummary.ApplyExploratoryFieldSpec(parent + ".oracleHostSummary");
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties == null && Exploration.Includes(parent + ".oracleNonSlaProperties"))
        {
            this.OracleNonSlaProperties = new OracleNonSlaProperties();
            this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(parent + ".oracleNonSlaProperties");
        }
    }


    #endregion

    } // class OracleHostDetail
    
    #endregion

    public static class ListOracleHostDetailExtensions
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
            this List<OracleHostDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleHostDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types