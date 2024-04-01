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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<CreateAwsExocomputeConfigsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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