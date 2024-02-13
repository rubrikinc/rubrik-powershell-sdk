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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region MssqlInstanceSummary
    public class MssqlInstanceSummary: BaseType
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

        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        [JsonProperty("protectionDateV91")]
        public DateTime? ProtectionDateV91 { get; set; }

        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        [JsonProperty("protectionDateV92")]
        public DateTime? ProtectionDateV92 { get; set; }

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

        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV91")]
        public List<System.String>? UnprotectableReasonsV91 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV92")]
        public List<System.String>? UnprotectableReasonsV92 { get; set; }

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

    public override string GetGqlTypeName() {
        return "MssqlInstanceSummary";
    }

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
        DateTime? ProtectionDateV91 = null,
        DateTime? ProtectionDateV92 = null,
        List<System.String>? UnprotectableReasonsV51 = null,
        List<System.String>? UnprotectableReasonsV52 = null,
        List<System.String>? UnprotectableReasonsV53 = null,
        List<System.String>? UnprotectableReasonsV60 = null,
        List<System.String>? UnprotectableReasonsV70 = null,
        List<System.String>? UnprotectableReasonsV80 = null,
        List<System.String>? UnprotectableReasonsV81 = null,
        List<System.String>? UnprotectableReasonsV90 = null,
        List<System.String>? UnprotectableReasonsV91 = null,
        List<System.String>? UnprotectableReasonsV92 = null,
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
        if ( ProtectionDateV91 != null ) {
            this.ProtectionDateV91 = ProtectionDateV91;
        }
        if ( ProtectionDateV92 != null ) {
            this.ProtectionDateV92 = ProtectionDateV92;
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
        if ( UnprotectableReasonsV91 != null ) {
            this.UnprotectableReasonsV91 = UnprotectableReasonsV91;
        }
        if ( UnprotectableReasonsV92 != null ) {
            this.UnprotectableReasonsV92 = UnprotectableReasonsV92;
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ClusterInstanceAddress
        // GraphQL -> clusterInstanceAddress: String (scalar)
        if (this.ClusterInstanceAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterInstanceAddress\n" ;
            } else {
                s += ind + "clusterInstanceAddress\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String (scalar)
        if (this.ConfiguredSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainName\n" ;
            } else {
                s += ind + "configuredSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: String (scalar)
        if (this.ConfiguredSlaDomainType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainType\n" ;
            } else {
                s += ind + "configuredSlaDomainType\n" ;
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
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long (scalar)
        if (this.InternalTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "internalTimestamp\n" ;
            } else {
                s += ind + "internalTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (this.IsRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetentionLocked\n" ;
            } else {
                s += ind + "isRetentionLocked\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (this.ProtectionDateV50 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV50\n" ;
            } else {
                s += ind + "protectionDateV50\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (this.ProtectionDateV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV51\n" ;
            } else {
                s += ind + "protectionDateV51\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (this.ProtectionDateV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV52\n" ;
            } else {
                s += ind + "protectionDateV52\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (this.ProtectionDateV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV53\n" ;
            } else {
                s += ind + "protectionDateV53\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (this.ProtectionDateV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV60\n" ;
            } else {
                s += ind + "protectionDateV60\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (this.ProtectionDateV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV70\n" ;
            } else {
                s += ind + "protectionDateV70\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (this.ProtectionDateV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV80\n" ;
            } else {
                s += ind + "protectionDateV80\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (this.ProtectionDateV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV81\n" ;
            } else {
                s += ind + "protectionDateV81\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (this.ProtectionDateV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV90\n" ;
            } else {
                s += ind + "protectionDateV90\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        if (this.ProtectionDateV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV91\n" ;
            } else {
                s += ind + "protectionDateV91\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        if (this.ProtectionDateV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV92\n" ;
            } else {
                s += ind + "protectionDateV92\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (this.UnprotectableReasonsV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV51\n" ;
            } else {
                s += ind + "unprotectableReasonsV51\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (this.UnprotectableReasonsV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV52\n" ;
            } else {
                s += ind + "unprotectableReasonsV52\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (this.UnprotectableReasonsV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV53\n" ;
            } else {
                s += ind + "unprotectableReasonsV53\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (this.UnprotectableReasonsV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV60\n" ;
            } else {
                s += ind + "unprotectableReasonsV60\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (this.UnprotectableReasonsV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV70\n" ;
            } else {
                s += ind + "unprotectableReasonsV70\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (this.UnprotectableReasonsV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV80\n" ;
            } else {
                s += ind + "unprotectableReasonsV80\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (this.UnprotectableReasonsV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV81\n" ;
            } else {
                s += ind + "unprotectableReasonsV81\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (this.UnprotectableReasonsV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV90\n" ;
            } else {
                s += ind + "unprotectableReasonsV90\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        if (this.UnprotectableReasonsV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV91\n" ;
            } else {
                s += ind + "unprotectableReasonsV91\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        if (this.UnprotectableReasonsV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV92\n" ;
            } else {
                s += ind + "unprotectableReasonsV92\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        if (this.MssqlNonSlaProperties != null) {
            var fspec = this.MssqlNonSlaProperties.AsFieldSpec(conf.Child("mssqlNonSlaProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlNonSlaProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        if (this.MssqlSlaRelatedProperties != null) {
            var fspec = this.MssqlSlaRelatedProperties.AsFieldSpec(conf.Child("mssqlSlaRelatedProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlSlaRelatedProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties != null) {
            var fspec = this.RootProperties.AsFieldSpec(conf.Child("rootProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rootProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (this.UnprotectableReasonsV50 != null) {
            var fspec = this.UnprotectableReasonsV50.AsFieldSpec(conf.Child("unprotectableReasonsV50"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unprotectableReasonsV50 {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterInstanceAddress
        // GraphQL -> clusterInstanceAddress: String (scalar)
        if (ec.Includes("clusterInstanceAddress",true))
        {
            if(this.ClusterInstanceAddress == null) {

                this.ClusterInstanceAddress = "FETCH";

            } else {


            }
        }
        else if (this.ClusterInstanceAddress != null && ec.Excludes("clusterInstanceAddress",true))
        {
            this.ClusterInstanceAddress = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String (scalar)
        if (ec.Includes("configuredSlaDomainName",true))
        {
            if(this.ConfiguredSlaDomainName == null) {

                this.ConfiguredSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainName != null && ec.Excludes("configuredSlaDomainName",true))
        {
            this.ConfiguredSlaDomainName = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: String (scalar)
        if (ec.Includes("configuredSlaDomainType",true))
        {
            if(this.ConfiguredSlaDomainType == null) {

                this.ConfiguredSlaDomainType = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainType != null && ec.Excludes("configuredSlaDomainType",true))
        {
            this.ConfiguredSlaDomainType = null;
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
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long (scalar)
        if (ec.Includes("internalTimestamp",true))
        {
            if(this.InternalTimestamp == null) {

                this.InternalTimestamp = new System.Int64();

            } else {


            }
        }
        else if (this.InternalTimestamp != null && ec.Excludes("internalTimestamp",true))
        {
            this.InternalTimestamp = null;
        }
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (ec.Includes("isRetentionLocked",true))
        {
            if(this.IsRetentionLocked == null) {

                this.IsRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsRetentionLocked != null && ec.Excludes("isRetentionLocked",true))
        {
            this.IsRetentionLocked = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (ec.Includes("protectionDateV50",true))
        {
            if(this.ProtectionDateV50 == null) {

                this.ProtectionDateV50 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV50 != null && ec.Excludes("protectionDateV50",true))
        {
            this.ProtectionDateV50 = null;
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (ec.Includes("protectionDateV51",true))
        {
            if(this.ProtectionDateV51 == null) {

                this.ProtectionDateV51 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV51 != null && ec.Excludes("protectionDateV51",true))
        {
            this.ProtectionDateV51 = null;
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (ec.Includes("protectionDateV52",true))
        {
            if(this.ProtectionDateV52 == null) {

                this.ProtectionDateV52 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV52 != null && ec.Excludes("protectionDateV52",true))
        {
            this.ProtectionDateV52 = null;
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (ec.Includes("protectionDateV53",true))
        {
            if(this.ProtectionDateV53 == null) {

                this.ProtectionDateV53 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV53 != null && ec.Excludes("protectionDateV53",true))
        {
            this.ProtectionDateV53 = null;
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (ec.Includes("protectionDateV60",true))
        {
            if(this.ProtectionDateV60 == null) {

                this.ProtectionDateV60 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV60 != null && ec.Excludes("protectionDateV60",true))
        {
            this.ProtectionDateV60 = null;
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (ec.Includes("protectionDateV70",true))
        {
            if(this.ProtectionDateV70 == null) {

                this.ProtectionDateV70 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV70 != null && ec.Excludes("protectionDateV70",true))
        {
            this.ProtectionDateV70 = null;
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (ec.Includes("protectionDateV80",true))
        {
            if(this.ProtectionDateV80 == null) {

                this.ProtectionDateV80 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV80 != null && ec.Excludes("protectionDateV80",true))
        {
            this.ProtectionDateV80 = null;
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (ec.Includes("protectionDateV81",true))
        {
            if(this.ProtectionDateV81 == null) {

                this.ProtectionDateV81 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV81 != null && ec.Excludes("protectionDateV81",true))
        {
            this.ProtectionDateV81 = null;
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (ec.Includes("protectionDateV90",true))
        {
            if(this.ProtectionDateV90 == null) {

                this.ProtectionDateV90 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV90 != null && ec.Excludes("protectionDateV90",true))
        {
            this.ProtectionDateV90 = null;
        }
        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        if (ec.Includes("protectionDateV91",true))
        {
            if(this.ProtectionDateV91 == null) {

                this.ProtectionDateV91 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV91 != null && ec.Excludes("protectionDateV91",true))
        {
            this.ProtectionDateV91 = null;
        }
        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        if (ec.Includes("protectionDateV92",true))
        {
            if(this.ProtectionDateV92 == null) {

                this.ProtectionDateV92 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV92 != null && ec.Excludes("protectionDateV92",true))
        {
            this.ProtectionDateV92 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV51",true))
        {
            if(this.UnprotectableReasonsV51 == null) {

                this.UnprotectableReasonsV51 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV51 != null && ec.Excludes("unprotectableReasonsV51",true))
        {
            this.UnprotectableReasonsV51 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV52",true))
        {
            if(this.UnprotectableReasonsV52 == null) {

                this.UnprotectableReasonsV52 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV52 != null && ec.Excludes("unprotectableReasonsV52",true))
        {
            this.UnprotectableReasonsV52 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV53",true))
        {
            if(this.UnprotectableReasonsV53 == null) {

                this.UnprotectableReasonsV53 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV53 != null && ec.Excludes("unprotectableReasonsV53",true))
        {
            this.UnprotectableReasonsV53 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV60",true))
        {
            if(this.UnprotectableReasonsV60 == null) {

                this.UnprotectableReasonsV60 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV60 != null && ec.Excludes("unprotectableReasonsV60",true))
        {
            this.UnprotectableReasonsV60 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV70",true))
        {
            if(this.UnprotectableReasonsV70 == null) {

                this.UnprotectableReasonsV70 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV70 != null && ec.Excludes("unprotectableReasonsV70",true))
        {
            this.UnprotectableReasonsV70 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV80",true))
        {
            if(this.UnprotectableReasonsV80 == null) {

                this.UnprotectableReasonsV80 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV80 != null && ec.Excludes("unprotectableReasonsV80",true))
        {
            this.UnprotectableReasonsV80 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV81",true))
        {
            if(this.UnprotectableReasonsV81 == null) {

                this.UnprotectableReasonsV81 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV81 != null && ec.Excludes("unprotectableReasonsV81",true))
        {
            this.UnprotectableReasonsV81 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV90",true))
        {
            if(this.UnprotectableReasonsV90 == null) {

                this.UnprotectableReasonsV90 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV90 != null && ec.Excludes("unprotectableReasonsV90",true))
        {
            this.UnprotectableReasonsV90 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV91",true))
        {
            if(this.UnprotectableReasonsV91 == null) {

                this.UnprotectableReasonsV91 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV91 != null && ec.Excludes("unprotectableReasonsV91",true))
        {
            this.UnprotectableReasonsV91 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV92",true))
        {
            if(this.UnprotectableReasonsV92 == null) {

                this.UnprotectableReasonsV92 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV92 != null && ec.Excludes("unprotectableReasonsV92",true))
        {
            this.UnprotectableReasonsV92 = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        if (ec.Includes("mssqlNonSlaProperties",false))
        {
            if(this.MssqlNonSlaProperties == null) {

                this.MssqlNonSlaProperties = new MssqlNonSlaProperties();
                this.MssqlNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlNonSlaProperties"));

            } else {

                this.MssqlNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlNonSlaProperties"));

            }
        }
        else if (this.MssqlNonSlaProperties != null && ec.Excludes("mssqlNonSlaProperties",false))
        {
            this.MssqlNonSlaProperties = null;
        }
        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        if (ec.Includes("mssqlSlaRelatedProperties",false))
        {
            if(this.MssqlSlaRelatedProperties == null) {

                this.MssqlSlaRelatedProperties = new MssqlSlaRelatedProperties();
                this.MssqlSlaRelatedProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSlaRelatedProperties"));

            } else {

                this.MssqlSlaRelatedProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSlaRelatedProperties"));

            }
        }
        else if (this.MssqlSlaRelatedProperties != null && ec.Excludes("mssqlSlaRelatedProperties",false))
        {
            this.MssqlSlaRelatedProperties = null;
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (ec.Includes("rootProperties",false))
        {
            if(this.RootProperties == null) {

                this.RootProperties = new MssqlRootProperties();
                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            } else {

                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            }
        }
        else if (this.RootProperties != null && ec.Excludes("rootProperties",false))
        {
            this.RootProperties = null;
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (ec.Includes("unprotectableReasonsV50",false))
        {
            if(this.UnprotectableReasonsV50 == null) {

                this.UnprotectableReasonsV50 = new List<MssqlUnprotectableReason>();
                this.UnprotectableReasonsV50.ApplyExploratoryFieldSpec(ec.NewChild("unprotectableReasonsV50"));

            } else {

                this.UnprotectableReasonsV50.ApplyExploratoryFieldSpec(ec.NewChild("unprotectableReasonsV50"));

            }
        }
        else if (this.UnprotectableReasonsV50 != null && ec.Excludes("unprotectableReasonsV50",false))
        {
            this.UnprotectableReasonsV50 = null;
        }
    }


    #endregion

    } // class MssqlInstanceSummary
    
    #endregion

    public static class ListMssqlInstanceSummaryExtensions
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
            this List<MssqlInstanceSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlInstanceSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlInstanceSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlInstanceSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlInstanceSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types