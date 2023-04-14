// RdsInstanceExportDefaults.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region RdsInstanceExportDefaults
    public class RdsInstanceExportDefaults: IFragment
    {
        #region members
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        [JsonProperty("allocatedStorageInGb")]
        public System.Int64? AllocatedStorageInGb { get; set; }

        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        [JsonProperty("dbEngineVersion")]
        public System.String? DbEngineVersion { get; set; }

        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        [JsonProperty("dbParameterGroupName")]
        public System.String? DbParameterGroupName { get; set; }

        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        [JsonProperty("dbSubnetGroupName")]
        public System.String? DbSubnetGroupName { get; set; }

        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
        [JsonProperty("iops")]
        public System.Int32? Iops { get; set; }

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

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        [JsonProperty("dbEngine")]
        public AwsNativeRdsDbEngine? DbEngine { get; set; }

        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        [JsonProperty("dbInstanceClass")]
        public AwsNativeRdsDbInstanceClass? DbInstanceClass { get; set; }

        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
        [JsonProperty("storageType")]
        public AwsNativeRdsStorageType? StorageType { get; set; }

        #endregion

    #region methods

    public RdsInstanceExportDefaults Set(
        System.Int64? AllocatedStorageInGb = null,
        System.String? DbEngineVersion = null,
        System.String? DbParameterGroupName = null,
        System.String? DbSubnetGroupName = null,
        System.Int32? Iops = null,
        System.Boolean? IsMultiAz = null,
        System.String? KmsKeyId = null,
        System.String? OptionGroupName = null,
        System.Int64? Port = null,
        System.String? PrimaryAz = null,
        System.String? VpcId = null,
        AwsNativeRdsDbEngine? DbEngine = null,
        AwsNativeRdsDbInstanceClass? DbInstanceClass = null,
        AwsNativeRdsStorageType? StorageType = null
    ) 
    {
        if ( AllocatedStorageInGb != null ) {
            this.AllocatedStorageInGb = AllocatedStorageInGb;
        }
        if ( DbEngineVersion != null ) {
            this.DbEngineVersion = DbEngineVersion;
        }
        if ( DbParameterGroupName != null ) {
            this.DbParameterGroupName = DbParameterGroupName;
        }
        if ( DbSubnetGroupName != null ) {
            this.DbSubnetGroupName = DbSubnetGroupName;
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
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( DbEngine != null ) {
            this.DbEngine = DbEngine;
        }
        if ( DbInstanceClass != null ) {
            this.DbInstanceClass = DbInstanceClass;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
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
            //      C# -> System.String? DbEngineVersion
            // GraphQL -> dbEngineVersion: String! (scalar)
            if (this.DbEngineVersion != null)
            {
                 s += ind + "dbEngineVersion\n";

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
            //      C# -> System.Int32? Iops
            // GraphQL -> iops: Int! (scalar)
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
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            //      C# -> AwsNativeRdsDbEngine? DbEngine
            // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
            if (this.DbEngine != null)
            {
                 s += ind + "dbEngine\n";

            }
            //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
            // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
            if (this.DbInstanceClass != null)
            {
                 s += ind + "dbInstanceClass\n";

            }
            //      C# -> AwsNativeRdsStorageType? StorageType
            // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
            if (this.StorageType != null)
            {
                 s += ind + "storageType\n";

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
            //      C# -> System.String? DbEngineVersion
            // GraphQL -> dbEngineVersion: String! (scalar)
            if (this.DbEngineVersion == null && Exploration.Includes(parent + ".dbEngineVersion$"))
            {
                this.DbEngineVersion = new System.String("FETCH");
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
            //      C# -> System.Int32? Iops
            // GraphQL -> iops: Int! (scalar)
            if (this.Iops == null && Exploration.Includes(parent + ".iops$"))
            {
                this.Iops = new System.Int32();
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
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
            //      C# -> AwsNativeRdsDbEngine? DbEngine
            // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
            if (this.DbEngine == null && Exploration.Includes(parent + ".dbEngine$"))
            {
                this.DbEngine = new AwsNativeRdsDbEngine();
            }
            //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
            // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
            if (this.DbInstanceClass == null && Exploration.Includes(parent + ".dbInstanceClass$"))
            {
                this.DbInstanceClass = new AwsNativeRdsDbInstanceClass();
            }
            //      C# -> AwsNativeRdsStorageType? StorageType
            // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
            if (this.StorageType == null && Exploration.Includes(parent + ".storageType$"))
            {
                this.StorageType = new AwsNativeRdsStorageType();
            }
        }


    #endregion

    } // class RdsInstanceExportDefaults
    #endregion

    public static class ListRdsInstanceExportDefaultsExtensions
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
            this List<RdsInstanceExportDefaults> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RdsInstanceExportDefaults> list, 
            String parent = "")
        {
            var item = new RdsInstanceExportDefaults();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types