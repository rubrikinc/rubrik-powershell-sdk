// SpecificResource.cs
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
    #region SpecificResource
    public class SpecificResource: BaseType
    {
        #region members

        //      C# -> ConfigResourceAwsAutoScalingGroup? AwsAutoScalingGroup
        // GraphQL -> awsAutoScalingGroup: ConfigResourceAwsAutoScalingGroup (type)
        [JsonProperty("awsAutoScalingGroup")]
        public ConfigResourceAwsAutoScalingGroup? AwsAutoScalingGroup { get; set; }

        //      C# -> ConfigResourceAwsEcr? AwsEcr
        // GraphQL -> awsEcr: ConfigResourceAwsEcr (type)
        [JsonProperty("awsEcr")]
        public ConfigResourceAwsEcr? AwsEcr { get; set; }

        //      C# -> ConfigResourceAwsEcs? AwsEcs
        // GraphQL -> awsEcs: ConfigResourceAwsEcs (type)
        [JsonProperty("awsEcs")]
        public ConfigResourceAwsEcs? AwsEcs { get; set; }

        //      C# -> ConfigResourceAwsEks? AwsEks
        // GraphQL -> awsEks: ConfigResourceAwsEks (type)
        [JsonProperty("awsEks")]
        public ConfigResourceAwsEks? AwsEks { get; set; }

        //      C# -> ConfigResourceAwsElasticache? AwsElasticache
        // GraphQL -> awsElasticache: ConfigResourceAwsElasticache (type)
        [JsonProperty("awsElasticache")]
        public ConfigResourceAwsElasticache? AwsElasticache { get; set; }

        //      C# -> ConfigResourceAwsElasticacheParameterGroup? AwsElasticacheParameterGroup
        // GraphQL -> awsElasticacheParameterGroup: ConfigResourceAwsElasticacheParameterGroup (type)
        [JsonProperty("awsElasticacheParameterGroup")]
        public ConfigResourceAwsElasticacheParameterGroup? AwsElasticacheParameterGroup { get; set; }

        //      C# -> ConfigResourceAwsElasticacheSubnetGroup? AwsElasticacheSubnetGroup
        // GraphQL -> awsElasticacheSubnetGroup: ConfigResourceAwsElasticacheSubnetGroup (type)
        [JsonProperty("awsElasticacheSubnetGroup")]
        public ConfigResourceAwsElasticacheSubnetGroup? AwsElasticacheSubnetGroup { get; set; }

        //      C# -> ConfigResourceAwsHostedZone? AwsHostedZone
        // GraphQL -> awsHostedZone: ConfigResourceAwsHostedZone (type)
        [JsonProperty("awsHostedZone")]
        public ConfigResourceAwsHostedZone? AwsHostedZone { get; set; }

        //      C# -> ConfigResourceAwsIamRole? AwsIamRole
        // GraphQL -> awsIamRole: ConfigResourceAwsIamRole (type)
        [JsonProperty("awsIamRole")]
        public ConfigResourceAwsIamRole? AwsIamRole { get; set; }

        //      C# -> ConfigResourceAwsLambda? AwsLambda
        // GraphQL -> awsLambda: ConfigResourceAwsLambda (type)
        [JsonProperty("awsLambda")]
        public ConfigResourceAwsLambda? AwsLambda { get; set; }

        //      C# -> ConfigResourceAwsLaunchTemplate? AwsLaunchTemplate
        // GraphQL -> awsLaunchTemplate: ConfigResourceAwsLaunchTemplate (type)
        [JsonProperty("awsLaunchTemplate")]
        public ConfigResourceAwsLaunchTemplate? AwsLaunchTemplate { get; set; }

        //      C# -> ConfigResourceAwsLoadBalancer? AwsLoadBalancer
        // GraphQL -> awsLoadBalancer: ConfigResourceAwsLoadBalancer (type)
        [JsonProperty("awsLoadBalancer")]
        public ConfigResourceAwsLoadBalancer? AwsLoadBalancer { get; set; }

        //      C# -> ConfigResourceAwsOptionGroup? AwsOptionGroup
        // GraphQL -> awsOptionGroup: ConfigResourceAwsOptionGroup (type)
        [JsonProperty("awsOptionGroup")]
        public ConfigResourceAwsOptionGroup? AwsOptionGroup { get; set; }

        //      C# -> ConfigResourceAwsParameterGroup? AwsParameterGroup
        // GraphQL -> awsParameterGroup: ConfigResourceAwsParameterGroup (type)
        [JsonProperty("awsParameterGroup")]
        public ConfigResourceAwsParameterGroup? AwsParameterGroup { get; set; }

        //      C# -> ConfigResourceAwsSecurityGroup? AwsSecurityGroup
        // GraphQL -> awsSecurityGroup: ConfigResourceAwsSecurityGroup (type)
        [JsonProperty("awsSecurityGroup")]
        public ConfigResourceAwsSecurityGroup? AwsSecurityGroup { get; set; }

        //      C# -> ConfigResourceAwsSubnet? AwsSubnet
        // GraphQL -> awsSubnet: ConfigResourceAwsSubnet (type)
        [JsonProperty("awsSubnet")]
        public ConfigResourceAwsSubnet? AwsSubnet { get; set; }

        //      C# -> ConfigResourceAwsTargetGroup? AwsTargetGroup
        // GraphQL -> awsTargetGroup: ConfigResourceAwsTargetGroup (type)
        [JsonProperty("awsTargetGroup")]
        public ConfigResourceAwsTargetGroup? AwsTargetGroup { get; set; }

        //      C# -> ConfigResourceAwsVpc? AwsVpc
        // GraphQL -> awsVpc: ConfigResourceAwsVpc (type)
        [JsonProperty("awsVpc")]
        public ConfigResourceAwsVpc? AwsVpc { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SpecificResource";
    }

    public SpecificResource Set(
        ConfigResourceAwsAutoScalingGroup? AwsAutoScalingGroup = null,
        ConfigResourceAwsEcr? AwsEcr = null,
        ConfigResourceAwsEcs? AwsEcs = null,
        ConfigResourceAwsEks? AwsEks = null,
        ConfigResourceAwsElasticache? AwsElasticache = null,
        ConfigResourceAwsElasticacheParameterGroup? AwsElasticacheParameterGroup = null,
        ConfigResourceAwsElasticacheSubnetGroup? AwsElasticacheSubnetGroup = null,
        ConfigResourceAwsHostedZone? AwsHostedZone = null,
        ConfigResourceAwsIamRole? AwsIamRole = null,
        ConfigResourceAwsLambda? AwsLambda = null,
        ConfigResourceAwsLaunchTemplate? AwsLaunchTemplate = null,
        ConfigResourceAwsLoadBalancer? AwsLoadBalancer = null,
        ConfigResourceAwsOptionGroup? AwsOptionGroup = null,
        ConfigResourceAwsParameterGroup? AwsParameterGroup = null,
        ConfigResourceAwsSecurityGroup? AwsSecurityGroup = null,
        ConfigResourceAwsSubnet? AwsSubnet = null,
        ConfigResourceAwsTargetGroup? AwsTargetGroup = null,
        ConfigResourceAwsVpc? AwsVpc = null
    ) 
    {
        if ( AwsAutoScalingGroup != null ) {
            this.AwsAutoScalingGroup = AwsAutoScalingGroup;
        }
        if ( AwsEcr != null ) {
            this.AwsEcr = AwsEcr;
        }
        if ( AwsEcs != null ) {
            this.AwsEcs = AwsEcs;
        }
        if ( AwsEks != null ) {
            this.AwsEks = AwsEks;
        }
        if ( AwsElasticache != null ) {
            this.AwsElasticache = AwsElasticache;
        }
        if ( AwsElasticacheParameterGroup != null ) {
            this.AwsElasticacheParameterGroup = AwsElasticacheParameterGroup;
        }
        if ( AwsElasticacheSubnetGroup != null ) {
            this.AwsElasticacheSubnetGroup = AwsElasticacheSubnetGroup;
        }
        if ( AwsHostedZone != null ) {
            this.AwsHostedZone = AwsHostedZone;
        }
        if ( AwsIamRole != null ) {
            this.AwsIamRole = AwsIamRole;
        }
        if ( AwsLambda != null ) {
            this.AwsLambda = AwsLambda;
        }
        if ( AwsLaunchTemplate != null ) {
            this.AwsLaunchTemplate = AwsLaunchTemplate;
        }
        if ( AwsLoadBalancer != null ) {
            this.AwsLoadBalancer = AwsLoadBalancer;
        }
        if ( AwsOptionGroup != null ) {
            this.AwsOptionGroup = AwsOptionGroup;
        }
        if ( AwsParameterGroup != null ) {
            this.AwsParameterGroup = AwsParameterGroup;
        }
        if ( AwsSecurityGroup != null ) {
            this.AwsSecurityGroup = AwsSecurityGroup;
        }
        if ( AwsSubnet != null ) {
            this.AwsSubnet = AwsSubnet;
        }
        if ( AwsTargetGroup != null ) {
            this.AwsTargetGroup = AwsTargetGroup;
        }
        if ( AwsVpc != null ) {
            this.AwsVpc = AwsVpc;
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
        //      C# -> ConfigResourceAwsAutoScalingGroup? AwsAutoScalingGroup
        // GraphQL -> awsAutoScalingGroup: ConfigResourceAwsAutoScalingGroup (type)
        if (this.AwsAutoScalingGroup != null) {
            var fspec = this.AwsAutoScalingGroup.AsFieldSpec(conf.Child("awsAutoScalingGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsAutoScalingGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsEcr? AwsEcr
        // GraphQL -> awsEcr: ConfigResourceAwsEcr (type)
        if (this.AwsEcr != null) {
            var fspec = this.AwsEcr.AsFieldSpec(conf.Child("awsEcr"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsEcr" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsEcs? AwsEcs
        // GraphQL -> awsEcs: ConfigResourceAwsEcs (type)
        if (this.AwsEcs != null) {
            var fspec = this.AwsEcs.AsFieldSpec(conf.Child("awsEcs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsEcs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsEks? AwsEks
        // GraphQL -> awsEks: ConfigResourceAwsEks (type)
        if (this.AwsEks != null) {
            var fspec = this.AwsEks.AsFieldSpec(conf.Child("awsEks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsEks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsElasticache? AwsElasticache
        // GraphQL -> awsElasticache: ConfigResourceAwsElasticache (type)
        if (this.AwsElasticache != null) {
            var fspec = this.AwsElasticache.AsFieldSpec(conf.Child("awsElasticache"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsElasticache" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsElasticacheParameterGroup? AwsElasticacheParameterGroup
        // GraphQL -> awsElasticacheParameterGroup: ConfigResourceAwsElasticacheParameterGroup (type)
        if (this.AwsElasticacheParameterGroup != null) {
            var fspec = this.AwsElasticacheParameterGroup.AsFieldSpec(conf.Child("awsElasticacheParameterGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsElasticacheParameterGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsElasticacheSubnetGroup? AwsElasticacheSubnetGroup
        // GraphQL -> awsElasticacheSubnetGroup: ConfigResourceAwsElasticacheSubnetGroup (type)
        if (this.AwsElasticacheSubnetGroup != null) {
            var fspec = this.AwsElasticacheSubnetGroup.AsFieldSpec(conf.Child("awsElasticacheSubnetGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsElasticacheSubnetGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsHostedZone? AwsHostedZone
        // GraphQL -> awsHostedZone: ConfigResourceAwsHostedZone (type)
        if (this.AwsHostedZone != null) {
            var fspec = this.AwsHostedZone.AsFieldSpec(conf.Child("awsHostedZone"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsHostedZone" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsIamRole? AwsIamRole
        // GraphQL -> awsIamRole: ConfigResourceAwsIamRole (type)
        if (this.AwsIamRole != null) {
            var fspec = this.AwsIamRole.AsFieldSpec(conf.Child("awsIamRole"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsIamRole" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsLambda? AwsLambda
        // GraphQL -> awsLambda: ConfigResourceAwsLambda (type)
        if (this.AwsLambda != null) {
            var fspec = this.AwsLambda.AsFieldSpec(conf.Child("awsLambda"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsLambda" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsLaunchTemplate? AwsLaunchTemplate
        // GraphQL -> awsLaunchTemplate: ConfigResourceAwsLaunchTemplate (type)
        if (this.AwsLaunchTemplate != null) {
            var fspec = this.AwsLaunchTemplate.AsFieldSpec(conf.Child("awsLaunchTemplate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsLaunchTemplate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsLoadBalancer? AwsLoadBalancer
        // GraphQL -> awsLoadBalancer: ConfigResourceAwsLoadBalancer (type)
        if (this.AwsLoadBalancer != null) {
            var fspec = this.AwsLoadBalancer.AsFieldSpec(conf.Child("awsLoadBalancer"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsLoadBalancer" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsOptionGroup? AwsOptionGroup
        // GraphQL -> awsOptionGroup: ConfigResourceAwsOptionGroup (type)
        if (this.AwsOptionGroup != null) {
            var fspec = this.AwsOptionGroup.AsFieldSpec(conf.Child("awsOptionGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsOptionGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsParameterGroup? AwsParameterGroup
        // GraphQL -> awsParameterGroup: ConfigResourceAwsParameterGroup (type)
        if (this.AwsParameterGroup != null) {
            var fspec = this.AwsParameterGroup.AsFieldSpec(conf.Child("awsParameterGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsParameterGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsSecurityGroup? AwsSecurityGroup
        // GraphQL -> awsSecurityGroup: ConfigResourceAwsSecurityGroup (type)
        if (this.AwsSecurityGroup != null) {
            var fspec = this.AwsSecurityGroup.AsFieldSpec(conf.Child("awsSecurityGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsSecurityGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsSubnet? AwsSubnet
        // GraphQL -> awsSubnet: ConfigResourceAwsSubnet (type)
        if (this.AwsSubnet != null) {
            var fspec = this.AwsSubnet.AsFieldSpec(conf.Child("awsSubnet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsSubnet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsTargetGroup? AwsTargetGroup
        // GraphQL -> awsTargetGroup: ConfigResourceAwsTargetGroup (type)
        if (this.AwsTargetGroup != null) {
            var fspec = this.AwsTargetGroup.AsFieldSpec(conf.Child("awsTargetGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsTargetGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigResourceAwsVpc? AwsVpc
        // GraphQL -> awsVpc: ConfigResourceAwsVpc (type)
        if (this.AwsVpc != null) {
            var fspec = this.AwsVpc.AsFieldSpec(conf.Child("awsVpc"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsVpc" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ConfigResourceAwsAutoScalingGroup? AwsAutoScalingGroup
        // GraphQL -> awsAutoScalingGroup: ConfigResourceAwsAutoScalingGroup (type)
        if (ec.Includes("awsAutoScalingGroup",false))
        {
            if(this.AwsAutoScalingGroup == null) {

                this.AwsAutoScalingGroup = new ConfigResourceAwsAutoScalingGroup();
                this.AwsAutoScalingGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsAutoScalingGroup"));

            } else {

                this.AwsAutoScalingGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsAutoScalingGroup"));

            }
        }
        else if (this.AwsAutoScalingGroup != null && ec.Excludes("awsAutoScalingGroup",false))
        {
            this.AwsAutoScalingGroup = null;
        }
        //      C# -> ConfigResourceAwsEcr? AwsEcr
        // GraphQL -> awsEcr: ConfigResourceAwsEcr (type)
        if (ec.Includes("awsEcr",false))
        {
            if(this.AwsEcr == null) {

                this.AwsEcr = new ConfigResourceAwsEcr();
                this.AwsEcr.ApplyExploratoryFieldSpec(ec.NewChild("awsEcr"));

            } else {

                this.AwsEcr.ApplyExploratoryFieldSpec(ec.NewChild("awsEcr"));

            }
        }
        else if (this.AwsEcr != null && ec.Excludes("awsEcr",false))
        {
            this.AwsEcr = null;
        }
        //      C# -> ConfigResourceAwsEcs? AwsEcs
        // GraphQL -> awsEcs: ConfigResourceAwsEcs (type)
        if (ec.Includes("awsEcs",false))
        {
            if(this.AwsEcs == null) {

                this.AwsEcs = new ConfigResourceAwsEcs();
                this.AwsEcs.ApplyExploratoryFieldSpec(ec.NewChild("awsEcs"));

            } else {

                this.AwsEcs.ApplyExploratoryFieldSpec(ec.NewChild("awsEcs"));

            }
        }
        else if (this.AwsEcs != null && ec.Excludes("awsEcs",false))
        {
            this.AwsEcs = null;
        }
        //      C# -> ConfigResourceAwsEks? AwsEks
        // GraphQL -> awsEks: ConfigResourceAwsEks (type)
        if (ec.Includes("awsEks",false))
        {
            if(this.AwsEks == null) {

                this.AwsEks = new ConfigResourceAwsEks();
                this.AwsEks.ApplyExploratoryFieldSpec(ec.NewChild("awsEks"));

            } else {

                this.AwsEks.ApplyExploratoryFieldSpec(ec.NewChild("awsEks"));

            }
        }
        else if (this.AwsEks != null && ec.Excludes("awsEks",false))
        {
            this.AwsEks = null;
        }
        //      C# -> ConfigResourceAwsElasticache? AwsElasticache
        // GraphQL -> awsElasticache: ConfigResourceAwsElasticache (type)
        if (ec.Includes("awsElasticache",false))
        {
            if(this.AwsElasticache == null) {

                this.AwsElasticache = new ConfigResourceAwsElasticache();
                this.AwsElasticache.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticache"));

            } else {

                this.AwsElasticache.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticache"));

            }
        }
        else if (this.AwsElasticache != null && ec.Excludes("awsElasticache",false))
        {
            this.AwsElasticache = null;
        }
        //      C# -> ConfigResourceAwsElasticacheParameterGroup? AwsElasticacheParameterGroup
        // GraphQL -> awsElasticacheParameterGroup: ConfigResourceAwsElasticacheParameterGroup (type)
        if (ec.Includes("awsElasticacheParameterGroup",false))
        {
            if(this.AwsElasticacheParameterGroup == null) {

                this.AwsElasticacheParameterGroup = new ConfigResourceAwsElasticacheParameterGroup();
                this.AwsElasticacheParameterGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticacheParameterGroup"));

            } else {

                this.AwsElasticacheParameterGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticacheParameterGroup"));

            }
        }
        else if (this.AwsElasticacheParameterGroup != null && ec.Excludes("awsElasticacheParameterGroup",false))
        {
            this.AwsElasticacheParameterGroup = null;
        }
        //      C# -> ConfigResourceAwsElasticacheSubnetGroup? AwsElasticacheSubnetGroup
        // GraphQL -> awsElasticacheSubnetGroup: ConfigResourceAwsElasticacheSubnetGroup (type)
        if (ec.Includes("awsElasticacheSubnetGroup",false))
        {
            if(this.AwsElasticacheSubnetGroup == null) {

                this.AwsElasticacheSubnetGroup = new ConfigResourceAwsElasticacheSubnetGroup();
                this.AwsElasticacheSubnetGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticacheSubnetGroup"));

            } else {

                this.AwsElasticacheSubnetGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsElasticacheSubnetGroup"));

            }
        }
        else if (this.AwsElasticacheSubnetGroup != null && ec.Excludes("awsElasticacheSubnetGroup",false))
        {
            this.AwsElasticacheSubnetGroup = null;
        }
        //      C# -> ConfigResourceAwsHostedZone? AwsHostedZone
        // GraphQL -> awsHostedZone: ConfigResourceAwsHostedZone (type)
        if (ec.Includes("awsHostedZone",false))
        {
            if(this.AwsHostedZone == null) {

                this.AwsHostedZone = new ConfigResourceAwsHostedZone();
                this.AwsHostedZone.ApplyExploratoryFieldSpec(ec.NewChild("awsHostedZone"));

            } else {

                this.AwsHostedZone.ApplyExploratoryFieldSpec(ec.NewChild("awsHostedZone"));

            }
        }
        else if (this.AwsHostedZone != null && ec.Excludes("awsHostedZone",false))
        {
            this.AwsHostedZone = null;
        }
        //      C# -> ConfigResourceAwsIamRole? AwsIamRole
        // GraphQL -> awsIamRole: ConfigResourceAwsIamRole (type)
        if (ec.Includes("awsIamRole",false))
        {
            if(this.AwsIamRole == null) {

                this.AwsIamRole = new ConfigResourceAwsIamRole();
                this.AwsIamRole.ApplyExploratoryFieldSpec(ec.NewChild("awsIamRole"));

            } else {

                this.AwsIamRole.ApplyExploratoryFieldSpec(ec.NewChild("awsIamRole"));

            }
        }
        else if (this.AwsIamRole != null && ec.Excludes("awsIamRole",false))
        {
            this.AwsIamRole = null;
        }
        //      C# -> ConfigResourceAwsLambda? AwsLambda
        // GraphQL -> awsLambda: ConfigResourceAwsLambda (type)
        if (ec.Includes("awsLambda",false))
        {
            if(this.AwsLambda == null) {

                this.AwsLambda = new ConfigResourceAwsLambda();
                this.AwsLambda.ApplyExploratoryFieldSpec(ec.NewChild("awsLambda"));

            } else {

                this.AwsLambda.ApplyExploratoryFieldSpec(ec.NewChild("awsLambda"));

            }
        }
        else if (this.AwsLambda != null && ec.Excludes("awsLambda",false))
        {
            this.AwsLambda = null;
        }
        //      C# -> ConfigResourceAwsLaunchTemplate? AwsLaunchTemplate
        // GraphQL -> awsLaunchTemplate: ConfigResourceAwsLaunchTemplate (type)
        if (ec.Includes("awsLaunchTemplate",false))
        {
            if(this.AwsLaunchTemplate == null) {

                this.AwsLaunchTemplate = new ConfigResourceAwsLaunchTemplate();
                this.AwsLaunchTemplate.ApplyExploratoryFieldSpec(ec.NewChild("awsLaunchTemplate"));

            } else {

                this.AwsLaunchTemplate.ApplyExploratoryFieldSpec(ec.NewChild("awsLaunchTemplate"));

            }
        }
        else if (this.AwsLaunchTemplate != null && ec.Excludes("awsLaunchTemplate",false))
        {
            this.AwsLaunchTemplate = null;
        }
        //      C# -> ConfigResourceAwsLoadBalancer? AwsLoadBalancer
        // GraphQL -> awsLoadBalancer: ConfigResourceAwsLoadBalancer (type)
        if (ec.Includes("awsLoadBalancer",false))
        {
            if(this.AwsLoadBalancer == null) {

                this.AwsLoadBalancer = new ConfigResourceAwsLoadBalancer();
                this.AwsLoadBalancer.ApplyExploratoryFieldSpec(ec.NewChild("awsLoadBalancer"));

            } else {

                this.AwsLoadBalancer.ApplyExploratoryFieldSpec(ec.NewChild("awsLoadBalancer"));

            }
        }
        else if (this.AwsLoadBalancer != null && ec.Excludes("awsLoadBalancer",false))
        {
            this.AwsLoadBalancer = null;
        }
        //      C# -> ConfigResourceAwsOptionGroup? AwsOptionGroup
        // GraphQL -> awsOptionGroup: ConfigResourceAwsOptionGroup (type)
        if (ec.Includes("awsOptionGroup",false))
        {
            if(this.AwsOptionGroup == null) {

                this.AwsOptionGroup = new ConfigResourceAwsOptionGroup();
                this.AwsOptionGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsOptionGroup"));

            } else {

                this.AwsOptionGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsOptionGroup"));

            }
        }
        else if (this.AwsOptionGroup != null && ec.Excludes("awsOptionGroup",false))
        {
            this.AwsOptionGroup = null;
        }
        //      C# -> ConfigResourceAwsParameterGroup? AwsParameterGroup
        // GraphQL -> awsParameterGroup: ConfigResourceAwsParameterGroup (type)
        if (ec.Includes("awsParameterGroup",false))
        {
            if(this.AwsParameterGroup == null) {

                this.AwsParameterGroup = new ConfigResourceAwsParameterGroup();
                this.AwsParameterGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsParameterGroup"));

            } else {

                this.AwsParameterGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsParameterGroup"));

            }
        }
        else if (this.AwsParameterGroup != null && ec.Excludes("awsParameterGroup",false))
        {
            this.AwsParameterGroup = null;
        }
        //      C# -> ConfigResourceAwsSecurityGroup? AwsSecurityGroup
        // GraphQL -> awsSecurityGroup: ConfigResourceAwsSecurityGroup (type)
        if (ec.Includes("awsSecurityGroup",false))
        {
            if(this.AwsSecurityGroup == null) {

                this.AwsSecurityGroup = new ConfigResourceAwsSecurityGroup();
                this.AwsSecurityGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsSecurityGroup"));

            } else {

                this.AwsSecurityGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsSecurityGroup"));

            }
        }
        else if (this.AwsSecurityGroup != null && ec.Excludes("awsSecurityGroup",false))
        {
            this.AwsSecurityGroup = null;
        }
        //      C# -> ConfigResourceAwsSubnet? AwsSubnet
        // GraphQL -> awsSubnet: ConfigResourceAwsSubnet (type)
        if (ec.Includes("awsSubnet",false))
        {
            if(this.AwsSubnet == null) {

                this.AwsSubnet = new ConfigResourceAwsSubnet();
                this.AwsSubnet.ApplyExploratoryFieldSpec(ec.NewChild("awsSubnet"));

            } else {

                this.AwsSubnet.ApplyExploratoryFieldSpec(ec.NewChild("awsSubnet"));

            }
        }
        else if (this.AwsSubnet != null && ec.Excludes("awsSubnet",false))
        {
            this.AwsSubnet = null;
        }
        //      C# -> ConfigResourceAwsTargetGroup? AwsTargetGroup
        // GraphQL -> awsTargetGroup: ConfigResourceAwsTargetGroup (type)
        if (ec.Includes("awsTargetGroup",false))
        {
            if(this.AwsTargetGroup == null) {

                this.AwsTargetGroup = new ConfigResourceAwsTargetGroup();
                this.AwsTargetGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsTargetGroup"));

            } else {

                this.AwsTargetGroup.ApplyExploratoryFieldSpec(ec.NewChild("awsTargetGroup"));

            }
        }
        else if (this.AwsTargetGroup != null && ec.Excludes("awsTargetGroup",false))
        {
            this.AwsTargetGroup = null;
        }
        //      C# -> ConfigResourceAwsVpc? AwsVpc
        // GraphQL -> awsVpc: ConfigResourceAwsVpc (type)
        if (ec.Includes("awsVpc",false))
        {
            if(this.AwsVpc == null) {

                this.AwsVpc = new ConfigResourceAwsVpc();
                this.AwsVpc.ApplyExploratoryFieldSpec(ec.NewChild("awsVpc"));

            } else {

                this.AwsVpc.ApplyExploratoryFieldSpec(ec.NewChild("awsVpc"));

            }
        }
        else if (this.AwsVpc != null && ec.Excludes("awsVpc",false))
        {
            this.AwsVpc = null;
        }
    }


    #endregion

    } // class SpecificResource
    
    #endregion

    public static class ListSpecificResourceExtensions
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
            this List<SpecificResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SpecificResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SpecificResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SpecificResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SpecificResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types