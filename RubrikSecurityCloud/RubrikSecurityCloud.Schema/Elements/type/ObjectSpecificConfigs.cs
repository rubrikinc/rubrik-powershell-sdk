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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> ManagedVolumeSlaConfig? ManagedVolumeSlaConfig
        // GraphQL -> managedVolumeSlaConfig: ManagedVolumeSlaConfig (type)
        [JsonProperty("managedVolumeSlaConfig")]
        public ManagedVolumeSlaConfig? ManagedVolumeSlaConfig { get; set; }

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

    public override string GetGqlTypeName() {
        return "ObjectSpecificConfigs";
    }

    public ObjectSpecificConfigs Set(
        AwsNativeS3SlaConfig? AwsNativeS3SlaConfig = null,
        AwsRdsConfig? AwsRdsConfig = null,
        AzureBlobConfig? AzureBlobConfig = null,
        AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig = null,
        AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig = null,
        Db2Config? Db2Config = null,
        ManagedVolumeSlaConfig? ManagedVolumeSlaConfig = null,
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
        if ( ManagedVolumeSlaConfig != null ) {
            this.ManagedVolumeSlaConfig = ManagedVolumeSlaConfig;
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
            var fspec = this.AwsNativeS3SlaConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsNativeS3SlaConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (this.AwsRdsConfig != null) {
            var fspec = this.AwsRdsConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsRdsConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (this.AzureBlobConfig != null) {
            var fspec = this.AzureBlobConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureBlobConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (this.AzureSqlDatabaseDbConfig != null) {
            var fspec = this.AzureSqlDatabaseDbConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureSqlDatabaseDbConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (this.AzureSqlManagedInstanceDbConfig != null) {
            var fspec = this.AzureSqlManagedInstanceDbConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureSqlManagedInstanceDbConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (this.Db2Config != null) {
            var fspec = this.Db2Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2Config {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSlaConfig? ManagedVolumeSlaConfig
        // GraphQL -> managedVolumeSlaConfig: ManagedVolumeSlaConfig (type)
        if (this.ManagedVolumeSlaConfig != null) {
            var fspec = this.ManagedVolumeSlaConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumeSlaConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (this.MongoConfig != null) {
            var fspec = this.MongoConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mongoConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (this.MssqlConfig != null) {
            var fspec = this.MssqlConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mssqlConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (this.OracleConfig != null) {
            var fspec = this.OracleConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (this.SapHanaConfig != null) {
            var fspec = this.SapHanaConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sapHanaConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (this.VmwareVmConfig != null) {
            var fspec = this.VmwareVmConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareVmConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        if (this.AwsNativeS3SlaConfig == null && ec.Includes("awsNativeS3SlaConfig",false))
        {
            this.AwsNativeS3SlaConfig = new AwsNativeS3SlaConfig();
            this.AwsNativeS3SlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeS3SlaConfig"));
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (this.AwsRdsConfig == null && ec.Includes("awsRdsConfig",false))
        {
            this.AwsRdsConfig = new AwsRdsConfig();
            this.AwsRdsConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsRdsConfig"));
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (this.AzureBlobConfig == null && ec.Includes("azureBlobConfig",false))
        {
            this.AzureBlobConfig = new AzureBlobConfig();
            this.AzureBlobConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureBlobConfig"));
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (this.AzureSqlDatabaseDbConfig == null && ec.Includes("azureSqlDatabaseDbConfig",false))
        {
            this.AzureSqlDatabaseDbConfig = new AzureSqlDatabaseDbConfig();
            this.AzureSqlDatabaseDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlDatabaseDbConfig"));
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (this.AzureSqlManagedInstanceDbConfig == null && ec.Includes("azureSqlManagedInstanceDbConfig",false))
        {
            this.AzureSqlManagedInstanceDbConfig = new AzureSqlManagedInstanceDbConfig();
            this.AzureSqlManagedInstanceDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlManagedInstanceDbConfig"));
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (this.Db2Config == null && ec.Includes("db2Config",false))
        {
            this.Db2Config = new Db2Config();
            this.Db2Config.ApplyExploratoryFieldSpec(ec.NewChild("db2Config"));
        }
        //      C# -> ManagedVolumeSlaConfig? ManagedVolumeSlaConfig
        // GraphQL -> managedVolumeSlaConfig: ManagedVolumeSlaConfig (type)
        if (this.ManagedVolumeSlaConfig == null && ec.Includes("managedVolumeSlaConfig",false))
        {
            this.ManagedVolumeSlaConfig = new ManagedVolumeSlaConfig();
            this.ManagedVolumeSlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSlaConfig"));
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (this.MongoConfig == null && ec.Includes("mongoConfig",false))
        {
            this.MongoConfig = new MongoConfig();
            this.MongoConfig.ApplyExploratoryFieldSpec(ec.NewChild("mongoConfig"));
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (this.MssqlConfig == null && ec.Includes("mssqlConfig",false))
        {
            this.MssqlConfig = new MssqlConfig();
            this.MssqlConfig.ApplyExploratoryFieldSpec(ec.NewChild("mssqlConfig"));
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (this.OracleConfig == null && ec.Includes("oracleConfig",false))
        {
            this.OracleConfig = new OracleConfig();
            this.OracleConfig.ApplyExploratoryFieldSpec(ec.NewChild("oracleConfig"));
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (this.SapHanaConfig == null && ec.Includes("sapHanaConfig",false))
        {
            this.SapHanaConfig = new SapHanaConfig();
            this.SapHanaConfig.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaConfig"));
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (this.VmwareVmConfig == null && ec.Includes("vmwareVmConfig",false))
        {
            this.VmwareVmConfig = new VmwareVmConfig();
            this.VmwareVmConfig.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmConfig"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ObjectSpecificConfigs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectSpecificConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectSpecificConfigs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types