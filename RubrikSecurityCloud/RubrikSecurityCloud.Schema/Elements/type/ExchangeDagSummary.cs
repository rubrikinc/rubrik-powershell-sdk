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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ExchangeDagSummary
    public class ExchangeDagSummary: BaseType
    {
        #region members

        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        [JsonProperty("backupPreference")]
        public ExchangeBackupPreference? BackupPreference { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExchangeDagSummary";
    }

    public ExchangeDagSummary Set(
        ExchangeBackupPreference? BackupPreference = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaType = null,
        System.String? Id = null,
        System.String? Name = null
    ) 
    {
        if ( BackupPreference != null ) {
            this.BackupPreference = BackupPreference;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (this.BackupPreference != null) {
            s += ind + "backupPreference\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (this.ConfiguredSlaType != null) {
            s += ind + "configuredSlaType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (this.BackupPreference == null && ec.Includes("backupPreference",true))
        {
            this.BackupPreference = new ExchangeBackupPreference();
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId == null && ec.Includes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (this.ConfiguredSlaType == null && ec.Includes("configuredSlaType",true))
        {
            this.ConfiguredSlaType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class ExchangeDagSummary
    
    #endregion

    public static class ListExchangeDagSummaryExtensions
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
            this List<ExchangeDagSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExchangeDagSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExchangeDagSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ExchangeDagSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types