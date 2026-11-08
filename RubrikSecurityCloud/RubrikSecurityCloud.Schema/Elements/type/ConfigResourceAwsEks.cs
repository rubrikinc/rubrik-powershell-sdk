// ConfigResourceAwsEks.cs
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
    #region ConfigResourceAwsEks
    public class ConfigResourceAwsEks: BaseType
    {
        #region members

        //      C# -> AwsEksAccessType? AccessType
        // GraphQL -> accessType: AwsEksAccessType! (enum)
        [JsonProperty("accessType")]
        public AwsEksAccessType? AccessType { get; set; }

        //      C# -> AwsEksComputeType? ComputeType
        // GraphQL -> computeType: AwsEksComputeType! (enum)
        [JsonProperty("computeType")]
        public AwsEksComputeType? ComputeType { get; set; }

        //      C# -> System.String? KubernetesVersion
        // GraphQL -> kubernetesVersion: String! (scalar)
        [JsonProperty("kubernetesVersion")]
        public System.String? KubernetesVersion { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsEks";
    }

    public ConfigResourceAwsEks Set(
        AwsEksAccessType? AccessType = null,
        AwsEksComputeType? ComputeType = null,
        System.String? KubernetesVersion = null,
        System.String? VpcName = null
    ) 
    {
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( ComputeType != null ) {
            this.ComputeType = ComputeType;
        }
        if ( KubernetesVersion != null ) {
            this.KubernetesVersion = KubernetesVersion;
        }
        if ( VpcName != null ) {
            this.VpcName = VpcName;
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
        //      C# -> AwsEksAccessType? AccessType
        // GraphQL -> accessType: AwsEksAccessType! (enum)
        if (this.AccessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessType\n" ;
            } else {
                s += ind + "accessType\n" ;
            }
        }
        //      C# -> AwsEksComputeType? ComputeType
        // GraphQL -> computeType: AwsEksComputeType! (enum)
        if (this.ComputeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeType\n" ;
            } else {
                s += ind + "computeType\n" ;
            }
        }
        //      C# -> System.String? KubernetesVersion
        // GraphQL -> kubernetesVersion: String! (scalar)
        if (this.KubernetesVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kubernetesVersion\n" ;
            } else {
                s += ind + "kubernetesVersion\n" ;
            }
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (this.VpcName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcName\n" ;
            } else {
                s += ind + "vpcName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsEksAccessType? AccessType
        // GraphQL -> accessType: AwsEksAccessType! (enum)
        if (ec.Includes("accessType",true))
        {
            if(this.AccessType == null) {

                this.AccessType = new AwsEksAccessType();

            } else {


            }
        }
        else if (this.AccessType != null && ec.Excludes("accessType",true))
        {
            this.AccessType = null;
        }
        //      C# -> AwsEksComputeType? ComputeType
        // GraphQL -> computeType: AwsEksComputeType! (enum)
        if (ec.Includes("computeType",true))
        {
            if(this.ComputeType == null) {

                this.ComputeType = new AwsEksComputeType();

            } else {


            }
        }
        else if (this.ComputeType != null && ec.Excludes("computeType",true))
        {
            this.ComputeType = null;
        }
        //      C# -> System.String? KubernetesVersion
        // GraphQL -> kubernetesVersion: String! (scalar)
        if (ec.Includes("kubernetesVersion",true))
        {
            if(this.KubernetesVersion == null) {

                this.KubernetesVersion = "FETCH";

            } else {


            }
        }
        else if (this.KubernetesVersion != null && ec.Excludes("kubernetesVersion",true))
        {
            this.KubernetesVersion = null;
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (ec.Includes("vpcName",true))
        {
            if(this.VpcName == null) {

                this.VpcName = "FETCH";

            } else {


            }
        }
        else if (this.VpcName != null && ec.Excludes("vpcName",true))
        {
            this.VpcName = null;
        }
    }


    #endregion

    } // class ConfigResourceAwsEks
    
    #endregion

    public static class ListConfigResourceAwsEksExtensions
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
            this List<ConfigResourceAwsEks> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsEks> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsEks> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsEks());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsEks> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types