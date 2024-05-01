// OracleNonSlaProperties.cs
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
    #region OracleNonSlaProperties
    public class OracleNonSlaProperties: BaseType
    {
        #region members

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        [JsonProperty("hostMount")]
        public System.String? HostMount { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        [JsonProperty("logBackupFrequencyInMinutes")]
        public System.Int32? LogBackupFrequencyInMinutes { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleNonSlaProperties";
    }

    public OracleNonSlaProperties Set(
        System.Int32? HostLogRetentionHours = null,
        System.String? HostMount = null,
        System.Int32? LogBackupFrequencyInMinutes = null,
        System.Int32? LogRetentionHours = null,
        System.Int32? NumChannels = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( HostMount != null ) {
            this.HostMount = HostMount;
        }
        if ( LogBackupFrequencyInMinutes != null ) {
            this.LogBackupFrequencyInMinutes = LogBackupFrequencyInMinutes;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
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
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetentionHours\n" ;
            } else {
                s += ind + "hostLogRetentionHours\n" ;
            }
        }
        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        if (this.HostMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostMount\n" ;
            } else {
                s += ind + "hostMount\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        if (this.LogBackupFrequencyInMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInMinutes\n" ;
            } else {
                s += ind + "logBackupFrequencyInMinutes\n" ;
            }
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionHours\n" ;
            } else {
                s += ind + "logRetentionHours\n" ;
            }
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numChannels\n" ;
            } else {
                s += ind + "numChannels\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (ec.Includes("hostLogRetentionHours",true))
        {
            if(this.HostLogRetentionHours == null) {

                this.HostLogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetentionHours != null && ec.Excludes("hostLogRetentionHours",true))
        {
            this.HostLogRetentionHours = null;
        }
        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        if (ec.Includes("hostMount",true))
        {
            if(this.HostMount == null) {

                this.HostMount = "FETCH";

            } else {


            }
        }
        else if (this.HostMount != null && ec.Excludes("hostMount",true))
        {
            this.HostMount = null;
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        if (ec.Includes("logBackupFrequencyInMinutes",true))
        {
            if(this.LogBackupFrequencyInMinutes == null) {

                this.LogBackupFrequencyInMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequencyInMinutes != null && ec.Excludes("logBackupFrequencyInMinutes",true))
        {
            this.LogBackupFrequencyInMinutes = null;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
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
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (ec.Includes("numChannels",true))
        {
            if(this.NumChannels == null) {

                this.NumChannels = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumChannels != null && ec.Excludes("numChannels",true))
        {
            this.NumChannels = null;
        }
    }


    #endregion

    } // class OracleNonSlaProperties
    
    #endregion

    public static class ListOracleNonSlaPropertiesExtensions
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
            this List<OracleNonSlaProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleNonSlaProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleNonSlaProperties> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleNonSlaProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleNonSlaProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types