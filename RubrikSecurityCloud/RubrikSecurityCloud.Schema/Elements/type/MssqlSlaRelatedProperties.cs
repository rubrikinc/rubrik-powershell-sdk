// MssqlSlaRelatedProperties.cs
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
    #region MssqlSlaRelatedProperties
    public class MssqlSlaRelatedProperties: BaseType
    {
        #region members

        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        [JsonProperty("copyOnly")]
        public System.Boolean? CopyOnly { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        [JsonProperty("hostLogRetention")]
        public System.Int32? HostLogRetention { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int32? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlSlaRelatedProperties";
    }

    public MssqlSlaRelatedProperties Set(
        System.Boolean? CopyOnly = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Int32? HostLogRetention = null,
        System.Int32? LogBackupFrequencyInSeconds = null,
        System.Int32? LogRetentionHours = null
    ) 
    {
        if ( CopyOnly != null ) {
            this.CopyOnly = CopyOnly;
        }
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
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
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        if (this.CopyOnly != null) {
            s += ind + "copyOnly\n" ;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            s += ind + "hasLogConfigFromSla\n" ;
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (this.HostLogRetention != null) {
            s += ind + "hostLogRetention\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            s += ind + "logBackupFrequencyInSeconds\n" ;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        if (this.LogRetentionHours != null) {
            s += ind + "logRetentionHours\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        if (this.CopyOnly == null && ec.Includes("copyOnly",true))
        {
            this.CopyOnly = true;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla == null && ec.Includes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = true;
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (this.HostLogRetention == null && ec.Includes("hostLogRetention",true))
        {
            this.HostLogRetention = Int32.MinValue;
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        if (this.LogBackupFrequencyInSeconds == null && ec.Includes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = Int32.MinValue;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        if (this.LogRetentionHours == null && ec.Includes("logRetentionHours",true))
        {
            this.LogRetentionHours = Int32.MinValue;
        }
    }


    #endregion

    } // class MssqlSlaRelatedProperties
    
    #endregion

    public static class ListMssqlSlaRelatedPropertiesExtensions
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
            this List<MssqlSlaRelatedProperties> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlSlaRelatedProperties> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlSlaRelatedProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MssqlSlaRelatedProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types