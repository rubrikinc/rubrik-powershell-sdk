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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        if (this.ConfigurationTypes != null) {
            s += ind + "configurationTypes\n" ;
        }
        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        if (this.Configurations != null) {
            s += ind + "configurations {\n" + this.Configurations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        if (this.ConfigurationTypes == null && Exploration.Includes(parent + ".configurationTypes", true))
        {
            this.ConfigurationTypes = new List<ConfigurationTypes>();
        }
        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        if (this.Configurations == null && Exploration.Includes(parent + ".configurations"))
        {
            this.Configurations = new RestoreFormConfigurations();
            this.Configurations.ApplyExploratoryFieldSpec(parent + ".configurations");
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GenerateConfigProtectionRestoreFormReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GenerateConfigProtectionRestoreFormReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types