// SapHanaLogPositionInterval.cs
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
    #region SapHanaLogPositionInterval
    public class SapHanaLogPositionInterval: BaseType
    {
        #region members

        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        [JsonProperty("newestLogPosition")]
        public System.Int64? NewestLogPosition { get; set; }

        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        [JsonProperty("oldestLogPosition")]
        public System.Int64? OldestLogPosition { get; set; }


        #endregion

    #region methods

    public SapHanaLogPositionInterval Set(
        System.Int64? NewestLogPosition = null,
        System.Int64? OldestLogPosition = null
    ) 
    {
        if ( NewestLogPosition != null ) {
            this.NewestLogPosition = NewestLogPosition;
        }
        if ( OldestLogPosition != null ) {
            this.OldestLogPosition = OldestLogPosition;
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
        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        if (this.NewestLogPosition != null) {
            s += ind + "newestLogPosition\n" ;
        }
        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        if (this.OldestLogPosition != null) {
            s += ind + "oldestLogPosition\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        if (this.NewestLogPosition == null && Exploration.Includes(parent + ".newestLogPosition", true))
        {
            this.NewestLogPosition = new System.Int64();
        }
        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        if (this.OldestLogPosition == null && Exploration.Includes(parent + ".oldestLogPosition", true))
        {
            this.OldestLogPosition = new System.Int64();
        }
    }


    #endregion

    } // class SapHanaLogPositionInterval
    
    #endregion

    public static class ListSapHanaLogPositionIntervalExtensions
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
            this List<SapHanaLogPositionInterval> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogPositionInterval> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogPositionInterval());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types