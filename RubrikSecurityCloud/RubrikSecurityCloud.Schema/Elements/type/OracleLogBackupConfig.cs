// OracleLogBackupConfig.cs
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
    #region OracleLogBackupConfig
    public class OracleLogBackupConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        [JsonProperty("logBackupFrequencyMin")]
        public System.Int32? LogBackupFrequencyMin { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleLogBackupConfig";
    }

    public OracleLogBackupConfig Set(
        System.Int32? HostLogRetentionHours = null,
        System.Int32? LogBackupFrequencyMin = null,
        System.Int32? LogRetentionHours = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( LogBackupFrequencyMin != null ) {
            this.LogBackupFrequencyMin = LogBackupFrequencyMin;
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
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (this.HostLogRetentionHours != null) {
            s += ind + "hostLogRetentionHours\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        if (this.LogBackupFrequencyMin != null) {
            s += ind + "logBackupFrequencyMin\n" ;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours != null) {
            s += ind + "logRetentionHours\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours", true))
        {
            this.HostLogRetentionHours = Int32.MinValue;
        }
        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        if (this.LogBackupFrequencyMin == null && Exploration.Includes(parent + ".logBackupFrequencyMin", true))
        {
            this.LogBackupFrequencyMin = Int32.MinValue;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours", true))
        {
            this.LogRetentionHours = Int32.MinValue;
        }
    }


    #endregion

    } // class OracleLogBackupConfig
    
    #endregion

    public static class ListOracleLogBackupConfigExtensions
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
            this List<OracleLogBackupConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleLogBackupConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLogBackupConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types