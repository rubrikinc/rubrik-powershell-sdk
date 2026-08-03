// AwsRdsInstanceRecoverySpec.cs
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
    #region AwsRdsInstanceRecoverySpec
    public class AwsRdsInstanceRecoverySpec: BaseType
    {
        #region members

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? ClusterParameterGroupName
        // GraphQL -> clusterParameterGroupName: String (scalar)
        [JsonProperty("clusterParameterGroupName")]
        public System.String? ClusterParameterGroupName { get; set; }

        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String! (scalar)
        [JsonProperty("dbEngineVersion")]
        public System.String? DbEngineVersion { get; set; }

        //      C# -> System.String? DbInstanceClass
        // GraphQL -> dbInstanceClass: String! (scalar)
        [JsonProperty("dbInstanceClass")]
        public System.String? DbInstanceClass { get; set; }

        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long (scalar)
        [JsonProperty("iops")]
        public System.Int64? Iops { get; set; }

        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        [JsonProperty("isMultiAz")]
        public System.Boolean? IsMultiAz { get; set; }

        //      C# -> System.Boolean? IsPubliclyAccessible
        // GraphQL -> isPubliclyAccessible: Boolean (scalar)
        [JsonProperty("isPubliclyAccessible")]
        public System.Boolean? IsPubliclyAccessible { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String (scalar)
        [JsonProperty("optionGroupName")]
        public System.String? OptionGroupName { get; set; }

        //      C# -> System.String? ParameterGroupName
        // GraphQL -> parameterGroupName: String (scalar)
        [JsonProperty("parameterGroupName")]
        public System.String? ParameterGroupName { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }

        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String (scalar)
        [JsonProperty("primaryAz")]
        public System.String? PrimaryAz { get; set; }

        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!] (scalar)
        [JsonProperty("securityGroupNativeIds")]
        public List<System.String>? SecurityGroupNativeIds { get; set; }

        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String (scalar)
        [JsonProperty("storageType")]
        public System.String? StorageType { get; set; }

        //      C# -> System.String? SubnetGroupName
        // GraphQL -> subnetGroupName: String (scalar)
        [JsonProperty("subnetGroupName")]
        public System.String? SubnetGroupName { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> System.String? VpcNativeId
        // GraphQL -> vpcNativeId: String! (scalar)
        [JsonProperty("vpcNativeId")]
        public System.String? VpcNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsRdsInstanceRecoverySpec";
    }

    public AwsRdsInstanceRecoverySpec Set(
        SnapshotType? SnapshotType = null,
        System.String? ClusterParameterGroupName = null,
        System.String? DbEngineVersion = null,
        System.String? DbInstanceClass = null,
        System.Int64? Iops = null,
        System.Boolean? IsMultiAz = null,
        System.Boolean? IsPubliclyAccessible = null,
        System.String? KmsKeyId = null,
        System.String? OptionGroupName = null,
        System.String? ParameterGroupName = null,
        System.Int64? Port = null,
        System.String? PrimaryAz = null,
        List<System.String>? SecurityGroupNativeIds = null,
        System.String? StorageType = null,
        System.String? SubnetGroupName = null,
        System.Int64? Version = null,
        System.String? VpcNativeId = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( ClusterParameterGroupName != null ) {
            this.ClusterParameterGroupName = ClusterParameterGroupName;
        }
        if ( DbEngineVersion != null ) {
            this.DbEngineVersion = DbEngineVersion;
        }
        if ( DbInstanceClass != null ) {
            this.DbInstanceClass = DbInstanceClass;
        }
        if ( Iops != null ) {
            this.Iops = Iops;
        }
        if ( IsMultiAz != null ) {
            this.IsMultiAz = IsMultiAz;
        }
        if ( IsPubliclyAccessible != null ) {
            this.IsPubliclyAccessible = IsPubliclyAccessible;
        }
        if ( KmsKeyId != null ) {
            this.KmsKeyId = KmsKeyId;
        }
        if ( OptionGroupName != null ) {
            this.OptionGroupName = OptionGroupName;
        }
        if ( ParameterGroupName != null ) {
            this.ParameterGroupName = ParameterGroupName;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( PrimaryAz != null ) {
            this.PrimaryAz = PrimaryAz;
        }
        if ( SecurityGroupNativeIds != null ) {
            this.SecurityGroupNativeIds = SecurityGroupNativeIds;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
        }
        if ( SubnetGroupName != null ) {
            this.SubnetGroupName = SubnetGroupName;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( VpcNativeId != null ) {
            this.VpcNativeId = VpcNativeId;
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
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> System.String? ClusterParameterGroupName
        // GraphQL -> clusterParameterGroupName: String (scalar)
        if (this.ClusterParameterGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterParameterGroupName\n" ;
            } else {
                s += ind + "clusterParameterGroupName\n" ;
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
        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long (scalar)
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
        //      C# -> System.Boolean? IsPubliclyAccessible
        // GraphQL -> isPubliclyAccessible: Boolean (scalar)
        if (this.IsPubliclyAccessible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPubliclyAccessible\n" ;
            } else {
                s += ind + "isPubliclyAccessible\n" ;
            }
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        if (this.KmsKeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKeyId\n" ;
            } else {
                s += ind + "kmsKeyId\n" ;
            }
        }
        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String (scalar)
        if (this.OptionGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "optionGroupName\n" ;
            } else {
                s += ind + "optionGroupName\n" ;
            }
        }
        //      C# -> System.String? ParameterGroupName
        // GraphQL -> parameterGroupName: String (scalar)
        if (this.ParameterGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parameterGroupName\n" ;
            } else {
                s += ind + "parameterGroupName\n" ;
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
        // GraphQL -> primaryAz: String (scalar)
        if (this.PrimaryAz != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryAz\n" ;
            } else {
                s += ind + "primaryAz\n" ;
            }
        }
        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!] (scalar)
        if (this.SecurityGroupNativeIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityGroupNativeIds\n" ;
            } else {
                s += ind + "securityGroupNativeIds\n" ;
            }
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String (scalar)
        if (this.StorageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageType\n" ;
            } else {
                s += ind + "storageType\n" ;
            }
        }
        //      C# -> System.String? SubnetGroupName
        // GraphQL -> subnetGroupName: String (scalar)
        if (this.SubnetGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetGroupName\n" ;
            } else {
                s += ind + "subnetGroupName\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> System.String? VpcNativeId
        // GraphQL -> vpcNativeId: String! (scalar)
        if (this.VpcNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcNativeId\n" ;
            } else {
                s += ind + "vpcNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new SnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> System.String? ClusterParameterGroupName
        // GraphQL -> clusterParameterGroupName: String (scalar)
        if (ec.Includes("clusterParameterGroupName",true))
        {
            if(this.ClusterParameterGroupName == null) {

                this.ClusterParameterGroupName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterParameterGroupName != null && ec.Excludes("clusterParameterGroupName",true))
        {
            this.ClusterParameterGroupName = null;
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
        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long (scalar)
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
        //      C# -> System.Boolean? IsPubliclyAccessible
        // GraphQL -> isPubliclyAccessible: Boolean (scalar)
        if (ec.Includes("isPubliclyAccessible",true))
        {
            if(this.IsPubliclyAccessible == null) {

                this.IsPubliclyAccessible = true;

            } else {


            }
        }
        else if (this.IsPubliclyAccessible != null && ec.Excludes("isPubliclyAccessible",true))
        {
            this.IsPubliclyAccessible = null;
        }
        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
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
        // GraphQL -> optionGroupName: String (scalar)
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
        //      C# -> System.String? ParameterGroupName
        // GraphQL -> parameterGroupName: String (scalar)
        if (ec.Includes("parameterGroupName",true))
        {
            if(this.ParameterGroupName == null) {

                this.ParameterGroupName = "FETCH";

            } else {


            }
        }
        else if (this.ParameterGroupName != null && ec.Excludes("parameterGroupName",true))
        {
            this.ParameterGroupName = null;
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
        // GraphQL -> primaryAz: String (scalar)
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
        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!] (scalar)
        if (ec.Includes("securityGroupNativeIds",true))
        {
            if(this.SecurityGroupNativeIds == null) {

                this.SecurityGroupNativeIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SecurityGroupNativeIds != null && ec.Excludes("securityGroupNativeIds",true))
        {
            this.SecurityGroupNativeIds = null;
        }
        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String (scalar)
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
        //      C# -> System.String? SubnetGroupName
        // GraphQL -> subnetGroupName: String (scalar)
        if (ec.Includes("subnetGroupName",true))
        {
            if(this.SubnetGroupName == null) {

                this.SubnetGroupName = "FETCH";

            } else {


            }
        }
        else if (this.SubnetGroupName != null && ec.Excludes("subnetGroupName",true))
        {
            this.SubnetGroupName = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> System.String? VpcNativeId
        // GraphQL -> vpcNativeId: String! (scalar)
        if (ec.Includes("vpcNativeId",true))
        {
            if(this.VpcNativeId == null) {

                this.VpcNativeId = "FETCH";

            } else {


            }
        }
        else if (this.VpcNativeId != null && ec.Excludes("vpcNativeId",true))
        {
            this.VpcNativeId = null;
        }
    }


    #endregion

    } // class AwsRdsInstanceRecoverySpec
    
    #endregion

    public static class ListAwsRdsInstanceRecoverySpecExtensions
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
            this List<AwsRdsInstanceRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsRdsInstanceRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsRdsInstanceRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRdsInstanceRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsRdsInstanceRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types