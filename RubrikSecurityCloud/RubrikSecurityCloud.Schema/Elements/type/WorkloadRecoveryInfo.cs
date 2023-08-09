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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (this.IsRefreshInProgressOpt != null) {
            s += ind + "isRefreshInProgressOpt\n" ;
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (this.LastUpdatedTimeOpt != null) {
            s += ind + "lastUpdatedTimeOpt\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> System.String? NewWorkloadId
        // GraphQL -> newWorkloadId: String! (scalar)
        if (this.NewWorkloadId != null) {
            s += ind + "newWorkloadId\n" ;
        }
        //      C# -> System.String? OldWorkloadId
        // GraphQL -> oldWorkloadId: String! (scalar)
        if (this.OldWorkloadId != null) {
            s += ind + "oldWorkloadId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (this.IsRefreshInProgressOpt == null && Exploration.Includes(parent + ".isRefreshInProgressOpt", true))
        {
            this.IsRefreshInProgressOpt = true;
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (this.LastUpdatedTimeOpt == null && Exploration.Includes(parent + ".lastUpdatedTimeOpt", true))
        {
            this.LastUpdatedTimeOpt = new DateTime();
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = "FETCH";
        }
        //      C# -> System.String? NewWorkloadId
        // GraphQL -> newWorkloadId: String! (scalar)
        if (this.NewWorkloadId == null && Exploration.Includes(parent + ".newWorkloadId", true))
        {
            this.NewWorkloadId = "FETCH";
        }
        //      C# -> System.String? OldWorkloadId
        // GraphQL -> oldWorkloadId: String! (scalar)
        if (this.OldWorkloadId == null && Exploration.Includes(parent + ".oldWorkloadId", true))
        {
            this.OldWorkloadId = "FETCH";
        }
    }


    #endregion

    } // class WorkloadRecoveryInfo
    
    #endregion

    public static class ListWorkloadRecoveryInfoExtensions
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
            this List<WorkloadRecoveryInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadRecoveryInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types