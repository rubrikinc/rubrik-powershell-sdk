// AwsNativeRdsPointInTimeRestoreWindow.cs
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
    #region AwsNativeRdsPointInTimeRestoreWindow
    public class AwsNativeRdsPointInTimeRestoreWindow: BaseType
    {
        #region members

        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        [JsonProperty("earliestTime")]
        public DateTime? EarliestTime { get; set; }

        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        [JsonProperty("latestTime")]
        public DateTime? LatestTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeRdsPointInTimeRestoreWindow";
    }

    public AwsNativeRdsPointInTimeRestoreWindow Set(
        DateTime? EarliestTime = null,
        DateTime? LatestTime = null
    ) 
    {
        if ( EarliestTime != null ) {
            this.EarliestTime = EarliestTime;
        }
        if ( LatestTime != null ) {
            this.LatestTime = LatestTime;
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
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (this.EarliestTime != null) {
            s += ind + "earliestTime\n" ;
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (this.LatestTime != null) {
            s += ind + "latestTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (this.EarliestTime == null && Exploration.Includes(parent + ".earliestTime", true))
        {
            this.EarliestTime = new DateTime();
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (this.LatestTime == null && Exploration.Includes(parent + ".latestTime", true))
        {
            this.LatestTime = new DateTime();
        }
    }


    #endregion

    } // class AwsNativeRdsPointInTimeRestoreWindow
    
    #endregion

    public static class ListAwsNativeRdsPointInTimeRestoreWindowExtensions
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
            this List<AwsNativeRdsPointInTimeRestoreWindow> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeRdsPointInTimeRestoreWindow> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeRdsPointInTimeRestoreWindow());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types