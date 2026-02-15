// SigninLogDetails.cs
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
    #region SigninLogDetails
    public class SigninLogDetails: BaseType
    {
        #region members

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

        //      C# -> System.String? ActorDomain
        // GraphQL -> actorDomain: String! (scalar)
        [JsonProperty("actorDomain")]
        public System.String? ActorDomain { get; set; }

        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        [JsonProperty("actorId")]
        public System.String? ActorId { get; set; }

        //      C# -> System.String? ActorPrincipalName
        // GraphQL -> actorPrincipalName: String! (scalar)
        [JsonProperty("actorPrincipalName")]
        public System.String? ActorPrincipalName { get; set; }

        //      C# -> System.String? ActorSid
        // GraphQL -> actorSid: String! (scalar)
        [JsonProperty("actorSid")]
        public System.String? ActorSid { get; set; }

        //      C# -> System.String? ActorUserType
        // GraphQL -> actorUserType: String! (scalar)
        [JsonProperty("actorUserType")]
        public System.String? ActorUserType { get; set; }

        //      C# -> System.String? AdditionalData
        // GraphQL -> additionalData: String! (scalar)
        [JsonProperty("additionalData")]
        public System.String? AdditionalData { get; set; }

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        [JsonProperty("applicationName")]
        public System.String? ApplicationName { get; set; }

        //      C# -> System.String? AuthenticationMethod
        // GraphQL -> authenticationMethod: String! (scalar)
        [JsonProperty("authenticationMethod")]
        public System.String? AuthenticationMethod { get; set; }

        //      C# -> System.String? AuthenticationPackage
        // GraphQL -> authenticationPackage: String! (scalar)
        [JsonProperty("authenticationPackage")]
        public System.String? AuthenticationPackage { get; set; }

        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        [JsonProperty("city")]
        public System.String? City { get; set; }

        //      C# -> System.String? CorrelationId
        // GraphQL -> correlationId: String! (scalar)
        [JsonProperty("correlationId")]
        public System.String? CorrelationId { get; set; }

        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        [JsonProperty("country")]
        public System.String? Country { get; set; }

        //      C# -> System.String? CountryCode
        // GraphQL -> countryCode: String! (scalar)
        [JsonProperty("countryCode")]
        public System.String? CountryCode { get; set; }

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? DeviceOs
        // GraphQL -> deviceOs: String! (scalar)
        [JsonProperty("deviceOs")]
        public System.String? DeviceOs { get; set; }

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

        //      C# -> System.String? EventTitle
        // GraphQL -> eventTitle: String! (scalar)
        [JsonProperty("eventTitle")]
        public System.String? EventTitle { get; set; }

        //      C# -> System.String? EventType
        // GraphQL -> eventType: String! (scalar)
        [JsonProperty("eventType")]
        public System.String? EventType { get; set; }

        //      C# -> DateTime? IngestionTimestamp
        // GraphQL -> ingestionTimestamp: DateTime (scalar)
        [JsonProperty("ingestionTimestamp")]
        public DateTime? IngestionTimestamp { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Int64? LogonType
        // GraphQL -> logonType: Long! (scalar)
        [JsonProperty("logonType")]
        public System.Int64? LogonType { get; set; }

        //      C# -> System.String? LogonTypeDescription
        // GraphQL -> logonTypeDescription: String! (scalar)
        [JsonProperty("logonTypeDescription")]
        public System.String? LogonTypeDescription { get; set; }

        //      C# -> System.String? MfaMethod
        // GraphQL -> mfaMethod: String! (scalar)
        [JsonProperty("mfaMethod")]
        public System.String? MfaMethod { get; set; }

        //      C# -> System.String? MfaStatus
        // GraphQL -> mfaStatus: String! (scalar)
        [JsonProperty("mfaStatus")]
        public System.String? MfaStatus { get; set; }

        //      C# -> System.String? ProcessName
        // GraphQL -> processName: String! (scalar)
        [JsonProperty("processName")]
        public System.String? ProcessName { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        [JsonProperty("resourceName")]
        public System.String? ResourceName { get; set; }

        //      C# -> System.String? ResultReason
        // GraphQL -> resultReason: String! (scalar)
        [JsonProperty("resultReason")]
        public System.String? ResultReason { get; set; }

        //      C# -> System.String? RiskIndicators
        // GraphQL -> riskIndicators: String! (scalar)
        [JsonProperty("riskIndicators")]
        public System.String? RiskIndicators { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? TargetDisplayName
        // GraphQL -> targetDisplayName: String! (scalar)
        [JsonProperty("targetDisplayName")]
        public System.String? TargetDisplayName { get; set; }

        //      C# -> System.String? TargetDomain
        // GraphQL -> targetDomain: String! (scalar)
        [JsonProperty("targetDomain")]
        public System.String? TargetDomain { get; set; }

        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        [JsonProperty("targetId")]
        public System.String? TargetId { get; set; }

        //      C# -> System.String? TargetPrincipalName
        // GraphQL -> targetPrincipalName: String! (scalar)
        [JsonProperty("targetPrincipalName")]
        public System.String? TargetPrincipalName { get; set; }

        //      C# -> System.String? TargetSid
        // GraphQL -> targetSid: String! (scalar)
        [JsonProperty("targetSid")]
        public System.String? TargetSid { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninLogDetails";
    }

    public SigninLogDetails Set(
        EventProvider? Provider = null,
        SigninLogResult? Result = null,
        SigninLogRiskLevel? RiskLevel = null,
        System.String? ActorDisplayName = null,
        System.String? ActorDomain = null,
        System.String? ActorId = null,
        System.String? ActorPrincipalName = null,
        System.String? ActorSid = null,
        System.String? ActorUserType = null,
        System.String? AdditionalData = null,
        System.String? ApplicationId = null,
        System.String? ApplicationName = null,
        System.String? AuthenticationMethod = null,
        System.String? AuthenticationPackage = null,
        System.String? City = null,
        System.String? CorrelationId = null,
        System.String? Country = null,
        System.String? CountryCode = null,
        System.String? DeviceName = null,
        System.String? DeviceOs = null,
        System.String? ErrorCode = null,
        System.String? EventId = null,
        DateTime? EventTimestamp = null,
        System.String? EventTitle = null,
        System.String? EventType = null,
        DateTime? IngestionTimestamp = null,
        System.String? IpAddress = null,
        System.Int64? LogonType = null,
        System.String? LogonTypeDescription = null,
        System.String? MfaMethod = null,
        System.String? MfaStatus = null,
        System.String? ProcessName = null,
        System.String? ResourceId = null,
        System.String? ResourceName = null,
        System.String? ResultReason = null,
        System.String? RiskIndicators = null,
        System.String? SessionId = null,
        System.String? State = null,
        System.String? TargetDisplayName = null,
        System.String? TargetDomain = null,
        System.String? TargetId = null,
        System.String? TargetPrincipalName = null,
        System.String? TargetSid = null,
        System.String? TenantId = null
    ) 
    {
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
        if ( ActorDomain != null ) {
            this.ActorDomain = ActorDomain;
        }
        if ( ActorId != null ) {
            this.ActorId = ActorId;
        }
        if ( ActorPrincipalName != null ) {
            this.ActorPrincipalName = ActorPrincipalName;
        }
        if ( ActorSid != null ) {
            this.ActorSid = ActorSid;
        }
        if ( ActorUserType != null ) {
            this.ActorUserType = ActorUserType;
        }
        if ( AdditionalData != null ) {
            this.AdditionalData = AdditionalData;
        }
        if ( ApplicationId != null ) {
            this.ApplicationId = ApplicationId;
        }
        if ( ApplicationName != null ) {
            this.ApplicationName = ApplicationName;
        }
        if ( AuthenticationMethod != null ) {
            this.AuthenticationMethod = AuthenticationMethod;
        }
        if ( AuthenticationPackage != null ) {
            this.AuthenticationPackage = AuthenticationPackage;
        }
        if ( City != null ) {
            this.City = City;
        }
        if ( CorrelationId != null ) {
            this.CorrelationId = CorrelationId;
        }
        if ( Country != null ) {
            this.Country = Country;
        }
        if ( CountryCode != null ) {
            this.CountryCode = CountryCode;
        }
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( DeviceOs != null ) {
            this.DeviceOs = DeviceOs;
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
        if ( EventTitle != null ) {
            this.EventTitle = EventTitle;
        }
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( IngestionTimestamp != null ) {
            this.IngestionTimestamp = IngestionTimestamp;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( LogonType != null ) {
            this.LogonType = LogonType;
        }
        if ( LogonTypeDescription != null ) {
            this.LogonTypeDescription = LogonTypeDescription;
        }
        if ( MfaMethod != null ) {
            this.MfaMethod = MfaMethod;
        }
        if ( MfaStatus != null ) {
            this.MfaStatus = MfaStatus;
        }
        if ( ProcessName != null ) {
            this.ProcessName = ProcessName;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceName != null ) {
            this.ResourceName = ResourceName;
        }
        if ( ResultReason != null ) {
            this.ResultReason = ResultReason;
        }
        if ( RiskIndicators != null ) {
            this.RiskIndicators = RiskIndicators;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( TargetDisplayName != null ) {
            this.TargetDisplayName = TargetDisplayName;
        }
        if ( TargetDomain != null ) {
            this.TargetDomain = TargetDomain;
        }
        if ( TargetId != null ) {
            this.TargetId = TargetId;
        }
        if ( TargetPrincipalName != null ) {
            this.TargetPrincipalName = TargetPrincipalName;
        }
        if ( TargetSid != null ) {
            this.TargetSid = TargetSid;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
        //      C# -> System.String? ActorDomain
        // GraphQL -> actorDomain: String! (scalar)
        if (this.ActorDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorDomain\n" ;
            } else {
                s += ind + "actorDomain\n" ;
            }
        }
        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        if (this.ActorId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorId\n" ;
            } else {
                s += ind + "actorId\n" ;
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
        //      C# -> System.String? ActorSid
        // GraphQL -> actorSid: String! (scalar)
        if (this.ActorSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorSid\n" ;
            } else {
                s += ind + "actorSid\n" ;
            }
        }
        //      C# -> System.String? ActorUserType
        // GraphQL -> actorUserType: String! (scalar)
        if (this.ActorUserType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorUserType\n" ;
            } else {
                s += ind + "actorUserType\n" ;
            }
        }
        //      C# -> System.String? AdditionalData
        // GraphQL -> additionalData: String! (scalar)
        if (this.AdditionalData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "additionalData\n" ;
            } else {
                s += ind + "additionalData\n" ;
            }
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        if (this.ApplicationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationId\n" ;
            } else {
                s += ind + "applicationId\n" ;
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
        //      C# -> System.String? AuthenticationPackage
        // GraphQL -> authenticationPackage: String! (scalar)
        if (this.AuthenticationPackage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationPackage\n" ;
            } else {
                s += ind + "authenticationPackage\n" ;
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
        //      C# -> System.String? CorrelationId
        // GraphQL -> correlationId: String! (scalar)
        if (this.CorrelationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "correlationId\n" ;
            } else {
                s += ind + "correlationId\n" ;
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
        //      C# -> System.String? CountryCode
        // GraphQL -> countryCode: String! (scalar)
        if (this.CountryCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countryCode\n" ;
            } else {
                s += ind + "countryCode\n" ;
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
        //      C# -> System.String? DeviceOs
        // GraphQL -> deviceOs: String! (scalar)
        if (this.DeviceOs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceOs\n" ;
            } else {
                s += ind + "deviceOs\n" ;
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
        //      C# -> System.String? EventTitle
        // GraphQL -> eventTitle: String! (scalar)
        if (this.EventTitle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTitle\n" ;
            } else {
                s += ind + "eventTitle\n" ;
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
        //      C# -> DateTime? IngestionTimestamp
        // GraphQL -> ingestionTimestamp: DateTime (scalar)
        if (this.IngestionTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ingestionTimestamp\n" ;
            } else {
                s += ind + "ingestionTimestamp\n" ;
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
        //      C# -> System.Int64? LogonType
        // GraphQL -> logonType: Long! (scalar)
        if (this.LogonType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logonType\n" ;
            } else {
                s += ind + "logonType\n" ;
            }
        }
        //      C# -> System.String? LogonTypeDescription
        // GraphQL -> logonTypeDescription: String! (scalar)
        if (this.LogonTypeDescription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logonTypeDescription\n" ;
            } else {
                s += ind + "logonTypeDescription\n" ;
            }
        }
        //      C# -> System.String? MfaMethod
        // GraphQL -> mfaMethod: String! (scalar)
        if (this.MfaMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaMethod\n" ;
            } else {
                s += ind + "mfaMethod\n" ;
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
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
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
        //      C# -> System.String? ResultReason
        // GraphQL -> resultReason: String! (scalar)
        if (this.ResultReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resultReason\n" ;
            } else {
                s += ind + "resultReason\n" ;
            }
        }
        //      C# -> System.String? RiskIndicators
        // GraphQL -> riskIndicators: String! (scalar)
        if (this.RiskIndicators != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskIndicators\n" ;
            } else {
                s += ind + "riskIndicators\n" ;
            }
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionId\n" ;
            } else {
                s += ind + "sessionId\n" ;
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
        //      C# -> System.String? TargetDisplayName
        // GraphQL -> targetDisplayName: String! (scalar)
        if (this.TargetDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetDisplayName\n" ;
            } else {
                s += ind + "targetDisplayName\n" ;
            }
        }
        //      C# -> System.String? TargetDomain
        // GraphQL -> targetDomain: String! (scalar)
        if (this.TargetDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetDomain\n" ;
            } else {
                s += ind + "targetDomain\n" ;
            }
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetId\n" ;
            } else {
                s += ind + "targetId\n" ;
            }
        }
        //      C# -> System.String? TargetPrincipalName
        // GraphQL -> targetPrincipalName: String! (scalar)
        if (this.TargetPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetPrincipalName\n" ;
            } else {
                s += ind + "targetPrincipalName\n" ;
            }
        }
        //      C# -> System.String? TargetSid
        // GraphQL -> targetSid: String! (scalar)
        if (this.TargetSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetSid\n" ;
            } else {
                s += ind + "targetSid\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? ActorDomain
        // GraphQL -> actorDomain: String! (scalar)
        if (ec.Includes("actorDomain",true))
        {
            if(this.ActorDomain == null) {

                this.ActorDomain = "FETCH";

            } else {


            }
        }
        else if (this.ActorDomain != null && ec.Excludes("actorDomain",true))
        {
            this.ActorDomain = null;
        }
        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        if (ec.Includes("actorId",true))
        {
            if(this.ActorId == null) {

                this.ActorId = "FETCH";

            } else {


            }
        }
        else if (this.ActorId != null && ec.Excludes("actorId",true))
        {
            this.ActorId = null;
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
        //      C# -> System.String? ActorSid
        // GraphQL -> actorSid: String! (scalar)
        if (ec.Includes("actorSid",true))
        {
            if(this.ActorSid == null) {

                this.ActorSid = "FETCH";

            } else {


            }
        }
        else if (this.ActorSid != null && ec.Excludes("actorSid",true))
        {
            this.ActorSid = null;
        }
        //      C# -> System.String? ActorUserType
        // GraphQL -> actorUserType: String! (scalar)
        if (ec.Includes("actorUserType",true))
        {
            if(this.ActorUserType == null) {

                this.ActorUserType = "FETCH";

            } else {


            }
        }
        else if (this.ActorUserType != null && ec.Excludes("actorUserType",true))
        {
            this.ActorUserType = null;
        }
        //      C# -> System.String? AdditionalData
        // GraphQL -> additionalData: String! (scalar)
        if (ec.Includes("additionalData",true))
        {
            if(this.AdditionalData == null) {

                this.AdditionalData = "FETCH";

            } else {


            }
        }
        else if (this.AdditionalData != null && ec.Excludes("additionalData",true))
        {
            this.AdditionalData = null;
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        if (ec.Includes("applicationId",true))
        {
            if(this.ApplicationId == null) {

                this.ApplicationId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationId != null && ec.Excludes("applicationId",true))
        {
            this.ApplicationId = null;
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
        //      C# -> System.String? AuthenticationPackage
        // GraphQL -> authenticationPackage: String! (scalar)
        if (ec.Includes("authenticationPackage",true))
        {
            if(this.AuthenticationPackage == null) {

                this.AuthenticationPackage = "FETCH";

            } else {


            }
        }
        else if (this.AuthenticationPackage != null && ec.Excludes("authenticationPackage",true))
        {
            this.AuthenticationPackage = null;
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
        //      C# -> System.String? CorrelationId
        // GraphQL -> correlationId: String! (scalar)
        if (ec.Includes("correlationId",true))
        {
            if(this.CorrelationId == null) {

                this.CorrelationId = "FETCH";

            } else {


            }
        }
        else if (this.CorrelationId != null && ec.Excludes("correlationId",true))
        {
            this.CorrelationId = null;
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
        //      C# -> System.String? CountryCode
        // GraphQL -> countryCode: String! (scalar)
        if (ec.Includes("countryCode",true))
        {
            if(this.CountryCode == null) {

                this.CountryCode = "FETCH";

            } else {


            }
        }
        else if (this.CountryCode != null && ec.Excludes("countryCode",true))
        {
            this.CountryCode = null;
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
        //      C# -> System.String? DeviceOs
        // GraphQL -> deviceOs: String! (scalar)
        if (ec.Includes("deviceOs",true))
        {
            if(this.DeviceOs == null) {

                this.DeviceOs = "FETCH";

            } else {


            }
        }
        else if (this.DeviceOs != null && ec.Excludes("deviceOs",true))
        {
            this.DeviceOs = null;
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
        //      C# -> System.String? EventTitle
        // GraphQL -> eventTitle: String! (scalar)
        if (ec.Includes("eventTitle",true))
        {
            if(this.EventTitle == null) {

                this.EventTitle = "FETCH";

            } else {


            }
        }
        else if (this.EventTitle != null && ec.Excludes("eventTitle",true))
        {
            this.EventTitle = null;
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
        //      C# -> DateTime? IngestionTimestamp
        // GraphQL -> ingestionTimestamp: DateTime (scalar)
        if (ec.Includes("ingestionTimestamp",true))
        {
            if(this.IngestionTimestamp == null) {

                this.IngestionTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.IngestionTimestamp != null && ec.Excludes("ingestionTimestamp",true))
        {
            this.IngestionTimestamp = null;
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
        //      C# -> System.Int64? LogonType
        // GraphQL -> logonType: Long! (scalar)
        if (ec.Includes("logonType",true))
        {
            if(this.LogonType == null) {

                this.LogonType = new System.Int64();

            } else {


            }
        }
        else if (this.LogonType != null && ec.Excludes("logonType",true))
        {
            this.LogonType = null;
        }
        //      C# -> System.String? LogonTypeDescription
        // GraphQL -> logonTypeDescription: String! (scalar)
        if (ec.Includes("logonTypeDescription",true))
        {
            if(this.LogonTypeDescription == null) {

                this.LogonTypeDescription = "FETCH";

            } else {


            }
        }
        else if (this.LogonTypeDescription != null && ec.Excludes("logonTypeDescription",true))
        {
            this.LogonTypeDescription = null;
        }
        //      C# -> System.String? MfaMethod
        // GraphQL -> mfaMethod: String! (scalar)
        if (ec.Includes("mfaMethod",true))
        {
            if(this.MfaMethod == null) {

                this.MfaMethod = "FETCH";

            } else {


            }
        }
        else if (this.MfaMethod != null && ec.Excludes("mfaMethod",true))
        {
            this.MfaMethod = null;
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
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
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
        //      C# -> System.String? ResultReason
        // GraphQL -> resultReason: String! (scalar)
        if (ec.Includes("resultReason",true))
        {
            if(this.ResultReason == null) {

                this.ResultReason = "FETCH";

            } else {


            }
        }
        else if (this.ResultReason != null && ec.Excludes("resultReason",true))
        {
            this.ResultReason = null;
        }
        //      C# -> System.String? RiskIndicators
        // GraphQL -> riskIndicators: String! (scalar)
        if (ec.Includes("riskIndicators",true))
        {
            if(this.RiskIndicators == null) {

                this.RiskIndicators = "FETCH";

            } else {


            }
        }
        else if (this.RiskIndicators != null && ec.Excludes("riskIndicators",true))
        {
            this.RiskIndicators = null;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (ec.Includes("sessionId",true))
        {
            if(this.SessionId == null) {

                this.SessionId = "FETCH";

            } else {


            }
        }
        else if (this.SessionId != null && ec.Excludes("sessionId",true))
        {
            this.SessionId = null;
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
        //      C# -> System.String? TargetDisplayName
        // GraphQL -> targetDisplayName: String! (scalar)
        if (ec.Includes("targetDisplayName",true))
        {
            if(this.TargetDisplayName == null) {

                this.TargetDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.TargetDisplayName != null && ec.Excludes("targetDisplayName",true))
        {
            this.TargetDisplayName = null;
        }
        //      C# -> System.String? TargetDomain
        // GraphQL -> targetDomain: String! (scalar)
        if (ec.Includes("targetDomain",true))
        {
            if(this.TargetDomain == null) {

                this.TargetDomain = "FETCH";

            } else {


            }
        }
        else if (this.TargetDomain != null && ec.Excludes("targetDomain",true))
        {
            this.TargetDomain = null;
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (ec.Includes("targetId",true))
        {
            if(this.TargetId == null) {

                this.TargetId = "FETCH";

            } else {


            }
        }
        else if (this.TargetId != null && ec.Excludes("targetId",true))
        {
            this.TargetId = null;
        }
        //      C# -> System.String? TargetPrincipalName
        // GraphQL -> targetPrincipalName: String! (scalar)
        if (ec.Includes("targetPrincipalName",true))
        {
            if(this.TargetPrincipalName == null) {

                this.TargetPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.TargetPrincipalName != null && ec.Excludes("targetPrincipalName",true))
        {
            this.TargetPrincipalName = null;
        }
        //      C# -> System.String? TargetSid
        // GraphQL -> targetSid: String! (scalar)
        if (ec.Includes("targetSid",true))
        {
            if(this.TargetSid == null) {

                this.TargetSid = "FETCH";

            } else {


            }
        }
        else if (this.TargetSid != null && ec.Excludes("targetSid",true))
        {
            this.TargetSid = null;
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
    }


    #endregion

    } // class SigninLogDetails
    
    #endregion

    public static class ListSigninLogDetailsExtensions
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
            this List<SigninLogDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninLogDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninLogDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninLogDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninLogDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types