// SapHanaLogBackupFiles.cs
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
    #region SapHanaLogBackupFiles
    public class SapHanaLogBackupFiles: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        [JsonProperty("backupId")]
        public System.Int64? BackupId { get; set; }

        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long (scalar)
        [JsonProperty("backupSizeInBytes")]
        public System.Int64? BackupSizeInBytes { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> System.String? DestinationType
        // GraphQL -> destinationType: String (scalar)
        [JsonProperty("destinationType")]
        public System.String? DestinationType { get; set; }

        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String (scalar)
        [JsonProperty("externalBackupId")]
        public System.String? ExternalBackupId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? ServiceTypeName
        // GraphQL -> serviceTypeName: String (scalar)
        [JsonProperty("serviceTypeName")]
        public System.String? ServiceTypeName { get; set; }

        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long (scalar)
        [JsonProperty("sourceId")]
        public System.Int64? SourceId { get; set; }

        //      C# -> System.String? SourceTypeName
        // GraphQL -> sourceTypeName: String (scalar)
        [JsonProperty("sourceTypeName")]
        public System.String? SourceTypeName { get; set; }

        //      C# -> SapHanaLogPositionInterval? LogPositionInterval
        // GraphQL -> logPositionInterval: SapHanaLogPositionInterval (type)
        [JsonProperty("logPositionInterval")]
        public SapHanaLogPositionInterval? LogPositionInterval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaLogBackupFiles";
    }

    public SapHanaLogBackupFiles Set(
        System.Int64? BackupId = null,
        System.Int64? BackupSizeInBytes = null,
        System.String? DestinationPath = null,
        System.String? DestinationType = null,
        System.String? ExternalBackupId = null,
        System.String? HostName = null,
        System.String? ServiceTypeName = null,
        System.Int64? SourceId = null,
        System.String? SourceTypeName = null,
        SapHanaLogPositionInterval? LogPositionInterval = null
    ) 
    {
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BackupSizeInBytes != null ) {
            this.BackupSizeInBytes = BackupSizeInBytes;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( DestinationType != null ) {
            this.DestinationType = DestinationType;
        }
        if ( ExternalBackupId != null ) {
            this.ExternalBackupId = ExternalBackupId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( ServiceTypeName != null ) {
            this.ServiceTypeName = ServiceTypeName;
        }
        if ( SourceId != null ) {
            this.SourceId = SourceId;
        }
        if ( SourceTypeName != null ) {
            this.SourceTypeName = SourceTypeName;
        }
        if ( LogPositionInterval != null ) {
            this.LogPositionInterval = LogPositionInterval;
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
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupId\n" ;
            } else {
                s += ind + "backupId\n" ;
            }
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long (scalar)
        if (this.BackupSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupSizeInBytes\n" ;
            } else {
                s += ind + "backupSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationPath\n" ;
            } else {
                s += ind + "destinationPath\n" ;
            }
        }
        //      C# -> System.String? DestinationType
        // GraphQL -> destinationType: String (scalar)
        if (this.DestinationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationType\n" ;
            } else {
                s += ind + "destinationType\n" ;
            }
        }
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String (scalar)
        if (this.ExternalBackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalBackupId\n" ;
            } else {
                s += ind + "externalBackupId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? ServiceTypeName
        // GraphQL -> serviceTypeName: String (scalar)
        if (this.ServiceTypeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceTypeName\n" ;
            } else {
                s += ind + "serviceTypeName\n" ;
            }
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long (scalar)
        if (this.SourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceId\n" ;
            } else {
                s += ind + "sourceId\n" ;
            }
        }
        //      C# -> System.String? SourceTypeName
        // GraphQL -> sourceTypeName: String (scalar)
        if (this.SourceTypeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceTypeName\n" ;
            } else {
                s += ind + "sourceTypeName\n" ;
            }
        }
        //      C# -> SapHanaLogPositionInterval? LogPositionInterval
        // GraphQL -> logPositionInterval: SapHanaLogPositionInterval (type)
        if (this.LogPositionInterval != null) {
            var fspec = this.LogPositionInterval.AsFieldSpec(conf.Child("logPositionInterval"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logPositionInterval" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (ec.Includes("backupId",true))
        {
            if(this.BackupId == null) {

                this.BackupId = new System.Int64();

            } else {


            }
        }
        else if (this.BackupId != null && ec.Excludes("backupId",true))
        {
            this.BackupId = null;
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long (scalar)
        if (ec.Includes("backupSizeInBytes",true))
        {
            if(this.BackupSizeInBytes == null) {

                this.BackupSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.BackupSizeInBytes != null && ec.Excludes("backupSizeInBytes",true))
        {
            this.BackupSizeInBytes = null;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (ec.Includes("destinationPath",true))
        {
            if(this.DestinationPath == null) {

                this.DestinationPath = "FETCH";

            } else {


            }
        }
        else if (this.DestinationPath != null && ec.Excludes("destinationPath",true))
        {
            this.DestinationPath = null;
        }
        //      C# -> System.String? DestinationType
        // GraphQL -> destinationType: String (scalar)
        if (ec.Includes("destinationType",true))
        {
            if(this.DestinationType == null) {

                this.DestinationType = "FETCH";

            } else {


            }
        }
        else if (this.DestinationType != null && ec.Excludes("destinationType",true))
        {
            this.DestinationType = null;
        }
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String (scalar)
        if (ec.Includes("externalBackupId",true))
        {
            if(this.ExternalBackupId == null) {

                this.ExternalBackupId = "FETCH";

            } else {


            }
        }
        else if (this.ExternalBackupId != null && ec.Excludes("externalBackupId",true))
        {
            this.ExternalBackupId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? ServiceTypeName
        // GraphQL -> serviceTypeName: String (scalar)
        if (ec.Includes("serviceTypeName",true))
        {
            if(this.ServiceTypeName == null) {

                this.ServiceTypeName = "FETCH";

            } else {


            }
        }
        else if (this.ServiceTypeName != null && ec.Excludes("serviceTypeName",true))
        {
            this.ServiceTypeName = null;
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long (scalar)
        if (ec.Includes("sourceId",true))
        {
            if(this.SourceId == null) {

                this.SourceId = new System.Int64();

            } else {


            }
        }
        else if (this.SourceId != null && ec.Excludes("sourceId",true))
        {
            this.SourceId = null;
        }
        //      C# -> System.String? SourceTypeName
        // GraphQL -> sourceTypeName: String (scalar)
        if (ec.Includes("sourceTypeName",true))
        {
            if(this.SourceTypeName == null) {

                this.SourceTypeName = "FETCH";

            } else {


            }
        }
        else if (this.SourceTypeName != null && ec.Excludes("sourceTypeName",true))
        {
            this.SourceTypeName = null;
        }
        //      C# -> SapHanaLogPositionInterval? LogPositionInterval
        // GraphQL -> logPositionInterval: SapHanaLogPositionInterval (type)
        if (ec.Includes("logPositionInterval",false))
        {
            if(this.LogPositionInterval == null) {

                this.LogPositionInterval = new SapHanaLogPositionInterval();
                this.LogPositionInterval.ApplyExploratoryFieldSpec(ec.NewChild("logPositionInterval"));

            } else {

                this.LogPositionInterval.ApplyExploratoryFieldSpec(ec.NewChild("logPositionInterval"));

            }
        }
        else if (this.LogPositionInterval != null && ec.Excludes("logPositionInterval",false))
        {
            this.LogPositionInterval = null;
        }
    }


    #endregion

    } // class SapHanaLogBackupFiles
    
    #endregion

    public static class ListSapHanaLogBackupFilesExtensions
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
            this List<SapHanaLogBackupFiles> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaLogBackupFiles> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogBackupFiles> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogBackupFiles());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaLogBackupFiles> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types