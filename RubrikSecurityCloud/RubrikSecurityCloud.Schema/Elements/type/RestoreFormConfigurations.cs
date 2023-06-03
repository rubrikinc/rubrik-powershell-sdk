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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
        if (this.GuestOsCredentials != null) {
            s += ind + "guestOsCredentials {\n" + this.GuestOsCredentials.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
        if (this.KmipServers != null) {
            s += ind + "kmipServers {\n" + this.KmipServers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
        // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
        if (this.LdapServers != null) {
            s += ind + "ldapServers {\n" + this.LdapServers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
        // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
        if (this.NasHosts != null) {
            s += ind + "nasHosts {\n" + this.NasHosts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
        if (this.ObjectStoreArchivalLocations != null) {
            s += ind + "objectStoreArchivalLocations {\n" + this.ObjectStoreArchivalLocations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
        if (this.Organizations != null) {
            s += ind + "organizations {\n" + this.Organizations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            s += ind + "replicationTargets {\n" + this.ReplicationTargets.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationReport>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
        if (this.Reports != null) {
            s += ind + "reports {\n" + this.Reports.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationRole>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
        if (this.Roles != null) {
            s += ind + "roles {\n" + this.Roles.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
        if (this.S3ArchivalLocations != null) {
            s += ind + "s3ArchivalLocations {\n" + this.S3ArchivalLocations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
        if (this.SlaDomains != null) {
            s += ind + "slaDomains {\n" + this.SlaDomains.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
        // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
        if (this.SmtpSettings != null) {
            s += ind + "smtpSettings {\n" + this.SmtpSettings.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
        // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
        if (this.SnmpSettings != null) {
            s += ind + "snmpSettings {\n" + this.SnmpSettings.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationUser>? Users
        // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
        if (this.Users != null) {
            s += ind + "users {\n" + this.Users.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
        // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
        if (this.VcenterServers != null) {
            s += ind + "vcenterServers {\n" + this.VcenterServers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
        if (this.WinAndUnixHosts != null) {
            s += ind + "winAndUnixHosts {\n" + this.WinAndUnixHosts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<RestoreFormConfigurationGuestOs>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [RestoreFormConfigurationGuestOs!]! (type)
        if (this.GuestOsCredentials == null && Exploration.Includes(parent + ".guestOsCredentials"))
        {
            this.GuestOsCredentials = new List<RestoreFormConfigurationGuestOs>();
            this.GuestOsCredentials.ApplyExploratoryFieldSpec(parent + ".guestOsCredentials");
        }
        //      C# -> List<RestoreFormConfigurationKmipServer>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServer!]! (type)
        if (this.KmipServers == null && Exploration.Includes(parent + ".kmipServers"))
        {
            this.KmipServers = new List<RestoreFormConfigurationKmipServer>();
            this.KmipServers.ApplyExploratoryFieldSpec(parent + ".kmipServers");
        }
        //      C# -> List<RestoreFormConfigurationLdapServer>? LdapServers
        // GraphQL -> ldapServers: [RestoreFormConfigurationLdapServer!]! (type)
        if (this.LdapServers == null && Exploration.Includes(parent + ".ldapServers"))
        {
            this.LdapServers = new List<RestoreFormConfigurationLdapServer>();
            this.LdapServers.ApplyExploratoryFieldSpec(parent + ".ldapServers");
        }
        //      C# -> List<RestoreFormConfigurationNasHost>? NasHosts
        // GraphQL -> nasHosts: [RestoreFormConfigurationNasHost!]! (type)
        if (this.NasHosts == null && Exploration.Includes(parent + ".nasHosts"))
        {
            this.NasHosts = new List<RestoreFormConfigurationNasHost>();
            this.NasHosts.ApplyExploratoryFieldSpec(parent + ".nasHosts");
        }
        //      C# -> List<RestoreFormConfigurationObjectStoreArchivalLocation>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [RestoreFormConfigurationObjectStoreArchivalLocation!]! (type)
        if (this.ObjectStoreArchivalLocations == null && Exploration.Includes(parent + ".objectStoreArchivalLocations"))
        {
            this.ObjectStoreArchivalLocations = new List<RestoreFormConfigurationObjectStoreArchivalLocation>();
            this.ObjectStoreArchivalLocations.ApplyExploratoryFieldSpec(parent + ".objectStoreArchivalLocations");
        }
        //      C# -> List<RestoreFormConfigurationOrganization>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganization!]! (type)
        if (this.Organizations == null && Exploration.Includes(parent + ".organizations"))
        {
            this.Organizations = new List<RestoreFormConfigurationOrganization>();
            this.Organizations.ApplyExploratoryFieldSpec(parent + ".organizations");
        }
        //      C# -> List<RestoreFormConfigurationReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [RestoreFormConfigurationReplicationTarget!]! (type)
        if (this.ReplicationTargets == null && Exploration.Includes(parent + ".replicationTargets"))
        {
            this.ReplicationTargets = new List<RestoreFormConfigurationReplicationTarget>();
            this.ReplicationTargets.ApplyExploratoryFieldSpec(parent + ".replicationTargets");
        }
        //      C# -> List<RestoreFormConfigurationReport>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReport!]! (type)
        if (this.Reports == null && Exploration.Includes(parent + ".reports"))
        {
            this.Reports = new List<RestoreFormConfigurationReport>();
            this.Reports.ApplyExploratoryFieldSpec(parent + ".reports");
        }
        //      C# -> List<RestoreFormConfigurationRole>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRole!]! (type)
        if (this.Roles == null && Exploration.Includes(parent + ".roles"))
        {
            this.Roles = new List<RestoreFormConfigurationRole>();
            this.Roles.ApplyExploratoryFieldSpec(parent + ".roles");
        }
        //      C# -> List<RestoreFormConfigurationS3ArchivalLocation>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [RestoreFormConfigurationS3ArchivalLocation!]! (type)
        if (this.S3ArchivalLocations == null && Exploration.Includes(parent + ".s3ArchivalLocations"))
        {
            this.S3ArchivalLocations = new List<RestoreFormConfigurationS3ArchivalLocation>();
            this.S3ArchivalLocations.ApplyExploratoryFieldSpec(parent + ".s3ArchivalLocations");
        }
        //      C# -> List<RestoreFormConfigurationSlaDomain>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomain!]! (type)
        if (this.SlaDomains == null && Exploration.Includes(parent + ".slaDomains"))
        {
            this.SlaDomains = new List<RestoreFormConfigurationSlaDomain>();
            this.SlaDomains.ApplyExploratoryFieldSpec(parent + ".slaDomains");
        }
        //      C# -> List<RestoreFormConfigurationSmtp>? SmtpSettings
        // GraphQL -> smtpSettings: [RestoreFormConfigurationSmtp!]! (type)
        if (this.SmtpSettings == null && Exploration.Includes(parent + ".smtpSettings"))
        {
            this.SmtpSettings = new List<RestoreFormConfigurationSmtp>();
            this.SmtpSettings.ApplyExploratoryFieldSpec(parent + ".smtpSettings");
        }
        //      C# -> List<RestoreFormConfigurationSnmp>? SnmpSettings
        // GraphQL -> snmpSettings: [RestoreFormConfigurationSnmp!]! (type)
        if (this.SnmpSettings == null && Exploration.Includes(parent + ".snmpSettings"))
        {
            this.SnmpSettings = new List<RestoreFormConfigurationSnmp>();
            this.SnmpSettings.ApplyExploratoryFieldSpec(parent + ".snmpSettings");
        }
        //      C# -> List<RestoreFormConfigurationUser>? Users
        // GraphQL -> users: [RestoreFormConfigurationUser!]! (type)
        if (this.Users == null && Exploration.Includes(parent + ".users"))
        {
            this.Users = new List<RestoreFormConfigurationUser>();
            this.Users.ApplyExploratoryFieldSpec(parent + ".users");
        }
        //      C# -> List<RestoreFormConfigurationVcenterServer>? VcenterServers
        // GraphQL -> vcenterServers: [RestoreFormConfigurationVcenterServer!]! (type)
        if (this.VcenterServers == null && Exploration.Includes(parent + ".vcenterServers"))
        {
            this.VcenterServers = new List<RestoreFormConfigurationVcenterServer>();
            this.VcenterServers.ApplyExploratoryFieldSpec(parent + ".vcenterServers");
        }
        //      C# -> List<RestoreFormConfigurationWinAndUnixHost>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHost!]! (type)
        if (this.WinAndUnixHosts == null && Exploration.Includes(parent + ".winAndUnixHosts"))
        {
            this.WinAndUnixHosts = new List<RestoreFormConfigurationWinAndUnixHost>();
            this.WinAndUnixHosts.ApplyExploratoryFieldSpec(parent + ".winAndUnixHosts");
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurations> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurations());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types