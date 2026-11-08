// ConfigResourceAwsParameterGroup.cs
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
    #region ConfigResourceAwsParameterGroup
    public class ConfigResourceAwsParameterGroup: BaseType
    {
        #region members

        //      C# -> AwsParameterGroupType? Type
        // GraphQL -> type: AwsParameterGroupType! (enum)
        [JsonProperty("type")]
        public AwsParameterGroupType? Type { get; set; }

        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        [JsonProperty("engine")]
        public System.String? Engine { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsParameterGroup";
    }

    public ConfigResourceAwsParameterGroup Set(
        AwsParameterGroupType? Type = null,
        System.String? Engine = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Engine != null ) {
            this.Engine = Engine;
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
        //      C# -> AwsParameterGroupType? Type
        // GraphQL -> type: AwsParameterGroupType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (this.Engine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "engine\n" ;
            } else {
                s += ind + "engine\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsParameterGroupType? Type
        // GraphQL -> type: AwsParameterGroupType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new AwsParameterGroupType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (ec.Includes("engine",true))
        {
            if(this.Engine == null) {

                this.Engine = "FETCH";

            } else {


            }
        }
        else if (this.Engine != null && ec.Excludes("engine",true))
        {
            this.Engine = null;
        }
    }


    #endregion

    } // class ConfigResourceAwsParameterGroup
    
    #endregion

    public static class ListConfigResourceAwsParameterGroupExtensions
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
            this List<ConfigResourceAwsParameterGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsParameterGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsParameterGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsParameterGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsParameterGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types