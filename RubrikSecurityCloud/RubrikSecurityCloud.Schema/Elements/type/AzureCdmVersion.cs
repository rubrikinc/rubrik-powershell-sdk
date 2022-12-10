// AzureCdmVersion.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    #region AzureCdmVersion
    public class AzureCdmVersion: IFragment
    {
        #region members
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        [JsonProperty("sku")]
        public System.String? Sku { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureCdmVersionTag>? Tags { get; set; }

        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        [JsonProperty("supportedInstanceTypes")]
        public List<AzureInstanceType>? SupportedInstanceTypes { get; set; }

        #endregion

    #region methods

    public AzureCdmVersion Set(
        System.String? CdmVersion = null,
        System.String? Sku = null,
        System.String? Version = null,
        List<AzureCdmVersionTag>? Tags = null,
        List<AzureInstanceType>? SupportedInstanceTypes = null
    ) 
    {
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( Sku != null ) {
            this.Sku = Sku;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( SupportedInstanceTypes != null ) {
            this.SupportedInstanceTypes = SupportedInstanceTypes;
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
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion != null)
            {
                 s += ind + "cdmVersion\n";

            }
            //      C# -> System.String? Sku
            // GraphQL -> sku: String! (scalar)
            if (this.Sku != null)
            {
                 s += ind + "sku\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> List<AzureCdmVersionTag>? Tags
            // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

                 s += ind + "{\n" + 
                 this.Tags.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
            // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
            if (this.SupportedInstanceTypes != null)
            {
                 s += ind + "supportedInstanceTypes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion$"))
            {
                this.CdmVersion = new System.String("FETCH");
            }
            //      C# -> System.String? Sku
            // GraphQL -> sku: String! (scalar)
            if (this.Sku == null && Exploration.Includes(parent + ".sku$"))
            {
                this.Sku = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> List<AzureCdmVersionTag>? Tags
            // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<AzureCdmVersionTag>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
            //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
            // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
            if (this.SupportedInstanceTypes == null && Exploration.Includes(parent + ".supportedInstanceTypes$"))
            {
                this.SupportedInstanceTypes = new List<AzureInstanceType>();
            }
        }


    #endregion

    } // class AzureCdmVersion
    #endregion

    public static class ListAzureCdmVersionExtensions
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
            this List<AzureCdmVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCdmVersion> list, 
            String parent = "")
        {
            var item = new AzureCdmVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types