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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        if (this.AwsNativeS3SlaConfig != null) {
            var fspec = this.AwsNativeS3SlaConfig.AsFieldSpec(conf.Child("awsNativeS3SlaConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeS3SlaConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (this.AwsRdsConfig != null) {
            var fspec = this.AwsRdsConfig.AsFieldSpec(conf.Child("awsRdsConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsRdsConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (this.AzureBlobConfig != null) {
            var fspec = this.AzureBlobConfig.AsFieldSpec(conf.Child("azureBlobConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureBlobConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (this.AzureSqlDatabaseDbConfig != null) {
            var fspec = this.AzureSqlDatabaseDbConfig.AsFieldSpec(conf.Child("azureSqlDatabaseDbConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSqlDatabaseDbConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (this.AzureSqlManagedInstanceDbConfig != null) {
            var fspec = this.AzureSqlManagedInstanceDbConfig.AsFieldSpec(conf.Child("azureSqlManagedInstanceDbConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSqlManagedInstanceDbConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (this.Db2Config != null) {
            var fspec = this.Db2Config.AsFieldSpec(conf.Child("db2Config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "db2Config {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSlaConfig? ManagedVolumeSlaConfig
        // GraphQL -> managedVolumeSlaConfig: ManagedVolumeSlaConfig (type)
        if (this.ManagedVolumeSlaConfig != null) {
            var fspec = this.ManagedVolumeSlaConfig.AsFieldSpec(conf.Child("managedVolumeSlaConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeSlaConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (this.MongoConfig != null) {
            var fspec = this.MongoConfig.AsFieldSpec(conf.Child("mongoConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mongoConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (this.MssqlConfig != null) {
            var fspec = this.MssqlConfig.AsFieldSpec(conf.Child("mssqlConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (this.OracleConfig != null) {
            var fspec = this.OracleConfig.AsFieldSpec(conf.Child("oracleConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (this.SapHanaConfig != null) {
            var fspec = this.SapHanaConfig.AsFieldSpec(conf.Child("sapHanaConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sapHanaConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (this.VmwareVmConfig != null) {
            var fspec = this.VmwareVmConfig.AsFieldSpec(conf.Child("vmwareVmConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVmConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsNativeS3SlaConfig? AwsNativeS3SlaConfig
        // GraphQL -> awsNativeS3SlaConfig: AwsNativeS3SlaConfig (type)
        if (ec.Includes("awsNativeS3SlaConfig",false))
        {
            if(this.AwsNativeS3SlaConfig == null) {

                this.AwsNativeS3SlaConfig = new AwsNativeS3SlaConfig();
                this.AwsNativeS3SlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeS3SlaConfig"));

            } else {

                this.AwsNativeS3SlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeS3SlaConfig"));

            }
        }
        else if (this.AwsNativeS3SlaConfig != null && ec.Excludes("awsNativeS3SlaConfig",false))
        {
            this.AwsNativeS3SlaConfig = null;
        }
        //      C# -> AwsRdsConfig? AwsRdsConfig
        // GraphQL -> awsRdsConfig: AwsRdsConfig (type)
        if (ec.Includes("awsRdsConfig",false))
        {
            if(this.AwsRdsConfig == null) {

                this.AwsRdsConfig = new AwsRdsConfig();
                this.AwsRdsConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsRdsConfig"));

            } else {

                this.AwsRdsConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsRdsConfig"));

            }
        }
        else if (this.AwsRdsConfig != null && ec.Excludes("awsRdsConfig",false))
        {
            this.AwsRdsConfig = null;
        }
        //      C# -> AzureBlobConfig? AzureBlobConfig
        // GraphQL -> azureBlobConfig: AzureBlobConfig (type)
        if (ec.Includes("azureBlobConfig",false))
        {
            if(this.AzureBlobConfig == null) {

                this.AzureBlobConfig = new AzureBlobConfig();
                this.AzureBlobConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureBlobConfig"));

            } else {

                this.AzureBlobConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureBlobConfig"));

            }
        }
        else if (this.AzureBlobConfig != null && ec.Excludes("azureBlobConfig",false))
        {
            this.AzureBlobConfig = null;
        }
        //      C# -> AzureSqlDatabaseDbConfig? AzureSqlDatabaseDbConfig
        // GraphQL -> azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig (type)
        if (ec.Includes("azureSqlDatabaseDbConfig",false))
        {
            if(this.AzureSqlDatabaseDbConfig == null) {

                this.AzureSqlDatabaseDbConfig = new AzureSqlDatabaseDbConfig();
                this.AzureSqlDatabaseDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlDatabaseDbConfig"));

            } else {

                this.AzureSqlDatabaseDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlDatabaseDbConfig"));

            }
        }
        else if (this.AzureSqlDatabaseDbConfig != null && ec.Excludes("azureSqlDatabaseDbConfig",false))
        {
            this.AzureSqlDatabaseDbConfig = null;
        }
        //      C# -> AzureSqlManagedInstanceDbConfig? AzureSqlManagedInstanceDbConfig
        // GraphQL -> azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig (type)
        if (ec.Includes("azureSqlManagedInstanceDbConfig",false))
        {
            if(this.AzureSqlManagedInstanceDbConfig == null) {

                this.AzureSqlManagedInstanceDbConfig = new AzureSqlManagedInstanceDbConfig();
                this.AzureSqlManagedInstanceDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlManagedInstanceDbConfig"));

            } else {

                this.AzureSqlManagedInstanceDbConfig.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlManagedInstanceDbConfig"));

            }
        }
        else if (this.AzureSqlManagedInstanceDbConfig != null && ec.Excludes("azureSqlManagedInstanceDbConfig",false))
        {
            this.AzureSqlManagedInstanceDbConfig = null;
        }
        //      C# -> Db2Config? Db2Config
        // GraphQL -> db2Config: Db2Config (type)
        if (ec.Includes("db2Config",false))
        {
            if(this.Db2Config == null) {

                this.Db2Config = new Db2Config();
                this.Db2Config.ApplyExploratoryFieldSpec(ec.NewChild("db2Config"));

            } else {

                this.Db2Config.ApplyExploratoryFieldSpec(ec.NewChild("db2Config"));

            }
        }
        else if (this.Db2Config != null && ec.Excludes("db2Config",false))
        {
            this.Db2Config = null;
        }
        //      C# -> ManagedVolumeSlaConfig? ManagedVolumeSlaConfig
        // GraphQL -> managedVolumeSlaConfig: ManagedVolumeSlaConfig (type)
        if (ec.Includes("managedVolumeSlaConfig",false))
        {
            if(this.ManagedVolumeSlaConfig == null) {

                this.ManagedVolumeSlaConfig = new ManagedVolumeSlaConfig();
                this.ManagedVolumeSlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSlaConfig"));

            } else {

                this.ManagedVolumeSlaConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSlaConfig"));

            }
        }
        else if (this.ManagedVolumeSlaConfig != null && ec.Excludes("managedVolumeSlaConfig",false))
        {
            this.ManagedVolumeSlaConfig = null;
        }
        //      C# -> MongoConfig? MongoConfig
        // GraphQL -> mongoConfig: MongoConfig (type)
        if (ec.Includes("mongoConfig",false))
        {
            if(this.MongoConfig == null) {

                this.MongoConfig = new MongoConfig();
                this.MongoConfig.ApplyExploratoryFieldSpec(ec.NewChild("mongoConfig"));

            } else {

                this.MongoConfig.ApplyExploratoryFieldSpec(ec.NewChild("mongoConfig"));

            }
        }
        else if (this.MongoConfig != null && ec.Excludes("mongoConfig",false))
        {
            this.MongoConfig = null;
        }
        //      C# -> MssqlConfig? MssqlConfig
        // GraphQL -> mssqlConfig: MssqlConfig (type)
        if (ec.Includes("mssqlConfig",false))
        {
            if(this.MssqlConfig == null) {

                this.MssqlConfig = new MssqlConfig();
                this.MssqlConfig.ApplyExploratoryFieldSpec(ec.NewChild("mssqlConfig"));

            } else {

                this.MssqlConfig.ApplyExploratoryFieldSpec(ec.NewChild("mssqlConfig"));

            }
        }
        else if (this.MssqlConfig != null && ec.Excludes("mssqlConfig",false))
        {
            this.MssqlConfig = null;
        }
        //      C# -> OracleConfig? OracleConfig
        // GraphQL -> oracleConfig: OracleConfig (type)
        if (ec.Includes("oracleConfig",false))
        {
            if(this.OracleConfig == null) {

                this.OracleConfig = new OracleConfig();
                this.OracleConfig.ApplyExploratoryFieldSpec(ec.NewChild("oracleConfig"));

            } else {

                this.OracleConfig.ApplyExploratoryFieldSpec(ec.NewChild("oracleConfig"));

            }
        }
        else if (this.OracleConfig != null && ec.Excludes("oracleConfig",false))
        {
            this.OracleConfig = null;
        }
        //      C# -> SapHanaConfig? SapHanaConfig
        // GraphQL -> sapHanaConfig: SapHanaConfig (type)
        if (ec.Includes("sapHanaConfig",false))
        {
            if(this.SapHanaConfig == null) {

                this.SapHanaConfig = new SapHanaConfig();
                this.SapHanaConfig.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaConfig"));

            } else {

                this.SapHanaConfig.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaConfig"));

            }
        }
        else if (this.SapHanaConfig != null && ec.Excludes("sapHanaConfig",false))
        {
            this.SapHanaConfig = null;
        }
        //      C# -> VmwareVmConfig? VmwareVmConfig
        // GraphQL -> vmwareVmConfig: VmwareVmConfig (type)
        if (ec.Includes("vmwareVmConfig",false))
        {
            if(this.VmwareVmConfig == null) {

                this.VmwareVmConfig = new VmwareVmConfig();
                this.VmwareVmConfig.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmConfig"));

            } else {

                this.VmwareVmConfig.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmConfig"));

            }
        }
        else if (this.VmwareVmConfig != null && ec.Excludes("vmwareVmConfig",false))
        {
            this.VmwareVmConfig = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ObjectSpecificConfigs> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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