// AwsApplicationServiceConfiguration.cs
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
    #region AwsApplicationServiceConfiguration
    public class AwsApplicationServiceConfiguration: BaseType
    {
        #region members

        //      C# -> System.Boolean? EbsEnabled
        // GraphQL -> ebsEnabled: Boolean! (scalar)
        [JsonProperty("ebsEnabled")]
        public System.Boolean? EbsEnabled { get; set; }

        //      C# -> System.Boolean? Ec2Enabled
        // GraphQL -> ec2Enabled: Boolean! (scalar)
        [JsonProperty("ec2Enabled")]
        public System.Boolean? Ec2Enabled { get; set; }

        //      C# -> System.Boolean? EcrEnabled
        // GraphQL -> ecrEnabled: Boolean! (scalar)
        [JsonProperty("ecrEnabled")]
        public System.Boolean? EcrEnabled { get; set; }

        //      C# -> System.Boolean? EksEnabled
        // GraphQL -> eksEnabled: Boolean! (scalar)
        [JsonProperty("eksEnabled")]
        public System.Boolean? EksEnabled { get; set; }

        //      C# -> System.Boolean? ElasticacheEnabled
        // GraphQL -> elasticacheEnabled: Boolean! (scalar)
        [JsonProperty("elasticacheEnabled")]
        public System.Boolean? ElasticacheEnabled { get; set; }

        //      C# -> System.Boolean? ElbEnabled
        // GraphQL -> elbEnabled: Boolean! (scalar)
        [JsonProperty("elbEnabled")]
        public System.Boolean? ElbEnabled { get; set; }

        //      C# -> System.Boolean? IsEcsEnabled
        // GraphQL -> isEcsEnabled: Boolean! (scalar)
        [JsonProperty("isEcsEnabled")]
        public System.Boolean? IsEcsEnabled { get; set; }

        //      C# -> System.Boolean? LambdaEnabled
        // GraphQL -> lambdaEnabled: Boolean! (scalar)
        [JsonProperty("lambdaEnabled")]
        public System.Boolean? LambdaEnabled { get; set; }

        //      C# -> System.Boolean? RdsEnabled
        // GraphQL -> rdsEnabled: Boolean! (scalar)
        [JsonProperty("rdsEnabled")]
        public System.Boolean? RdsEnabled { get; set; }

        //      C# -> System.Boolean? S3Enabled
        // GraphQL -> s3Enabled: Boolean! (scalar)
        [JsonProperty("s3Enabled")]
        public System.Boolean? S3Enabled { get; set; }

        //      C# -> System.Boolean? SecretsEnabled
        // GraphQL -> secretsEnabled: Boolean! (scalar)
        [JsonProperty("secretsEnabled")]
        public System.Boolean? SecretsEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsApplicationServiceConfiguration";
    }

    public AwsApplicationServiceConfiguration Set(
        System.Boolean? EbsEnabled = null,
        System.Boolean? Ec2Enabled = null,
        System.Boolean? EcrEnabled = null,
        System.Boolean? EksEnabled = null,
        System.Boolean? ElasticacheEnabled = null,
        System.Boolean? ElbEnabled = null,
        System.Boolean? IsEcsEnabled = null,
        System.Boolean? LambdaEnabled = null,
        System.Boolean? RdsEnabled = null,
        System.Boolean? S3Enabled = null,
        System.Boolean? SecretsEnabled = null
    ) 
    {
        if ( EbsEnabled != null ) {
            this.EbsEnabled = EbsEnabled;
        }
        if ( Ec2Enabled != null ) {
            this.Ec2Enabled = Ec2Enabled;
        }
        if ( EcrEnabled != null ) {
            this.EcrEnabled = EcrEnabled;
        }
        if ( EksEnabled != null ) {
            this.EksEnabled = EksEnabled;
        }
        if ( ElasticacheEnabled != null ) {
            this.ElasticacheEnabled = ElasticacheEnabled;
        }
        if ( ElbEnabled != null ) {
            this.ElbEnabled = ElbEnabled;
        }
        if ( IsEcsEnabled != null ) {
            this.IsEcsEnabled = IsEcsEnabled;
        }
        if ( LambdaEnabled != null ) {
            this.LambdaEnabled = LambdaEnabled;
        }
        if ( RdsEnabled != null ) {
            this.RdsEnabled = RdsEnabled;
        }
        if ( S3Enabled != null ) {
            this.S3Enabled = S3Enabled;
        }
        if ( SecretsEnabled != null ) {
            this.SecretsEnabled = SecretsEnabled;
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
        //      C# -> System.Boolean? EbsEnabled
        // GraphQL -> ebsEnabled: Boolean! (scalar)
        if (this.EbsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ebsEnabled\n" ;
            } else {
                s += ind + "ebsEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? Ec2Enabled
        // GraphQL -> ec2Enabled: Boolean! (scalar)
        if (this.Ec2Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ec2Enabled\n" ;
            } else {
                s += ind + "ec2Enabled\n" ;
            }
        }
        //      C# -> System.Boolean? EcrEnabled
        // GraphQL -> ecrEnabled: Boolean! (scalar)
        if (this.EcrEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ecrEnabled\n" ;
            } else {
                s += ind + "ecrEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? EksEnabled
        // GraphQL -> eksEnabled: Boolean! (scalar)
        if (this.EksEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eksEnabled\n" ;
            } else {
                s += ind + "eksEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? ElasticacheEnabled
        // GraphQL -> elasticacheEnabled: Boolean! (scalar)
        if (this.ElasticacheEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elasticacheEnabled\n" ;
            } else {
                s += ind + "elasticacheEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? ElbEnabled
        // GraphQL -> elbEnabled: Boolean! (scalar)
        if (this.ElbEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elbEnabled\n" ;
            } else {
                s += ind + "elbEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsEcsEnabled
        // GraphQL -> isEcsEnabled: Boolean! (scalar)
        if (this.IsEcsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEcsEnabled\n" ;
            } else {
                s += ind + "isEcsEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? LambdaEnabled
        // GraphQL -> lambdaEnabled: Boolean! (scalar)
        if (this.LambdaEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lambdaEnabled\n" ;
            } else {
                s += ind + "lambdaEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? RdsEnabled
        // GraphQL -> rdsEnabled: Boolean! (scalar)
        if (this.RdsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rdsEnabled\n" ;
            } else {
                s += ind + "rdsEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? S3Enabled
        // GraphQL -> s3Enabled: Boolean! (scalar)
        if (this.S3Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3Enabled\n" ;
            } else {
                s += ind + "s3Enabled\n" ;
            }
        }
        //      C# -> System.Boolean? SecretsEnabled
        // GraphQL -> secretsEnabled: Boolean! (scalar)
        if (this.SecretsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secretsEnabled\n" ;
            } else {
                s += ind + "secretsEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? EbsEnabled
        // GraphQL -> ebsEnabled: Boolean! (scalar)
        if (ec.Includes("ebsEnabled",true))
        {
            if(this.EbsEnabled == null) {

                this.EbsEnabled = true;

            } else {


            }
        }
        else if (this.EbsEnabled != null && ec.Excludes("ebsEnabled",true))
        {
            this.EbsEnabled = null;
        }
        //      C# -> System.Boolean? Ec2Enabled
        // GraphQL -> ec2Enabled: Boolean! (scalar)
        if (ec.Includes("ec2Enabled",true))
        {
            if(this.Ec2Enabled == null) {

                this.Ec2Enabled = true;

            } else {


            }
        }
        else if (this.Ec2Enabled != null && ec.Excludes("ec2Enabled",true))
        {
            this.Ec2Enabled = null;
        }
        //      C# -> System.Boolean? EcrEnabled
        // GraphQL -> ecrEnabled: Boolean! (scalar)
        if (ec.Includes("ecrEnabled",true))
        {
            if(this.EcrEnabled == null) {

                this.EcrEnabled = true;

            } else {


            }
        }
        else if (this.EcrEnabled != null && ec.Excludes("ecrEnabled",true))
        {
            this.EcrEnabled = null;
        }
        //      C# -> System.Boolean? EksEnabled
        // GraphQL -> eksEnabled: Boolean! (scalar)
        if (ec.Includes("eksEnabled",true))
        {
            if(this.EksEnabled == null) {

                this.EksEnabled = true;

            } else {


            }
        }
        else if (this.EksEnabled != null && ec.Excludes("eksEnabled",true))
        {
            this.EksEnabled = null;
        }
        //      C# -> System.Boolean? ElasticacheEnabled
        // GraphQL -> elasticacheEnabled: Boolean! (scalar)
        if (ec.Includes("elasticacheEnabled",true))
        {
            if(this.ElasticacheEnabled == null) {

                this.ElasticacheEnabled = true;

            } else {


            }
        }
        else if (this.ElasticacheEnabled != null && ec.Excludes("elasticacheEnabled",true))
        {
            this.ElasticacheEnabled = null;
        }
        //      C# -> System.Boolean? ElbEnabled
        // GraphQL -> elbEnabled: Boolean! (scalar)
        if (ec.Includes("elbEnabled",true))
        {
            if(this.ElbEnabled == null) {

                this.ElbEnabled = true;

            } else {


            }
        }
        else if (this.ElbEnabled != null && ec.Excludes("elbEnabled",true))
        {
            this.ElbEnabled = null;
        }
        //      C# -> System.Boolean? IsEcsEnabled
        // GraphQL -> isEcsEnabled: Boolean! (scalar)
        if (ec.Includes("isEcsEnabled",true))
        {
            if(this.IsEcsEnabled == null) {

                this.IsEcsEnabled = true;

            } else {


            }
        }
        else if (this.IsEcsEnabled != null && ec.Excludes("isEcsEnabled",true))
        {
            this.IsEcsEnabled = null;
        }
        //      C# -> System.Boolean? LambdaEnabled
        // GraphQL -> lambdaEnabled: Boolean! (scalar)
        if (ec.Includes("lambdaEnabled",true))
        {
            if(this.LambdaEnabled == null) {

                this.LambdaEnabled = true;

            } else {


            }
        }
        else if (this.LambdaEnabled != null && ec.Excludes("lambdaEnabled",true))
        {
            this.LambdaEnabled = null;
        }
        //      C# -> System.Boolean? RdsEnabled
        // GraphQL -> rdsEnabled: Boolean! (scalar)
        if (ec.Includes("rdsEnabled",true))
        {
            if(this.RdsEnabled == null) {

                this.RdsEnabled = true;

            } else {


            }
        }
        else if (this.RdsEnabled != null && ec.Excludes("rdsEnabled",true))
        {
            this.RdsEnabled = null;
        }
        //      C# -> System.Boolean? S3Enabled
        // GraphQL -> s3Enabled: Boolean! (scalar)
        if (ec.Includes("s3Enabled",true))
        {
            if(this.S3Enabled == null) {

                this.S3Enabled = true;

            } else {


            }
        }
        else if (this.S3Enabled != null && ec.Excludes("s3Enabled",true))
        {
            this.S3Enabled = null;
        }
        //      C# -> System.Boolean? SecretsEnabled
        // GraphQL -> secretsEnabled: Boolean! (scalar)
        if (ec.Includes("secretsEnabled",true))
        {
            if(this.SecretsEnabled == null) {

                this.SecretsEnabled = true;

            } else {


            }
        }
        else if (this.SecretsEnabled != null && ec.Excludes("secretsEnabled",true))
        {
            this.SecretsEnabled = null;
        }
    }


    #endregion

    } // class AwsApplicationServiceConfiguration
    
    #endregion

    public static class ListAwsApplicationServiceConfigurationExtensions
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
            this List<AwsApplicationServiceConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsApplicationServiceConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsApplicationServiceConfiguration> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsApplicationServiceConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsApplicationServiceConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types