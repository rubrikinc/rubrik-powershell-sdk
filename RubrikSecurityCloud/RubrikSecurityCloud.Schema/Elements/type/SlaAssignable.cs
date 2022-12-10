// SlaAssignable.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    #region SlaAssignable
    public class SlaAssignable: IFragment
    {
        #region members
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

        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        [JsonProperty("configuredSlaDomainType")]
        public ConfiguredSlaType? ConfiguredSlaDomainType { get; set; }

        #endregion

    #region methods

    public SlaAssignable Set(
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaDomainName = null,
        System.String? Id = null,
        System.Boolean? IsConfiguredSlaDomainRetentionLocked = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        DateTime? SlaLastUpdateTime = null,
        ConfiguredSlaType? ConfiguredSlaDomainType = null
    ) 
    {
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
        if ( ConfiguredSlaDomainType != null ) {
            this.ConfiguredSlaDomainType = ConfiguredSlaDomainType;
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
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String! (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> System.String? ConfiguredSlaDomainName
            // GraphQL -> configuredSlaDomainName: String! (scalar)
            if (this.ConfiguredSlaDomainName != null)
            {
                 s += ind + "configuredSlaDomainName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
            // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsConfiguredSlaDomainRetentionLocked != null)
            {
                 s += ind + "isConfiguredSlaDomainRetentionLocked\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
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
            //      C# -> DateTime? SlaLastUpdateTime
            // GraphQL -> slaLastUpdateTime: DateTime (scalar)
            if (this.SlaLastUpdateTime != null)
            {
                 s += ind + "slaLastUpdateTime\n";

            }
            //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
            // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
            if (this.ConfiguredSlaDomainType != null)
            {
                 s += ind + "configuredSlaDomainType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String! (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? ConfiguredSlaDomainName
            // GraphQL -> configuredSlaDomainName: String! (scalar)
            if (this.ConfiguredSlaDomainName == null && Exploration.Includes(parent + ".configuredSlaDomainName$"))
            {
                this.ConfiguredSlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
            // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsConfiguredSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isConfiguredSlaDomainRetentionLocked$"))
            {
                this.IsConfiguredSlaDomainRetentionLocked = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
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
            //      C# -> DateTime? SlaLastUpdateTime
            // GraphQL -> slaLastUpdateTime: DateTime (scalar)
            if (this.SlaLastUpdateTime == null && Exploration.Includes(parent + ".slaLastUpdateTime$"))
            {
                this.SlaLastUpdateTime = new DateTime();
            }
            //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
            // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
            if (this.ConfiguredSlaDomainType == null && Exploration.Includes(parent + ".configuredSlaDomainType$"))
            {
                this.ConfiguredSlaDomainType = new ConfiguredSlaType();
            }
        }


    #endregion

    } // class SlaAssignable
    #endregion

    public static class ListSlaAssignableExtensions
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
            this List<SlaAssignable> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaAssignable> list, 
            String parent = "")
        {
            var item = new SlaAssignable();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types