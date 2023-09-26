// RdsInstanceDetailsFromAws.cs
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
    #region RdsInstanceDetailsFromAws
    public class RdsInstanceDetailsFromAws: BaseType
    {
        #region members

        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        [JsonProperty("allocatedStorageInGb")]
        public System.Int64? AllocatedStorageInGb { get; set; }

        //      C# -> System.Int64? BackupRetentionPeriod
        // GraphQL -> backupRetentionPeriod: Long! (scalar)
        [JsonProperty("backupRetentionPeriod")]
        public System.Int64? BackupRetentionPeriod { get; set; }

        //      C# -> System.String? DbEngine
        // GraphQL -> dbEngine: String! (scalar)
        [JsonProperty("dbEngine")]
        public System.String? DbEngine { get; set; }

        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        [JsonProperty("dbEngineVersion")]
        public System.String? DbEngineVersion { get; set; }

        //      C# -> System.String? DbInstanceClass
        // GraphQL -> dbInstanceClass: String! (scalar)
        [JsonProperty("dbInstanceClass")]
        public System.String? DbInstanceClass { get; set; }

        //      C# -> System.String? DbInstanceStatus
        // GraphQL -> dbInstanceStatus: String! (scalar)
        [JsonProperty("dbInstanceStatus")]
        public System.String? DbInstanceStatus { get; set; }

        //      C# -> System.String? DbMaintenanceWindow
        // GraphQL -> dbMaintenanceWindow: String! (scalar)
        [JsonProperty("dbMaintenanceWindow")]
        public System.String? DbMaintenanceWindow { get; set; }

        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        [JsonProperty("dbParameterGroupName")]
        public System.String? DbParameterGroupName { get; set; }

        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        [JsonProperty("dbSubnetGroupName")]
        public System.String? DbSubnetGroupName { get; set; }

        //      C# -> System.String? EngineVersion
        // GraphQL -> engineVersion: String! (scalar)
        [JsonProperty("engineVersion")]
        public System.String? EngineVersion { get; set; }

        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long! (scalar)
        [JsonProperty("iops")]
        public System.Int64? Iops { get; set; }

        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        [JsonProperty("isMultiAz")]
        public System.Boolean? IsMultiAz { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String! (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String! (scalar)
        [JsonProperty("optionGroupName")]
        public System.String? OptionGroupName { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }

        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String! (scalar)
        [JsonProperty("primaryAz")]
        public System.String? PrimaryAz { get; set; }

        //      C# -> System.String? RdsInstanceArn
        // GraphQL -> rdsInstanceArn: String! (scalar)
        [JsonProperty("rdsInstanceArn")]
        public System.String? RdsInstanceArn { get; set; }

        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        [JsonProperty("storageType")]
        public System.String? StorageType { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RdsInstanceDetailsFromAws";
    }

    public RdsInstanceDetailsFromAws Set(
        System.Int64? AllocatedStorageInGb = null,
        System.Int64? BackupRetentionPeriod = null,
        System.String? DbEngine = null,
        System.String? DbEngineVersion = null,
        System.String? DbInstanceClass = null,
        System.String? DbInstanceStatus = null,
        System.String? DbMaintenanceWindow = null,
        System.String? DbParameterGroupName = null,
        System.String? DbSubnetGroupName = null,
        System.String? EngineVersion = null,
        System.Int64? Iops = null,
        System.Boolean? IsMultiAz = null,
        System.String? KmsKeyId = null,
        System.String? OptionGroupName = null,
        System.Int64? Port = null,
        System.String? PrimaryAz = null,
        System.String? RdsInstanceArn = null,
        System.String? StorageType = null,
        System.String? VpcId = null
    ) 
    {
        if ( AllocatedStorageInGb != null ) {
            this.AllocatedStorageInGb = AllocatedStorageInGb;
        }
        if ( BackupRetentionPeriod != null ) {
            this.BackupRetentionPeriod = BackupRetentionPeriod;
        }
        if ( DbEngine != null ) {
            this.DbEngine = DbEngine;
        }
        if ( DbEngineVersion != null ) {
            this.DbEngineVersion = DbEngineVersion;
        }
        if ( DbInstanceClass != null ) {
            this.DbInstanceClass = DbInstanceClass;
        }
        if ( DbInstanceStatus != null ) {
            this.DbInstanceStatus = DbInstanceStatus;
        }
        if ( DbMaintenanceWindow != null ) {
            this.DbMaintenanceWindow = DbMaintenanceWindow;
        }
        if ( DbParameterGroupName != null ) {
            this.DbParameterGroupName = DbParameterGroupName;
        }
        if ( DbSubnetGroupName != null ) {
            this.DbSubnetGroupName = DbSubnetGroupName;
        }
        if ( EngineVersion != null ) {
            this.EngineVersion = EngineVersion;
        }
        if ( Iops != null ) {
            this.Iops = Iops;
        }
        if ( IsMultiAz != null ) {
            this.IsMultiAz = IsMultiAz;
        }
        if ( KmsKeyId != null ) {
            this.KmsKeyId = KmsKeyId;
        }
        if ( OptionGroupName != null ) {
            this.OptionGroupName = OptionGroupName;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( PrimaryAz != null ) {
            this.PrimaryAz = PrimaryAz;
        }
        if ( RdsInstanceArn != null ) {
            this.RdsInstanceArn = RdsInstanceArn;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
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
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        if (this.AllocatedStorageInGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allocatedStorageInGb\n" ;
            } else {
                s += ind + "allocatedStorageInGb\n" ;
            }
        }
        //      C# -> System.Int64? BackupRetentionPeriod
        // GraphQL -> backupRetentionPeriod: Long! (scalar)
        if (this.BackupRetentionPeriod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupRetentionPeriod\n" ;
            } else {
                s += ind + "backupRetentionPeriod\n" ;
            }
        }
        //      C# -> System.String? DbEngine
        // GraphQL -> dbEngine: String! (scalar)
        if (this.DbEngine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEngine\n" ;
            } else {
                s += ind + "dbEngine\n" ;
            }
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        if (this.DbEngineVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEngineVersion\n" ;
            } else {
                s += ind + "dbEngineVersion\n" ;
            }
        }
        //      C# -> System.String? DbInstanceClass
        // GraphQL -> dbInstanceClass: String! (scalar)
        if (this.DbInstanceClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbInstanceClass\n" ;
            } else {
                s += ind + "dbInstanceClass\n" ;
            }
        }
        //      C# -> System.String? DbInstanceStatus
        // GraphQL -> dbInstanceStatus: String! (scalar)
        if (this.DbInstanceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbInstanceStatus\n" ;
            } else {
                s += ind + "dbInstanceStatus\n" ;
            }
        }
        //      C# -> System.String? DbMaintenanceWindow
        // GraphQL -> dbMaintenanceWindow: String! (scalar)
        if (this.DbMaintenanceWindow != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbMaintenanceWindow\n" ;
            } else {
                s += ind + "dbMaintenanceWindow\n" ;
            }
        }
        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        if (this.DbParameterGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbParameterGroupName\n" ;
            } else {
                s += ind + "dbParameterGroupName\n" ;
            }
        }
        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        if (this.DbSubnetGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbSubnetGroupName\n" ;
            } else {
                s += ind + "dbSubnetGroupName\n" ;
            }
        }
        //      C# -> System.String? EngineVersion
        // GraphQL -> engineVersion: String! (scalar)
        if (this.EngineVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "engineVersion\n" ;
            } else {
                s += ind + "engineVersion\n" ;
            }
        }
        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long! (scalar)
        if (this.Iops != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iops\n" ;
            } else {
                s += ind + "iops\n" ;
            }
        }
        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        if (this.IsMultiAz != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMultiAz\n" ;
            } else {
                s += ind + "isMultiAz\n" ;
            }
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String! (scalar)
        if (this.KmsKeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKeyId\n" ;
            } else {
                s += ind + "kmsKeyId\n" ;
            }
        }
        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String! (scalar)
        if (this.OptionGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "optionGroupName\n" ;
            } else {
                s += ind + "optionGroupName\n" ;
            }
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String! (scalar)
        if (this.PrimaryAz != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryAz\n" ;
            } else {
                s += ind + "primaryAz\n" ;
            }
        }
        //      C# -> System.String? RdsInstanceArn
        // GraphQL -> rdsInstanceArn: String! (scalar)
        if (this.RdsInstanceArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rdsInstanceArn\n" ;
            } else {
                s += ind + "rdsInstanceArn\n" ;
            }
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        if (this.StorageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageType\n" ;
            } else {
                s += ind + "storageType\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        if (ec.Includes("allocatedStorageInGb",true))
        {
            if(this.AllocatedStorageInGb == null) {

                this.AllocatedStorageInGb = new System.Int64();

            } else {


            }
        }
        else if (this.AllocatedStorageInGb != null && ec.Excludes("allocatedStorageInGb",true))
        {
            this.AllocatedStorageInGb = null;
        }
        //      C# -> System.Int64? BackupRetentionPeriod
        // GraphQL -> backupRetentionPeriod: Long! (scalar)
        if (ec.Includes("backupRetentionPeriod",true))
        {
            if(this.BackupRetentionPeriod == null) {

                this.BackupRetentionPeriod = new System.Int64();

            } else {


            }
        }
        else if (this.BackupRetentionPeriod != null && ec.Excludes("backupRetentionPeriod",true))
        {
            this.BackupRetentionPeriod = null;
        }
        //      C# -> System.String? DbEngine
        // GraphQL -> dbEngine: String! (scalar)
        if (ec.Includes("dbEngine",true))
        {
            if(this.DbEngine == null) {

                this.DbEngine = "FETCH";

            } else {


            }
        }
        else if (this.DbEngine != null && ec.Excludes("dbEngine",true))
        {
            this.DbEngine = null;
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        if (ec.Includes("dbEngineVersion",true))
        {
            if(this.DbEngineVersion == null) {

                this.DbEngineVersion = "FETCH";

            } else {


            }
        }
        else if (this.DbEngineVersion != null && ec.Excludes("dbEngineVersion",true))
        {
            this.DbEngineVersion = null;
        }
        //      C# -> System.String? DbInstanceClass
        // GraphQL -> dbInstanceClass: String! (scalar)
        if (ec.Includes("dbInstanceClass",true))
        {
            if(this.DbInstanceClass == null) {

                this.DbInstanceClass = "FETCH";

            } else {


            }
        }
        else if (this.DbInstanceClass != null && ec.Excludes("dbInstanceClass",true))
        {
            this.DbInstanceClass = null;
        }
        //      C# -> System.String? DbInstanceStatus
        // GraphQL -> dbInstanceStatus: String! (scalar)
        if (ec.Includes("dbInstanceStatus",true))
        {
            if(this.DbInstanceStatus == null) {

                this.DbInstanceStatus = "FETCH";

            } else {


            }
        }
        else if (this.DbInstanceStatus != null && ec.Excludes("dbInstanceStatus",true))
        {
            this.DbInstanceStatus = null;
        }
        //      C# -> System.String? DbMaintenanceWindow
        // GraphQL -> dbMaintenanceWindow: String! (scalar)
        if (ec.Includes("dbMaintenanceWindow",true))
        {
            if(this.DbMaintenanceWindow == null) {

                this.DbMaintenanceWindow = "FETCH";

            } else {


            }
        }
        else if (this.DbMaintenanceWindow != null && ec.Excludes("dbMaintenanceWindow",true))
        {
            this.DbMaintenanceWindow = null;
        }
        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        if (ec.Includes("dbParameterGroupName",true))
        {
            if(this.DbParameterGroupName == null) {

                this.DbParameterGroupName = "FETCH";

            } else {


            }
        }
        else if (this.DbParameterGroupName != null && ec.Excludes("dbParameterGroupName",true))
        {
            this.DbParameterGroupName = null;
        }
        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        if (ec.Includes("dbSubnetGroupName",true))
        {
            if(this.DbSubnetGroupName == null) {

                this.DbSubnetGroupName = "FETCH";

            } else {


            }
        }
        else if (this.DbSubnetGroupName != null && ec.Excludes("dbSubnetGroupName",true))
        {
            this.DbSubnetGroupName = null;
        }
        //      C# -> System.String? EngineVersion
        // GraphQL -> engineVersion: String! (scalar)
        if (ec.Includes("engineVersion",true))
        {
            if(this.EngineVersion == null) {

                this.EngineVersion = "FETCH";

            } else {


            }
        }
        else if (this.EngineVersion != null && ec.Excludes("engineVersion",true))
        {
            this.EngineVersion = null;
        }
        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long! (scalar)
        if (ec.Includes("iops",true))
        {
            if(this.Iops == null) {

                this.Iops = new System.Int64();

            } else {


            }
        }
        else if (this.Iops != null && ec.Excludes("iops",true))
        {
            this.Iops = null;
        }
        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        if (ec.Includes("isMultiAz",true))
        {
            if(this.IsMultiAz == null) {

                this.IsMultiAz = true;

            } else {


            }
        }
        else if (this.IsMultiAz != null && ec.Excludes("isMultiAz",true))
        {
            this.IsMultiAz = null;
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String! (scalar)
        if (ec.Includes("kmsKeyId",true))
        {
            if(this.KmsKeyId == null) {

                this.KmsKeyId = "FETCH";

            } else {


            }
        }
        else if (this.KmsKeyId != null && ec.Excludes("kmsKeyId",true))
        {
            this.KmsKeyId = null;
        }
        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String! (scalar)
        if (ec.Includes("optionGroupName",true))
        {
            if(this.OptionGroupName == null) {

                this.OptionGroupName = "FETCH";

            } else {


            }
        }
        else if (this.OptionGroupName != null && ec.Excludes("optionGroupName",true))
        {
            this.OptionGroupName = null;
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = new System.Int64();

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String! (scalar)
        if (ec.Includes("primaryAz",true))
        {
            if(this.PrimaryAz == null) {

                this.PrimaryAz = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryAz != null && ec.Excludes("primaryAz",true))
        {
            this.PrimaryAz = null;
        }
        //      C# -> System.String? RdsInstanceArn
        // GraphQL -> rdsInstanceArn: String! (scalar)
        if (ec.Includes("rdsInstanceArn",true))
        {
            if(this.RdsInstanceArn == null) {

                this.RdsInstanceArn = "FETCH";

            } else {


            }
        }
        else if (this.RdsInstanceArn != null && ec.Excludes("rdsInstanceArn",true))
        {
            this.RdsInstanceArn = null;
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String! (scalar)
        if (ec.Includes("storageType",true))
        {
            if(this.StorageType == null) {

                this.StorageType = "FETCH";

            } else {


            }
        }
        else if (this.StorageType != null && ec.Excludes("storageType",true))
        {
            this.StorageType = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
    }


    #endregion

    } // class RdsInstanceDetailsFromAws
    
    #endregion

    public static class ListRdsInstanceDetailsFromAwsExtensions
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
            this List<RdsInstanceDetailsFromAws> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RdsInstanceDetailsFromAws> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RdsInstanceDetailsFromAws());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RdsInstanceDetailsFromAws> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types