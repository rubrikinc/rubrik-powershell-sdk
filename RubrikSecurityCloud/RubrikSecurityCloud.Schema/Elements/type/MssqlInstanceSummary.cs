// MssqlInstanceSummary.cs
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
    #region MssqlInstanceSummary
    public class MssqlInstanceSummary: IFragment
    {
        #region members
        //      C# -> System.String? ClusterInstanceAddress
        // GraphQL -> clusterInstanceAddress: String (scalar)
        [JsonProperty("clusterInstanceAddress")]
        public System.String? ClusterInstanceAddress { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String (scalar)
        [JsonProperty("configuredSlaDomainName")]
        public System.String? ConfiguredSlaDomainName { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: String (scalar)
        [JsonProperty("configuredSlaDomainType")]
        public System.String? ConfiguredSlaDomainType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long (scalar)
        [JsonProperty("internalTimestamp")]
        public System.Int64? InternalTimestamp { get; set; }

        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        [JsonProperty("isRetentionLocked")]
        public System.Boolean? IsRetentionLocked { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        [JsonProperty("protectionDateV50")]
        public System.String? ProtectionDateV50 { get; set; }

        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        [JsonProperty("protectionDateV51")]
        public System.String? ProtectionDateV51 { get; set; }

        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        [JsonProperty("protectionDateV52")]
        public System.String? ProtectionDateV52 { get; set; }

        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        [JsonProperty("protectionDateV53")]
        public System.String? ProtectionDateV53 { get; set; }

        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        [JsonProperty("protectionDateV60")]
        public DateTime? ProtectionDateV60 { get; set; }

        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        [JsonProperty("protectionDateV70")]
        public DateTime? ProtectionDateV70 { get; set; }

        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        [JsonProperty("protectionDateV80")]
        public DateTime? ProtectionDateV80 { get; set; }

        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        [JsonProperty("protectionDateV81")]
        public DateTime? ProtectionDateV81 { get; set; }

        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        [JsonProperty("protectionDateV90")]
        public DateTime? ProtectionDateV90 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV51")]
        public List<System.String>? UnprotectableReasonsV51 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV52")]
        public List<System.String>? UnprotectableReasonsV52 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV53")]
        public List<System.String>? UnprotectableReasonsV53 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV60")]
        public List<System.String>? UnprotectableReasonsV60 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV70")]
        public List<System.String>? UnprotectableReasonsV70 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV80")]
        public List<System.String>? UnprotectableReasonsV80 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV81")]
        public List<System.String>? UnprotectableReasonsV81 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV90")]
        public List<System.String>? UnprotectableReasonsV90 { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        [JsonProperty("mssqlNonSlaProperties")]
        public MssqlNonSlaProperties? MssqlNonSlaProperties { get; set; }

        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        [JsonProperty("mssqlSlaRelatedProperties")]
        public MssqlSlaRelatedProperties? MssqlSlaRelatedProperties { get; set; }

        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        [JsonProperty("rootProperties")]
        public MssqlRootProperties? RootProperties { get; set; }

        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        [JsonProperty("unprotectableReasonsV50")]
        public List<MssqlUnprotectableReason>? UnprotectableReasonsV50 { get; set; }

        #endregion

    #region methods

    public MssqlInstanceSummary Set(
        System.String? ClusterInstanceAddress = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaDomainName = null,
        System.String? ConfiguredSlaDomainType = null,
        System.String? Id = null,
        System.Int64? InternalTimestamp = null,
        System.Boolean? IsRetentionLocked = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        System.String? ProtectionDateV50 = null,
        System.String? ProtectionDateV51 = null,
        System.String? ProtectionDateV52 = null,
        System.String? ProtectionDateV53 = null,
        DateTime? ProtectionDateV60 = null,
        DateTime? ProtectionDateV70 = null,
        DateTime? ProtectionDateV80 = null,
        DateTime? ProtectionDateV81 = null,
        DateTime? ProtectionDateV90 = null,
        List<System.String>? UnprotectableReasonsV51 = null,
        List<System.String>? UnprotectableReasonsV52 = null,
        List<System.String>? UnprotectableReasonsV53 = null,
        List<System.String>? UnprotectableReasonsV60 = null,
        List<System.String>? UnprotectableReasonsV70 = null,
        List<System.String>? UnprotectableReasonsV80 = null,
        List<System.String>? UnprotectableReasonsV81 = null,
        List<System.String>? UnprotectableReasonsV90 = null,
        System.String? Version = null,
        MssqlNonSlaProperties? MssqlNonSlaProperties = null,
        MssqlSlaRelatedProperties? MssqlSlaRelatedProperties = null,
        MssqlRootProperties? RootProperties = null,
        List<MssqlUnprotectableReason>? UnprotectableReasonsV50 = null
    ) 
    {
        if ( ClusterInstanceAddress != null ) {
            this.ClusterInstanceAddress = ClusterInstanceAddress;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaDomainName != null ) {
            this.ConfiguredSlaDomainName = ConfiguredSlaDomainName;
        }
        if ( ConfiguredSlaDomainType != null ) {
            this.ConfiguredSlaDomainType = ConfiguredSlaDomainType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InternalTimestamp != null ) {
            this.InternalTimestamp = InternalTimestamp;
        }
        if ( IsRetentionLocked != null ) {
            this.IsRetentionLocked = IsRetentionLocked;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( ProtectionDateV50 != null ) {
            this.ProtectionDateV50 = ProtectionDateV50;
        }
        if ( ProtectionDateV51 != null ) {
            this.ProtectionDateV51 = ProtectionDateV51;
        }
        if ( ProtectionDateV52 != null ) {
            this.ProtectionDateV52 = ProtectionDateV52;
        }
        if ( ProtectionDateV53 != null ) {
            this.ProtectionDateV53 = ProtectionDateV53;
        }
        if ( ProtectionDateV60 != null ) {
            this.ProtectionDateV60 = ProtectionDateV60;
        }
        if ( ProtectionDateV70 != null ) {
            this.ProtectionDateV70 = ProtectionDateV70;
        }
        if ( ProtectionDateV80 != null ) {
            this.ProtectionDateV80 = ProtectionDateV80;
        }
        if ( ProtectionDateV81 != null ) {
            this.ProtectionDateV81 = ProtectionDateV81;
        }
        if ( ProtectionDateV90 != null ) {
            this.ProtectionDateV90 = ProtectionDateV90;
        }
        if ( UnprotectableReasonsV51 != null ) {
            this.UnprotectableReasonsV51 = UnprotectableReasonsV51;
        }
        if ( UnprotectableReasonsV52 != null ) {
            this.UnprotectableReasonsV52 = UnprotectableReasonsV52;
        }
        if ( UnprotectableReasonsV53 != null ) {
            this.UnprotectableReasonsV53 = UnprotectableReasonsV53;
        }
        if ( UnprotectableReasonsV60 != null ) {
            this.UnprotectableReasonsV60 = UnprotectableReasonsV60;
        }
        if ( UnprotectableReasonsV70 != null ) {
            this.UnprotectableReasonsV70 = UnprotectableReasonsV70;
        }
        if ( UnprotectableReasonsV80 != null ) {
            this.UnprotectableReasonsV80 = UnprotectableReasonsV80;
        }
        if ( UnprotectableReasonsV81 != null ) {
            this.UnprotectableReasonsV81 = UnprotectableReasonsV81;
        }
        if ( UnprotectableReasonsV90 != null ) {
            this.UnprotectableReasonsV90 = UnprotectableReasonsV90;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( MssqlNonSlaProperties != null ) {
            this.MssqlNonSlaProperties = MssqlNonSlaProperties;
        }
        if ( MssqlSlaRelatedProperties != null ) {
            this.MssqlSlaRelatedProperties = MssqlSlaRelatedProperties;
        }
        if ( RootProperties != null ) {
            this.RootProperties = RootProperties;
        }
        if ( UnprotectableReasonsV50 != null ) {
            this.UnprotectableReasonsV50 = UnprotectableReasonsV50;
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
            //      C# -> System.String? ClusterInstanceAddress
            // GraphQL -> clusterInstanceAddress: String (scalar)
            if (this.ClusterInstanceAddress != null)
            {
                 s += ind + "clusterInstanceAddress\n";

            }
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> System.String? ConfiguredSlaDomainName
            // GraphQL -> configuredSlaDomainName: String (scalar)
            if (this.ConfiguredSlaDomainName != null)
            {
                 s += ind + "configuredSlaDomainName\n";

            }
            //      C# -> System.String? ConfiguredSlaDomainType
            // GraphQL -> configuredSlaDomainType: String (scalar)
            if (this.ConfiguredSlaDomainType != null)
            {
                 s += ind + "configuredSlaDomainType\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? InternalTimestamp
            // GraphQL -> internalTimestamp: Long (scalar)
            if (this.InternalTimestamp != null)
            {
                 s += ind + "internalTimestamp\n";

            }
            //      C# -> System.Boolean? IsRetentionLocked
            // GraphQL -> isRetentionLocked: Boolean (scalar)
            if (this.IsRetentionLocked != null)
            {
                 s += ind + "isRetentionLocked\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.String? ProtectionDateV50
            // GraphQL -> protectionDateV50: String (scalar)
            if (this.ProtectionDateV50 != null)
            {
                 s += ind + "protectionDateV50\n";

            }
            //      C# -> System.String? ProtectionDateV51
            // GraphQL -> protectionDateV51: String (scalar)
            if (this.ProtectionDateV51 != null)
            {
                 s += ind + "protectionDateV51\n";

            }
            //      C# -> System.String? ProtectionDateV52
            // GraphQL -> protectionDateV52: String (scalar)
            if (this.ProtectionDateV52 != null)
            {
                 s += ind + "protectionDateV52\n";

            }
            //      C# -> System.String? ProtectionDateV53
            // GraphQL -> protectionDateV53: String (scalar)
            if (this.ProtectionDateV53 != null)
            {
                 s += ind + "protectionDateV53\n";

            }
            //      C# -> DateTime? ProtectionDateV60
            // GraphQL -> protectionDateV60: DateTime (scalar)
            if (this.ProtectionDateV60 != null)
            {
                 s += ind + "protectionDateV60\n";

            }
            //      C# -> DateTime? ProtectionDateV70
            // GraphQL -> protectionDateV70: DateTime (scalar)
            if (this.ProtectionDateV70 != null)
            {
                 s += ind + "protectionDateV70\n";

            }
            //      C# -> DateTime? ProtectionDateV80
            // GraphQL -> protectionDateV80: DateTime (scalar)
            if (this.ProtectionDateV80 != null)
            {
                 s += ind + "protectionDateV80\n";

            }
            //      C# -> DateTime? ProtectionDateV81
            // GraphQL -> protectionDateV81: DateTime (scalar)
            if (this.ProtectionDateV81 != null)
            {
                 s += ind + "protectionDateV81\n";

            }
            //      C# -> DateTime? ProtectionDateV90
            // GraphQL -> protectionDateV90: DateTime (scalar)
            if (this.ProtectionDateV90 != null)
            {
                 s += ind + "protectionDateV90\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV51
            // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
            if (this.UnprotectableReasonsV51 != null)
            {
                 s += ind + "unprotectableReasonsV51\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV52
            // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
            if (this.UnprotectableReasonsV52 != null)
            {
                 s += ind + "unprotectableReasonsV52\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV53
            // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
            if (this.UnprotectableReasonsV53 != null)
            {
                 s += ind + "unprotectableReasonsV53\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV60
            // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
            if (this.UnprotectableReasonsV60 != null)
            {
                 s += ind + "unprotectableReasonsV60\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV70
            // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
            if (this.UnprotectableReasonsV70 != null)
            {
                 s += ind + "unprotectableReasonsV70\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV80
            // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
            if (this.UnprotectableReasonsV80 != null)
            {
                 s += ind + "unprotectableReasonsV80\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV81
            // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
            if (this.UnprotectableReasonsV81 != null)
            {
                 s += ind + "unprotectableReasonsV81\n";

            }
            //      C# -> List<System.String>? UnprotectableReasonsV90
            // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
            if (this.UnprotectableReasonsV90 != null)
            {
                 s += ind + "unprotectableReasonsV90\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
            // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
            if (this.MssqlNonSlaProperties != null)
            {
                 s += ind + "mssqlNonSlaProperties\n";

                 s += ind + "{\n" + 
                 this.MssqlNonSlaProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
            // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
            if (this.MssqlSlaRelatedProperties != null)
            {
                 s += ind + "mssqlSlaRelatedProperties\n";

                 s += ind + "{\n" + 
                 this.MssqlSlaRelatedProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlRootProperties? RootProperties
            // GraphQL -> rootProperties: MssqlRootProperties (type)
            if (this.RootProperties != null)
            {
                 s += ind + "rootProperties\n";

                 s += ind + "{\n" + 
                 this.RootProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
            // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
            if (this.UnprotectableReasonsV50 != null)
            {
                 s += ind + "unprotectableReasonsV50\n";

                 s += ind + "{\n" + 
                 this.UnprotectableReasonsV50.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterInstanceAddress
            // GraphQL -> clusterInstanceAddress: String (scalar)
            if (this.ClusterInstanceAddress == null && Exploration.Includes(parent + ".clusterInstanceAddress$"))
            {
                this.ClusterInstanceAddress = new System.String("FETCH");
            }
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? ConfiguredSlaDomainName
            // GraphQL -> configuredSlaDomainName: String (scalar)
            if (this.ConfiguredSlaDomainName == null && Exploration.Includes(parent + ".configuredSlaDomainName$"))
            {
                this.ConfiguredSlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? ConfiguredSlaDomainType
            // GraphQL -> configuredSlaDomainType: String (scalar)
            if (this.ConfiguredSlaDomainType == null && Exploration.Includes(parent + ".configuredSlaDomainType$"))
            {
                this.ConfiguredSlaDomainType = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? InternalTimestamp
            // GraphQL -> internalTimestamp: Long (scalar)
            if (this.InternalTimestamp == null && Exploration.Includes(parent + ".internalTimestamp$"))
            {
                this.InternalTimestamp = new System.Int64();
            }
            //      C# -> System.Boolean? IsRetentionLocked
            // GraphQL -> isRetentionLocked: Boolean (scalar)
            if (this.IsRetentionLocked == null && Exploration.Includes(parent + ".isRetentionLocked$"))
            {
                this.IsRetentionLocked = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? ProtectionDateV50
            // GraphQL -> protectionDateV50: String (scalar)
            if (this.ProtectionDateV50 == null && Exploration.Includes(parent + ".protectionDateV50$"))
            {
                this.ProtectionDateV50 = new System.String("FETCH");
            }
            //      C# -> System.String? ProtectionDateV51
            // GraphQL -> protectionDateV51: String (scalar)
            if (this.ProtectionDateV51 == null && Exploration.Includes(parent + ".protectionDateV51$"))
            {
                this.ProtectionDateV51 = new System.String("FETCH");
            }
            //      C# -> System.String? ProtectionDateV52
            // GraphQL -> protectionDateV52: String (scalar)
            if (this.ProtectionDateV52 == null && Exploration.Includes(parent + ".protectionDateV52$"))
            {
                this.ProtectionDateV52 = new System.String("FETCH");
            }
            //      C# -> System.String? ProtectionDateV53
            // GraphQL -> protectionDateV53: String (scalar)
            if (this.ProtectionDateV53 == null && Exploration.Includes(parent + ".protectionDateV53$"))
            {
                this.ProtectionDateV53 = new System.String("FETCH");
            }
            //      C# -> DateTime? ProtectionDateV60
            // GraphQL -> protectionDateV60: DateTime (scalar)
            if (this.ProtectionDateV60 == null && Exploration.Includes(parent + ".protectionDateV60$"))
            {
                this.ProtectionDateV60 = new DateTime();
            }
            //      C# -> DateTime? ProtectionDateV70
            // GraphQL -> protectionDateV70: DateTime (scalar)
            if (this.ProtectionDateV70 == null && Exploration.Includes(parent + ".protectionDateV70$"))
            {
                this.ProtectionDateV70 = new DateTime();
            }
            //      C# -> DateTime? ProtectionDateV80
            // GraphQL -> protectionDateV80: DateTime (scalar)
            if (this.ProtectionDateV80 == null && Exploration.Includes(parent + ".protectionDateV80$"))
            {
                this.ProtectionDateV80 = new DateTime();
            }
            //      C# -> DateTime? ProtectionDateV81
            // GraphQL -> protectionDateV81: DateTime (scalar)
            if (this.ProtectionDateV81 == null && Exploration.Includes(parent + ".protectionDateV81$"))
            {
                this.ProtectionDateV81 = new DateTime();
            }
            //      C# -> DateTime? ProtectionDateV90
            // GraphQL -> protectionDateV90: DateTime (scalar)
            if (this.ProtectionDateV90 == null && Exploration.Includes(parent + ".protectionDateV90$"))
            {
                this.ProtectionDateV90 = new DateTime();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV51
            // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
            if (this.UnprotectableReasonsV51 == null && Exploration.Includes(parent + ".unprotectableReasonsV51$"))
            {
                this.UnprotectableReasonsV51 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV52
            // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
            if (this.UnprotectableReasonsV52 == null && Exploration.Includes(parent + ".unprotectableReasonsV52$"))
            {
                this.UnprotectableReasonsV52 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV53
            // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
            if (this.UnprotectableReasonsV53 == null && Exploration.Includes(parent + ".unprotectableReasonsV53$"))
            {
                this.UnprotectableReasonsV53 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV60
            // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
            if (this.UnprotectableReasonsV60 == null && Exploration.Includes(parent + ".unprotectableReasonsV60$"))
            {
                this.UnprotectableReasonsV60 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV70
            // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
            if (this.UnprotectableReasonsV70 == null && Exploration.Includes(parent + ".unprotectableReasonsV70$"))
            {
                this.UnprotectableReasonsV70 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV80
            // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
            if (this.UnprotectableReasonsV80 == null && Exploration.Includes(parent + ".unprotectableReasonsV80$"))
            {
                this.UnprotectableReasonsV80 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV81
            // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
            if (this.UnprotectableReasonsV81 == null && Exploration.Includes(parent + ".unprotectableReasonsV81$"))
            {
                this.UnprotectableReasonsV81 = new List<System.String>();
            }
            //      C# -> List<System.String>? UnprotectableReasonsV90
            // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
            if (this.UnprotectableReasonsV90 == null && Exploration.Includes(parent + ".unprotectableReasonsV90$"))
            {
                this.UnprotectableReasonsV90 = new List<System.String>();
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
            // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
            if (this.MssqlNonSlaProperties == null && Exploration.Includes(parent + ".mssqlNonSlaProperties"))
            {
                this.MssqlNonSlaProperties = new MssqlNonSlaProperties();
                this.MssqlNonSlaProperties.ApplyExploratoryFragment(parent + ".mssqlNonSlaProperties");
            }
            //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
            // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
            if (this.MssqlSlaRelatedProperties == null && Exploration.Includes(parent + ".mssqlSlaRelatedProperties"))
            {
                this.MssqlSlaRelatedProperties = new MssqlSlaRelatedProperties();
                this.MssqlSlaRelatedProperties.ApplyExploratoryFragment(parent + ".mssqlSlaRelatedProperties");
            }
            //      C# -> MssqlRootProperties? RootProperties
            // GraphQL -> rootProperties: MssqlRootProperties (type)
            if (this.RootProperties == null && Exploration.Includes(parent + ".rootProperties"))
            {
                this.RootProperties = new MssqlRootProperties();
                this.RootProperties.ApplyExploratoryFragment(parent + ".rootProperties");
            }
            //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
            // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
            if (this.UnprotectableReasonsV50 == null && Exploration.Includes(parent + ".unprotectableReasonsV50"))
            {
                this.UnprotectableReasonsV50 = new List<MssqlUnprotectableReason>();
                this.UnprotectableReasonsV50.ApplyExploratoryFragment(parent + ".unprotectableReasonsV50");
            }
        }


    #endregion

    } // class MssqlInstanceSummary
    #endregion

    public static class ListMssqlInstanceSummaryExtensions
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
            this List<MssqlInstanceSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlInstanceSummary> list, 
            String parent = "")
        {
            var item = new MssqlInstanceSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types