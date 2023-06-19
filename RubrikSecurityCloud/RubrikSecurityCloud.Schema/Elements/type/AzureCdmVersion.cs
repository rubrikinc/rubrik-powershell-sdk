// AzureCdmVersion.cs
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
    #region AzureCdmVersion
    public class AzureCdmVersion: BaseType
    {
        #region members

        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        [JsonProperty("supportedInstanceTypes")]
        public List<AzureInstanceType>? SupportedInstanceTypes { get; set; }

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


        #endregion

    #region methods

    public AzureCdmVersion Set(
        List<AzureInstanceType>? SupportedInstanceTypes = null,
        System.String? CdmVersion = null,
        System.String? Sku = null,
        System.String? Version = null,
        List<AzureCdmVersionTag>? Tags = null
    ) 
    {
        if ( SupportedInstanceTypes != null ) {
            this.SupportedInstanceTypes = SupportedInstanceTypes;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        if (this.SupportedInstanceTypes != null) {
            s += ind + "supportedInstanceTypes\n" ;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            s += ind + "cdmVersion\n" ;
        }
        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        if (this.Sku != null) {
            s += ind + "sku\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tags {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        if (this.SupportedInstanceTypes == null && Exploration.Includes(parent + ".supportedInstanceTypes", true))
        {
            this.SupportedInstanceTypes = new List<AzureInstanceType>();
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion", true))
        {
            this.CdmVersion = "FETCH";
        }
        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        if (this.Sku == null && Exploration.Includes(parent + ".sku", true))
        {
            this.Sku = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<AzureCdmVersionTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
    }


    #endregion

    } // class AzureCdmVersion
    
    #endregion

    public static class ListAzureCdmVersionExtensions
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
            this List<AzureCdmVersion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCdmVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCdmVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types