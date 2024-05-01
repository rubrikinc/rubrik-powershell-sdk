// NetworkThrottleScheduleSummary.cs
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
    #region NetworkThrottleScheduleSummary
    public class NetworkThrottleScheduleSummary: BaseType
    {
        #region members

        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        [JsonProperty("daysOfWeek")]
        public List<System.Int32>? DaysOfWeek { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        [JsonProperty("throttleLimit")]
        public System.Single? ThrottleLimit { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkThrottleScheduleSummary";
    }

    public NetworkThrottleScheduleSummary Set(
        List<System.Int32>? DaysOfWeek = null,
        System.Int64? EndTime = null,
        System.Int64? StartTime = null,
        System.Single? ThrottleLimit = null
    ) 
    {
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( ThrottleLimit != null ) {
            this.ThrottleLimit = ThrottleLimit;
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
        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        if (this.DaysOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "daysOfWeek\n" ;
            } else {
                s += ind + "daysOfWeek\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        if (this.ThrottleLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throttleLimit\n" ;
            } else {
                s += ind + "throttleLimit\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        if (ec.Includes("daysOfWeek",true))
        {
            if(this.DaysOfWeek == null) {

                this.DaysOfWeek = new List<System.Int32>();

            } else {


            }
        }
        else if (this.DaysOfWeek != null && ec.Excludes("daysOfWeek",true))
        {
            this.DaysOfWeek = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        if (ec.Includes("throttleLimit",true))
        {
            if(this.ThrottleLimit == null) {

                this.ThrottleLimit = new System.Single();

            } else {


            }
        }
        else if (this.ThrottleLimit != null && ec.Excludes("throttleLimit",true))
        {
            this.ThrottleLimit = null;
        }
    }


    #endregion

    } // class NetworkThrottleScheduleSummary
    
    #endregion

    public static class ListNetworkThrottleScheduleSummaryExtensions
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
            this List<NetworkThrottleScheduleSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NetworkThrottleScheduleSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkThrottleScheduleSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkThrottleScheduleSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkThrottleScheduleSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types