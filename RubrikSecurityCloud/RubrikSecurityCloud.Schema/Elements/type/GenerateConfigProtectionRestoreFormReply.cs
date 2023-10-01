// GenerateConfigProtectionRestoreFormReply.cs
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
    #region GenerateConfigProtectionRestoreFormReply
    public class GenerateConfigProtectionRestoreFormReply: BaseType
    {
        #region members

        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        [JsonProperty("configurationTypes")]
        public List<ConfigurationTypes>? ConfigurationTypes { get; set; }

        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        [JsonProperty("configurations")]
        public RestoreFormConfigurations? Configurations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GenerateConfigProtectionRestoreFormReply";
    }

    public GenerateConfigProtectionRestoreFormReply Set(
        List<ConfigurationTypes>? ConfigurationTypes = null,
        RestoreFormConfigurations? Configurations = null
    ) 
    {
        if ( ConfigurationTypes != null ) {
            this.ConfigurationTypes = ConfigurationTypes;
        }
        if ( Configurations != null ) {
            this.Configurations = Configurations;
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
        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        if (this.ConfigurationTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configurationTypes\n" ;
            } else {
                s += ind + "configurationTypes\n" ;
            }
        }
        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        if (this.Configurations != null) {
            var fspec = this.Configurations.AsFieldSpec(conf.Child("configurations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configurations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        if (ec.Includes("configurationTypes",true))
        {
            if(this.ConfigurationTypes == null) {

                this.ConfigurationTypes = new List<ConfigurationTypes>();

            } else {


            }
        }
        else if (this.ConfigurationTypes != null && ec.Excludes("configurationTypes",true))
        {
            this.ConfigurationTypes = null;
        }
        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        if (ec.Includes("configurations",false))
        {
            if(this.Configurations == null) {

                this.Configurations = new RestoreFormConfigurations();
                this.Configurations.ApplyExploratoryFieldSpec(ec.NewChild("configurations"));

            } else {

                this.Configurations.ApplyExploratoryFieldSpec(ec.NewChild("configurations"));

            }
        }
        else if (this.Configurations != null && ec.Excludes("configurations",false))
        {
            this.Configurations = null;
        }
    }


    #endregion

    } // class GenerateConfigProtectionRestoreFormReply
    
    #endregion

    public static class ListGenerateConfigProtectionRestoreFormReplyExtensions
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
            this List<GenerateConfigProtectionRestoreFormReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GenerateConfigProtectionRestoreFormReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GenerateConfigProtectionRestoreFormReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GenerateConfigProtectionRestoreFormReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GenerateConfigProtectionRestoreFormReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types