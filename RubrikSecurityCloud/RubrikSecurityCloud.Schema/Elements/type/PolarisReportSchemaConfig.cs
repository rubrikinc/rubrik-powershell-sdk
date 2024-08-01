// PolarisReportSchemaConfig.cs
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
    #region PolarisReportSchemaConfig
    public class PolarisReportSchemaConfig: BaseType
    {
        #region members

        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        [JsonProperty("chartTitle")]
        public System.String? ChartTitle { get; set; }

        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        [JsonProperty("defaultName")]
        public System.String? DefaultName { get; set; }

        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        [JsonProperty("tableTitle")]
        public System.String? TableTitle { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportSchemaConfig";
    }

    public PolarisReportSchemaConfig Set(
        System.String? ChartTitle = null,
        System.String? DefaultName = null,
        System.String? TableTitle = null
    ) 
    {
        if ( ChartTitle != null ) {
            this.ChartTitle = ChartTitle;
        }
        if ( DefaultName != null ) {
            this.DefaultName = DefaultName;
        }
        if ( TableTitle != null ) {
            this.TableTitle = TableTitle;
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
        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        if (this.ChartTitle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartTitle\n" ;
            } else {
                s += ind + "chartTitle\n" ;
            }
        }
        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        if (this.DefaultName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultName\n" ;
            } else {
                s += ind + "defaultName\n" ;
            }
        }
        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        if (this.TableTitle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tableTitle\n" ;
            } else {
                s += ind + "tableTitle\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        if (ec.Includes("chartTitle",true))
        {
            if(this.ChartTitle == null) {

                this.ChartTitle = "FETCH";

            } else {


            }
        }
        else if (this.ChartTitle != null && ec.Excludes("chartTitle",true))
        {
            this.ChartTitle = null;
        }
        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        if (ec.Includes("defaultName",true))
        {
            if(this.DefaultName == null) {

                this.DefaultName = "FETCH";

            } else {


            }
        }
        else if (this.DefaultName != null && ec.Excludes("defaultName",true))
        {
            this.DefaultName = null;
        }
        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        if (ec.Includes("tableTitle",true))
        {
            if(this.TableTitle == null) {

                this.TableTitle = "FETCH";

            } else {


            }
        }
        else if (this.TableTitle != null && ec.Excludes("tableTitle",true))
        {
            this.TableTitle = null;
        }
    }


    #endregion

    } // class PolarisReportSchemaConfig
    
    #endregion

    public static class ListPolarisReportSchemaConfigExtensions
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
            this List<PolarisReportSchemaConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportSchemaConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportSchemaConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportSchemaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportSchemaConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types