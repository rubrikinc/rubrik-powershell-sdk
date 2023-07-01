// OracleDatabaseLastValidationStatus.cs
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
    #region OracleDatabaseLastValidationStatus
    public class OracleDatabaseLastValidationStatus: BaseType
    {
        #region members

        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        [JsonProperty("timestampMs")]
        public DateTime? TimestampMs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleDatabaseLastValidationStatus";
    }

    public OracleDatabaseLastValidationStatus Set(
        System.String? EventId = null,
        System.Boolean? IsSuccess = null,
        System.String? SnapshotId = null,
        DateTime? TimestampMs = null
    ) 
    {
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( TimestampMs != null ) {
            this.TimestampMs = TimestampMs;
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
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            s += ind + "eventId\n" ;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            s += ind + "isSuccess\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        if (this.TimestampMs != null) {
            s += ind + "timestampMs\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId == null && Exploration.Includes(parent + ".eventId", true))
        {
            this.EventId = "FETCH";
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess", true))
        {
            this.IsSuccess = true;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        if (this.TimestampMs == null && Exploration.Includes(parent + ".timestampMs", true))
        {
            this.TimestampMs = new DateTime();
        }
    }


    #endregion

    } // class OracleDatabaseLastValidationStatus
    
    #endregion

    public static class ListOracleDatabaseLastValidationStatusExtensions
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
            this List<OracleDatabaseLastValidationStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleDatabaseLastValidationStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDatabaseLastValidationStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types