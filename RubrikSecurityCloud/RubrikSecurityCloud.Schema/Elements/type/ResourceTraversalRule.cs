// ResourceTraversalRule.cs
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
    #region ResourceTraversalRule
    public class ResourceTraversalRule: BaseType
    {
        #region members

        //      C# -> List<ConfigResourceType>? TraversableTypes
        // GraphQL -> traversableTypes: [ConfigResourceType!]! (enum)
        [JsonProperty("traversableTypes")]
        public List<ConfigResourceType>? TraversableTypes { get; set; }

        //      C# -> ConfigResourceType? Type
        // GraphQL -> type: ConfigResourceType! (enum)
        [JsonProperty("type")]
        public ConfigResourceType? Type { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ResourceTraversalRule";
    }

    public ResourceTraversalRule Set(
        List<ConfigResourceType>? TraversableTypes = null,
        ConfigResourceType? Type = null
    ) 
    {
        if ( TraversableTypes != null ) {
            this.TraversableTypes = TraversableTypes;
        }
        if ( Type != null ) {
            this.Type = Type;
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
        //      C# -> List<ConfigResourceType>? TraversableTypes
        // GraphQL -> traversableTypes: [ConfigResourceType!]! (enum)
        if (this.TraversableTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "traversableTypes\n" ;
            } else {
                s += ind + "traversableTypes\n" ;
            }
        }
        //      C# -> ConfigResourceType? Type
        // GraphQL -> type: ConfigResourceType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ConfigResourceType>? TraversableTypes
        // GraphQL -> traversableTypes: [ConfigResourceType!]! (enum)
        if (ec.Includes("traversableTypes",true))
        {
            if(this.TraversableTypes == null) {

                this.TraversableTypes = new List<ConfigResourceType>();

            } else {


            }
        }
        else if (this.TraversableTypes != null && ec.Excludes("traversableTypes",true))
        {
            this.TraversableTypes = null;
        }
        //      C# -> ConfigResourceType? Type
        // GraphQL -> type: ConfigResourceType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ConfigResourceType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
    }


    #endregion

    } // class ResourceTraversalRule
    
    #endregion

    public static class ListResourceTraversalRuleExtensions
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
            this List<ResourceTraversalRule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ResourceTraversalRule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ResourceTraversalRule> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ResourceTraversalRule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ResourceTraversalRule> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types