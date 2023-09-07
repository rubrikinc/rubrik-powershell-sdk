// MosaicRecoveryRangeObject.cs
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
    #region MosaicRecoveryRangeObject
    public class MosaicRecoveryRangeObject: BaseType
    {
        #region members

        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        [JsonProperty("earliestTimestamp")]
        public System.String? EarliestTimestamp { get; set; }

        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        [JsonProperty("latestTimestamp")]
        public System.String? LatestTimestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicRecoveryRangeObject";
    }

    public MosaicRecoveryRangeObject Set(
        System.String? EarliestTimestamp = null,
        System.String? LatestTimestamp = null
    ) 
    {
        if ( EarliestTimestamp != null ) {
            this.EarliestTimestamp = EarliestTimestamp;
        }
        if ( LatestTimestamp != null ) {
            this.LatestTimestamp = LatestTimestamp;
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
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        if (this.EarliestTimestamp != null) {
            s += ind + "earliestTimestamp\n" ;
        }
        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        if (this.LatestTimestamp != null) {
            s += ind + "latestTimestamp\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        if (this.EarliestTimestamp == null && ec.Includes("earliestTimestamp",true))
        {
            this.EarliestTimestamp = "FETCH";
        }
        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        if (this.LatestTimestamp == null && ec.Includes("latestTimestamp",true))
        {
            this.LatestTimestamp = "FETCH";
        }
    }


    #endregion

    } // class MosaicRecoveryRangeObject
    
    #endregion

    public static class ListMosaicRecoveryRangeObjectExtensions
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
            this List<MosaicRecoveryRangeObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicRecoveryRangeObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicRecoveryRangeObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MosaicRecoveryRangeObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types