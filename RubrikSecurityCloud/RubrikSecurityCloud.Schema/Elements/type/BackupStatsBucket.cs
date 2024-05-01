// BackupStatsBucket.cs
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
    #region BackupStatsBucket
    public class BackupStatsBucket: BaseType
    {
        #region members

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        [JsonProperty("numFailed")]
        public System.Int32? NumFailed { get; set; }

        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        [JsonProperty("numSucceeded")]
        public System.Int32? NumSucceeded { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupStatsBucket";
    }

    public BackupStatsBucket Set(
        DateTime? EndTime = null,
        System.Int32? NumFailed = null,
        System.Int32? NumSucceeded = null,
        DateTime? StartTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NumFailed != null ) {
            this.NumFailed = NumFailed;
        }
        if ( NumSucceeded != null ) {
            this.NumSucceeded = NumSucceeded;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (this.NumFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFailed\n" ;
            } else {
                s += ind + "numFailed\n" ;
            }
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (this.NumSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSucceeded\n" ;
            } else {
                s += ind + "numSucceeded\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (ec.Includes("numFailed",true))
        {
            if(this.NumFailed == null) {

                this.NumFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFailed != null && ec.Excludes("numFailed",true))
        {
            this.NumFailed = null;
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (ec.Includes("numSucceeded",true))
        {
            if(this.NumSucceeded == null) {

                this.NumSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSucceeded != null && ec.Excludes("numSucceeded",true))
        {
            this.NumSucceeded = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
    }


    #endregion

    } // class BackupStatsBucket
    
    #endregion

    public static class ListBackupStatsBucketExtensions
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
            this List<BackupStatsBucket> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupStatsBucket> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupStatsBucket> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupStatsBucket());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupStatsBucket> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types