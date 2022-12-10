// RdsInstanceDetailsFromAws.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:11.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region RdsInstanceDetailsFromAws
    public class RdsInstanceDetailsFromAws: IFragment
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

    public RdsInstanceDetailsFromAws Set(
        System.Int64? AllocatedStorageInGb = null,
        System.Int64? BackupRetentionPeriod = null,
        System.String? DbEngine = null,
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? AllocatedStorageInGb
            // GraphQL -> allocatedStorageInGb: Long! (scalar)
            if (this.AllocatedStorageInGb != null)
            {
                 s += ind + "allocatedStorageInGb\n";

            }
            //      C# -> System.Int64? BackupRetentionPeriod
            // GraphQL -> backupRetentionPeriod: Long! (scalar)
            if (this.BackupRetentionPeriod != null)
            {
                 s += ind + "backupRetentionPeriod\n";

            }
            //      C# -> System.String? DbEngine
            // GraphQL -> dbEngine: String! (scalar)
            if (this.DbEngine != null)
            {
                 s += ind + "dbEngine\n";

            }
            //      C# -> System.String? DbInstanceClass
            // GraphQL -> dbInstanceClass: String! (scalar)
            if (this.DbInstanceClass != null)
            {
                 s += ind + "dbInstanceClass\n";

            }
            //      C# -> System.String? DbInstanceStatus
            // GraphQL -> dbInstanceStatus: String! (scalar)
            if (this.DbInstanceStatus != null)
            {
                 s += ind + "dbInstanceStatus\n";

            }
            //      C# -> System.String? DbMaintenanceWindow
            // GraphQL -> dbMaintenanceWindow: String! (scalar)
            if (this.DbMaintenanceWindow != null)
            {
                 s += ind + "dbMaintenanceWindow\n";

            }
            //      C# -> System.String? DbParameterGroupName
            // GraphQL -> dbParameterGroupName: String! (scalar)
            if (this.DbParameterGroupName != null)
            {
                 s += ind + "dbParameterGroupName\n";

            }
            //      C# -> System.String? DbSubnetGroupName
            // GraphQL -> dbSubnetGroupName: String! (scalar)
            if (this.DbSubnetGroupName != null)
            {
                 s += ind + "dbSubnetGroupName\n";

            }
            //      C# -> System.String? EngineVersion
            // GraphQL -> engineVersion: String! (scalar)
            if (this.EngineVersion != null)
            {
                 s += ind + "engineVersion\n";

            }
            //      C# -> System.Int64? Iops
            // GraphQL -> iops: Long! (scalar)
            if (this.Iops != null)
            {
                 s += ind + "iops\n";

            }
            //      C# -> System.Boolean? IsMultiAz
            // GraphQL -> isMultiAz: Boolean! (scalar)
            if (this.IsMultiAz != null)
            {
                 s += ind + "isMultiAz\n";

            }
            //      C# -> System.String? KmsKeyId
            // GraphQL -> kmsKeyId: String! (scalar)
            if (this.KmsKeyId != null)
            {
                 s += ind + "kmsKeyId\n";

            }
            //      C# -> System.String? OptionGroupName
            // GraphQL -> optionGroupName: String! (scalar)
            if (this.OptionGroupName != null)
            {
                 s += ind + "optionGroupName\n";

            }
            //      C# -> System.Int64? Port
            // GraphQL -> port: Long! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> System.String? PrimaryAz
            // GraphQL -> primaryAz: String! (scalar)
            if (this.PrimaryAz != null)
            {
                 s += ind + "primaryAz\n";

            }
            //      C# -> System.String? RdsInstanceArn
            // GraphQL -> rdsInstanceArn: String! (scalar)
            if (this.RdsInstanceArn != null)
            {
                 s += ind + "rdsInstanceArn\n";

            }
            //      C# -> System.String? StorageType
            // GraphQL -> storageType: String! (scalar)
            if (this.StorageType != null)
            {
                 s += ind + "storageType\n";

            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? AllocatedStorageInGb
            // GraphQL -> allocatedStorageInGb: Long! (scalar)
            if (this.AllocatedStorageInGb == null && Exploration.Includes(parent + ".allocatedStorageInGb$"))
            {
                this.AllocatedStorageInGb = new System.Int64();
            }
            //      C# -> System.Int64? BackupRetentionPeriod
            // GraphQL -> backupRetentionPeriod: Long! (scalar)
            if (this.BackupRetentionPeriod == null && Exploration.Includes(parent + ".backupRetentionPeriod$"))
            {
                this.BackupRetentionPeriod = new System.Int64();
            }
            //      C# -> System.String? DbEngine
            // GraphQL -> dbEngine: String! (scalar)
            if (this.DbEngine == null && Exploration.Includes(parent + ".dbEngine$"))
            {
                this.DbEngine = new System.String("FETCH");
            }
            //      C# -> System.String? DbInstanceClass
            // GraphQL -> dbInstanceClass: String! (scalar)
            if (this.DbInstanceClass == null && Exploration.Includes(parent + ".dbInstanceClass$"))
            {
                this.DbInstanceClass = new System.String("FETCH");
            }
            //      C# -> System.String? DbInstanceStatus
            // GraphQL -> dbInstanceStatus: String! (scalar)
            if (this.DbInstanceStatus == null && Exploration.Includes(parent + ".dbInstanceStatus$"))
            {
                this.DbInstanceStatus = new System.String("FETCH");
            }
            //      C# -> System.String? DbMaintenanceWindow
            // GraphQL -> dbMaintenanceWindow: String! (scalar)
            if (this.DbMaintenanceWindow == null && Exploration.Includes(parent + ".dbMaintenanceWindow$"))
            {
                this.DbMaintenanceWindow = new System.String("FETCH");
            }
            //      C# -> System.String? DbParameterGroupName
            // GraphQL -> dbParameterGroupName: String! (scalar)
            if (this.DbParameterGroupName == null && Exploration.Includes(parent + ".dbParameterGroupName$"))
            {
                this.DbParameterGroupName = new System.String("FETCH");
            }
            //      C# -> System.String? DbSubnetGroupName
            // GraphQL -> dbSubnetGroupName: String! (scalar)
            if (this.DbSubnetGroupName == null && Exploration.Includes(parent + ".dbSubnetGroupName$"))
            {
                this.DbSubnetGroupName = new System.String("FETCH");
            }
            //      C# -> System.String? EngineVersion
            // GraphQL -> engineVersion: String! (scalar)
            if (this.EngineVersion == null && Exploration.Includes(parent + ".engineVersion$"))
            {
                this.EngineVersion = new System.String("FETCH");
            }
            //      C# -> System.Int64? Iops
            // GraphQL -> iops: Long! (scalar)
            if (this.Iops == null && Exploration.Includes(parent + ".iops$"))
            {
                this.Iops = new System.Int64();
            }
            //      C# -> System.Boolean? IsMultiAz
            // GraphQL -> isMultiAz: Boolean! (scalar)
            if (this.IsMultiAz == null && Exploration.Includes(parent + ".isMultiAz$"))
            {
                this.IsMultiAz = new System.Boolean();
            }
            //      C# -> System.String? KmsKeyId
            // GraphQL -> kmsKeyId: String! (scalar)
            if (this.KmsKeyId == null && Exploration.Includes(parent + ".kmsKeyId$"))
            {
                this.KmsKeyId = new System.String("FETCH");
            }
            //      C# -> System.String? OptionGroupName
            // GraphQL -> optionGroupName: String! (scalar)
            if (this.OptionGroupName == null && Exploration.Includes(parent + ".optionGroupName$"))
            {
                this.OptionGroupName = new System.String("FETCH");
            }
            //      C# -> System.Int64? Port
            // GraphQL -> port: Long! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int64();
            }
            //      C# -> System.String? PrimaryAz
            // GraphQL -> primaryAz: String! (scalar)
            if (this.PrimaryAz == null && Exploration.Includes(parent + ".primaryAz$"))
            {
                this.PrimaryAz = new System.String("FETCH");
            }
            //      C# -> System.String? RdsInstanceArn
            // GraphQL -> rdsInstanceArn: String! (scalar)
            if (this.RdsInstanceArn == null && Exploration.Includes(parent + ".rdsInstanceArn$"))
            {
                this.RdsInstanceArn = new System.String("FETCH");
            }
            //      C# -> System.String? StorageType
            // GraphQL -> storageType: String! (scalar)
            if (this.StorageType == null && Exploration.Includes(parent + ".storageType$"))
            {
                this.StorageType = new System.String("FETCH");
            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
        }


    #endregion

    } // class RdsInstanceDetailsFromAws
    #endregion

    public static class ListRdsInstanceDetailsFromAwsExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<RdsInstanceDetailsFromAws> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RdsInstanceDetailsFromAws> list, 
            String parent = "")
        {
            var item = new RdsInstanceDetailsFromAws();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types