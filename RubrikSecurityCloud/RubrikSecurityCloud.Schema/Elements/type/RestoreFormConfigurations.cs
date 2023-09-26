// RestoreFormConfigurations.cs
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
    #region RestoreFormConfigurations
    public class RestoreFormConfigurations: BaseType
    {
        #region members

        //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
        [JsonProperty("guestOsCredentials")]
        public List<RestoreFormConfigurationGuestOs>? GuestOsCredentials { get; set; }

        //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
        [JsonProperty("kmipServers")]
        public List<RestoreFormConfigurationKmipServer>? KmipServers { get; set; }

        //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
        // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
        [JsonProperty("ldapServers")]
        public List<RestoreFormConfigurationLdapServer>? LdapServers { get; set; }

        //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
        // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
        [JsonProperty("nasHosts")]
        public List<RestoreFormConfigurationNasHost>? NasHosts { get; set; }

        //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
        [JsonProperty("objectStoreArchivalLocations")]
        public List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations { get; set; }

        //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
        [JsonProperty("organizations")]
        public List<RestoreFormConfigurationOrganization>? Organizations { get; set; }

        //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
        [JsonProperty("replicationTargets")]
        public List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets { get; set; }

        //      C# -> List<RestoreFormConfigurationReport>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
        [JsonProperty("reports")]
        public List<RestoreFormConfigurationReport>? Reports { get; set; }

        //      C# -> List<RestoreFormConfigurationRole>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
        [JsonProperty("roles")]
        public List<RestoreFormConfigurationRole>? Roles { get; set; }

        //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
        [JsonProperty("s3ArchivalLocations")]
        public List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations { get; set; }

        //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
        [JsonProperty("slaDomains")]
        public List<RestoreFormConfigurationSlaDomain>? SlaDomains { get; set; }

        //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
        // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
        [JsonProperty("smtpSettings")]
        public List<RestoreFormConfigurationSmtp>? SmtpSettings { get; set; }

        //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
        // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
        [JsonProperty("snmpSettings")]
        public List<RestoreFormConfigurationSnmp>? SnmpSettings { get; set; }

        //      C# -> List<RestoreFormConfigurationUser>? Users
        // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
        [JsonProperty("users")]
        public List<RestoreFormConfigurationUser>? Users { get; set; }

        //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
        // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
        [JsonProperty("vcenterServers")]
        public List<RestoreFormConfigurationVcenterServer>? VcenterServers { get; set; }

        //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
        [JsonProperty("winAndUnixHosts")]
        public List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurations";
    }

    public RestoreFormConfigurations Set(
        List<RestoreFormConfigurationGuestOs>? GuestOsCredentials = null,
        List<RestoreFormConfigurationKmipServer>? KmipServers = null,
        List<RestoreFormConfigurationLdapServer>? LdapServers = null,
        List<RestoreFormConfigurationNasHost>? NasHosts = null,
        List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations = null,
        List<RestoreFormConfigurationOrganization>? Organizations = null,
        List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets = null,
        List<RestoreFormConfigurationReport>? Reports = null,
        List<RestoreFormConfigurationRole>? Roles = null,
        List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations = null,
        List<RestoreFormConfigurationSlaDomain>? SlaDomains = null,
        List<RestoreFormConfigurationSmtp>? SmtpSettings = null,
        List<RestoreFormConfigurationSnmp>? SnmpSettings = null,
        List<RestoreFormConfigurationUser>? Users = null,
        List<RestoreFormConfigurationVcenterServer>? VcenterServers = null,
        List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts = null
    ) 
    {
        if ( GuestOsCredentials != null ) {
            this.GuestOsCredentials = GuestOsCredentials;
        }
        if ( KmipServers != null ) {
            this.KmipServers = KmipServers;
        }
        if ( LdapServers != null ) {
            this.LdapServers = LdapServers;
        }
        if ( NasHosts != null ) {
            this.NasHosts = NasHosts;
        }
        if ( ObjectStoreArchivalLocations != null ) {
            this.ObjectStoreArchivalLocations = ObjectStoreArchivalLocations;
        }
        if ( Organizations != null ) {
            this.Organizations = Organizations;
        }
        if ( ReplicationTargets != null ) {
            this.ReplicationTargets = ReplicationTargets;
        }
        if ( Reports != null ) {
            this.Reports = Reports;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( S3ArchivalLocations != null ) {
            this.S3ArchivalLocations = S3ArchivalLocations;
        }
        if ( SlaDomains != null ) {
            this.SlaDomains = SlaDomains;
        }
        if ( SmtpSettings != null ) {
            this.SmtpSettings = SmtpSettings;
        }
        if ( SnmpSettings != null ) {
            this.SnmpSettings = SnmpSettings;
        }
        if ( Users != null ) {
            this.Users = Users;
        }
        if ( VcenterServers != null ) {
            this.VcenterServers = VcenterServers;
        }
        if ( WinAndUnixHosts != null ) {
            this.WinAndUnixHosts = WinAndUnixHosts;
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
        //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
        if (this.GuestOsCredentials != null) {
            var fspec = this.GuestOsCredentials.AsFieldSpec(conf.Child("guestOsCredentials"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "guestOsCredentials {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
        if (this.KmipServers != null) {
            var fspec = this.KmipServers.AsFieldSpec(conf.Child("kmipServers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kmipServers {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
        // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
        if (this.LdapServers != null) {
            var fspec = this.LdapServers.AsFieldSpec(conf.Child("ldapServers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ldapServers {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
        // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
        if (this.NasHosts != null) {
            var fspec = this.NasHosts.AsFieldSpec(conf.Child("nasHosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nasHosts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
        if (this.ObjectStoreArchivalLocations != null) {
            var fspec = this.ObjectStoreArchivalLocations.AsFieldSpec(conf.Child("objectStoreArchivalLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectStoreArchivalLocations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
        if (this.Organizations != null) {
            var fspec = this.Organizations.AsFieldSpec(conf.Child("organizations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "organizations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            var fspec = this.ReplicationTargets.AsFieldSpec(conf.Child("replicationTargets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationTargets {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationReport>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
        if (this.Reports != null) {
            var fspec = this.Reports.AsFieldSpec(conf.Child("reports"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reports {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationRole>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
        if (this.S3ArchivalLocations != null) {
            var fspec = this.S3ArchivalLocations.AsFieldSpec(conf.Child("s3ArchivalLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "s3ArchivalLocations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
        if (this.SlaDomains != null) {
            var fspec = this.SlaDomains.AsFieldSpec(conf.Child("slaDomains"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomains {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
        // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
        if (this.SmtpSettings != null) {
            var fspec = this.SmtpSettings.AsFieldSpec(conf.Child("smtpSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "smtpSettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
        // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
        if (this.SnmpSettings != null) {
            var fspec = this.SnmpSettings.AsFieldSpec(conf.Child("snmpSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snmpSettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationUser>? Users
        // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(conf.Child("users"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "users {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
        // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
        if (this.VcenterServers != null) {
            var fspec = this.VcenterServers.AsFieldSpec(conf.Child("vcenterServers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vcenterServers {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
        if (this.WinAndUnixHosts != null) {
            var fspec = this.WinAndUnixHosts.AsFieldSpec(conf.Child("winAndUnixHosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "winAndUnixHosts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
        if (ec.Includes("guestOsCredentials",false))
        {
            if(this.GuestOsCredentials == null) {

                this.GuestOsCredentials = new List<RestoreFormConfigurationGuestOs>();
                this.GuestOsCredentials.ApplyExploratoryFieldSpec(ec.NewChild("guestOsCredentials"));

            } else {

                this.GuestOsCredentials.ApplyExploratoryFieldSpec(ec.NewChild("guestOsCredentials"));

            }
        }
        else if (this.GuestOsCredentials != null && ec.Excludes("guestOsCredentials",false))
        {
            this.GuestOsCredentials = null;
        }
        //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
        if (ec.Includes("kmipServers",false))
        {
            if(this.KmipServers == null) {

                this.KmipServers = new List<RestoreFormConfigurationKmipServer>();
                this.KmipServers.ApplyExploratoryFieldSpec(ec.NewChild("kmipServers"));

            } else {

                this.KmipServers.ApplyExploratoryFieldSpec(ec.NewChild("kmipServers"));

            }
        }
        else if (this.KmipServers != null && ec.Excludes("kmipServers",false))
        {
            this.KmipServers = null;
        }
        //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
        // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
        if (ec.Includes("ldapServers",false))
        {
            if(this.LdapServers == null) {

                this.LdapServers = new List<RestoreFormConfigurationLdapServer>();
                this.LdapServers.ApplyExploratoryFieldSpec(ec.NewChild("ldapServers"));

            } else {

                this.LdapServers.ApplyExploratoryFieldSpec(ec.NewChild("ldapServers"));

            }
        }
        else if (this.LdapServers != null && ec.Excludes("ldapServers",false))
        {
            this.LdapServers = null;
        }
        //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
        // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
        if (ec.Includes("nasHosts",false))
        {
            if(this.NasHosts == null) {

                this.NasHosts = new List<RestoreFormConfigurationNasHost>();
                this.NasHosts.ApplyExploratoryFieldSpec(ec.NewChild("nasHosts"));

            } else {

                this.NasHosts.ApplyExploratoryFieldSpec(ec.NewChild("nasHosts"));

            }
        }
        else if (this.NasHosts != null && ec.Excludes("nasHosts",false))
        {
            this.NasHosts = null;
        }
        //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
        if (ec.Includes("objectStoreArchivalLocations",false))
        {
            if(this.ObjectStoreArchivalLocations == null) {

                this.ObjectStoreArchivalLocations = new List<RestoreFormConfigurationObjectStoreArchivalLocation>();
                this.ObjectStoreArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("objectStoreArchivalLocations"));

            } else {

                this.ObjectStoreArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("objectStoreArchivalLocations"));

            }
        }
        else if (this.ObjectStoreArchivalLocations != null && ec.Excludes("objectStoreArchivalLocations",false))
        {
            this.ObjectStoreArchivalLocations = null;
        }
        //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
        if (ec.Includes("organizations",false))
        {
            if(this.Organizations == null) {

                this.Organizations = new List<RestoreFormConfigurationOrganization>();
                this.Organizations.ApplyExploratoryFieldSpec(ec.NewChild("organizations"));

            } else {

                this.Organizations.ApplyExploratoryFieldSpec(ec.NewChild("organizations"));

            }
        }
        else if (this.Organizations != null && ec.Excludes("organizations",false))
        {
            this.Organizations = null;
        }
        //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
        if (ec.Includes("replicationTargets",false))
        {
            if(this.ReplicationTargets == null) {

                this.ReplicationTargets = new List<RestoreFormConfigurationReplicationTarget>();
                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            } else {

                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            }
        }
        else if (this.ReplicationTargets != null && ec.Excludes("replicationTargets",false))
        {
            this.ReplicationTargets = null;
        }
        //      C# -> List<RestoreFormConfigurationReport>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
        if (ec.Includes("reports",false))
        {
            if(this.Reports == null) {

                this.Reports = new List<RestoreFormConfigurationReport>();
                this.Reports.ApplyExploratoryFieldSpec(ec.NewChild("reports"));

            } else {

                this.Reports.ApplyExploratoryFieldSpec(ec.NewChild("reports"));

            }
        }
        else if (this.Reports != null && ec.Excludes("reports",false))
        {
            this.Reports = null;
        }
        //      C# -> List<RestoreFormConfigurationRole>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<RestoreFormConfigurationRole>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
        //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
        if (ec.Includes("s3ArchivalLocations",false))
        {
            if(this.S3ArchivalLocations == null) {

                this.S3ArchivalLocations = new List<RestoreFormConfigurationS3ArchivalLocation>();
                this.S3ArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("s3ArchivalLocations"));

            } else {

                this.S3ArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("s3ArchivalLocations"));

            }
        }
        else if (this.S3ArchivalLocations != null && ec.Excludes("s3ArchivalLocations",false))
        {
            this.S3ArchivalLocations = null;
        }
        //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
        if (ec.Includes("slaDomains",false))
        {
            if(this.SlaDomains == null) {

                this.SlaDomains = new List<RestoreFormConfigurationSlaDomain>();
                this.SlaDomains.ApplyExploratoryFieldSpec(ec.NewChild("slaDomains"));

            } else {

                this.SlaDomains.ApplyExploratoryFieldSpec(ec.NewChild("slaDomains"));

            }
        }
        else if (this.SlaDomains != null && ec.Excludes("slaDomains",false))
        {
            this.SlaDomains = null;
        }
        //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
        // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
        if (ec.Includes("smtpSettings",false))
        {
            if(this.SmtpSettings == null) {

                this.SmtpSettings = new List<RestoreFormConfigurationSmtp>();
                this.SmtpSettings.ApplyExploratoryFieldSpec(ec.NewChild("smtpSettings"));

            } else {

                this.SmtpSettings.ApplyExploratoryFieldSpec(ec.NewChild("smtpSettings"));

            }
        }
        else if (this.SmtpSettings != null && ec.Excludes("smtpSettings",false))
        {
            this.SmtpSettings = null;
        }
        //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
        // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
        if (ec.Includes("snmpSettings",false))
        {
            if(this.SnmpSettings == null) {

                this.SnmpSettings = new List<RestoreFormConfigurationSnmp>();
                this.SnmpSettings.ApplyExploratoryFieldSpec(ec.NewChild("snmpSettings"));

            } else {

                this.SnmpSettings.ApplyExploratoryFieldSpec(ec.NewChild("snmpSettings"));

            }
        }
        else if (this.SnmpSettings != null && ec.Excludes("snmpSettings",false))
        {
            this.SnmpSettings = null;
        }
        //      C# -> List<RestoreFormConfigurationUser>? Users
        // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
        if (ec.Includes("users",false))
        {
            if(this.Users == null) {

                this.Users = new List<RestoreFormConfigurationUser>();
                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            } else {

                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            }
        }
        else if (this.Users != null && ec.Excludes("users",false))
        {
            this.Users = null;
        }
        //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
        // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
        if (ec.Includes("vcenterServers",false))
        {
            if(this.VcenterServers == null) {

                this.VcenterServers = new List<RestoreFormConfigurationVcenterServer>();
                this.VcenterServers.ApplyExploratoryFieldSpec(ec.NewChild("vcenterServers"));

            } else {

                this.VcenterServers.ApplyExploratoryFieldSpec(ec.NewChild("vcenterServers"));

            }
        }
        else if (this.VcenterServers != null && ec.Excludes("vcenterServers",false))
        {
            this.VcenterServers = null;
        }
        //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
        if (ec.Includes("winAndUnixHosts",false))
        {
            if(this.WinAndUnixHosts == null) {

                this.WinAndUnixHosts = new List<RestoreFormConfigurationWinAndUnixHost>();
                this.WinAndUnixHosts.ApplyExploratoryFieldSpec(ec.NewChild("winAndUnixHosts"));

            } else {

                this.WinAndUnixHosts.ApplyExploratoryFieldSpec(ec.NewChild("winAndUnixHosts"));

            }
        }
        else if (this.WinAndUnixHosts != null && ec.Excludes("winAndUnixHosts",false))
        {
            this.WinAndUnixHosts = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurations
    
    #endregion

    public static class ListRestoreFormConfigurationsExtensions
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
            this List<RestoreFormConfigurations> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurations> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurations());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RestoreFormConfigurations> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types