// AwsCdmVersion.cs
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
    #region AwsCdmVersion
    public class AwsCdmVersion: BaseType
    {
        #region members

        //      C# -> List<AwsInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AwsInstanceType!]! (enum)
        [JsonProperty("supportedInstanceTypes")]
        public List<AwsInstanceType>? SupportedInstanceTypes { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        [JsonProperty("isLatest")]
        public System.Boolean? IsLatest { get; set; }

        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        [JsonProperty("productCodes")]
        public List<System.String>? ProductCodes { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
        [JsonProperty("tags")]
        public List<AwsCdmVersionTag>? Tags { get; set; }


        #endregion

    #region methods

    public AwsCdmVersion Set(
        List<AwsInstanceType>? SupportedInstanceTypes = null,
        System.String? ImageId = null,
        System.Boolean? IsLatest = null,
        List<System.String>? ProductCodes = null,
        System.String? Version = null,
        List<AwsCdmVersionTag>? Tags = null
    ) 
    {
        if ( SupportedInstanceTypes != null ) {
            this.SupportedInstanceTypes = SupportedInstanceTypes;
        }
        if ( ImageId != null ) {
            this.ImageId = ImageId;
        }
        if ( IsLatest != null ) {
            this.IsLatest = IsLatest;
        }
        if ( ProductCodes != null ) {
            this.ProductCodes = ProductCodes;
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
        //      C# -> List<AwsInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AwsInstanceType!]! (enum)
        if (this.SupportedInstanceTypes != null) {
            s += ind + "supportedInstanceTypes\n" ;
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            s += ind + "imageId\n" ;
        }
        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        if (this.IsLatest != null) {
            s += ind + "isLatest\n" ;
        }
        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        if (this.ProductCodes != null) {
            s += ind + "productCodes\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
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
        //      C# -> List<AwsInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AwsInstanceType!]! (enum)
        if (this.SupportedInstanceTypes == null && Exploration.Includes(parent + ".supportedInstanceTypes", true))
        {
            this.SupportedInstanceTypes = new List<AwsInstanceType>();
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId == null && Exploration.Includes(parent + ".imageId", true))
        {
            this.ImageId = "FETCH";
        }
        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        if (this.IsLatest == null && Exploration.Includes(parent + ".isLatest", true))
        {
            this.IsLatest = true;
        }
        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        if (this.ProductCodes == null && Exploration.Includes(parent + ".productCodes", true))
        {
            this.ProductCodes = new List<System.String>();
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<AwsCdmVersionTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
    }


    #endregion

    } // class AwsCdmVersion
    
    #endregion

    public static class ListAwsCdmVersionExtensions
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
            this List<AwsCdmVersion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCdmVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCdmVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types