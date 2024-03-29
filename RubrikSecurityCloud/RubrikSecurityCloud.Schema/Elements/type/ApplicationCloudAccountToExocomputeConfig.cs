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

        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        [JsonProperty("exocomputeConfigs")]
        public List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs { get; set; }

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        [JsonProperty("isHost")]
        public System.Boolean? IsHost { get; set; }

        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("mappedExocomputeAccount")]
        public CloudAccountDetails? MappedExocomputeAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationCloudAccountToExocomputeConfig";
    }

    public ApplicationCloudAccountToExocomputeConfig Set(
        List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs = null,
        System.String? ApplicationCloudAccountId = null,
        System.Boolean? IsHost = null,
        CloudAccountDetails? MappedExocomputeAccount = null
    ) 
    {
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
        }
        if ( IsHost != null ) {
            this.IsHost = IsHost;
        }
        if ( MappedExocomputeAccount != null ) {
            this.MappedExocomputeAccount = MappedExocomputeAccount;
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
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (this.ExocomputeConfigs != null) {
                var fspec = this.ExocomputeConfigs.AsFieldSpec(conf.Child("exocomputeConfigs"));
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
        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        if (this.IsHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHost\n" ;
            } else {
                s += ind + "isHost\n" ;
            }
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (this.MappedExocomputeAccount != null) {
            var fspec = this.MappedExocomputeAccount.AsFieldSpec(conf.Child("mappedExocomputeAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeAccount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                this.ExocomputeConfigs = new List<AwsExocomputeGetConfigurationResponse>();
                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            } else {

                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

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
        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        if (ec.Includes("isHost",true))
        {
            if(this.IsHost == null) {

                this.IsHost = true;

            } else {


            }
        }
        else if (this.IsHost != null && ec.Excludes("isHost",true))
        {
            this.IsHost = null;
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (ec.Includes("mappedExocomputeAccount",false))
        {
            if(this.MappedExocomputeAccount == null) {

                this.MappedExocomputeAccount = new CloudAccountDetails();
                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            } else {

                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            }
        }
        else if (this.MappedExocomputeAccount != null && ec.Excludes("mappedExocomputeAccount",false))
        {
            this.MappedExocomputeAccount = null;
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