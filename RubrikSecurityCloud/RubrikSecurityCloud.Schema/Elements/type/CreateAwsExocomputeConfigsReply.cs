// CreateAwsExocomputeConfigsReply.cs
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
    #region CreateAwsExocomputeConfigsReply
    public class CreateAwsExocomputeConfigsReply: BaseType
    {
        #region members

        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        [JsonProperty("exocomputeConfigs")]
        public List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs { get; set; }

        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        [JsonProperty("configs")]
        public List<AwsExocomputeGetConfigResponse>? Configs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateAwsExocomputeConfigsReply";
    }

    public CreateAwsExocomputeConfigsReply Set(
        List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs = null,
        List<AwsExocomputeGetConfigResponse>? Configs = null
    ) 
    {
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( Configs != null ) {
            this.Configs = Configs;
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
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(conf.Child("configs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configs {\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (ec.Includes("configs",false))
        {
            if(this.Configs == null) {

                this.Configs = new List<AwsExocomputeGetConfigResponse>();
                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            } else {

                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            }
        }
        else if (this.Configs != null && ec.Excludes("configs",false))
        {
            this.Configs = null;
        }
    }


    #endregion

    } // class CreateAwsExocomputeConfigsReply
    
    #endregion

    public static class ListCreateAwsExocomputeConfigsReplyExtensions
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
            this List<CreateAwsExocomputeConfigsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateAwsExocomputeConfigsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateAwsExocomputeConfigsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateAwsExocomputeConfigsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateAwsExocomputeConfigsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types