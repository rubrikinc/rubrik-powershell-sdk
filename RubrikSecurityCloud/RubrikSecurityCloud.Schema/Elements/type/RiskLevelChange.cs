// RiskLevelChange.cs
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
    #region RiskLevelChange
    public class RiskLevelChange: BaseType
    {
        #region members

        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        [JsonProperty("from")]
        public RiskLevelType? From { get; set; }

        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        [JsonProperty("to")]
        public RiskLevelType? To { get; set; }


        #endregion

    #region methods

    public RiskLevelChange Set(
        RiskLevelType? From = null,
        RiskLevelType? To = null
    ) 
    {
        if ( From != null ) {
            this.From = From;
        }
        if ( To != null ) {
            this.To = To;
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
        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        if (this.From != null) {
            s += ind + "from\n" ;
        }
        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        if (this.To != null) {
            s += ind + "to\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        if (this.From == null && Exploration.Includes(parent + ".from", true))
        {
            this.From = new RiskLevelType();
        }
        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        if (this.To == null && Exploration.Includes(parent + ".to", true))
        {
            this.To = new RiskLevelType();
        }
    }


    #endregion

    } // class RiskLevelChange
    
    #endregion

    public static class ListRiskLevelChangeExtensions
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
            this List<RiskLevelChange> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RiskLevelChange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RiskLevelChange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types