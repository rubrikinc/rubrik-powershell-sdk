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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "UserSessionManagementConfig";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        if (this.InactivityTimeoutInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inactivityTimeoutInSeconds\n" ;
            } else {
                s += ind + "inactivityTimeoutInSeconds\n" ;
            }
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMaxLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inactivityTimeoutInSecondsMaxLimit\n" ;
            } else {
                s += ind + "inactivityTimeoutInSecondsMaxLimit\n" ;
            }
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.InactivityTimeoutInSecondsMinLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inactivityTimeoutInSecondsMinLimit\n" ;
            } else {
                s += ind + "inactivityTimeoutInSecondsMinLimit\n" ;
            }
        }
        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        if (this.IsConcurrentSessionLimitationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConcurrentSessionLimitationEnabled\n" ;
            } else {
                s += ind + "isConcurrentSessionLimitationEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsGlobalPolicyEnforced
        // GraphQL -> isGlobalPolicyEnforced: Boolean! (scalar)
        if (this.IsGlobalPolicyEnforced != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isGlobalPolicyEnforced\n" ;
            } else {
                s += ind + "isGlobalPolicyEnforced\n" ;
            }
        }
        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        if (this.IsInactivityTimeoutEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInactivityTimeoutEnabled\n" ;
            } else {
                s += ind + "isInactivityTimeoutEnabled\n" ;
            }
        }
        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        if (this.MaxConcurrentSessions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxConcurrentSessions\n" ;
            } else {
                s += ind + "maxConcurrentSessions\n" ;
            }
        }
        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        if (this.MaxConcurrentSessionsMaxLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxConcurrentSessionsMaxLimit\n" ;
            } else {
                s += ind + "maxConcurrentSessionsMaxLimit\n" ;
            }
        }
        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        if (this.SessionTimeoutInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionTimeoutInSeconds\n" ;
            } else {
                s += ind + "sessionTimeoutInSeconds\n" ;
            }
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMaxLimit
        // GraphQL -> sessionTimeoutInSecondsMaxLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMaxLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionTimeoutInSecondsMaxLimit\n" ;
            } else {
                s += ind + "sessionTimeoutInSecondsMaxLimit\n" ;
            }
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMinLimit
        // GraphQL -> sessionTimeoutInSecondsMinLimit: Long! (scalar)
        if (this.SessionTimeoutInSecondsMinLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionTimeoutInSecondsMinLimit\n" ;
            } else {
                s += ind + "sessionTimeoutInSecondsMinLimit\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        if (ec.Includes("inactivityTimeoutInSeconds",true))
        {
            if(this.InactivityTimeoutInSeconds == null) {

                this.InactivityTimeoutInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.InactivityTimeoutInSeconds != null && ec.Excludes("inactivityTimeoutInSeconds",true))
        {
            this.InactivityTimeoutInSeconds = null;
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        if (ec.Includes("inactivityTimeoutInSecondsMaxLimit",true))
        {
            if(this.InactivityTimeoutInSecondsMaxLimit == null) {

                this.InactivityTimeoutInSecondsMaxLimit = new System.Int64();

            } else {


            }
        }
        else if (this.InactivityTimeoutInSecondsMaxLimit != null && ec.Excludes("inactivityTimeoutInSecondsMaxLimit",true))
        {
            this.InactivityTimeoutInSecondsMaxLimit = null;
        }
        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        if (ec.Includes("inactivityTimeoutInSecondsMinLimit",true))
        {
            if(this.InactivityTimeoutInSecondsMinLimit == null) {

                this.InactivityTimeoutInSecondsMinLimit = new System.Int64();

            } else {


            }
        }
        else if (this.InactivityTimeoutInSecondsMinLimit != null && ec.Excludes("inactivityTimeoutInSecondsMinLimit",true))
        {
            this.InactivityTimeoutInSecondsMinLimit = null;
        }
        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        if (ec.Includes("isConcurrentSessionLimitationEnabled",true))
        {
            if(this.IsConcurrentSessionLimitationEnabled == null) {

                this.IsConcurrentSessionLimitationEnabled = true;

            } else {


            }
        }
        else if (this.IsConcurrentSessionLimitationEnabled != null && ec.Excludes("isConcurrentSessionLimitationEnabled",true))
        {
            this.IsConcurrentSessionLimitationEnabled = null;
        }
        //      C# -> System.Boolean? IsGlobalPolicyEnforced
        // GraphQL -> isGlobalPolicyEnforced: Boolean! (scalar)
        if (ec.Includes("isGlobalPolicyEnforced",true))
        {
            if(this.IsGlobalPolicyEnforced == null) {

                this.IsGlobalPolicyEnforced = true;

            } else {


            }
        }
        else if (this.IsGlobalPolicyEnforced != null && ec.Excludes("isGlobalPolicyEnforced",true))
        {
            this.IsGlobalPolicyEnforced = null;
        }
        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        if (ec.Includes("isInactivityTimeoutEnabled",true))
        {
            if(this.IsInactivityTimeoutEnabled == null) {

                this.IsInactivityTimeoutEnabled = true;

            } else {


            }
        }
        else if (this.IsInactivityTimeoutEnabled != null && ec.Excludes("isInactivityTimeoutEnabled",true))
        {
            this.IsInactivityTimeoutEnabled = null;
        }
        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        if (ec.Includes("maxConcurrentSessions",true))
        {
            if(this.MaxConcurrentSessions == null) {

                this.MaxConcurrentSessions = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxConcurrentSessions != null && ec.Excludes("maxConcurrentSessions",true))
        {
            this.MaxConcurrentSessions = null;
        }
        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        if (ec.Includes("maxConcurrentSessionsMaxLimit",true))
        {
            if(this.MaxConcurrentSessionsMaxLimit == null) {

                this.MaxConcurrentSessionsMaxLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxConcurrentSessionsMaxLimit != null && ec.Excludes("maxConcurrentSessionsMaxLimit",true))
        {
            this.MaxConcurrentSessionsMaxLimit = null;
        }
        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        if (ec.Includes("sessionTimeoutInSeconds",true))
        {
            if(this.SessionTimeoutInSeconds == null) {

                this.SessionTimeoutInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.SessionTimeoutInSeconds != null && ec.Excludes("sessionTimeoutInSeconds",true))
        {
            this.SessionTimeoutInSeconds = null;
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMaxLimit
        // GraphQL -> sessionTimeoutInSecondsMaxLimit: Long! (scalar)
        if (ec.Includes("sessionTimeoutInSecondsMaxLimit",true))
        {
            if(this.SessionTimeoutInSecondsMaxLimit == null) {

                this.SessionTimeoutInSecondsMaxLimit = new System.Int64();

            } else {


            }
        }
        else if (this.SessionTimeoutInSecondsMaxLimit != null && ec.Excludes("sessionTimeoutInSecondsMaxLimit",true))
        {
            this.SessionTimeoutInSecondsMaxLimit = null;
        }
        //      C# -> System.Int64? SessionTimeoutInSecondsMinLimit
        // GraphQL -> sessionTimeoutInSecondsMinLimit: Long! (scalar)
        if (ec.Includes("sessionTimeoutInSecondsMinLimit",true))
        {
            if(this.SessionTimeoutInSecondsMinLimit == null) {

                this.SessionTimeoutInSecondsMinLimit = new System.Int64();

            } else {


            }
        }
        else if (this.SessionTimeoutInSecondsMinLimit != null && ec.Excludes("sessionTimeoutInSecondsMinLimit",true))
        {
            this.SessionTimeoutInSecondsMinLimit = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserSessionManagementConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserSessionManagementConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserSessionManagementConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types