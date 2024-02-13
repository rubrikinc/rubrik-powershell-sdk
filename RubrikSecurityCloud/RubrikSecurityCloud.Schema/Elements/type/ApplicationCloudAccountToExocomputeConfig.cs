// ApplicationCloudAccountToExocomputeConfig.cs
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
    #region ApplicationCloudAccountToExocomputeConfig
    public class ApplicationCloudAccountToExocomputeConfig: BaseType
    {
        #region members

        //      C# -> AwsExocomputeGetConfigurationResponse? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: AwsExocomputeGetConfigurationResponse (interface)
        [JsonProperty("exocomputeConfigs")]
        public AwsExocomputeGetConfigurationResponse? ExocomputeConfigs { get; set; }

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationCloudAccountToExocomputeConfig";
    }

    public ApplicationCloudAccountToExocomputeConfig Set(
        AwsExocomputeGetConfigurationResponse? ExocomputeConfigs = null,
        System.String? ApplicationCloudAccountId = null
    ) 
    {
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
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
        //      C# -> AwsExocomputeGetConfigurationResponse? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: AwsExocomputeGetConfigurationResponse (interface)
        if (this.ExocomputeConfigs != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ExocomputeConfigs).AsFieldSpec(conf.Child("exocomputeConfigs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigs {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        if (this.ApplicationCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationCloudAccountId\n" ;
            } else {
                s += ind + "applicationCloudAccountId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsExocomputeGetConfigurationResponse? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: AwsExocomputeGetConfigurationResponse (interface)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                var impls = new List<AwsExocomputeGetConfigurationResponse>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));
                this.ExocomputeConfigs = (AwsExocomputeGetConfigurationResponse)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<AwsExocomputeGetConfigurationResponse>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));
                this.ExocomputeConfigs = (AwsExocomputeGetConfigurationResponse)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ExocomputeConfigs != null && ec.Excludes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = null;
        }
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        if (ec.Includes("applicationCloudAccountId",true))
        {
            if(this.ApplicationCloudAccountId == null) {

                this.ApplicationCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationCloudAccountId != null && ec.Excludes("applicationCloudAccountId",true))
        {
            this.ApplicationCloudAccountId = null;
        }
    }


    #endregion

    } // class ApplicationCloudAccountToExocomputeConfig
    
    #endregion

    public static class ListApplicationCloudAccountToExocomputeConfigExtensions
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
            this List<ApplicationCloudAccountToExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ApplicationCloudAccountToExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationCloudAccountToExocomputeConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationCloudAccountToExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationCloudAccountToExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types