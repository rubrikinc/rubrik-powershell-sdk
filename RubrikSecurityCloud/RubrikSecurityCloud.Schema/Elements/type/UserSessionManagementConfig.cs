// UserSessionManagementConfig.cs
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
    #region UserSessionManagementConfig
    public class UserSessionManagementConfig: BaseType
    {
        #region members

        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSecondsMaxLimit")]
        public System.Int64? InactivityTimeoutInSecondsMaxLimit { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSecondsMinLimit")]
        public System.Int64? InactivityTimeoutInSecondsMinLimit { get; set; }

        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        [JsonProperty("isConcurrentSessionLimitationEnabled")]
        public System.Boolean? IsConcurrentSessionLimitationEnabled { get; set; }

        //      C# -> System.Boolean? IsGlobalPolicyEnforced
        // GraphQL -> isGlobalPolicyEnforced: Boolean! (scalar)
        [JsonProperty("isGlobalPolicyEnforced")]
        public System.Boolean? IsGlobalPolicyEnforced { get; set; }

        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        [JsonProperty("isInactivityTimeoutEnabled")]
        public System.Boolean? IsInactivityTimeoutEnabled { get; set; }

        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        [JsonProperty("maxConcurrentSessions")]
        public System.Int32? MaxConcurrentSessions { get; set; }

        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        [JsonProperty("maxConcurrentSessionsMaxLimit")]
        public System.Int32? MaxConcurrentSessionsMaxLimit { get; set; }

        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        [JsonProperty("sessionTimeoutInSeconds")]
        public System.Int64? SessionTimeoutInSeconds { get; set; }

        //      C# -> System.Int64? SessionTimeoutInSecondsMaxLimit
        // GraphQL -> sessionTimeoutInSecondsMaxLimit: Long! (scalar)
        [JsonProperty("sessionTimeoutInSecondsMaxLimit")]
        public System.Int64? SessionTimeoutInSecondsMaxLimit { get; set; }

        //      C# -> System.Int64? SessionTimeoutInSecondsMinLimit
        // GraphQL -> sessionTimeoutInSecondsMinLimit: Long! (scalar)
        [JsonProperty("sessionTimeoutInSecondsMinLimit")]
        public System.Int64? SessionTimeoutInSecondsMinLimit { get; set; }


        #endregion

    #region methods

    public UserSessionManagementConfig Set(
        System.Int64? InactivityTimeoutInSeconds = null,
        System.Int64? InactivityTimeoutInSecondsMaxLimit = null,
        System.Int64? InactivityTimeoutInSecondsMinLimit = null,
        System.Boolean? IsConcurrentSessionLimitationEnabled = null,
        System.Boolean? IsGlobalPolicyEnforced = null,
        System.Boolean? IsInactivityTimeoutEnabled = null,
        System.Int32? MaxConcurrentSessions = null,
        System.Int32? MaxConcurrentSessionsMaxLimit = null,
        System.Int64? SessionTimeoutInSeconds = null,
        System.Int64? SessionTimeoutInSecondsMaxLimit = null,
        System.Int64? SessionTimeoutInSecondsMinLimit = null
    ) 
    {
        if ( InactivityTimeoutInSeconds != null ) {
            this.InactivityTimeoutInSeconds = InactivityTimeoutInSeconds;
        }
        if ( InactivityTimeoutInSecondsMaxLimit != null ) {
            this.InactivityTimeoutInSecondsMaxLimit = InactivityTimeoutInSecondsMaxLimit;
        }
        if ( InactivityTimeoutInSecondsMinLimit != null ) {
            this.InactivityTimeoutInSecondsMinLimit = InactivityTimeoutInSecondsMinLimit;
        }
        if ( IsConcurrentSessionLimitationEnabled != null ) {
            this.IsConcurrentSessionLimitationEnabled = IsConcurrentSessionLimitationEnabled;
        }
        if ( IsGlobalPolicyEnforced != null ) {
            this.IsGlobalPolicyEnforced = IsGlobalPolicyEnforced;
        }
        if ( IsInactivityTimeoutEnabled != null ) {
            this.IsInactivityTimeoutEnabled = IsInactivityTimeoutEnabled;
        }
        if ( MaxConcurrentSessions != null ) {
            this.MaxConcurrentSessions = MaxConcurrentSessions;
        }
        if ( MaxConcurrentSessionsMaxLimit != null ) {
            this.MaxConcurrentSessionsMaxLimit = MaxConcurrentSessionsMaxLimit;
        }
        if ( SessionTimeoutInSeconds != null ) {
            this.SessionTimeoutInSeconds = SessionTimeoutInSeconds;
        }
        if ( SessionTimeoutInSecondsMaxLimit != null ) {
            this.SessionTimeoutInSecondsMaxLimit = SessionTimeoutInSecondsMaxLimit;
        }
        if ( SessionTimeoutInSecondsMinLimit != null ) {
            this.SessionTimeoutInSecondsMinLimit = SessionTimeoutInSecondsMinLimit;
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
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        if (this.InactivityTimeoutInSeconds != null) {
            s += ind + "inactivityTimeoutInSeconds\n" ;
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMaxLimit != null) {
            s += ind + "inactivityTimeoutInSecondsMaxLimit\n" ;
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMinLimit != null) {
            s += ind + "inactivityTimeoutInSecondsMinLimit\n" ;
        }
        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        if (this.IsConcurrentSessionLimitationEnabled != null) {
            s += ind + "isConcurrentSessionLimitationEnabled\n" ;
        }
        //      C# -> System.Boolean? IsGlobalPolicyEnforced
        // GraphQL -> isGlobalPolicyEnforced: Boolean! (scalar)
        if (this.IsGlobalPolicyEnforced != null) {
            s += ind + "isGlobalPolicyEnforced\n" ;
        }
        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        if (this.IsInactivityTimeoutEnabled != null) {
            s += ind + "isInactivityTimeoutEnabled\n" ;
        }
        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        if (this.MaxConcurrentSessions != null) {
            s += ind + "maxConcurrentSessions\n" ;
        }
        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        if (this.MaxConcurrentSessionsMaxLimit != null) {
            s += ind + "maxConcurrentSessionsMaxLimit\n" ;
        }
        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        if (this.SessionTimeoutInSeconds != null) {
            s += ind + "sessionTimeoutInSeconds\n" ;
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMaxLimit
        // GraphQL -> sessionTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMaxLimit != null) {
            s += ind + "sessionTimeoutInSecondsMaxLimit\n" ;
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMinLimit
        // GraphQL -> sessionTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMinLimit != null) {
            s += ind + "sessionTimeoutInSecondsMinLimit\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        if (this.InactivityTimeoutInSeconds == null && Exploration.Includes(parent + ".inactivityTimeoutInSeconds", true))
        {
            this.InactivityTimeoutInSeconds = new System.Int64();
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMaxLimit == null && Exploration.Includes(parent + ".inactivityTimeoutInSecondsMaxLimit", true))
        {
            this.InactivityTimeoutInSecondsMaxLimit = new System.Int64();
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMinLimit == null && Exploration.Includes(parent + ".inactivityTimeoutInSecondsMinLimit", true))
        {
            this.InactivityTimeoutInSecondsMinLimit = new System.Int64();
        }
        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        if (this.IsConcurrentSessionLimitationEnabled == null && Exploration.Includes(parent + ".isConcurrentSessionLimitationEnabled", true))
        {
            this.IsConcurrentSessionLimitationEnabled = true;
        }
        //      C# -> System.Boolean? IsGlobalPolicyEnforced
        // GraphQL -> isGlobalPolicyEnforced: Boolean! (scalar)
        if (this.IsGlobalPolicyEnforced == null && Exploration.Includes(parent + ".isGlobalPolicyEnforced", true))
        {
            this.IsGlobalPolicyEnforced = true;
        }
        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        if (this.IsInactivityTimeoutEnabled == null && Exploration.Includes(parent + ".isInactivityTimeoutEnabled", true))
        {
            this.IsInactivityTimeoutEnabled = true;
        }
        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        if (this.MaxConcurrentSessions == null && Exploration.Includes(parent + ".maxConcurrentSessions", true))
        {
            this.MaxConcurrentSessions = Int32.MinValue;
        }
        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        if (this.MaxConcurrentSessionsMaxLimit == null && Exploration.Includes(parent + ".maxConcurrentSessionsMaxLimit", true))
        {
            this.MaxConcurrentSessionsMaxLimit = Int32.MinValue;
        }
        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        if (this.SessionTimeoutInSeconds == null && Exploration.Includes(parent + ".sessionTimeoutInSeconds", true))
        {
            this.SessionTimeoutInSeconds = new System.Int64();
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMaxLimit
        // GraphQL -> sessionTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMaxLimit == null && Exploration.Includes(parent + ".sessionTimeoutInSecondsMaxLimit", true))
        {
            this.SessionTimeoutInSecondsMaxLimit = new System.Int64();
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMinLimit
        // GraphQL -> sessionTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMinLimit == null && Exploration.Includes(parent + ".sessionTimeoutInSecondsMinLimit", true))
        {
            this.SessionTimeoutInSecondsMinLimit = new System.Int64();
        }
    }


    #endregion

    } // class UserSessionManagementConfig
    
    #endregion

    public static class ListUserSessionManagementConfigExtensions
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
            this List<UserSessionManagementConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserSessionManagementConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserSessionManagementConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types