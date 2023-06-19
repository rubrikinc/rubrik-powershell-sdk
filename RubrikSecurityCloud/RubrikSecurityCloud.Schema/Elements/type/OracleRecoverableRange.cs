// OracleRecoverableRange.cs
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
    #region OracleRecoverableRange
    public class OracleRecoverableRange: BaseType
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

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<OracleDbSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [OracleDbSnapshotSummary!]! (type)
        [JsonProperty("dbSnapshotSummaries")]
        public List<OracleDbSnapshotSummary>? DbSnapshotSummaries { get; set; }


        #endregion

    #region methods

    public OracleRecoverableRange Set(
        DateTime? BeginTime = null,
        DateTime? EndTime = null,
        System.String? Status = null,
        List<OracleDbSnapshotSummary>? DbSnapshotSummaries = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( DbSnapshotSummaries != null ) {
            this.DbSnapshotSummaries = DbSnapshotSummaries;
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<OracleDbSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [OracleDbSnapshotSummary!]! (type)
        if (this.DbSnapshotSummaries != null) {
            var fspec = this.DbSnapshotSummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "dbSnapshotSummaries {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> List<OracleDbSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [OracleDbSnapshotSummary!]! (type)
        if (this.DbSnapshotSummaries == null && Exploration.Includes(parent + ".dbSnapshotSummaries"))
        {
            this.DbSnapshotSummaries = new List<OracleDbSnapshotSummary>();
            this.DbSnapshotSummaries.ApplyExploratoryFieldSpec(parent + ".dbSnapshotSummaries");
        }
    }


    #endregion

    } // class OracleRecoverableRange
    
    #endregion

    public static class ListOracleRecoverableRangeExtensions
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
            this List<OracleRecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleRecoverableRange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRecoverableRange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types