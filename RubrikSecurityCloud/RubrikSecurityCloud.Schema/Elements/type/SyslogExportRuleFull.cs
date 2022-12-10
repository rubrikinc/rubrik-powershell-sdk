// SyslogExportRuleFull.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:49.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region SyslogExportRuleFull
    public class SyslogExportRuleFull: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public SyslogExportRuleFull Set(
        System.String? CertificateId = null,
        System.Boolean? EnableTls = null,
        System.String? Hostname = null,
        System.Int32? Port = null,
        SyslogFacility? Facility = null,
        TransportLayerProtocol? Protocol = null,
        SyslogSeverity? Severity = null
    ) 
    {
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
        if ( Facility != null ) {
            this.Facility = Facility;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CertificateId
            // GraphQL -> certificateId: String (scalar)
            if (this.CertificateId != null)
            {
                 s += ind + "certificateId\n";

            }
            //      C# -> System.Boolean? EnableTls
            // GraphQL -> enableTls: Boolean! (scalar)
            if (this.EnableTls != null)
            {
                 s += ind + "enableTls\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> SyslogFacility? Facility
            // GraphQL -> facility: SyslogFacility! (enum)
            if (this.Facility != null)
            {
                 s += ind + "facility\n";

            }
            //      C# -> TransportLayerProtocol? Protocol
            // GraphQL -> protocol: TransportLayerProtocol! (enum)
            if (this.Protocol != null)
            {
                 s += ind + "protocol\n";

            }
            //      C# -> SyslogSeverity? Severity
            // GraphQL -> severity: SyslogSeverity! (enum)
            if (this.Severity != null)
            {
                 s += ind + "severity\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CertificateId
            // GraphQL -> certificateId: String (scalar)
            if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId$"))
            {
                this.CertificateId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? EnableTls
            // GraphQL -> enableTls: Boolean! (scalar)
            if (this.EnableTls == null && Exploration.Includes(parent + ".enableTls$"))
            {
                this.EnableTls = new System.Boolean();
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int32();
            }
            //      C# -> SyslogFacility? Facility
            // GraphQL -> facility: SyslogFacility! (enum)
            if (this.Facility == null && Exploration.Includes(parent + ".facility$"))
            {
                this.Facility = new SyslogFacility();
            }
            //      C# -> TransportLayerProtocol? Protocol
            // GraphQL -> protocol: TransportLayerProtocol! (enum)
            if (this.Protocol == null && Exploration.Includes(parent + ".protocol$"))
            {
                this.Protocol = new TransportLayerProtocol();
            }
            //      C# -> SyslogSeverity? Severity
            // GraphQL -> severity: SyslogSeverity! (enum)
            if (this.Severity == null && Exploration.Includes(parent + ".severity$"))
            {
                this.Severity = new SyslogSeverity();
            }
        }


    #endregion

    } // class SyslogExportRuleFull
    #endregion

    public static class ListSyslogExportRuleFullExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SyslogExportRuleFull> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SyslogExportRuleFull> list, 
            String parent = "")
        {
            var item = new SyslogExportRuleFull();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types