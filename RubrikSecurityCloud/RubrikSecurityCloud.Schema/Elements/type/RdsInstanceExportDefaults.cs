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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region RdsInstanceExportDefaults
    public class RdsInstanceExportDefaults: BaseType
    {
        #region members

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

        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        [JsonProperty("allocatedStorageInGb")]
        public System.Int64? AllocatedStorageInGb { get; set; }

        //      C# -> System.String? DatabaseInstanceClass
        // GraphQL -> databaseInstanceClass: String! (scalar)
        [JsonProperty("databaseInstanceClass")]
        public System.String? DatabaseInstanceClass { get; set; }

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

        //      C# -> List<System.String>? SupportedDbEngineVersions
        // GraphQL -> supportedDbEngineVersions: [String!]! (scalar)
        [JsonProperty("supportedDbEngineVersions")]
        public List<System.String>? SupportedDbEngineVersions { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> List<KeyValuePair>? Metadata
        // GraphQL -> metadata: [KeyValuePair!]! (type)
        [JsonProperty("metadata")]
        public List<KeyValuePair>? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RdsInstanceExportDefaults";
    }

    public RdsInstanceExportDefaults Set(
        AwsNativeRdsDbEngine? DbEngine = null,
        AwsNativeRdsDbInstanceClass? DbInstanceClass = null,
        AwsNativeRdsStorageType? StorageType = null,
        System.Int64? AllocatedStorageInGb = null,
        System.String? DatabaseInstanceClass = null,
        System.String? DbEngineVersion = null,
        System.String? DbParameterGroupName = null,
        System.String? DbSubnetGroupName = null,
        System.Int32? Iops = null,
        System.Boolean? IsMultiAz = null,
        System.String? KmsKeyId = null,
        System.String? OptionGroupName = null,
        System.Int64? Port = null,
        System.String? PrimaryAz = null,
        List<System.String>? SupportedDbEngineVersions = null,
        System.String? VpcId = null,
        List<KeyValuePair>? Metadata = null
    ) 
    {
        if ( DbEngine != null ) {
            this.DbEngine = DbEngine;
        }
        if ( DbInstanceClass != null ) {
            this.DbInstanceClass = DbInstanceClass;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
        }
        if ( AllocatedStorageInGb != null ) {
            this.AllocatedStorageInGb = AllocatedStorageInGb;
        }
        if ( DatabaseInstanceClass != null ) {
            this.DatabaseInstanceClass = DatabaseInstanceClass;
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
        if ( SupportedDbEngineVersions != null ) {
            this.SupportedDbEngineVersions = SupportedDbEngineVersions;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (this.DbEngine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEngine\n" ;
            } else {
                s += ind + "dbEngine\n" ;
            }
        }
        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        if (this.DbInstanceClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbInstanceClass\n" ;
            } else {
                s += ind + "dbInstanceClass\n" ;
            }
        }
        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
        if (this.StorageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageType\n" ;
            } else {
                s += ind + "storageType\n" ;
            }
        }
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        if (this.AllocatedStorageInGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allocatedStorageInGb\n" ;
            } else {
                s += ind + "allocatedStorageInGb\n" ;
            }
        }
        //      C# -> System.String? DatabaseInstanceClass
        // GraphQL -> databaseInstanceClass: String! (scalar)
        if (this.DatabaseInstanceClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseInstanceClass\n" ;
            } else {
                s += ind + "databaseInstanceClass\n" ;
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
        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
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
        //      C# -> List<System.String>? SupportedDbEngineVersions
        // GraphQL -> supportedDbEngineVersions: [String!]! (scalar)
        if (this.SupportedDbEngineVersions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedDbEngineVersions\n" ;
            } else {
                s += ind + "supportedDbEngineVersions\n" ;
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
        //      C# -> List<KeyValuePair>? Metadata
        // GraphQL -> metadata: [KeyValuePair!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (ec.Includes("dbEngine",true))
        {
            if(this.DbEngine == null) {

                this.DbEngine = new AwsNativeRdsDbEngine();

            } else {


            }
        }
        else if (this.DbEngine != null && ec.Excludes("dbEngine",true))
        {
            this.DbEngine = null;
        }
        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        if (ec.Includes("dbInstanceClass",true))
        {
            if(this.DbInstanceClass == null) {

                this.DbInstanceClass = new AwsNativeRdsDbInstanceClass();

            } else {


            }
        }
        else if (this.DbInstanceClass != null && ec.Excludes("dbInstanceClass",true))
        {
            this.DbInstanceClass = null;
        }
        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
        if (ec.Includes("storageType",true))
        {
            if(this.StorageType == null) {

                this.StorageType = new AwsNativeRdsStorageType();

            } else {


            }
        }
        else if (this.StorageType != null && ec.Excludes("storageType",true))
        {
            this.StorageType = null;
        }
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
        //      C# -> System.String? DatabaseInstanceClass
        // GraphQL -> databaseInstanceClass: String! (scalar)
        if (ec.Includes("databaseInstanceClass",true))
        {
            if(this.DatabaseInstanceClass == null) {

                this.DatabaseInstanceClass = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseInstanceClass != null && ec.Excludes("databaseInstanceClass",true))
        {
            this.DatabaseInstanceClass = null;
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
        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
        if (ec.Includes("iops",true))
        {
            if(this.Iops == null) {

                this.Iops = Int32.MinValue;

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
        //      C# -> List<System.String>? SupportedDbEngineVersions
        // GraphQL -> supportedDbEngineVersions: [String!]! (scalar)
        if (ec.Includes("supportedDbEngineVersions",true))
        {
            if(this.SupportedDbEngineVersions == null) {

                this.SupportedDbEngineVersions = new List<System.String>();

            } else {


            }
        }
        else if (this.SupportedDbEngineVersions != null && ec.Excludes("supportedDbEngineVersions",true))
        {
            this.SupportedDbEngineVersions = null;
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
        //      C# -> List<KeyValuePair>? Metadata
        // GraphQL -> metadata: [KeyValuePair!]! (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new List<KeyValuePair>();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class RdsInstanceExportDefaults
    
    #endregion

    public static class ListRdsInstanceExportDefaultsExtensions
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
            this List<RdsInstanceExportDefaults> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RdsInstanceExportDefaults> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RdsInstanceExportDefaults> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RdsInstanceExportDefaults());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RdsInstanceExportDefaults> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types