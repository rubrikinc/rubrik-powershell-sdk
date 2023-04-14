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

namespace Rubrik.SecurityCloud.Types
{
    #region GenerateConfigProtectionRestoreFormReply
    public class GenerateConfigProtectionRestoreFormReply: IFragment
    {
        #region members
        //      C# -> RestoreFormConfigurations? Configurations
        // GraphQL -> configurations: RestoreFormConfigurations (type)
        [JsonProperty("configurations")]
        public RestoreFormConfigurations? Configurations { get; set; }

        //      C# -> List<ConfigurationTypes>? ConfigurationTypes
        // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
        [JsonProperty("configurationTypes")]
        public List<ConfigurationTypes>? ConfigurationTypes { get; set; }

        #endregion

    #region methods

    public GenerateConfigProtectionRestoreFormReply Set(
        RestoreFormConfigurations? Configurations = null,
        List<ConfigurationTypes>? ConfigurationTypes = null
    ) 
    {
        if ( Configurations != null ) {
            this.Configurations = Configurations;
        }
        if ( ConfigurationTypes != null ) {
            this.ConfigurationTypes = ConfigurationTypes;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> RestoreFormConfigurations? Configurations
            // GraphQL -> configurations: RestoreFormConfigurations (type)
            if (this.Configurations != null)
            {
                 s += ind + "configurations\n";

                 s += ind + "{\n" + 
                 this.Configurations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ConfigurationTypes>? ConfigurationTypes
            // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
            if (this.ConfigurationTypes != null)
            {
                 s += ind + "configurationTypes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> RestoreFormConfigurations? Configurations
            // GraphQL -> configurations: RestoreFormConfigurations (type)
            if (this.Configurations == null && Exploration.Includes(parent + ".configurations"))
            {
                this.Configurations = new RestoreFormConfigurations();
                this.Configurations.ApplyExploratoryFragment(parent + ".configurations");
            }
            //      C# -> List<ConfigurationTypes>? ConfigurationTypes
            // GraphQL -> configurationTypes: [ConfigurationTypes!]! (enum)
            if (this.ConfigurationTypes == null && Exploration.Includes(parent + ".configurationTypes$"))
            {
                this.ConfigurationTypes = new List<ConfigurationTypes>();
            }
        }


    #endregion

    } // class GenerateConfigProtectionRestoreFormReply
    #endregion

    public static class ListGenerateConfigProtectionRestoreFormReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GenerateConfigProtectionRestoreFormReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GenerateConfigProtectionRestoreFormReply> list, 
            String parent = "")
        {
            var item = new GenerateConfigProtectionRestoreFormReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types