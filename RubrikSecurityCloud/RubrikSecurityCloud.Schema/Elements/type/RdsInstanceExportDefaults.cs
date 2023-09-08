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

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }


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
        System.String? VpcId = null
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
        if ( VpcId != null ) {
            this.VpcId = VpcId;
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
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (this.DbEngine != null) {
            s += ind + "dbEngine\n" ;
        }
        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        if (this.DbInstanceClass != null) {
            s += ind + "dbInstanceClass\n" ;
        }
        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
        if (this.StorageType != null) {
            s += ind + "storageType\n" ;
        }
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        if (this.AllocatedStorageInGb != null) {
            s += ind + "allocatedStorageInGb\n" ;
        }
        //      C# -> System.String? DatabaseInstanceClass
        // GraphQL -> databaseInstanceClass: String! (scalar)
        if (this.DatabaseInstanceClass != null) {
            s += ind + "databaseInstanceClass\n" ;
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        if (this.DbEngineVersion != null) {
            s += ind + "dbEngineVersion\n" ;
        }
        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        if (this.DbParameterGroupName != null) {
            s += ind + "dbParameterGroupName\n" ;
        }
        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        if (this.DbSubnetGroupName != null) {
            s += ind + "dbSubnetGroupName\n" ;
        }
        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
        if (this.Iops != null) {
            s += ind + "iops\n" ;
        }
        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        if (this.IsMultiAz != null) {
            s += ind + "isMultiAz\n" ;
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String! (scalar)
        if (this.KmsKeyId != null) {
            s += ind + "kmsKeyId\n" ;
        }
        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String! (scalar)
        if (this.OptionGroupName != null) {
            s += ind + "optionGroupName\n" ;
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String! (scalar)
        if (this.PrimaryAz != null) {
            s += ind + "primaryAz\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (this.DbEngine == null && ec.Includes("dbEngine",true))
        {
            this.DbEngine = new AwsNativeRdsDbEngine();
        }
        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        if (this.DbInstanceClass == null && ec.Includes("dbInstanceClass",true))
        {
            this.DbInstanceClass = new AwsNativeRdsDbInstanceClass();
        }
        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType! (enum)
        if (this.StorageType == null && ec.Includes("storageType",true))
        {
            this.StorageType = new AwsNativeRdsStorageType();
        }
        //      C# -> System.Int64? AllocatedStorageInGb
        // GraphQL -> allocatedStorageInGb: Long! (scalar)
        if (this.AllocatedStorageInGb == null && ec.Includes("allocatedStorageInGb",true))
        {
            this.AllocatedStorageInGb = new System.Int64();
        }
        //      C# -> System.String? DatabaseInstanceClass
        // GraphQL -> databaseInstanceClass: String! (scalar)
        if (this.DatabaseInstanceClass == null && ec.Includes("databaseInstanceClass",true))
        {
            this.DatabaseInstanceClass = "FETCH";
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        if (this.DbEngineVersion == null && ec.Includes("dbEngineVersion",true))
        {
            this.DbEngineVersion = "FETCH";
        }
        //      C# -> System.String? DbParameterGroupName
        // GraphQL -> dbParameterGroupName: String! (scalar)
        if (this.DbParameterGroupName == null && ec.Includes("dbParameterGroupName",true))
        {
            this.DbParameterGroupName = "FETCH";
        }
        //      C# -> System.String? DbSubnetGroupName
        // GraphQL -> dbSubnetGroupName: String! (scalar)
        if (this.DbSubnetGroupName == null && ec.Includes("dbSubnetGroupName",true))
        {
            this.DbSubnetGroupName = "FETCH";
        }
        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
        if (this.Iops == null && ec.Includes("iops",true))
        {
            this.Iops = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        if (this.IsMultiAz == null && ec.Includes("isMultiAz",true))
        {
            this.IsMultiAz = true;
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String! (scalar)
        if (this.KmsKeyId == null && ec.Includes("kmsKeyId",true))
        {
            this.KmsKeyId = "FETCH";
        }
        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String! (scalar)
        if (this.OptionGroupName == null && ec.Includes("optionGroupName",true))
        {
            this.OptionGroupName = "FETCH";
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        if (this.Port == null && ec.Includes("port",true))
        {
            this.Port = new System.Int64();
        }
        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String! (scalar)
        if (this.PrimaryAz == null && ec.Includes("primaryAz",true))
        {
            this.PrimaryAz = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && ec.Includes("vpcId",true))
        {
            this.VpcId = "FETCH";
        }
    }


    #endregion

    } // class RdsInstanceExportDefaults
    
    #endregion

    public static class ListRdsInstanceExportDefaultsExtensions
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
            this List<RdsInstanceExportDefaults> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RdsInstanceExportDefaults> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RdsInstanceExportDefaults());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RdsInstanceExportDefaults> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types