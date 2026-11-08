// ApplicationCloudConfig.cs
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
    #region ApplicationCloudConfig
    public class ApplicationCloudConfig: BaseType
    {
        #region members

        //      C# -> AwsApplicationServiceConfiguration? AwsConfig
        // GraphQL -> awsConfig: AwsApplicationServiceConfiguration (type)
        [JsonProperty("awsConfig")]
        public AwsApplicationServiceConfiguration? AwsConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationCloudConfig";
    }

    public ApplicationCloudConfig Set(
        AwsApplicationServiceConfiguration? AwsConfig = null
    ) 
    {
        if ( AwsConfig != null ) {
            this.AwsConfig = AwsConfig;
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
        //      C# -> AwsApplicationServiceConfiguration? AwsConfig
        // GraphQL -> awsConfig: AwsApplicationServiceConfiguration (type)
        if (this.AwsConfig != null) {
            var fspec = this.AwsConfig.AsFieldSpec(conf.Child("awsConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsApplicationServiceConfiguration? AwsConfig
        // GraphQL -> awsConfig: AwsApplicationServiceConfiguration (type)
        if (ec.Includes("awsConfig",false))
        {
            if(this.AwsConfig == null) {

                this.AwsConfig = new AwsApplicationServiceConfiguration();
                this.AwsConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsConfig"));

            } else {

                this.AwsConfig.ApplyExploratoryFieldSpec(ec.NewChild("awsConfig"));

            }
        }
        else if (this.AwsConfig != null && ec.Excludes("awsConfig",false))
        {
            this.AwsConfig = null;
        }
    }


    #endregion

    } // class ApplicationCloudConfig
    
    #endregion

    public static class ListApplicationCloudConfigExtensions
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
            this List<ApplicationCloudConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationCloudConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationCloudConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationCloudConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationCloudConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types