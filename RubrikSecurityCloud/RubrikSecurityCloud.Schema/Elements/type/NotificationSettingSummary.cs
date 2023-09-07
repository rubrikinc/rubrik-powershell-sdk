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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses != null) {
            s += ind + "emailAddresses\n" ;
        }
        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!]! (scalar)
        if (this.EventTypes != null) {
            s += ind + "eventTypes\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> List<System.String>? ObjectTypes
        // GraphQL -> objectTypes: [String!]! (scalar)
        if (this.ObjectTypes != null) {
            s += ind + "objectTypes\n" ;
        }
        //      C# -> List<System.String>? Severity
        // GraphQL -> severity: [String!]! (scalar)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.Boolean? ShouldSendToSyslog
        // GraphQL -> shouldSendToSyslog: Boolean! (scalar)
        if (this.ShouldSendToSyslog != null) {
            s += ind + "shouldSendToSyslog\n" ;
        }
        //      C# -> List<System.String>? SnmpAddresses
        // GraphQL -> snmpAddresses: [String!]! (scalar)
        if (this.SnmpAddresses != null) {
            s += ind + "snmpAddresses\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses == null && ec.Includes("emailAddresses",true))
        {
            this.EmailAddresses = new List<System.String>();
        }
        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!]! (scalar)
        if (this.EventTypes == null && ec.Includes("eventTypes",true))
        {
            this.EventTypes = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> List<System.String>? ObjectTypes
        // GraphQL -> objectTypes: [String!]! (scalar)
        if (this.ObjectTypes == null && ec.Includes("objectTypes",true))
        {
            this.ObjectTypes = new List<System.String>();
        }
        //      C# -> List<System.String>? Severity
        // GraphQL -> severity: [String!]! (scalar)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new List<System.String>();
        }
        //      C# -> System.Boolean? ShouldSendToSyslog
        // GraphQL -> shouldSendToSyslog: Boolean! (scalar)
        if (this.ShouldSendToSyslog == null && ec.Includes("shouldSendToSyslog",true))
        {
            this.ShouldSendToSyslog = true;
        }
        //      C# -> List<System.String>? SnmpAddresses
        // GraphQL -> snmpAddresses: [String!]! (scalar)
        if (this.SnmpAddresses == null && ec.Includes("snmpAddresses",true))
        {
            this.SnmpAddresses = new List<System.String>();
        }
    }


    #endregion

    } // class NotificationSettingSummary
    
    #endregion

    public static class ListNotificationSettingSummaryExtensions
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
            this List<NotificationSettingSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<NotificationSettingSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types