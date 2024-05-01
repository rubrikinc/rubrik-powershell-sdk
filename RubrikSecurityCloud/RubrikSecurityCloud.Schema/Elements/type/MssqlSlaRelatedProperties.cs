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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        if (this.CopyOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "copyOnly\n" ;
            } else {
                s += ind + "copyOnly\n" ;
            }
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLogConfigFromSla\n" ;
            } else {
                s += ind + "hasLogConfigFromSla\n" ;
            }
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (this.HostLogRetention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetention\n" ;
            } else {
                s += ind + "hostLogRetention\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInSeconds\n" ;
            } else {
                s += ind + "logBackupFrequencyInSeconds\n" ;
            }
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        if (this.LogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionHours\n" ;
            } else {
                s += ind + "logRetentionHours\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        if (ec.Includes("copyOnly",true))
        {
            if(this.CopyOnly == null) {

                this.CopyOnly = true;

            } else {


            }
        }
        else if (this.CopyOnly != null && ec.Excludes("copyOnly",true))
        {
            this.CopyOnly = null;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (ec.Includes("hasLogConfigFromSla",true))
        {
            if(this.HasLogConfigFromSla == null) {

                this.HasLogConfigFromSla = true;

            } else {


            }
        }
        else if (this.HasLogConfigFromSla != null && ec.Excludes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = null;
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (ec.Includes("hostLogRetention",true))
        {
            if(this.HostLogRetention == null) {

                this.HostLogRetention = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetention != null && ec.Excludes("hostLogRetention",true))
        {
            this.HostLogRetention = null;
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        if (ec.Includes("logBackupFrequencyInSeconds",true))
        {
            if(this.LogBackupFrequencyInSeconds == null) {

                this.LogBackupFrequencyInSeconds = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequencyInSeconds != null && ec.Excludes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = null;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        if (ec.Includes("logRetentionHours",true))
        {
            if(this.LogRetentionHours == null) {

                this.LogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogRetentionHours != null && ec.Excludes("logRetentionHours",true))
        {
            this.LogRetentionHours = null;
        }
    }


    #endregion

    } // class MssqlSlaRelatedProperties
    
    #endregion

    public static class ListMssqlSlaRelatedPropertiesExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<MssqlSlaRelatedProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlSlaRelatedProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<MssqlSlaRelatedProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types