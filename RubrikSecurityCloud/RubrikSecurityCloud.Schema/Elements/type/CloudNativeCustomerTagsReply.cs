// CloudNativeCustomerTagsReply.cs
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
    #region CloudNativeCustomerTagsReply
    public class CloudNativeCustomerTagsReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        [JsonProperty("shouldOverrideResourceTags")]
        public System.Boolean? ShouldOverrideResourceTags { get; set; }

        //      C# -> List<TagObject>? CustomerTags
        // GraphQL -> customerTags: [TagObject!]! (type)
        [JsonProperty("customerTags")]
        public List<TagObject>? CustomerTags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeCustomerTagsReply";
    }

    public CloudNativeCustomerTagsReply Set(
        System.Boolean? ShouldOverrideResourceTags = null,
        List<TagObject>? CustomerTags = null
    ) 
    {
        if ( ShouldOverrideResourceTags != null ) {
            this.ShouldOverrideResourceTags = ShouldOverrideResourceTags;
        }
        if ( CustomerTags != null ) {
            this.CustomerTags = CustomerTags;
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
        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        if (this.ShouldOverrideResourceTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldOverrideResourceTags\n" ;
            } else {
                s += ind + "shouldOverrideResourceTags\n" ;
            }
        }
        //      C# -> List<TagObject>? CustomerTags
        // GraphQL -> customerTags: [TagObject!]! (type)
        if (this.CustomerTags != null) {
            var fspec = this.CustomerTags.AsFieldSpec(conf.Child("customerTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "customerTags {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        if (ec.Includes("shouldOverrideResourceTags",true))
        {
            if(this.ShouldOverrideResourceTags == null) {

                this.ShouldOverrideResourceTags = true;

            } else {


            }
        }
        else if (this.ShouldOverrideResourceTags != null && ec.Excludes("shouldOverrideResourceTags",true))
        {
            this.ShouldOverrideResourceTags = null;
        }
        //      C# -> List<TagObject>? CustomerTags
        // GraphQL -> customerTags: [TagObject!]! (type)
        if (ec.Includes("customerTags",false))
        {
            if(this.CustomerTags == null) {

                this.CustomerTags = new List<TagObject>();
                this.CustomerTags.ApplyExploratoryFieldSpec(ec.NewChild("customerTags"));

            } else {

                this.CustomerTags.ApplyExploratoryFieldSpec(ec.NewChild("customerTags"));

            }
        }
        else if (this.CustomerTags != null && ec.Excludes("customerTags",false))
        {
            this.CustomerTags = null;
        }
    }


    #endregion

    } // class CloudNativeCustomerTagsReply
    
    #endregion

    public static class ListCloudNativeCustomerTagsReplyExtensions
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
            this List<CloudNativeCustomerTagsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CloudNativeCustomerTagsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeCustomerTagsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeCustomerTagsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeCustomerTagsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types