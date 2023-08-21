// ScheduleInfo.cs
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
    #region ScheduleInfo
    public class ScheduleInfo: BaseType
    {
        #region members

        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        [JsonProperty("frequency")]
        public ScheduleFrequency? Frequency { get; set; }

        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        [JsonProperty("recipients")]
        public List<System.String>? Recipients { get; set; }

        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        [JsonProperty("startRunTime")]
        public DateTime? StartRunTime { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> RecoveryConfig? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfig (type)
        [JsonProperty("recoveryConfig")]
        public RecoveryConfig? RecoveryConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScheduleInfo";
    }

    public ScheduleInfo Set(
        ScheduleFrequency? Frequency = null,
        List<System.String>? Recipients = null,
        DateTime? StartRunTime = null,
        System.String? Timezone = null,
        RecoveryConfig? RecoveryConfig = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Recipients != null ) {
            this.Recipients = Recipients;
        }
        if ( StartRunTime != null ) {
            this.StartRunTime = StartRunTime;
        }
        if ( Timezone != null ) {
            this.Timezone = Timezone;
        }
        if ( RecoveryConfig != null ) {
            this.RecoveryConfig = RecoveryConfig;
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
        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        if (this.Frequency != null) {
            s += ind + "frequency\n" ;
        }
        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        if (this.Recipients != null) {
            s += ind + "recipients\n" ;
        }
        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        if (this.StartRunTime != null) {
            s += ind + "startRunTime\n" ;
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        if (this.Timezone != null) {
            s += ind + "timezone\n" ;
        }
        //      C# -> RecoveryConfig? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfig (type)
        if (this.RecoveryConfig != null) {
            var fspec = this.RecoveryConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        if (this.Frequency == null && Exploration.Includes(parent + ".frequency", true))
        {
            this.Frequency = new ScheduleFrequency();
        }
        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        if (this.Recipients == null && Exploration.Includes(parent + ".recipients", true))
        {
            this.Recipients = new List<System.String>();
        }
        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        if (this.StartRunTime == null && Exploration.Includes(parent + ".startRunTime", true))
        {
            this.StartRunTime = new DateTime();
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        if (this.Timezone == null && Exploration.Includes(parent + ".timezone", true))
        {
            this.Timezone = "FETCH";
        }
        //      C# -> RecoveryConfig? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfig (type)
        if (this.RecoveryConfig == null && Exploration.Includes(parent + ".recoveryConfig"))
        {
            this.RecoveryConfig = new RecoveryConfig();
            this.RecoveryConfig.ApplyExploratoryFieldSpec(parent + ".recoveryConfig");
        }
    }


    #endregion

    } // class ScheduleInfo
    
    #endregion

    public static class ListScheduleInfoExtensions
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
            this List<ScheduleInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ScheduleInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ScheduleInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types