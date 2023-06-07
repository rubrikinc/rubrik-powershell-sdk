// MosaicRecoverableRangeObject.cs
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
    #region MosaicRecoverableRangeObject
    public class MosaicRecoverableRangeObject: BaseType
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

    public MosaicRecoverableRangeObject Set(
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        if (this.EarliestTimestamp == null && Exploration.Includes(parent + ".earliestTimestamp", true))
        {
            this.EarliestTimestamp = "FETCH";
        }
        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        if (this.LatestTimestamp == null && Exploration.Includes(parent + ".latestTimestamp", true))
        {
            this.LatestTimestamp = "FETCH";
        }
    }


    #endregion

    } // class MosaicRecoverableRangeObject
    
    #endregion

    public static class ListMosaicRecoverableRangeObjectExtensions
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
            this List<MosaicRecoverableRangeObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicRecoverableRangeObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicRecoverableRangeObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types