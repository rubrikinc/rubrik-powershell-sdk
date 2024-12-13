// TemplateInfo.cs
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
    #region TemplateInfo
    public class TemplateInfo: BaseType
    {
        #region members

        //      C# -> System.String? CustomTemplate
        // GraphQL -> customTemplate: String (scalar)
        [JsonProperty("customTemplate")]
        public System.String? CustomTemplate { get; set; }

        //      C# -> System.Int64? TemplateId
        // GraphQL -> templateId: Long (scalar)
        [JsonProperty("templateId")]
        public System.Int64? TemplateId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TemplateInfo";
    }

    public TemplateInfo Set(
        System.String? CustomTemplate = null,
        System.Int64? TemplateId = null
    ) 
    {
        if ( CustomTemplate != null ) {
            this.CustomTemplate = CustomTemplate;
        }
        if ( TemplateId != null ) {
            this.TemplateId = TemplateId;
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
        //      C# -> System.String? CustomTemplate
        // GraphQL -> customTemplate: String (scalar)
        if (this.CustomTemplate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customTemplate\n" ;
            } else {
                s += ind + "customTemplate\n" ;
            }
        }
        //      C# -> System.Int64? TemplateId
        // GraphQL -> templateId: Long (scalar)
        if (this.TemplateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateId\n" ;
            } else {
                s += ind + "templateId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CustomTemplate
        // GraphQL -> customTemplate: String (scalar)
        if (ec.Includes("customTemplate",true))
        {
            if(this.CustomTemplate == null) {

                this.CustomTemplate = "FETCH";

            } else {


            }
        }
        else if (this.CustomTemplate != null && ec.Excludes("customTemplate",true))
        {
            this.CustomTemplate = null;
        }
        //      C# -> System.Int64? TemplateId
        // GraphQL -> templateId: Long (scalar)
        if (ec.Includes("templateId",true))
        {
            if(this.TemplateId == null) {

                this.TemplateId = new System.Int64();

            } else {


            }
        }
        else if (this.TemplateId != null && ec.Excludes("templateId",true))
        {
            this.TemplateId = null;
        }
    }


    #endregion

    } // class TemplateInfo
    
    #endregion

    public static class ListTemplateInfoExtensions
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
            this List<TemplateInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TemplateInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TemplateInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TemplateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TemplateInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types