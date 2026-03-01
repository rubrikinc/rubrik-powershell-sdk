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

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

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
        EventProvider? Provider = null,
        SigninLogResult? Result = null,
        SigninLogRiskLevel? RiskLevel = null,
        System.String? ActorDisplayName = null,
        System.String? ActorPrincipalName = null,
        System.String? ApplicationName = null,
        System.String? City = null,
        System.String? Country = null,
        System.String? DeviceName = null,
        System.String? EventId = null,
        DateTime? EventTimestamp = null,
        System.String? EventType = null,
        System.String? IpAddress = null,
        System.String? State = null,
        System.String? UserSid = null
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
        if ( ActorPrincipalName != null ) {
            this.ActorPrincipalName = ActorPrincipalName;
        }
        if ( ApplicationName != null ) {
            this.ApplicationName = ApplicationName;
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
        if ( State != null ) {
            this.State = State;
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
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
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