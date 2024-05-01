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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventId\n" ;
            } else {
                s += ind + "eventId\n" ;
            }
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccess\n" ;
            } else {
                s += ind + "isSuccess\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        if (this.TimestampMs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestampMs\n" ;
            } else {
                s += ind + "timestampMs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (ec.Includes("eventId",true))
        {
            if(this.EventId == null) {

                this.EventId = "FETCH";

            } else {


            }
        }
        else if (this.EventId != null && ec.Excludes("eventId",true))
        {
            this.EventId = null;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (ec.Includes("isSuccess",true))
        {
            if(this.IsSuccess == null) {

                this.IsSuccess = true;

            } else {


            }
        }
        else if (this.IsSuccess != null && ec.Excludes("isSuccess",true))
        {
            this.IsSuccess = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        if (ec.Includes("timestampMs",true))
        {
            if(this.TimestampMs == null) {

                this.TimestampMs = new DateTime();

            } else {


            }
        }
        else if (this.TimestampMs != null && ec.Excludes("timestampMs",true))
        {
            this.TimestampMs = null;
        }
    }


    #endregion

    } // class OracleDatabaseLastValidationStatus
    
    #endregion

    public static class ListOracleDatabaseLastValidationStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OracleDatabaseLastValidationStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleDatabaseLastValidationStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleDatabaseLastValidationStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDatabaseLastValidationStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleDatabaseLastValidationStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types