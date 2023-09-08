// SyslogExportRuleFull.cs
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
    #region SyslogExportRuleFull
    public class SyslogExportRuleFull: BaseType
    {
        #region members

        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility! (enum)
        [JsonProperty("facility")]
        public SyslogFacility? Facility { get; set; }

        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol! (enum)
        [JsonProperty("protocol")]
        public TransportLayerProtocol? Protocol { get; set; }

        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity! (enum)
        [JsonProperty("severity")]
        public SyslogSeverity? Severity { get; set; }

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean! (scalar)
        [JsonProperty("enableTls")]
        public System.Boolean? EnableTls { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogExportRuleFull";
    }

    public SyslogExportRuleFull Set(
        SyslogFacility? Facility = null,
        TransportLayerProtocol? Protocol = null,
        SyslogSeverity? Severity = null,
        System.String? CertificateId = null,
        System.Boolean? EnableTls = null,
        System.String? Hostname = null,
        System.Int32? Port = null
    ) 
    {
        if ( Facility != null ) {
            this.Facility = Facility;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( EnableTls != null ) {
            this.EnableTls = EnableTls;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility! (enum)
        if (this.Facility != null) {
            s += ind + "facility\n" ;
        }
        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol! (enum)
        if (this.Protocol != null) {
            s += ind + "protocol\n" ;
        }
        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        if (this.CertificateId != null) {
            s += ind + "certificateId\n" ;
        }
        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean! (scalar)
        if (this.EnableTls != null) {
            s += ind + "enableTls\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility! (enum)
        if (this.Facility == null && ec.Includes("facility",true))
        {
            this.Facility = new SyslogFacility();
        }
        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol! (enum)
        if (this.Protocol == null && ec.Includes("protocol",true))
        {
            this.Protocol = new TransportLayerProtocol();
        }
        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new SyslogSeverity();
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        if (this.CertificateId == null && ec.Includes("certificateId",true))
        {
            this.CertificateId = "FETCH";
        }
        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean! (scalar)
        if (this.EnableTls == null && ec.Includes("enableTls",true))
        {
            this.EnableTls = true;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && ec.Includes("hostname",true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && ec.Includes("port",true))
        {
            this.Port = Int32.MinValue;
        }
    }


    #endregion

    } // class SyslogExportRuleFull
    
    #endregion

    public static class ListSyslogExportRuleFullExtensions
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
            this List<SyslogExportRuleFull> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SyslogExportRuleFull> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogExportRuleFull());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SyslogExportRuleFull> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types