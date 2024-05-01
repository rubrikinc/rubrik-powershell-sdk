// SapHanaDatabaseInfoObject.cs
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
    #region SapHanaDatabaseInfoObject
    public class SapHanaDatabaseInfoObject: BaseType
    {
        #region members

        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        [JsonProperty("approxDbSizeInMb")]
        public System.Int64? ApproxDbSizeInMb { get; set; }

        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        [JsonProperty("backintPath")]
        public System.String? BackintPath { get; set; }

        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        [JsonProperty("databaseType")]
        public System.String? DatabaseType { get; set; }

        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        [JsonProperty("logBackupIntervalSecs")]
        public System.Int32? LogBackupIntervalSecs { get; set; }

        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        [JsonProperty("logMode")]
        public System.String? LogMode { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        [JsonProperty("paramFilePath")]
        public System.String? ParamFilePath { get; set; }

        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        [JsonProperty("restoreConfiguredSrcDatabaseId")]
        public System.String? RestoreConfiguredSrcDatabaseId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaDatabaseInfoObject";
    }

    public SapHanaDatabaseInfoObject Set(
        System.Int64? ApproxDbSizeInMb = null,
        System.String? BackintPath = null,
        System.String? DatabaseType = null,
        System.Int32? LogBackupIntervalSecs = null,
        System.String? LogMode = null,
        System.Int32? NumChannels = null,
        System.String? ParamFilePath = null,
        System.String? RestoreConfiguredSrcDatabaseId = null,
        System.String? Status = null
    ) 
    {
        if ( ApproxDbSizeInMb != null ) {
            this.ApproxDbSizeInMb = ApproxDbSizeInMb;
        }
        if ( BackintPath != null ) {
            this.BackintPath = BackintPath;
        }
        if ( DatabaseType != null ) {
            this.DatabaseType = DatabaseType;
        }
        if ( LogBackupIntervalSecs != null ) {
            this.LogBackupIntervalSecs = LogBackupIntervalSecs;
        }
        if ( LogMode != null ) {
            this.LogMode = LogMode;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( ParamFilePath != null ) {
            this.ParamFilePath = ParamFilePath;
        }
        if ( RestoreConfiguredSrcDatabaseId != null ) {
            this.RestoreConfiguredSrcDatabaseId = RestoreConfiguredSrcDatabaseId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        if (this.ApproxDbSizeInMb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "approxDbSizeInMb\n" ;
            } else {
                s += ind + "approxDbSizeInMb\n" ;
            }
        }
        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        if (this.BackintPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backintPath\n" ;
            } else {
                s += ind + "backintPath\n" ;
            }
        }
        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        if (this.DatabaseType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseType\n" ;
            } else {
                s += ind + "databaseType\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        if (this.LogBackupIntervalSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupIntervalSecs\n" ;
            } else {
                s += ind + "logBackupIntervalSecs\n" ;
            }
        }
        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        if (this.LogMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logMode\n" ;
            } else {
                s += ind + "logMode\n" ;
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
        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        if (this.ParamFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paramFilePath\n" ;
            } else {
                s += ind + "paramFilePath\n" ;
            }
        }
        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        if (this.RestoreConfiguredSrcDatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "restoreConfiguredSrcDatabaseId\n" ;
            } else {
                s += ind + "restoreConfiguredSrcDatabaseId\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        if (ec.Includes("approxDbSizeInMb",true))
        {
            if(this.ApproxDbSizeInMb == null) {

                this.ApproxDbSizeInMb = new System.Int64();

            } else {


            }
        }
        else if (this.ApproxDbSizeInMb != null && ec.Excludes("approxDbSizeInMb",true))
        {
            this.ApproxDbSizeInMb = null;
        }
        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        if (ec.Includes("backintPath",true))
        {
            if(this.BackintPath == null) {

                this.BackintPath = "FETCH";

            } else {


            }
        }
        else if (this.BackintPath != null && ec.Excludes("backintPath",true))
        {
            this.BackintPath = null;
        }
        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        if (ec.Includes("databaseType",true))
        {
            if(this.DatabaseType == null) {

                this.DatabaseType = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseType != null && ec.Excludes("databaseType",true))
        {
            this.DatabaseType = null;
        }
        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        if (ec.Includes("logBackupIntervalSecs",true))
        {
            if(this.LogBackupIntervalSecs == null) {

                this.LogBackupIntervalSecs = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupIntervalSecs != null && ec.Excludes("logBackupIntervalSecs",true))
        {
            this.LogBackupIntervalSecs = null;
        }
        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        if (ec.Includes("logMode",true))
        {
            if(this.LogMode == null) {

                this.LogMode = "FETCH";

            } else {


            }
        }
        else if (this.LogMode != null && ec.Excludes("logMode",true))
        {
            this.LogMode = null;
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
        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        if (ec.Includes("paramFilePath",true))
        {
            if(this.ParamFilePath == null) {

                this.ParamFilePath = "FETCH";

            } else {


            }
        }
        else if (this.ParamFilePath != null && ec.Excludes("paramFilePath",true))
        {
            this.ParamFilePath = null;
        }
        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        if (ec.Includes("restoreConfiguredSrcDatabaseId",true))
        {
            if(this.RestoreConfiguredSrcDatabaseId == null) {

                this.RestoreConfiguredSrcDatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.RestoreConfiguredSrcDatabaseId != null && ec.Excludes("restoreConfiguredSrcDatabaseId",true))
        {
            this.RestoreConfiguredSrcDatabaseId = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class SapHanaDatabaseInfoObject
    
    #endregion

    public static class ListSapHanaDatabaseInfoObjectExtensions
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
            this List<SapHanaDatabaseInfoObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaDatabaseInfoObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaDatabaseInfoObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaDatabaseInfoObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaDatabaseInfoObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types