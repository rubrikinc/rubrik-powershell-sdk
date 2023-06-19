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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId != null) {
            s += ind + "backupId\n" ;
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long (scalar)
        if (this.BackupSizeInBytes != null) {
            s += ind + "backupSizeInBytes\n" ;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath != null) {
            s += ind + "destinationPath\n" ;
        }
        //      C# -> System.String? DestinationType
        // GraphQL -> destinationType: String (scalar)
        if (this.DestinationType != null) {
            s += ind + "destinationType\n" ;
        }
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String (scalar)
        if (this.ExternalBackupId != null) {
            s += ind + "externalBackupId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? ServiceTypeName
        // GraphQL -> serviceTypeName: String (scalar)
        if (this.ServiceTypeName != null) {
            s += ind + "serviceTypeName\n" ;
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long (scalar)
        if (this.SourceId != null) {
            s += ind + "sourceId\n" ;
        }
        //      C# -> System.String? SourceTypeName
        // GraphQL -> sourceTypeName: String (scalar)
        if (this.SourceTypeName != null) {
            s += ind + "sourceTypeName\n" ;
        }
        //      C# -> SapHanaLogPositionInterval? LogPositionInterval
        // GraphQL -> logPositionInterval: SapHanaLogPositionInterval (type)
        if (this.LogPositionInterval != null) {
            var fspec = this.LogPositionInterval.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logPositionInterval {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId == null && Exploration.Includes(parent + ".backupId", true))
        {
            this.BackupId = new System.Int64();
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long (scalar)
        if (this.BackupSizeInBytes == null && Exploration.Includes(parent + ".backupSizeInBytes", true))
        {
            this.BackupSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath == null && Exploration.Includes(parent + ".destinationPath", true))
        {
            this.DestinationPath = "FETCH";
        }
        //      C# -> System.String? DestinationType
        // GraphQL -> destinationType: String (scalar)
        if (this.DestinationType == null && Exploration.Includes(parent + ".destinationType", true))
        {
            this.DestinationType = "FETCH";
        }
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String (scalar)
        if (this.ExternalBackupId == null && Exploration.Includes(parent + ".externalBackupId", true))
        {
            this.ExternalBackupId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? ServiceTypeName
        // GraphQL -> serviceTypeName: String (scalar)
        if (this.ServiceTypeName == null && Exploration.Includes(parent + ".serviceTypeName", true))
        {
            this.ServiceTypeName = "FETCH";
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long (scalar)
        if (this.SourceId == null && Exploration.Includes(parent + ".sourceId", true))
        {
            this.SourceId = new System.Int64();
        }
        //      C# -> System.String? SourceTypeName
        // GraphQL -> sourceTypeName: String (scalar)
        if (this.SourceTypeName == null && Exploration.Includes(parent + ".sourceTypeName", true))
        {
            this.SourceTypeName = "FETCH";
        }
        //      C# -> SapHanaLogPositionInterval? LogPositionInterval
        // GraphQL -> logPositionInterval: SapHanaLogPositionInterval (type)
        if (this.LogPositionInterval == null && Exploration.Includes(parent + ".logPositionInterval"))
        {
            this.LogPositionInterval = new SapHanaLogPositionInterval();
            this.LogPositionInterval.ApplyExploratoryFieldSpec(parent + ".logPositionInterval");
        }
    }


    #endregion

    } // class SapHanaLogBackupFiles
    
    #endregion

    public static class ListSapHanaLogBackupFilesExtensions
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
            this List<SapHanaLogBackupFiles> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogBackupFiles> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogBackupFiles());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types