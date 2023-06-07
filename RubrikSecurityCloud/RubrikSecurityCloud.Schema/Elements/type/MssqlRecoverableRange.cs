// MssqlRecoverableRange.cs
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
    #region MssqlRecoverableRange
    public class MssqlRecoverableRange: BaseType
    {
        #region members

        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Boolean? IsMountAllowed
        // GraphQL -> isMountAllowed: Boolean! (scalar)
        [JsonProperty("isMountAllowed")]
        public System.Boolean? IsMountAllowed { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public MssqlRecoverableRange Set(
        DateTime? BeginTime = null,
        DateTime? EndTime = null,
        System.Boolean? IsMountAllowed = null,
        System.String? Status = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( IsMountAllowed != null ) {
            this.IsMountAllowed = IsMountAllowed;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime != null) {
            s += ind + "beginTime\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Boolean? IsMountAllowed
        // GraphQL -> isMountAllowed: Boolean! (scalar)
        if (this.IsMountAllowed != null) {
            s += ind + "isMountAllowed\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime == null && Exploration.Includes(parent + ".beginTime", true))
        {
            this.BeginTime = new DateTime();
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.Boolean? IsMountAllowed
        // GraphQL -> isMountAllowed: Boolean! (scalar)
        if (this.IsMountAllowed == null && Exploration.Includes(parent + ".isMountAllowed", true))
        {
            this.IsMountAllowed = true;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class MssqlRecoverableRange
    
    #endregion

    public static class ListMssqlRecoverableRangeExtensions
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
            this List<MssqlRecoverableRange> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRecoverableRange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRecoverableRange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types