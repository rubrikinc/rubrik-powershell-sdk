// HostSummary.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region HostSummary
    public class HostSummary: IFragment
    {
        #region members
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        [JsonProperty("alias")]
        public System.String? Alias { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }

        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        [JsonProperty("operatingSystemType")]
        public System.String? OperatingSystemType { get; set; }

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        [JsonProperty("hdfsBaseConfig")]
        public HdfsBaseConfig? HdfsBaseConfig { get; set; }

        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        [JsonProperty("nasBaseConfig")]
        public NasBaseConfig? NasBaseConfig { get; set; }

        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        [JsonProperty("mssqlCbtEffectiveStatus")]
        public MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus { get; set; }

        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        [JsonProperty("mssqlCbtEnabled")]
        public MssqlCbtStatusType? MssqlCbtEnabled { get; set; }

        #endregion

    #region methods

    public HostSummary Set(
        System.String? Alias = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? OperatingSystem = null,
        System.String? OperatingSystemType = null,
        System.String? OrganizationId = null,
        System.String? OrganizationName = null,
        System.String? PrimaryClusterId = null,
        System.String? Status = null,
        HdfsBaseConfig? HdfsBaseConfig = null,
        NasBaseConfig? NasBaseConfig = null,
        MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus = null,
        MssqlCbtStatusType? MssqlCbtEnabled = null
    ) 
    {
        if ( Alias != null ) {
            this.Alias = Alias;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
        }
        if ( OrganizationName != null ) {
            this.OrganizationName = OrganizationName;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HdfsBaseConfig != null ) {
            this.HdfsBaseConfig = HdfsBaseConfig;
        }
        if ( NasBaseConfig != null ) {
            this.NasBaseConfig = NasBaseConfig;
        }
        if ( MssqlCbtEffectiveStatus != null ) {
            this.MssqlCbtEffectiveStatus = MssqlCbtEffectiveStatus;
        }
        if ( MssqlCbtEnabled != null ) {
            this.MssqlCbtEnabled = MssqlCbtEnabled;
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
            //      C# -> System.String? Alias
            // GraphQL -> alias: String (scalar)
            if (this.Alias != null)
            {
                 s += ind + "alias\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OperatingSystem
            // GraphQL -> operatingSystem: String (scalar)
            if (this.OperatingSystem != null)
            {
                 s += ind + "operatingSystem\n";

            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String (scalar)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            //      C# -> System.String? OrganizationId
            // GraphQL -> organizationId: String (scalar)
            if (this.OrganizationId != null)
            {
                 s += ind + "organizationId\n";

            }
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String (scalar)
            if (this.OrganizationName != null)
            {
                 s += ind + "organizationName\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> HdfsBaseConfig? HdfsBaseConfig
            // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
            if (this.HdfsBaseConfig != null)
            {
                 s += ind + "hdfsBaseConfig\n";

                 s += ind + "{\n" + 
                 this.HdfsBaseConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NasBaseConfig? NasBaseConfig
            // GraphQL -> nasBaseConfig: NasBaseConfig (type)
            if (this.NasBaseConfig != null)
            {
                 s += ind + "nasBaseConfig\n";

                 s += ind + "{\n" + 
                 this.NasBaseConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
            // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
            if (this.MssqlCbtEffectiveStatus != null)
            {
                 s += ind + "mssqlCbtEffectiveStatus\n";

            }
            //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
            // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
            if (this.MssqlCbtEnabled != null)
            {
                 s += ind + "mssqlCbtEnabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Alias
            // GraphQL -> alias: String (scalar)
            if (this.Alias == null && Exploration.Includes(parent + ".alias$"))
            {
                this.Alias = new System.String("FETCH");
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OperatingSystem
            // GraphQL -> operatingSystem: String (scalar)
            if (this.OperatingSystem == null && Exploration.Includes(parent + ".operatingSystem$"))
            {
                this.OperatingSystem = new System.String("FETCH");
            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String (scalar)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new System.String("FETCH");
            }
            //      C# -> System.String? OrganizationId
            // GraphQL -> organizationId: String (scalar)
            if (this.OrganizationId == null && Exploration.Includes(parent + ".organizationId$"))
            {
                this.OrganizationId = new System.String("FETCH");
            }
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String (scalar)
            if (this.OrganizationName == null && Exploration.Includes(parent + ".organizationName$"))
            {
                this.OrganizationName = new System.String("FETCH");
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> HdfsBaseConfig? HdfsBaseConfig
            // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
            if (this.HdfsBaseConfig == null && Exploration.Includes(parent + ".hdfsBaseConfig"))
            {
                this.HdfsBaseConfig = new HdfsBaseConfig();
                this.HdfsBaseConfig.ApplyExploratoryFragment(parent + ".hdfsBaseConfig");
            }
            //      C# -> NasBaseConfig? NasBaseConfig
            // GraphQL -> nasBaseConfig: NasBaseConfig (type)
            if (this.NasBaseConfig == null && Exploration.Includes(parent + ".nasBaseConfig"))
            {
                this.NasBaseConfig = new NasBaseConfig();
                this.NasBaseConfig.ApplyExploratoryFragment(parent + ".nasBaseConfig");
            }
            //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
            // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
            if (this.MssqlCbtEffectiveStatus == null && Exploration.Includes(parent + ".mssqlCbtEffectiveStatus$"))
            {
                this.MssqlCbtEffectiveStatus = new MssqlCbtEffectiveStatusType();
            }
            //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
            // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
            if (this.MssqlCbtEnabled == null && Exploration.Includes(parent + ".mssqlCbtEnabled$"))
            {
                this.MssqlCbtEnabled = new MssqlCbtStatusType();
            }
        }


    #endregion

    } // class HostSummary
    #endregion

    public static class ListHostSummaryExtensions
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
            this List<HostSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HostSummary> list, 
            String parent = "")
        {
            var item = new HostSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types