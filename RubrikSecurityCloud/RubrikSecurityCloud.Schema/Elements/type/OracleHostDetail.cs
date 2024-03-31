// OracleHostDetail.cs
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
    #region OracleHostDetail
    public class OracleHostDetail: BaseType
    {
        #region members

        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        [JsonProperty("oracleHostSummary")]
        public OracleHostSummary? OracleHostSummary { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleHostDetail";
    }

    public OracleHostDetail Set(
        OracleHostSummary? OracleHostSummary = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null
    ) 
    {
        if ( OracleHostSummary != null ) {
            this.OracleHostSummary = OracleHostSummary;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
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
        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        if (this.OracleHostSummary != null) {
            var fspec = this.OracleHostSummary.AsFieldSpec(conf.Child("oracleHostSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleHostSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(conf.Child("oracleNonSlaProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleNonSlaProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        if (ec.Includes("oracleHostSummary",false))
        {
            if(this.OracleHostSummary == null) {

                this.OracleHostSummary = new OracleHostSummary();
                this.OracleHostSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleHostSummary"));

            } else {

                this.OracleHostSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleHostSummary"));

            }
        }
        else if (this.OracleHostSummary != null && ec.Excludes("oracleHostSummary",false))
        {
            this.OracleHostSummary = null;
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (ec.Includes("oracleNonSlaProperties",false))
        {
            if(this.OracleNonSlaProperties == null) {

                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            } else {

                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            }
        }
        else if (this.OracleNonSlaProperties != null && ec.Excludes("oracleNonSlaProperties",false))
        {
            this.OracleNonSlaProperties = null;
        }
    }


    #endregion

    } // class OracleHostDetail
    
    #endregion

    public static class ListOracleHostDetailExtensions
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
            this List<OracleHostDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleHostDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleHostDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleHostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types