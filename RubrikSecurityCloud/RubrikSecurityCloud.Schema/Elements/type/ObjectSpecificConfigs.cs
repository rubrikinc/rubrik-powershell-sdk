// ObjectSpecificConfigs.cs
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
    #region ObjectSpecificConfigs
    public class ObjectSpecificConfigs: IFragment
    {
        #region members
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        [JsonProperty("awsNativeS3SlaConfig")]
        public AwsNativeS3SlaConfig? AwsNativeS3SlaConfig { get; set; }

        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        [JsonProperty("awsRdsConfig")]
        public AwsRdsConfig? AwsRdsConfig { get; set; }

        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        [JsonProperty("azureBlobConfig")]
        public AzureBlobConfig? AzureBlobConfig { get; set; }

        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        [JsonProperty("azureSqlDatabaseDbConfig")]
        public AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig { get; set; }

        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        [JsonProperty("azureSqlManagedInstanceDbConfig")]
        public AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig { get; set; }

        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        [JsonProperty("db2Config")]
        public Db2Config? Db2Config { get; set; }

        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        [JsonProperty("mongoConfig")]
        public MongoConfig? MongoConfig { get; set; }

        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        [JsonProperty("mssqlConfig")]
        public MssqlConfig? MssqlConfig { get; set; }

        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        [JsonProperty("oracleConfig")]
        public OracleConfig? OracleConfig { get; set; }

        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        [JsonProperty("sapHanaConfig")]
        public SapHanaConfig? SapHanaConfig { get; set; }

        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        [JsonProperty("vmwareVmConfig")]
        public VmwareVmConfig? VmwareVmConfig { get; set; }

        #endregion

    #region methods

    public ObjectSpecificConfigs Set(
        AwsNativeS3SlaConfig? AwsNativeS3SlaConfig = null,
        AwsRdsConfig? AwsRdsConfig = null,
        AzureBlobConfig? AzureBlobConfig = null,
        AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig = null,
        AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig = null,
        Db2Config? Db2Config = null,
        MongoConfig? MongoConfig = null,
        MssqlConfig? MssqlConfig = null,
        OracleConfig? OracleConfig = null,
        SapHanaConfig? SapHanaConfig = null,
        VmwareVmConfig? VmwareVmConfig = null
    ) 
    {
        if ( AwsNativeS3SlaConfig != null ) {
            this.AwsNativeS3SlaConfig = AwsNativeS3SlaConfig;
        }
        if ( AwsRdsConfig != null ) {
            this.AwsRdsConfig = AwsRdsConfig;
        }
        if ( AzureBlobConfig != null ) {
            this.AzureBlobConfig = AzureBlobConfig;
        }
        if ( AzureSqlDatabaseDbConfig != null ) {
            this.AzureSqlDatabaseDbConfig = AzureSqlDatabaseDbConfig;
        }
        if ( AzureSqlManagedInstanceDbConfig != null ) {
            this.AzureSqlManagedInstanceDbConfig = AzureSqlManagedInstanceDbConfig;
        }
        if ( Db2Config != null ) {
            this.Db2Config = Db2Config;
        }
        if ( MongoConfig != null ) {
            this.MongoConfig = MongoConfig;
        }
        if ( MssqlConfig != null ) {
            this.MssqlConfig = MssqlConfig;
        }
        if ( OracleConfig != null ) {
            this.OracleConfig = OracleConfig;
        }
        if ( SapHanaConfig != null ) {
            this.SapHanaConfig = SapHanaConfig;
        }
        if ( VmwareVmConfig != null ) {
            this.VmwareVmConfig = VmwareVmConfig;
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
            //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
            // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
            if (this.AwsNativeS3SlaConfig != null)
            {
                 s += ind + "awsNativeS3SlaConfig\n";

                 s += ind + "{\n" + 
                 this.AwsNativeS3SlaConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsRdsConfig? AwsRdsConfig
            // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
            if (this.AwsRdsConfig != null)
            {
                 s += ind + "awsRdsConfig\n";

                 s += ind + "{\n" + 
                 this.AwsRdsConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureBlobConfig? AzureBlobConfig
            // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
            if (this.AzureBlobConfig != null)
            {
                 s += ind + "azureBlobConfig\n";

                 s += ind + "{\n" + 
                 this.AzureBlobConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
            // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
            if (this.AzureSqlDatabaseDbConfig != null)
            {
                 s += ind + "azureSqlDatabaseDbConfig\n";

                 s += ind + "{\n" + 
                 this.AzureSqlDatabaseDbConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
            // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
            if (this.AzureSqlManagedInstanceDbConfig != null)
            {
                 s += ind + "azureSqlManagedInstanceDbConfig\n";

                 s += ind + "{\n" + 
                 this.AzureSqlManagedInstanceDbConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Db2Config? Db2Config
            // GraphQL -> db2Config: Db2Config (type)
            if (this.Db2Config != null)
            {
                 s += ind + "db2Config\n";

                 s += ind + "{\n" + 
                 this.Db2Config.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MongoConfig? MongoConfig
            // GraphQL -> mongoConfig: MongoConfig (type)
            if (this.MongoConfig != null)
            {
                 s += ind + "mongoConfig\n";

                 s += ind + "{\n" + 
                 this.MongoConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlConfig? MssqlConfig
            // GraphQL -> mssqlConfig: MssqlConfig (type)
            if (this.MssqlConfig != null)
            {
                 s += ind + "mssqlConfig\n";

                 s += ind + "{\n" + 
                 this.MssqlConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleConfig? OracleConfig
            // GraphQL -> oracleConfig: OracleConfig (type)
            if (this.OracleConfig != null)
            {
                 s += ind + "oracleConfig\n";

                 s += ind + "{\n" + 
                 this.OracleConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SapHanaConfig? SapHanaConfig
            // GraphQL -> sapHanaConfig: SapHanaConfig (type)
            if (this.SapHanaConfig != null)
            {
                 s += ind + "sapHanaConfig\n";

                 s += ind + "{\n" + 
                 this.SapHanaConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VmwareVmConfig? VmwareVmConfig
            // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
            if (this.VmwareVmConfig != null)
            {
                 s += ind + "vmwareVmConfig\n";

                 s += ind + "{\n" + 
                 this.VmwareVmConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
            // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
            if (this.AwsNativeS3SlaConfig == null && Exploration.Includes(parent + ".awsNativeS3SlaConfig"))
            {
                this.AwsNativeS3SlaConfig = new AwsNativeS3SlaConfig();
                this.AwsNativeS3SlaConfig.ApplyExploratoryFragment(parent + ".awsNativeS3SlaConfig");
            }
            //      C# -> AwsRdsConfig? AwsRdsConfig
            // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
            if (this.AwsRdsConfig == null && Exploration.Includes(parent + ".awsRdsConfig"))
            {
                this.AwsRdsConfig = new AwsRdsConfig();
                this.AwsRdsConfig.ApplyExploratoryFragment(parent + ".awsRdsConfig");
            }
            //      C# -> AzureBlobConfig? AzureBlobConfig
            // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
            if (this.AzureBlobConfig == null && Exploration.Includes(parent + ".azureBlobConfig"))
            {
                this.AzureBlobConfig = new AzureBlobConfig();
                this.AzureBlobConfig.ApplyExploratoryFragment(parent + ".azureBlobConfig");
            }
            //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
            // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
            if (this.AzureSqlDatabaseDbConfig == null && Exploration.Includes(parent + ".azureSqlDatabaseDbConfig"))
            {
                this.AzureSqlDatabaseDbConfig = new AzureSqlDatabaseDbConfig();
                this.AzureSqlDatabaseDbConfig.ApplyExploratoryFragment(parent + ".azureSqlDatabaseDbConfig");
            }
            //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
            // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
            if (this.AzureSqlManagedInstanceDbConfig == null && Exploration.Includes(parent + ".azureSqlManagedInstanceDbConfig"))
            {
                this.AzureSqlManagedInstanceDbConfig = new AzureSqlManagedInstanceDbConfig();
                this.AzureSqlManagedInstanceDbConfig.ApplyExploratoryFragment(parent + ".azureSqlManagedInstanceDbConfig");
            }
            //      C# -> Db2Config? Db2Config
            // GraphQL -> db2Config: Db2Config (type)
            if (this.Db2Config == null && Exploration.Includes(parent + ".db2Config"))
            {
                this.Db2Config = new Db2Config();
                this.Db2Config.ApplyExploratoryFragment(parent + ".db2Config");
            }
            //      C# -> MongoConfig? MongoConfig
            // GraphQL -> mongoConfig: MongoConfig (type)
            if (this.MongoConfig == null && Exploration.Includes(parent + ".mongoConfig"))
            {
                this.MongoConfig = new MongoConfig();
                this.MongoConfig.ApplyExploratoryFragment(parent + ".mongoConfig");
            }
            //      C# -> MssqlConfig? MssqlConfig
            // GraphQL -> mssqlConfig: MssqlConfig (type)
            if (this.MssqlConfig == null && Exploration.Includes(parent + ".mssqlConfig"))
            {
                this.MssqlConfig = new MssqlConfig();
                this.MssqlConfig.ApplyExploratoryFragment(parent + ".mssqlConfig");
            }
            //      C# -> OracleConfig? OracleConfig
            // GraphQL -> oracleConfig: OracleConfig (type)
            if (this.OracleConfig == null && Exploration.Includes(parent + ".oracleConfig"))
            {
                this.OracleConfig = new OracleConfig();
                this.OracleConfig.ApplyExploratoryFragment(parent + ".oracleConfig");
            }
            //      C# -> SapHanaConfig? SapHanaConfig
            // GraphQL -> sapHanaConfig: SapHanaConfig (type)
            if (this.SapHanaConfig == null && Exploration.Includes(parent + ".sapHanaConfig"))
            {
                this.SapHanaConfig = new SapHanaConfig();
                this.SapHanaConfig.ApplyExploratoryFragment(parent + ".sapHanaConfig");
            }
            //      C# -> VmwareVmConfig? VmwareVmConfig
            // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
            if (this.VmwareVmConfig == null && Exploration.Includes(parent + ".vmwareVmConfig"))
            {
                this.VmwareVmConfig = new VmwareVmConfig();
                this.VmwareVmConfig.ApplyExploratoryFragment(parent + ".vmwareVmConfig");
            }
        }


    #endregion

    } // class ObjectSpecificConfigs
    #endregion

    public static class ListObjectSpecificConfigsExtensions
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
            this List<ObjectSpecificConfigs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ObjectSpecificConfigs> list, 
            String parent = "")
        {
            var item = new ObjectSpecificConfigs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types