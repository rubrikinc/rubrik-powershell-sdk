// ExchangeDagSummary.cs
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
    #region ExchangeDagSummary
    public class ExchangeDagSummary: IFragment
    {
        #region members
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        [JsonProperty("configuredSlaType")]
        public System.String? ConfiguredSlaType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        [JsonProperty("backupPreference")]
        public ExchangeBackupPreference? BackupPreference { get; set; }

        #endregion

    #region methods

    public ExchangeDagSummary Set(
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaType = null,
        System.String? Id = null,
        System.String? Name = null,
        ExchangeBackupPreference? BackupPreference = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaType != null ) {
            this.ConfiguredSlaType = ConfiguredSlaType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( BackupPreference != null ) {
            this.BackupPreference = BackupPreference;
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
            //      C# -> System.String? ConfiguredSlaType
            // GraphQL -> configuredSlaType: String! (scalar)
            if (this.ConfiguredSlaType != null)
            {
                 s += ind + "configuredSlaType\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> ExchangeBackupPreference? BackupPreference
            // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
            if (this.BackupPreference != null)
            {
                 s += ind + "backupPreference\n";

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
            //      C# -> System.String? ConfiguredSlaType
            // GraphQL -> configuredSlaType: String! (scalar)
            if (this.ConfiguredSlaType == null && Exploration.Includes(parent + ".configuredSlaType$"))
            {
                this.ConfiguredSlaType = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> ExchangeBackupPreference? BackupPreference
            // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
            if (this.BackupPreference == null && Exploration.Includes(parent + ".backupPreference$"))
            {
                this.BackupPreference = new ExchangeBackupPreference();
            }
        }


    #endregion

    } // class ExchangeDagSummary
    #endregion

    public static class ListExchangeDagSummaryExtensions
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
            this List<ExchangeDagSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ExchangeDagSummary> list, 
            String parent = "")
        {
            var item = new ExchangeDagSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types