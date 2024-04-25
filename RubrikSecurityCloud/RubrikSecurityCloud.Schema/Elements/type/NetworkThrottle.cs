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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Single? CurrentThrottleLimit
        // GraphQL -> currentThrottleLimit: Float! (scalar)
        if (this.CurrentThrottleLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentThrottleLimit\n" ;
            } else {
                s += ind + "currentThrottleLimit\n" ;
            }
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float! (scalar)
        if (this.DefaultThrottleLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultThrottleLimit\n" ;
            } else {
                s += ind + "defaultThrottleLimit\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String! (scalar)
        if (this.NetworkInterface != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkInterface\n" ;
            } else {
                s += ind + "networkInterface\n" ;
            }
        }
        //      C# -> List<NetworkThrottleSchedule>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleSchedule!]! (type)
        if (this.ScheduledThrottles != null) {
            var fspec = this.ScheduledThrottles.AsFieldSpec(conf.Child("scheduledThrottles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scheduledThrottles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? CurrentThrottleLimit
        // GraphQL -> currentThrottleLimit: Float! (scalar)
        if (ec.Includes("currentThrottleLimit",true))
        {
            if(this.CurrentThrottleLimit == null) {

                this.CurrentThrottleLimit = new System.Single();

            } else {


            }
        }
        else if (this.CurrentThrottleLimit != null && ec.Excludes("currentThrottleLimit",true))
        {
            this.CurrentThrottleLimit = null;
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float! (scalar)
        if (ec.Includes("defaultThrottleLimit",true))
        {
            if(this.DefaultThrottleLimit == null) {

                this.DefaultThrottleLimit = new System.Single();

            } else {


            }
        }
        else if (this.DefaultThrottleLimit != null && ec.Excludes("defaultThrottleLimit",true))
        {
            this.DefaultThrottleLimit = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String! (scalar)
        if (ec.Includes("networkInterface",true))
        {
            if(this.NetworkInterface == null) {

                this.NetworkInterface = "FETCH";

            } else {


            }
        }
        else if (this.NetworkInterface != null && ec.Excludes("networkInterface",true))
        {
            this.NetworkInterface = null;
        }
        //      C# -> List<NetworkThrottleSchedule>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleSchedule!]! (type)
        if (ec.Includes("scheduledThrottles",false))
        {
            if(this.ScheduledThrottles == null) {

                this.ScheduledThrottles = new List<NetworkThrottleSchedule>();
                this.ScheduledThrottles.ApplyExploratoryFieldSpec(ec.NewChild("scheduledThrottles"));

            } else {

                this.ScheduledThrottles.ApplyExploratoryFieldSpec(ec.NewChild("scheduledThrottles"));

            }
        }
        else if (this.ScheduledThrottles != null && ec.Excludes("scheduledThrottles",false))
        {
            this.ScheduledThrottles = null;
        }
    }


    #endregion

    } // class NetworkThrottle
    
    #endregion

    public static class ListNetworkThrottleExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<NetworkThrottle> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NetworkThrottle> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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