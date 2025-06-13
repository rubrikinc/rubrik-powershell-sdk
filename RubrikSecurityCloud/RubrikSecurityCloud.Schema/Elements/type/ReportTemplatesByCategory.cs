// ReportTemplatesByCategory.cs
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
    #region ReportTemplatesByCategory
    public class ReportTemplatesByCategory: BaseType
    {
        #region members

        //      C# -> ReportCategory? Category
        // GraphQL -> category: ReportCategory! (enum)
        [JsonProperty("category")]
        public ReportCategory? Category { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> List<RscReportTemplate>? Templates
        // GraphQL -> templates: [RscReportTemplate!]! (type)
        [JsonProperty("templates")]
        public List<RscReportTemplate>? Templates { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReportTemplatesByCategory";
    }

    public ReportTemplatesByCategory Set(
        ReportCategory? Category = null,
        System.String? DisplayName = null,
        List<RscReportTemplate>? Templates = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Templates != null ) {
            this.Templates = Templates;
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
        //      C# -> ReportCategory? Category
        // GraphQL -> category: ReportCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> List<RscReportTemplate>? Templates
        // GraphQL -> templates: [RscReportTemplate!]! (type)
        if (this.Templates != null) {
            var fspec = this.Templates.AsFieldSpec(conf.Child("templates"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "templates" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ReportCategory? Category
        // GraphQL -> category: ReportCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new ReportCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> List<RscReportTemplate>? Templates
        // GraphQL -> templates: [RscReportTemplate!]! (type)
        if (ec.Includes("templates",false))
        {
            if(this.Templates == null) {

                this.Templates = new List<RscReportTemplate>();
                this.Templates.ApplyExploratoryFieldSpec(ec.NewChild("templates"));

            } else {

                this.Templates.ApplyExploratoryFieldSpec(ec.NewChild("templates"));

            }
        }
        else if (this.Templates != null && ec.Excludes("templates",false))
        {
            this.Templates = null;
        }
    }


    #endregion

    } // class ReportTemplatesByCategory
    
    #endregion

    public static class ListReportTemplatesByCategoryExtensions
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
            this List<ReportTemplatesByCategory> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReportTemplatesByCategory> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReportTemplatesByCategory> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportTemplatesByCategory());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportTemplatesByCategory> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types