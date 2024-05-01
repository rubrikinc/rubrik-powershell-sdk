// NotificationSettingSummary.cs
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
    #region NotificationSettingSummary
    public class NotificationSettingSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        [JsonProperty("emailAddresses")]
        public List<System.String>? EmailAddresses { get; set; }

        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!]! (scalar)
        [JsonProperty("eventTypes")]
        public List<System.String>? EventTypes { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? ObjectTypes
        // GraphQL -> objectTypes: [String!]! (scalar)
        [JsonProperty("objectTypes")]
        public List<System.String>? ObjectTypes { get; set; }

        //      C# -> List<System.String>? Severity
        // GraphQL -> severity: [String!]! (scalar)
        [JsonProperty("severity")]
        public List<System.String>? Severity { get; set; }

        //      C# -> System.Boolean? ShouldSendToSyslog
        // GraphQL -> shouldSendToSyslog: Boolean! (scalar)
        [JsonProperty("shouldSendToSyslog")]
        public System.Boolean? ShouldSendToSyslog { get; set; }

        //      C# -> List<System.String>? SnmpAddresses
        // GraphQL -> snmpAddresses: [String!]! (scalar)
        [JsonProperty("snmpAddresses")]
        public List<System.String>? SnmpAddresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NotificationSettingSummary";
    }

    public NotificationSettingSummary Set(
        List<System.String>? EmailAddresses = null,
        List<System.String>? EventTypes = null,
        System.String? Id = null,
        List<System.String>? ObjectTypes = null,
        List<System.String>? Severity = null,
        System.Boolean? ShouldSendToSyslog = null,
        List<System.String>? SnmpAddresses = null
    ) 
    {
        if ( EmailAddresses != null ) {
            this.EmailAddresses = EmailAddresses;
        }
        if ( EventTypes != null ) {
            this.EventTypes = EventTypes;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ObjectTypes != null ) {
            this.ObjectTypes = ObjectTypes;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ShouldSendToSyslog != null ) {
            this.ShouldSendToSyslog = ShouldSendToSyslog;
        }
        if ( SnmpAddresses != null ) {
            this.SnmpAddresses = SnmpAddresses;
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
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "emailAddresses\n" ;
            } else {
                s += ind + "emailAddresses\n" ;
            }
        }
        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!]! (scalar)
        if (this.EventTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTypes\n" ;
            } else {
                s += ind + "eventTypes\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> List<System.String>? ObjectTypes
        // GraphQL -> objectTypes: [String!]! (scalar)
        if (this.ObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectTypes\n" ;
            } else {
                s += ind + "objectTypes\n" ;
            }
        }
        //      C# -> List<System.String>? Severity
        // GraphQL -> severity: [String!]! (scalar)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldSendToSyslog
        // GraphQL -> shouldSendToSyslog: Boolean! (scalar)
        if (this.ShouldSendToSyslog != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldSendToSyslog\n" ;
            } else {
                s += ind + "shouldSendToSyslog\n" ;
            }
        }
        //      C# -> List<System.String>? SnmpAddresses
        // GraphQL -> snmpAddresses: [String!]! (scalar)
        if (this.SnmpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snmpAddresses\n" ;
            } else {
                s += ind + "snmpAddresses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (ec.Includes("emailAddresses",true))
        {
            if(this.EmailAddresses == null) {

                this.EmailAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.EmailAddresses != null && ec.Excludes("emailAddresses",true))
        {
            this.EmailAddresses = null;
        }
        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!]! (scalar)
        if (ec.Includes("eventTypes",true))
        {
            if(this.EventTypes == null) {

                this.EventTypes = new List<System.String>();

            } else {


            }
        }
        else if (this.EventTypes != null && ec.Excludes("eventTypes",true))
        {
            this.EventTypes = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> List<System.String>? ObjectTypes
        // GraphQL -> objectTypes: [String!]! (scalar)
        if (ec.Includes("objectTypes",true))
        {
            if(this.ObjectTypes == null) {

                this.ObjectTypes = new List<System.String>();

            } else {


            }
        }
        else if (this.ObjectTypes != null && ec.Excludes("objectTypes",true))
        {
            this.ObjectTypes = null;
        }
        //      C# -> List<System.String>? Severity
        // GraphQL -> severity: [String!]! (scalar)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new List<System.String>();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Boolean? ShouldSendToSyslog
        // GraphQL -> shouldSendToSyslog: Boolean! (scalar)
        if (ec.Includes("shouldSendToSyslog",true))
        {
            if(this.ShouldSendToSyslog == null) {

                this.ShouldSendToSyslog = true;

            } else {


            }
        }
        else if (this.ShouldSendToSyslog != null && ec.Excludes("shouldSendToSyslog",true))
        {
            this.ShouldSendToSyslog = null;
        }
        //      C# -> List<System.String>? SnmpAddresses
        // GraphQL -> snmpAddresses: [String!]! (scalar)
        if (ec.Includes("snmpAddresses",true))
        {
            if(this.SnmpAddresses == null) {

                this.SnmpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.SnmpAddresses != null && ec.Excludes("snmpAddresses",true))
        {
            this.SnmpAddresses = null;
        }
    }


    #endregion

    } // class NotificationSettingSummary
    
    #endregion

    public static class ListNotificationSettingSummaryExtensions
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
            this List<NotificationSettingSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NotificationSettingSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NotificationSettingSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NotificationSettingSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NotificationSettingSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types