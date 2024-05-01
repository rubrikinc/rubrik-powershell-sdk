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

    public override string GetGqlTypeName() {
        return "AwsCdmVersion";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<AwsInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AwsInstanceType!]! (enum)
        if (this.SupportedInstanceTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedInstanceTypes\n" ;
            } else {
                s += ind + "supportedInstanceTypes\n" ;
            }
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageId\n" ;
            } else {
                s += ind + "imageId\n" ;
            }
        }
        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        if (this.IsLatest != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLatest\n" ;
            } else {
                s += ind + "isLatest\n" ;
            }
        }
        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        if (this.ProductCodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productCodes\n" ;
            } else {
                s += ind + "productCodes\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(conf.Child("tags"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AwsInstanceType!]! (enum)
        if (ec.Includes("supportedInstanceTypes",true))
        {
            if(this.SupportedInstanceTypes == null) {

                this.SupportedInstanceTypes = new List<AwsInstanceType>();

            } else {


            }
        }
        else if (this.SupportedInstanceTypes != null && ec.Excludes("supportedInstanceTypes",true))
        {
            this.SupportedInstanceTypes = null;
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (ec.Includes("imageId",true))
        {
            if(this.ImageId == null) {

                this.ImageId = "FETCH";

            } else {


            }
        }
        else if (this.ImageId != null && ec.Excludes("imageId",true))
        {
            this.ImageId = null;
        }
        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        if (ec.Includes("isLatest",true))
        {
            if(this.IsLatest == null) {

                this.IsLatest = true;

            } else {


            }
        }
        else if (this.IsLatest != null && ec.Excludes("isLatest",true))
        {
            this.IsLatest = null;
        }
        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        if (ec.Includes("productCodes",true))
        {
            if(this.ProductCodes == null) {

                this.ProductCodes = new List<System.String>();

            } else {


            }
        }
        else if (this.ProductCodes != null && ec.Excludes("productCodes",true))
        {
            this.ProductCodes = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
        if (ec.Includes("tags",false))
        {
            if(this.Tags == null) {

                this.Tags = new List<AwsCdmVersionTag>();
                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            } else {

                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            }
        }
        else if (this.Tags != null && ec.Excludes("tags",false))
        {
            this.Tags = null;
        }
    }


    #endregion

    } // class AwsCdmVersion
    
    #endregion

    public static class ListAwsCdmVersionExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsCdmVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCdmVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCdmVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCdmVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCdmVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types