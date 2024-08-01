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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        if (this.Frequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequency\n" ;
            } else {
                s += ind + "frequency\n" ;
            }
        }
        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        if (this.Recipients != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recipients\n" ;
            } else {
                s += ind + "recipients\n" ;
            }
        }
        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        if (this.StartRunTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startRunTime\n" ;
            } else {
                s += ind + "startRunTime\n" ;
            }
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        if (this.Timezone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timezone\n" ;
            } else {
                s += ind + "timezone\n" ;
            }
        }
        //      C# -> RecoveryConfig? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfig (type)
        if (this.RecoveryConfig != null) {
            var fspec = this.RecoveryConfig.AsFieldSpec(conf.Child("recoveryConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        if (ec.Includes("frequency",true))
        {
            if(this.Frequency == null) {

                this.Frequency = new ScheduleFrequency();

            } else {


            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",true))
        {
            this.Frequency = null;
        }
        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        if (ec.Includes("recipients",true))
        {
            if(this.Recipients == null) {

                this.Recipients = new List<System.String>();

            } else {


            }
        }
        else if (this.Recipients != null && ec.Excludes("recipients",true))
        {
            this.Recipients = null;
        }
        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        if (ec.Includes("startRunTime",true))
        {
            if(this.StartRunTime == null) {

                this.StartRunTime = new DateTime();

            } else {


            }
        }
        else if (this.StartRunTime != null && ec.Excludes("startRunTime",true))
        {
            this.StartRunTime = null;
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        if (ec.Includes("timezone",true))
        {
            if(this.Timezone == null) {

                this.Timezone = "FETCH";

            } else {


            }
        }
        else if (this.Timezone != null && ec.Excludes("timezone",true))
        {
            this.Timezone = null;
        }
        //      C# -> RecoveryConfig? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfig (type)
        if (ec.Includes("recoveryConfig",false))
        {
            if(this.RecoveryConfig == null) {

                this.RecoveryConfig = new RecoveryConfig();
                this.RecoveryConfig.ApplyExploratoryFieldSpec(ec.NewChild("recoveryConfig"));

            } else {

                this.RecoveryConfig.ApplyExploratoryFieldSpec(ec.NewChild("recoveryConfig"));

            }
        }
        else if (this.RecoveryConfig != null && ec.Excludes("recoveryConfig",false))
        {
            this.RecoveryConfig = null;
        }
    }


    #endregion

    } // class ScheduleInfo
    
    #endregion

    public static class ListScheduleInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ScheduleInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScheduleInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScheduleInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScheduleInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScheduleInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types