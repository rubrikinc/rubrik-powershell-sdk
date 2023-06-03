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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ObjectSpecificConfigs
    public class ObjectSpecificConfigs: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        if (this.AwsNativeS3SlaConfig != null) {
            s += ind + "awsNativeS3SlaConfig {\n" + this.AwsNativeS3SlaConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (this.AwsRdsConfig != null) {
            s += ind + "awsRdsConfig {\n" + this.AwsRdsConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (this.AzureBlobConfig != null) {
            s += ind + "azureBlobConfig {\n" + this.AzureBlobConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (this.AzureSqlDatabaseDbConfig != null) {
            s += ind + "azureSqlDatabaseDbConfig {\n" + this.AzureSqlDatabaseDbConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (this.AzureSqlManagedInstanceDbConfig != null) {
            s += ind + "azureSqlManagedInstanceDbConfig {\n" + this.AzureSqlManagedInstanceDbConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (this.Db2Config != null) {
            s += ind + "db2Config {\n" + this.Db2Config.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (this.MongoConfig != null) {
            s += ind + "mongoConfig {\n" + this.MongoConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (this.MssqlConfig != null) {
            s += ind + "mssqlConfig {\n" + this.MssqlConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (this.OracleConfig != null) {
            s += ind + "oracleConfig {\n" + this.OracleConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (this.SapHanaConfig != null) {
            s += ind + "sapHanaConfig {\n" + this.SapHanaConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (this.VmwareVmConfig != null) {
            s += ind + "vmwareVmConfig {\n" + this.VmwareVmConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        if (this.AwsNativeS3SlaConfig == null && Exploration.Includes(parent + ".awsNativeS3SlaConfig"))
        {
            this.AwsNativeS3SlaConfig = new AwsNativeS3SlaConfig();
            this.AwsNativeS3SlaConfig.ApplyExploratoryFieldSpec(parent + ".awsNativeS3SlaConfig");
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (this.AwsRdsConfig == null && Exploration.Includes(parent + ".awsRdsConfig"))
        {
            this.AwsRdsConfig = new AwsRdsConfig();
            this.AwsRdsConfig.ApplyExploratoryFieldSpec(parent + ".awsRdsConfig");
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (this.AzureBlobConfig == null && Exploration.Includes(parent + ".azureBlobConfig"))
        {
            this.AzureBlobConfig = new AzureBlobConfig();
            this.AzureBlobConfig.ApplyExploratoryFieldSpec(parent + ".azureBlobConfig");
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (this.AzureSqlDatabaseDbConfig == null && Exploration.Includes(parent + ".azureSqlDatabaseDbConfig"))
        {
            this.AzureSqlDatabaseDbConfig = new AzureSqlDatabaseDbConfig();
            this.AzureSqlDatabaseDbConfig.ApplyExploratoryFieldSpec(parent + ".azureSqlDatabaseDbConfig");
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (this.AzureSqlManagedInstanceDbConfig == null && Exploration.Includes(parent + ".azureSqlManagedInstanceDbConfig"))
        {
            this.AzureSqlManagedInstanceDbConfig = new AzureSqlManagedInstanceDbConfig();
            this.AzureSqlManagedInstanceDbConfig.ApplyExploratoryFieldSpec(parent + ".azureSqlManagedInstanceDbConfig");
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (this.Db2Config == null && Exploration.Includes(parent + ".db2Config"))
        {
            this.Db2Config = new Db2Config();
            this.Db2Config.ApplyExploratoryFieldSpec(parent + ".db2Config");
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (this.MongoConfig == null && Exploration.Includes(parent + ".mongoConfig"))
        {
            this.MongoConfig = new MongoConfig();
            this.MongoConfig.ApplyExploratoryFieldSpec(parent + ".mongoConfig");
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (this.MssqlConfig == null && Exploration.Includes(parent + ".mssqlConfig"))
        {
            this.MssqlConfig = new MssqlConfig();
            this.MssqlConfig.ApplyExploratoryFieldSpec(parent + ".mssqlConfig");
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (this.OracleConfig == null && Exploration.Includes(parent + ".oracleConfig"))
        {
            this.OracleConfig = new OracleConfig();
            this.OracleConfig.ApplyExploratoryFieldSpec(parent + ".oracleConfig");
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (this.SapHanaConfig == null && Exploration.Includes(parent + ".sapHanaConfig"))
        {
            this.SapHanaConfig = new SapHanaConfig();
            this.SapHanaConfig.ApplyExploratoryFieldSpec(parent + ".sapHanaConfig");
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (this.VmwareVmConfig == null && Exploration.Includes(parent + ".vmwareVmConfig"))
        {
            this.VmwareVmConfig = new VmwareVmConfig();
            this.VmwareVmConfig.ApplyExploratoryFieldSpec(parent + ".vmwareVmConfig");
        }
    }


    #endregion

    } // class ObjectSpecificConfigs
    
    #endregion

    public static class ListObjectSpecificConfigsExtensions
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
            this List<ObjectSpecificConfigs> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ObjectSpecificConfigs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectSpecificConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types