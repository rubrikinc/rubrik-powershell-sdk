// AwsEc2InstanceRecoverySpec.cs
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
    #region AwsEc2InstanceRecoverySpec
    public class AwsEc2InstanceRecoverySpec: BaseType
    {
        #region members

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String (scalar)
        [JsonProperty("iamInstanceProfileArn")]
        public System.String? IamInstanceProfileArn { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!]! (scalar)
        [JsonProperty("securityGroupNativeIds")]
        public List<System.String>? SecurityGroupNativeIds { get; set; }

        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String (scalar)
        [JsonProperty("sshKeyPairName")]
        public System.String? SshKeyPairName { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

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
        return "AwsEc2InstanceRecoverySpec";
    }

    public AwsEc2InstanceRecoverySpec Set(
        SnapshotType? SnapshotType = null,
        System.String? IamInstanceProfileArn = null,
        System.String? InstanceType = null,
        System.String? KmsKeyId = null,
        List<System.String>? SecurityGroupNativeIds = null,
        System.String? SshKeyPairName = null,
        System.String? SubnetNativeId = null,
        System.Int64? Version = null,
        System.String? VpcNativeId = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( IamInstanceProfileArn != null ) {
            this.IamInstanceProfileArn = IamInstanceProfileArn;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( KmsKeyId != null ) {
            this.KmsKeyId = KmsKeyId;
        }
        if ( SecurityGroupNativeIds != null ) {
            this.SecurityGroupNativeIds = SecurityGroupNativeIds;
        }
        if ( SshKeyPairName != null ) {
            this.SshKeyPairName = SshKeyPairName;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
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
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String (scalar)
        if (this.IamInstanceProfileArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iamInstanceProfileArn\n" ;
            } else {
                s += ind + "iamInstanceProfileArn\n" ;
            }
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceType\n" ;
            } else {
                s += ind + "instanceType\n" ;
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
        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!]! (scalar)
        if (this.SecurityGroupNativeIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityGroupNativeIds\n" ;
            } else {
                s += ind + "securityGroupNativeIds\n" ;
            }
        }
        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String (scalar)
        if (this.SshKeyPairName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sshKeyPairName\n" ;
            } else {
                s += ind + "sshKeyPairName\n" ;
            }
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetNativeId\n" ;
            } else {
                s += ind + "subnetNativeId\n" ;
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
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String (scalar)
        if (ec.Includes("iamInstanceProfileArn",true))
        {
            if(this.IamInstanceProfileArn == null) {

                this.IamInstanceProfileArn = "FETCH";

            } else {


            }
        }
        else if (this.IamInstanceProfileArn != null && ec.Excludes("iamInstanceProfileArn",true))
        {
            this.IamInstanceProfileArn = null;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (ec.Includes("instanceType",true))
        {
            if(this.InstanceType == null) {

                this.InstanceType = "FETCH";

            } else {


            }
        }
        else if (this.InstanceType != null && ec.Excludes("instanceType",true))
        {
            this.InstanceType = null;
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
        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!]! (scalar)
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
        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String (scalar)
        if (ec.Includes("sshKeyPairName",true))
        {
            if(this.SshKeyPairName == null) {

                this.SshKeyPairName = "FETCH";

            } else {


            }
        }
        else if (this.SshKeyPairName != null && ec.Excludes("sshKeyPairName",true))
        {
            this.SshKeyPairName = null;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (ec.Includes("subnetNativeId",true))
        {
            if(this.SubnetNativeId == null) {

                this.SubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetNativeId != null && ec.Excludes("subnetNativeId",true))
        {
            this.SubnetNativeId = null;
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

    } // class AwsEc2InstanceRecoverySpec
    
    #endregion

    public static class ListAwsEc2InstanceRecoverySpecExtensions
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
            this List<AwsEc2InstanceRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsEc2InstanceRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsEc2InstanceRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsEc2InstanceRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsEc2InstanceRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types