// SigninLogSummary.cs
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
    #region SigninLogSummary
    public class SigninLogSummary: BaseType
    {
        #region members

        //      C# -> SigninLogFailureCategory? FailureCategory
        // GraphQL -> failureCategory: SigninLogFailureCategory (enum)
        [JsonProperty("failureCategory")]
        public SigninLogFailureCategory? FailureCategory { get; set; }

        //      C# -> EventProvider? Provider
        // GraphQL -> provider: EventProvider! (enum)
        [JsonProperty("provider")]
        public EventProvider? Provider { get; set; }

        //      C# -> SigninLogResult? Result
        // GraphQL -> result: SigninLogResult! (enum)
        [JsonProperty("result")]
        public SigninLogResult? Result { get; set; }

        //      C# -> SigninLogRiskLevel? RiskLevel
        // GraphQL -> riskLevel: SigninLogRiskLevel! (enum)
        [JsonProperty("riskLevel")]
        public SigninLogRiskLevel? RiskLevel { get; set; }

        //      C# -> System.String? ActorDisplayName
        // GraphQL -> actorDisplayName: String! (scalar)
        [JsonProperty("actorDisplayName")]
        public System.String? ActorDisplayName { get; set; }

        //      C# -> System.String? ActorPrincipalName
        // GraphQL -> actorPrincipalName: String! (scalar)
        [JsonProperty("actorPrincipalName")]
        public System.String? ActorPrincipalName { get; set; }

        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        [JsonProperty("applicationName")]
        public System.String? ApplicationName { get; set; }

        //      C# -> System.String? AuthenticationMethod
        // GraphQL -> authenticationMethod: String! (scalar)
        [JsonProperty("authenticationMethod")]
        public System.String? AuthenticationMethod { get; set; }

        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        [JsonProperty("city")]
        public System.String? City { get; set; }

        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        [JsonProperty("country")]
        public System.String? Country { get; set; }

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? ErrorCode
        // GraphQL -> errorCode: String! (scalar)
        [JsonProperty("errorCode")]
        public System.String? ErrorCode { get; set; }

        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> DateTime? EventTimestamp
        // GraphQL -> eventTimestamp: DateTime (scalar)
        [JsonProperty("eventTimestamp")]
        public DateTime? EventTimestamp { get; set; }

        //      C# -> System.String? EventType
        // GraphQL -> eventType: String! (scalar)
        [JsonProperty("eventType")]
        public System.String? EventType { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? LogonType
        // GraphQL -> logonType: String! (scalar)
        [JsonProperty("logonType")]
        public System.String? LogonType { get; set; }

        //      C# -> System.String? MfaStatus
        // GraphQL -> mfaStatus: String! (scalar)
        [JsonProperty("mfaStatus")]
        public System.String? MfaStatus { get; set; }

        //      C# -> System.String? ProcessName
        // GraphQL -> processName: String! (scalar)
        [JsonProperty("processName")]
        public System.String? ProcessName { get; set; }

        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        [JsonProperty("resourceName")]
        public System.String? ResourceName { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }

        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        [JsonProperty("userSid")]
        public System.String? UserSid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninLogSummary";
    }

    public SigninLogSummary Set(
        SigninLogFailureCategory? FailureCategory = null,
        EventProvider? Provider = null,
        SigninLogResult? Result = null,
        SigninLogRiskLevel? RiskLevel = null,
        System.String? ActorDisplayName = null,
        System.String? ActorPrincipalName = null,
        System.String? ApplicationName = null,
        System.String? AuthenticationMethod = null,
        System.String? City = null,
        System.String? Country = null,
        System.String? DeviceName = null,
        System.String? ErrorCode = null,
        System.String? EventId = null,
        DateTime? EventTimestamp = null,
        System.String? EventType = null,
        System.String? IpAddress = null,
        System.String? LogonType = null,
        System.String? MfaStatus = null,
        System.String? ProcessName = null,
        System.String? ResourceName = null,
        System.String? State = null,
        System.String? TenantId = null,
        System.String? UserId = null,
        System.String? UserSid = null
    ) 
    {
        if ( FailureCategory != null ) {
            this.FailureCategory = FailureCategory;
        }
        if ( Provider != null ) {
            this.Provider = Provider;
        }
        if ( Result != null ) {
            this.Result = Result;
        }
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( ActorDisplayName != null ) {
            this.ActorDisplayName = ActorDisplayName;
        }
        if ( ActorPrincipalName != null ) {
            this.ActorPrincipalName = ActorPrincipalName;
        }
        if ( ApplicationName != null ) {
            this.ApplicationName = ApplicationName;
        }
        if ( AuthenticationMethod != null ) {
            this.AuthenticationMethod = AuthenticationMethod;
        }
        if ( City != null ) {
            this.City = City;
        }
        if ( Country != null ) {
            this.Country = Country;
        }
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( ErrorCode != null ) {
            this.ErrorCode = ErrorCode;
        }
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( EventTimestamp != null ) {
            this.EventTimestamp = EventTimestamp;
        }
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( LogonType != null ) {
            this.LogonType = LogonType;
        }
        if ( MfaStatus != null ) {
            this.MfaStatus = MfaStatus;
        }
        if ( ProcessName != null ) {
            this.ProcessName = ProcessName;
        }
        if ( ResourceName != null ) {
            this.ResourceName = ResourceName;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( UserId != null ) {
            this.UserId = UserId;
        }
        if ( UserSid != null ) {
            this.UserSid = UserSid;
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
        //      C# -> SigninLogFailureCategory? FailureCategory
        // GraphQL -> failureCategory: SigninLogFailureCategory (enum)
        if (this.FailureCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureCategory\n" ;
            } else {
                s += ind + "failureCategory\n" ;
            }
        }
        //      C# -> EventProvider? Provider
        // GraphQL -> provider: EventProvider! (enum)
        if (this.Provider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provider\n" ;
            } else {
                s += ind + "provider\n" ;
            }
        }
        //      C# -> SigninLogResult? Result
        // GraphQL -> result: SigninLogResult! (enum)
        if (this.Result != null) {
            if (conf.Flat) {
                s += conf.Prefix + "result\n" ;
            } else {
                s += ind + "result\n" ;
            }
        }
        //      C# -> SigninLogRiskLevel? RiskLevel
        // GraphQL -> riskLevel: SigninLogRiskLevel! (enum)
        if (this.RiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskLevel\n" ;
            } else {
                s += ind + "riskLevel\n" ;
            }
        }
        //      C# -> System.String? ActorDisplayName
        // GraphQL -> actorDisplayName: String! (scalar)
        if (this.ActorDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorDisplayName\n" ;
            } else {
                s += ind + "actorDisplayName\n" ;
            }
        }
        //      C# -> System.String? ActorPrincipalName
        // GraphQL -> actorPrincipalName: String! (scalar)
        if (this.ActorPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorPrincipalName\n" ;
            } else {
                s += ind + "actorPrincipalName\n" ;
            }
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (this.ApplicationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationName\n" ;
            } else {
                s += ind + "applicationName\n" ;
            }
        }
        //      C# -> System.String? AuthenticationMethod
        // GraphQL -> authenticationMethod: String! (scalar)
        if (this.AuthenticationMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationMethod\n" ;
            } else {
                s += ind + "authenticationMethod\n" ;
            }
        }
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (this.City != null) {
            if (conf.Flat) {
                s += conf.Prefix + "city\n" ;
            } else {
                s += ind + "city\n" ;
            }
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (this.Country != null) {
            if (conf.Flat) {
                s += conf.Prefix + "country\n" ;
            } else {
                s += ind + "country\n" ;
            }
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceName\n" ;
            } else {
                s += ind + "deviceName\n" ;
            }
        }
        //      C# -> System.String? ErrorCode
        // GraphQL -> errorCode: String! (scalar)
        if (this.ErrorCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorCode\n" ;
            } else {
                s += ind + "errorCode\n" ;
            }
        }
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventId\n" ;
            } else {
                s += ind + "eventId\n" ;
            }
        }
        //      C# -> DateTime? EventTimestamp
        // GraphQL -> eventTimestamp: DateTime (scalar)
        if (this.EventTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTimestamp\n" ;
            } else {
                s += ind + "eventTimestamp\n" ;
            }
        }
        //      C# -> System.String? EventType
        // GraphQL -> eventType: String! (scalar)
        if (this.EventType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventType\n" ;
            } else {
                s += ind + "eventType\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.String? LogonType
        // GraphQL -> logonType: String! (scalar)
        if (this.LogonType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logonType\n" ;
            } else {
                s += ind + "logonType\n" ;
            }
        }
        //      C# -> System.String? MfaStatus
        // GraphQL -> mfaStatus: String! (scalar)
        if (this.MfaStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaStatus\n" ;
            } else {
                s += ind + "mfaStatus\n" ;
            }
        }
        //      C# -> System.String? ProcessName
        // GraphQL -> processName: String! (scalar)
        if (this.ProcessName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "processName\n" ;
            } else {
                s += ind + "processName\n" ;
            }
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceName\n" ;
            } else {
                s += ind + "resourceName\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userId\n" ;
            } else {
                s += ind + "userId\n" ;
            }
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (this.UserSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userSid\n" ;
            } else {
                s += ind + "userSid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SigninLogFailureCategory? FailureCategory
        // GraphQL -> failureCategory: SigninLogFailureCategory (enum)
        if (ec.Includes("failureCategory",true))
        {
            if(this.FailureCategory == null) {

                this.FailureCategory = new SigninLogFailureCategory();

            } else {


            }
        }
        else if (this.FailureCategory != null && ec.Excludes("failureCategory",true))
        {
            this.FailureCategory = null;
        }
        //      C# -> EventProvider? Provider
        // GraphQL -> provider: EventProvider! (enum)
        if (ec.Includes("provider",true))
        {
            if(this.Provider == null) {

                this.Provider = new EventProvider();

            } else {


            }
        }
        else if (this.Provider != null && ec.Excludes("provider",true))
        {
            this.Provider = null;
        }
        //      C# -> SigninLogResult? Result
        // GraphQL -> result: SigninLogResult! (enum)
        if (ec.Includes("result",true))
        {
            if(this.Result == null) {

                this.Result = new SigninLogResult();

            } else {


            }
        }
        else if (this.Result != null && ec.Excludes("result",true))
        {
            this.Result = null;
        }
        //      C# -> SigninLogRiskLevel? RiskLevel
        // GraphQL -> riskLevel: SigninLogRiskLevel! (enum)
        if (ec.Includes("riskLevel",true))
        {
            if(this.RiskLevel == null) {

                this.RiskLevel = new SigninLogRiskLevel();

            } else {


            }
        }
        else if (this.RiskLevel != null && ec.Excludes("riskLevel",true))
        {
            this.RiskLevel = null;
        }
        //      C# -> System.String? ActorDisplayName
        // GraphQL -> actorDisplayName: String! (scalar)
        if (ec.Includes("actorDisplayName",true))
        {
            if(this.ActorDisplayName == null) {

                this.ActorDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.ActorDisplayName != null && ec.Excludes("actorDisplayName",true))
        {
            this.ActorDisplayName = null;
        }
        //      C# -> System.String? ActorPrincipalName
        // GraphQL -> actorPrincipalName: String! (scalar)
        if (ec.Includes("actorPrincipalName",true))
        {
            if(this.ActorPrincipalName == null) {

                this.ActorPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.ActorPrincipalName != null && ec.Excludes("actorPrincipalName",true))
        {
            this.ActorPrincipalName = null;
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (ec.Includes("applicationName",true))
        {
            if(this.ApplicationName == null) {

                this.ApplicationName = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationName != null && ec.Excludes("applicationName",true))
        {
            this.ApplicationName = null;
        }
        //      C# -> System.String? AuthenticationMethod
        // GraphQL -> authenticationMethod: String! (scalar)
        if (ec.Includes("authenticationMethod",true))
        {
            if(this.AuthenticationMethod == null) {

                this.AuthenticationMethod = "FETCH";

            } else {


            }
        }
        else if (this.AuthenticationMethod != null && ec.Excludes("authenticationMethod",true))
        {
            this.AuthenticationMethod = null;
        }
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (ec.Includes("city",true))
        {
            if(this.City == null) {

                this.City = "FETCH";

            } else {


            }
        }
        else if (this.City != null && ec.Excludes("city",true))
        {
            this.City = null;
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (ec.Includes("country",true))
        {
            if(this.Country == null) {

                this.Country = "FETCH";

            } else {


            }
        }
        else if (this.Country != null && ec.Excludes("country",true))
        {
            this.Country = null;
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (ec.Includes("deviceName",true))
        {
            if(this.DeviceName == null) {

                this.DeviceName = "FETCH";

            } else {


            }
        }
        else if (this.DeviceName != null && ec.Excludes("deviceName",true))
        {
            this.DeviceName = null;
        }
        //      C# -> System.String? ErrorCode
        // GraphQL -> errorCode: String! (scalar)
        if (ec.Includes("errorCode",true))
        {
            if(this.ErrorCode == null) {

                this.ErrorCode = "FETCH";

            } else {


            }
        }
        else if (this.ErrorCode != null && ec.Excludes("errorCode",true))
        {
            this.ErrorCode = null;
        }
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
        //      C# -> DateTime? EventTimestamp
        // GraphQL -> eventTimestamp: DateTime (scalar)
        if (ec.Includes("eventTimestamp",true))
        {
            if(this.EventTimestamp == null) {

                this.EventTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.EventTimestamp != null && ec.Excludes("eventTimestamp",true))
        {
            this.EventTimestamp = null;
        }
        //      C# -> System.String? EventType
        // GraphQL -> eventType: String! (scalar)
        if (ec.Includes("eventType",true))
        {
            if(this.EventType == null) {

                this.EventType = "FETCH";

            } else {


            }
        }
        else if (this.EventType != null && ec.Excludes("eventType",true))
        {
            this.EventType = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.String? LogonType
        // GraphQL -> logonType: String! (scalar)
        if (ec.Includes("logonType",true))
        {
            if(this.LogonType == null) {

                this.LogonType = "FETCH";

            } else {


            }
        }
        else if (this.LogonType != null && ec.Excludes("logonType",true))
        {
            this.LogonType = null;
        }
        //      C# -> System.String? MfaStatus
        // GraphQL -> mfaStatus: String! (scalar)
        if (ec.Includes("mfaStatus",true))
        {
            if(this.MfaStatus == null) {

                this.MfaStatus = "FETCH";

            } else {


            }
        }
        else if (this.MfaStatus != null && ec.Excludes("mfaStatus",true))
        {
            this.MfaStatus = null;
        }
        //      C# -> System.String? ProcessName
        // GraphQL -> processName: String! (scalar)
        if (ec.Includes("processName",true))
        {
            if(this.ProcessName == null) {

                this.ProcessName = "FETCH";

            } else {


            }
        }
        else if (this.ProcessName != null && ec.Excludes("processName",true))
        {
            this.ProcessName = null;
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (ec.Includes("resourceName",true))
        {
            if(this.ResourceName == null) {

                this.ResourceName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceName != null && ec.Excludes("resourceName",true))
        {
            this.ResourceName = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (ec.Includes("userId",true))
        {
            if(this.UserId == null) {

                this.UserId = "FETCH";

            } else {


            }
        }
        else if (this.UserId != null && ec.Excludes("userId",true))
        {
            this.UserId = null;
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (ec.Includes("userSid",true))
        {
            if(this.UserSid == null) {

                this.UserSid = "FETCH";

            } else {


            }
        }
        else if (this.UserSid != null && ec.Excludes("userSid",true))
        {
            this.UserSid = null;
        }
    }


    #endregion

    } // class SigninLogSummary
    
    #endregion

    public static class ListSigninLogSummaryExtensions
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
            this List<SigninLogSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninLogSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninLogSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninLogSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninLogSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types