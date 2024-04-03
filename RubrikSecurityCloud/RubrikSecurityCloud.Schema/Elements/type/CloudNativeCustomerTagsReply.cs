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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "customerTags" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<CloudNativeCustomerTagsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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