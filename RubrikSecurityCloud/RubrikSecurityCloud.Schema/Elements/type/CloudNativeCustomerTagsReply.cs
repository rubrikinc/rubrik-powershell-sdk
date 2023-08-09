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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        if (this.ShouldOverrideResourceTags != null) {
            s += ind + "shouldOverrideResourceTags\n" ;
        }
        //      C# -> List<TagObject>? CustomerTags
        // GraphQL -> customerTags: [TagObject!]! (type)
        if (this.CustomerTags != null) {
            var fspec = this.CustomerTags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "customerTags {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        if (this.ShouldOverrideResourceTags == null && Exploration.Includes(parent + ".shouldOverrideResourceTags", true))
        {
            this.ShouldOverrideResourceTags = true;
        }
        //      C# -> List<TagObject>? CustomerTags
        // GraphQL -> customerTags: [TagObject!]! (type)
        if (this.CustomerTags == null && Exploration.Includes(parent + ".customerTags"))
        {
            this.CustomerTags = new List<TagObject>();
            this.CustomerTags.ApplyExploratoryFieldSpec(parent + ".customerTags");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeCustomerTagsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeCustomerTagsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types