// NetworkThrottle.cs
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
    #region NetworkThrottle
    public class NetworkThrottle: BaseType
    {
        #region members

        //      C# -> System.Single? CurrentThrottleLimit
        // GraphQL -> currentThrottleLimit: Float! (scalar)
        [JsonProperty("currentThrottleLimit")]
        public System.Single? CurrentThrottleLimit { get; set; }

        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float! (scalar)
        [JsonProperty("defaultThrottleLimit")]
        public System.Single? DefaultThrottleLimit { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String! (scalar)
        [JsonProperty("networkInterface")]
        public System.String? NetworkInterface { get; set; }

        //      C# -> List<NetworkThrottleSchedule>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleSchedule!]! (type)
        [JsonProperty("scheduledThrottles")]
        public List<NetworkThrottleSchedule>? ScheduledThrottles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkThrottle";
    }

    public NetworkThrottle Set(
        System.Single? CurrentThrottleLimit = null,
        System.Single? DefaultThrottleLimit = null,
        System.Boolean? IsEnabled = null,
        System.String? NetworkInterface = null,
        List<NetworkThrottleSchedule>? ScheduledThrottles = null
    ) 
    {
        if ( CurrentThrottleLimit != null ) {
            this.CurrentThrottleLimit = CurrentThrottleLimit;
        }
        if ( DefaultThrottleLimit != null ) {
            this.DefaultThrottleLimit = DefaultThrottleLimit;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( NetworkInterface != null ) {
            this.NetworkInterface = NetworkInterface;
        }
        if ( ScheduledThrottles != null ) {
            this.ScheduledThrottles = ScheduledThrottles;
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
        //      C# -> System.Single? CurrentThrottleLimit
        // GraphQL -> currentThrottleLimit: Float! (scalar)
        if (this.CurrentThrottleLimit != null) {
            s += ind + "currentThrottleLimit\n" ;
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float! (scalar)
        if (this.DefaultThrottleLimit != null) {
            s += ind + "defaultThrottleLimit\n" ;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            s += ind + "isEnabled\n" ;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String! (scalar)
        if (this.NetworkInterface != null) {
            s += ind + "networkInterface\n" ;
        }
        //      C# -> List<NetworkThrottleSchedule>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleSchedule!]! (type)
        if (this.ScheduledThrottles != null) {
            var fspec = this.ScheduledThrottles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "scheduledThrottles {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? CurrentThrottleLimit
        // GraphQL -> currentThrottleLimit: Float! (scalar)
        if (this.CurrentThrottleLimit == null && ec.Includes("currentThrottleLimit",true))
        {
            this.CurrentThrottleLimit = new System.Single();
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float! (scalar)
        if (this.DefaultThrottleLimit == null && ec.Includes("defaultThrottleLimit",true))
        {
            this.DefaultThrottleLimit = new System.Single();
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled == null && ec.Includes("isEnabled",true))
        {
            this.IsEnabled = true;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String! (scalar)
        if (this.NetworkInterface == null && ec.Includes("networkInterface",true))
        {
            this.NetworkInterface = "FETCH";
        }
        //      C# -> List<NetworkThrottleSchedule>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleSchedule!]! (type)
        if (this.ScheduledThrottles == null && ec.Includes("scheduledThrottles",false))
        {
            this.ScheduledThrottles = new List<NetworkThrottleSchedule>();
            this.ScheduledThrottles.ApplyExploratoryFieldSpec(ec.NewChild("scheduledThrottles"));
        }
    }


    #endregion

    } // class NetworkThrottle
    
    #endregion

    public static class ListNetworkThrottleExtensions
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
            this List<NetworkThrottle> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkThrottle> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkThrottle());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkThrottle> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types