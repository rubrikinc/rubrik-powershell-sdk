// WorkloadRecoveryInfo.cs
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
    #region WorkloadRecoveryInfo
    public class WorkloadRecoveryInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        [JsonProperty("isRefreshInProgressOpt")]
        public System.Boolean? IsRefreshInProgressOpt { get; set; }

        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        [JsonProperty("lastUpdatedTimeOpt")]
        public DateTime? LastUpdatedTimeOpt { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? NewWorkloadId
        // GraphQL -> newWorkloadId: String! (scalar)
        [JsonProperty("newWorkloadId")]
        public System.String? NewWorkloadId { get; set; }

        //      C# -> System.String? OldWorkloadId
        // GraphQL -> oldWorkloadId: String! (scalar)
        [JsonProperty("oldWorkloadId")]
        public System.String? OldWorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadRecoveryInfo";
    }

    public WorkloadRecoveryInfo Set(
        System.Boolean? IsRefreshInProgressOpt = null,
        DateTime? LastUpdatedTimeOpt = null,
        System.String? LocationId = null,
        System.String? NewWorkloadId = null,
        System.String? OldWorkloadId = null
    ) 
    {
        if ( IsRefreshInProgressOpt != null ) {
            this.IsRefreshInProgressOpt = IsRefreshInProgressOpt;
        }
        if ( LastUpdatedTimeOpt != null ) {
            this.LastUpdatedTimeOpt = LastUpdatedTimeOpt;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( NewWorkloadId != null ) {
            this.NewWorkloadId = NewWorkloadId;
        }
        if ( OldWorkloadId != null ) {
            this.OldWorkloadId = OldWorkloadId;
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
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (this.IsRefreshInProgressOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRefreshInProgressOpt\n" ;
            } else {
                s += ind + "isRefreshInProgressOpt\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (this.LastUpdatedTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedTimeOpt\n" ;
            } else {
                s += ind + "lastUpdatedTimeOpt\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? NewWorkloadId
        // GraphQL -> newWorkloadId: String! (scalar)
        if (this.NewWorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newWorkloadId\n" ;
            } else {
                s += ind + "newWorkloadId\n" ;
            }
        }
        //      C# -> System.String? OldWorkloadId
        // GraphQL -> oldWorkloadId: String! (scalar)
        if (this.OldWorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldWorkloadId\n" ;
            } else {
                s += ind + "oldWorkloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (ec.Includes("isRefreshInProgressOpt",true))
        {
            if(this.IsRefreshInProgressOpt == null) {

                this.IsRefreshInProgressOpt = true;

            } else {


            }
        }
        else if (this.IsRefreshInProgressOpt != null && ec.Excludes("isRefreshInProgressOpt",true))
        {
            this.IsRefreshInProgressOpt = null;
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (ec.Includes("lastUpdatedTimeOpt",true))
        {
            if(this.LastUpdatedTimeOpt == null) {

                this.LastUpdatedTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedTimeOpt != null && ec.Excludes("lastUpdatedTimeOpt",true))
        {
            this.LastUpdatedTimeOpt = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? NewWorkloadId
        // GraphQL -> newWorkloadId: String! (scalar)
        if (ec.Includes("newWorkloadId",true))
        {
            if(this.NewWorkloadId == null) {

                this.NewWorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.NewWorkloadId != null && ec.Excludes("newWorkloadId",true))
        {
            this.NewWorkloadId = null;
        }
        //      C# -> System.String? OldWorkloadId
        // GraphQL -> oldWorkloadId: String! (scalar)
        if (ec.Includes("oldWorkloadId",true))
        {
            if(this.OldWorkloadId == null) {

                this.OldWorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.OldWorkloadId != null && ec.Excludes("oldWorkloadId",true))
        {
            this.OldWorkloadId = null;
        }
    }


    #endregion

    } // class WorkloadRecoveryInfo
    
    #endregion

    public static class ListWorkloadRecoveryInfoExtensions
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
            this List<WorkloadRecoveryInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadRecoveryInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadRecoveryInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadRecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types