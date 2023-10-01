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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility! (enum)
        if (this.Facility != null) {
            if (conf.Flat) {
                s += conf.Prefix + "facility\n" ;
            } else {
                s += ind + "facility\n" ;
            }
        }
        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol! (enum)
        if (this.Protocol != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protocol\n" ;
            } else {
                s += ind + "protocol\n" ;
            }
        }
        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        if (this.CertificateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateId\n" ;
            } else {
                s += ind + "certificateId\n" ;
            }
        }
        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean! (scalar)
        if (this.EnableTls != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableTls\n" ;
            } else {
                s += ind + "enableTls\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility! (enum)
        if (ec.Includes("facility",true))
        {
            if(this.Facility == null) {

                this.Facility = new SyslogFacility();

            } else {


            }
        }
        else if (this.Facility != null && ec.Excludes("facility",true))
        {
            this.Facility = null;
        }
        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol! (enum)
        if (ec.Includes("protocol",true))
        {
            if(this.Protocol == null) {

                this.Protocol = new TransportLayerProtocol();

            } else {


            }
        }
        else if (this.Protocol != null && ec.Excludes("protocol",true))
        {
            this.Protocol = null;
        }
        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new SyslogSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        if (ec.Includes("certificateId",true))
        {
            if(this.CertificateId == null) {

                this.CertificateId = "FETCH";

            } else {


            }
        }
        else if (this.CertificateId != null && ec.Excludes("certificateId",true))
        {
            this.CertificateId = null;
        }
        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean! (scalar)
        if (ec.Includes("enableTls",true))
        {
            if(this.EnableTls == null) {

                this.EnableTls = true;

            } else {


            }
        }
        else if (this.EnableTls != null && ec.Excludes("enableTls",true))
        {
            this.EnableTls = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = Int32.MinValue;

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SyslogExportRuleFull> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SyslogExportRuleFull> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types