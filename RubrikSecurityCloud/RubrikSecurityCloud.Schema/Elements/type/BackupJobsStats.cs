// BackupJobsStats.cs
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
    #region BackupJobsStats
    public class BackupJobsStats: BaseType
    {
        #region members

        //      C# -> DateTime? LastBackupTime
        // GraphQL -> lastBackupTime: DateTime (scalar)
        [JsonProperty("lastBackupTime")]
        public DateTime? LastBackupTime { get; set; }

        //      C# -> System.Int32? NumFailedInGivenInterval
        // GraphQL -> numFailedInGivenInterval: Int! (scalar)
        [JsonProperty("numFailedInGivenInterval")]
        public System.Int32? NumFailedInGivenInterval { get; set; }

        //      C# -> System.Int32? NumSucceededInGivenInterval
        // GraphQL -> numSucceededInGivenInterval: Int! (scalar)
        [JsonProperty("numSucceededInGivenInterval")]
        public System.Int32? NumSucceededInGivenInterval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "backupJobsStats";
    }

    public BackupJobsStats Set(
        DateTime? LastBackupTime = null,
        System.Int32? NumFailedInGivenInterval = null,
        System.Int32? NumSucceededInGivenInterval = null
    ) 
    {
        if ( LastBackupTime != null ) {
            this.LastBackupTime = LastBackupTime;
        }
        if ( NumFailedInGivenInterval != null ) {
            this.NumFailedInGivenInterval = NumFailedInGivenInterval;
        }
        if ( NumSucceededInGivenInterval != null ) {
            this.NumSucceededInGivenInterval = NumSucceededInGivenInterval;
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
        //      C# -> DateTime? LastBackupTime
        // GraphQL -> lastBackupTime: DateTime (scalar)
        if (this.LastBackupTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastBackupTime\n" ;
            } else {
                s += ind + "lastBackupTime\n" ;
            }
        }
        //      C# -> System.Int32? NumFailedInGivenInterval
        // GraphQL -> numFailedInGivenInterval: Int! (scalar)
        if (this.NumFailedInGivenInterval != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFailedInGivenInterval\n" ;
            } else {
                s += ind + "numFailedInGivenInterval\n" ;
            }
        }
        //      C# -> System.Int32? NumSucceededInGivenInterval
        // GraphQL -> numSucceededInGivenInterval: Int! (scalar)
        if (this.NumSucceededInGivenInterval != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSucceededInGivenInterval\n" ;
            } else {
                s += ind + "numSucceededInGivenInterval\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? LastBackupTime
        // GraphQL -> lastBackupTime: DateTime (scalar)
        if (ec.Includes("lastBackupTime",true))
        {
            if(this.LastBackupTime == null) {

                this.LastBackupTime = new DateTime();

            } else {


            }
        }
        else if (this.LastBackupTime != null && ec.Excludes("lastBackupTime",true))
        {
            this.LastBackupTime = null;
        }
        //      C# -> System.Int32? NumFailedInGivenInterval
        // GraphQL -> numFailedInGivenInterval: Int! (scalar)
        if (ec.Includes("numFailedInGivenInterval",true))
        {
            if(this.NumFailedInGivenInterval == null) {

                this.NumFailedInGivenInterval = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFailedInGivenInterval != null && ec.Excludes("numFailedInGivenInterval",true))
        {
            this.NumFailedInGivenInterval = null;
        }
        //      C# -> System.Int32? NumSucceededInGivenInterval
        // GraphQL -> numSucceededInGivenInterval: Int! (scalar)
        if (ec.Includes("numSucceededInGivenInterval",true))
        {
            if(this.NumSucceededInGivenInterval == null) {

                this.NumSucceededInGivenInterval = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSucceededInGivenInterval != null && ec.Excludes("numSucceededInGivenInterval",true))
        {
            this.NumSucceededInGivenInterval = null;
        }
    }


    #endregion

    } // class BackupJobsStats
    
    #endregion

    public static class ListBackupJobsStatsExtensions
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
            this List<BackupJobsStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupJobsStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupJobsStats> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupJobsStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupJobsStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types