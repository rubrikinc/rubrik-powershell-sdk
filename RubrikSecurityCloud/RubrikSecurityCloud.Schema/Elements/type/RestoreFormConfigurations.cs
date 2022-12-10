// RestoreFormConfigurations.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:18.
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
    #region RestoreFormConfigurations
    public class RestoreFormConfigurations: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
            // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
            if (this.GuestOsCredentials != null)
            {
                 s += ind + "guestOsCredentials\n";

                 s += ind + "{\n" + 
                 this.GuestOsCredentials.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
            // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
            if (this.KmipServers != null)
            {
                 s += ind + "kmipServers\n";

                 s += ind + "{\n" + 
                 this.KmipServers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
            // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
            if (this.LdapServers != null)
            {
                 s += ind + "ldapServers\n";

                 s += ind + "{\n" + 
                 this.LdapServers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
            // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
            if (this.NasHosts != null)
            {
                 s += ind + "nasHosts\n";

                 s += ind + "{\n" + 
                 this.NasHosts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
            // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
            if (this.ObjectStoreArchivalLocations != null)
            {
                 s += ind + "objectStoreArchivalLocations\n";

                 s += ind + "{\n" + 
                 this.ObjectStoreArchivalLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
            // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
            if (this.Organizations != null)
            {
                 s += ind + "organizations\n";

                 s += ind + "{\n" + 
                 this.Organizations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
            // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
            if (this.ReplicationTargets != null)
            {
                 s += ind + "replicationTargets\n";

                 s += ind + "{\n" + 
                 this.ReplicationTargets.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationReport>? Reports
            // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
            if (this.Reports != null)
            {
                 s += ind + "reports\n";

                 s += ind + "{\n" + 
                 this.Reports.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationRole>? Roles
            // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
            if (this.Roles != null)
            {
                 s += ind + "roles\n";

                 s += ind + "{\n" + 
                 this.Roles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
            // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
            if (this.S3ArchivalLocations != null)
            {
                 s += ind + "s3ArchivalLocations\n";

                 s += ind + "{\n" + 
                 this.S3ArchivalLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
            // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
            if (this.SlaDomains != null)
            {
                 s += ind + "slaDomains\n";

                 s += ind + "{\n" + 
                 this.SlaDomains.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
            // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
            if (this.SmtpSettings != null)
            {
                 s += ind + "smtpSettings\n";

                 s += ind + "{\n" + 
                 this.SmtpSettings.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
            // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
            if (this.SnmpSettings != null)
            {
                 s += ind + "snmpSettings\n";

                 s += ind + "{\n" + 
                 this.SnmpSettings.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationUser>? Users
            // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
            if (this.Users != null)
            {
                 s += ind + "users\n";

                 s += ind + "{\n" + 
                 this.Users.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
            // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
            if (this.VcenterServers != null)
            {
                 s += ind + "vcenterServers\n";

                 s += ind + "{\n" + 
                 this.VcenterServers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
            // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
            if (this.WinAndUnixHosts != null)
            {
                 s += ind + "winAndUnixHosts\n";

                 s += ind + "{\n" + 
                 this.WinAndUnixHosts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
            // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
            if (this.GuestOsCredentials == null && Exploration.Includes(parent + ".guestOsCredentials"))
            {
                this.GuestOsCredentials = new List<RestoreFormConfigurationGuestOs>();
                this.GuestOsCredentials.ApplyExploratoryFragment(parent + ".guestOsCredentials");
            }
            //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
            // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
            if (this.KmipServers == null && Exploration.Includes(parent + ".kmipServers"))
            {
                this.KmipServers = new List<RestoreFormConfigurationKmipServer>();
                this.KmipServers.ApplyExploratoryFragment(parent + ".kmipServers");
            }
            //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
            // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
            if (this.LdapServers == null && Exploration.Includes(parent + ".ldapServers"))
            {
                this.LdapServers = new List<RestoreFormConfigurationLdapServer>();
                this.LdapServers.ApplyExploratoryFragment(parent + ".ldapServers");
            }
            //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
            // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
            if (this.NasHosts == null && Exploration.Includes(parent + ".nasHosts"))
            {
                this.NasHosts = new List<RestoreFormConfigurationNasHost>();
                this.NasHosts.ApplyExploratoryFragment(parent + ".nasHosts");
            }
            //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
            // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
            if (this.ObjectStoreArchivalLocations == null && Exploration.Includes(parent + ".objectStoreArchivalLocations"))
            {
                this.ObjectStoreArchivalLocations = new List<RestoreFormConfigurationObjectStoreArchivalLocation>();
                this.ObjectStoreArchivalLocations.ApplyExploratoryFragment(parent + ".objectStoreArchivalLocations");
            }
            //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
            // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
            if (this.Organizations == null && Exploration.Includes(parent + ".organizations"))
            {
                this.Organizations = new List<RestoreFormConfigurationOrganization>();
                this.Organizations.ApplyExploratoryFragment(parent + ".organizations");
            }
            //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
            // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
            if (this.ReplicationTargets == null && Exploration.Includes(parent + ".replicationTargets"))
            {
                this.ReplicationTargets = new List<RestoreFormConfigurationReplicationTarget>();
                this.ReplicationTargets.ApplyExploratoryFragment(parent + ".replicationTargets");
            }
            //      C# -> List<RestoreFormConfigurationReport>? Reports
            // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
            if (this.Reports == null && Exploration.Includes(parent + ".reports"))
            {
                this.Reports = new List<RestoreFormConfigurationReport>();
                this.Reports.ApplyExploratoryFragment(parent + ".reports");
            }
            //      C# -> List<RestoreFormConfigurationRole>? Roles
            // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
            if (this.Roles == null && Exploration.Includes(parent + ".roles"))
            {
                this.Roles = new List<RestoreFormConfigurationRole>();
                this.Roles.ApplyExploratoryFragment(parent + ".roles");
            }
            //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
            // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
            if (this.S3ArchivalLocations == null && Exploration.Includes(parent + ".s3ArchivalLocations"))
            {
                this.S3ArchivalLocations = new List<RestoreFormConfigurationS3ArchivalLocation>();
                this.S3ArchivalLocations.ApplyExploratoryFragment(parent + ".s3ArchivalLocations");
            }
            //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
            // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
            if (this.SlaDomains == null && Exploration.Includes(parent + ".slaDomains"))
            {
                this.SlaDomains = new List<RestoreFormConfigurationSlaDomain>();
                this.SlaDomains.ApplyExploratoryFragment(parent + ".slaDomains");
            }
            //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
            // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
            if (this.SmtpSettings == null && Exploration.Includes(parent + ".smtpSettings"))
            {
                this.SmtpSettings = new List<RestoreFormConfigurationSmtp>();
                this.SmtpSettings.ApplyExploratoryFragment(parent + ".smtpSettings");
            }
            //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
            // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
            if (this.SnmpSettings == null && Exploration.Includes(parent + ".snmpSettings"))
            {
                this.SnmpSettings = new List<RestoreFormConfigurationSnmp>();
                this.SnmpSettings.ApplyExploratoryFragment(parent + ".snmpSettings");
            }
            //      C# -> List<RestoreFormConfigurationUser>? Users
            // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
            if (this.Users == null && Exploration.Includes(parent + ".users"))
            {
                this.Users = new List<RestoreFormConfigurationUser>();
                this.Users.ApplyExploratoryFragment(parent + ".users");
            }
            //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
            // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
            if (this.VcenterServers == null && Exploration.Includes(parent + ".vcenterServers"))
            {
                this.VcenterServers = new List<RestoreFormConfigurationVcenterServer>();
                this.VcenterServers.ApplyExploratoryFragment(parent + ".vcenterServers");
            }
            //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
            // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
            if (this.WinAndUnixHosts == null && Exploration.Includes(parent + ".winAndUnixHosts"))
            {
                this.WinAndUnixHosts = new List<RestoreFormConfigurationWinAndUnixHost>();
                this.WinAndUnixHosts.ApplyExploratoryFragment(parent + ".winAndUnixHosts");
            }
        }


    #endregion

    } // class RestoreFormConfigurations
    #endregion

    public static class ListRestoreFormConfigurationsExtensions
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
            this List<RestoreFormConfigurations> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RestoreFormConfigurations> list, 
            String parent = "")
        {
            var item = new RestoreFormConfigurations();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types