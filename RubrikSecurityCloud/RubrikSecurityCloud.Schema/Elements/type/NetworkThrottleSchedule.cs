// NetworkThrottleSchedule.cs
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
    #region NetworkThrottleSchedule
    public class NetworkThrottleSchedule: BaseType
    {
        #region members

        //      C# -> List<DayOfWeek>? DaysOfWeek
        // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
        [JsonProperty("daysOfWeek")]
        public List<DayOfWeek>? DaysOfWeek { get; set; }

        //      C# -> System.Int32? EndHour
        // GraphQL -> endHour: Int! (scalar)
        [JsonProperty("endHour")]
        public System.Int32? EndHour { get; set; }

        //      C# -> System.Int32? StartHour
        // GraphQL -> startHour: Int! (scalar)
        [JsonProperty("startHour")]
        public System.Int32? StartHour { get; set; }

        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        [JsonProperty("throttleLimit")]
        public System.Single? ThrottleLimit { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkThrottleSchedule";
    }

    public NetworkThrottleSchedule Set(
        List<DayOfWeek>? DaysOfWeek = null,
        System.Int32? EndHour = null,
        System.Int32? StartHour = null,
        System.Single? ThrottleLimit = null
    ) 
    {
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( EndHour != null ) {
            this.EndHour = EndHour;
        }
        if ( StartHour != null ) {
            this.StartHour = StartHour;
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
        //      C# -> List<DayOfWeek>? DaysOfWeek
        // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
        if (this.DaysOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "daysOfWeek\n" ;
            } else {
                s += ind + "daysOfWeek\n" ;
            }
        }
        //      C# -> System.Int32? EndHour
        // GraphQL -> endHour: Int! (scalar)
        if (this.EndHour != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endHour\n" ;
            } else {
                s += ind + "endHour\n" ;
            }
        }
        //      C# -> System.Int32? StartHour
        // GraphQL -> startHour: Int! (scalar)
        if (this.StartHour != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startHour\n" ;
            } else {
                s += ind + "startHour\n" ;
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
        //      C# -> List<DayOfWeek>? DaysOfWeek
        // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
        if (ec.Includes("daysOfWeek",true))
        {
            if(this.DaysOfWeek == null) {

                this.DaysOfWeek = new List<DayOfWeek>();

            } else {


            }
        }
        else if (this.DaysOfWeek != null && ec.Excludes("daysOfWeek",true))
        {
            this.DaysOfWeek = null;
        }
        //      C# -> System.Int32? EndHour
        // GraphQL -> endHour: Int! (scalar)
        if (ec.Includes("endHour",true))
        {
            if(this.EndHour == null) {

                this.EndHour = Int32.MinValue;

            } else {


            }
        }
        else if (this.EndHour != null && ec.Excludes("endHour",true))
        {
            this.EndHour = null;
        }
        //      C# -> System.Int32? StartHour
        // GraphQL -> startHour: Int! (scalar)
        if (ec.Includes("startHour",true))
        {
            if(this.StartHour == null) {

                this.StartHour = Int32.MinValue;

            } else {


            }
        }
        else if (this.StartHour != null && ec.Excludes("startHour",true))
        {
            this.StartHour = null;
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

    } // class NetworkThrottleSchedule
    
    #endregion

    public static class ListNetworkThrottleScheduleExtensions
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
            this List<NetworkThrottleSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkThrottleSchedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkThrottleSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkThrottleSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types