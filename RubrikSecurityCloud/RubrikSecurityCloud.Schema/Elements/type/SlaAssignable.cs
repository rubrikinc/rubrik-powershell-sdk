// SlaAssignable.cs
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
    #region SlaAssignable
    public class SlaAssignable: BaseType
    {
        #region members

        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        [JsonProperty("configuredSlaDomainType")]
        public ConfiguredSlaType? ConfiguredSlaDomainType { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        [JsonProperty("configuredSlaDomainName")]
        public System.String? ConfiguredSlaDomainName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isConfiguredSlaDomainRetentionLocked")]
        public System.Boolean? IsConfiguredSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        [JsonProperty("slaLastUpdateTime")]
        public DateTime? SlaLastUpdateTime { get; set; }


        #endregion

    #region methods

    public SlaAssignable Set(
        ConfiguredSlaType? ConfiguredSlaDomainType = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaDomainName = null,
        System.String? Id = null,
        System.Boolean? IsConfiguredSlaDomainRetentionLocked = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        DateTime? SlaLastUpdateTime = null
    ) 
    {
        if ( ConfiguredSlaDomainType != null ) {
            this.ConfiguredSlaDomainType = ConfiguredSlaDomainType;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaDomainName != null ) {
            this.ConfiguredSlaDomainName = ConfiguredSlaDomainName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsConfiguredSlaDomainRetentionLocked != null ) {
            this.IsConfiguredSlaDomainRetentionLocked = IsConfiguredSlaDomainRetentionLocked;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( SlaLastUpdateTime != null ) {
            this.SlaLastUpdateTime = SlaLastUpdateTime;
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
        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        if (this.ConfiguredSlaDomainType != null) {
            s += ind + "configuredSlaDomainType\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName != null) {
            s += ind + "configuredSlaDomainName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsConfiguredSlaDomainRetentionLocked != null) {
            s += ind + "isConfiguredSlaDomainRetentionLocked\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        if (this.SlaLastUpdateTime != null) {
            s += ind + "slaLastUpdateTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        if (this.ConfiguredSlaDomainType == null && Exploration.Includes(parent + ".configuredSlaDomainType", true))
        {
            this.ConfiguredSlaDomainType = new ConfiguredSlaType();
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName == null && Exploration.Includes(parent + ".configuredSlaDomainName", true))
        {
            this.ConfiguredSlaDomainName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsConfiguredSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isConfiguredSlaDomainRetentionLocked", true))
        {
            this.IsConfiguredSlaDomainRetentionLocked = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        if (this.SlaLastUpdateTime == null && Exploration.Includes(parent + ".slaLastUpdateTime", true))
        {
            this.SlaLastUpdateTime = new DateTime();
        }
    }


    #endregion

    } // class SlaAssignable
    
    #endregion

    public static class ListSlaAssignableExtensions
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
            this List<SlaAssignable> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaAssignable> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaAssignable());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types