// GcpCloudAccountProjectDetail.cs
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
    #region GcpCloudAccountProjectDetail
    public class GcpCloudAccountProjectDetail: BaseType
    {
        #region members

        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        [JsonProperty("featureDetail")]
        public GcpCloudAccountFeatureDetail? FeatureDetail { get; set; }

        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        [JsonProperty("project")]
        public GcpCloudAccountProject? Project { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountProjectDetail";
    }

    public GcpCloudAccountProjectDetail Set(
        GcpCloudAccountFeatureDetail? FeatureDetail = null,
        GcpCloudAccountProject? Project = null
    ) 
    {
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( Project != null ) {
            this.Project = Project;
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
        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(conf.Child("featureDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        if (this.Project != null) {
            var fspec = this.Project.AsFieldSpec(conf.Child("project"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "project {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        if (ec.Includes("featureDetail",false))
        {
            if(this.FeatureDetail == null) {

                this.FeatureDetail = new GcpCloudAccountFeatureDetail();
                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            } else {

                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            }
        }
        else if (this.FeatureDetail != null && ec.Excludes("featureDetail",false))
        {
            this.FeatureDetail = null;
        }
        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        if (ec.Includes("project",false))
        {
            if(this.Project == null) {

                this.Project = new GcpCloudAccountProject();
                this.Project.ApplyExploratoryFieldSpec(ec.NewChild("project"));

            } else {

                this.Project.ApplyExploratoryFieldSpec(ec.NewChild("project"));

            }
        }
        else if (this.Project != null && ec.Excludes("project",false))
        {
            this.Project = null;
        }
    }


    #endregion

    } // class GcpCloudAccountProjectDetail
    
    #endregion

    public static class ListGcpCloudAccountProjectDetailExtensions
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
            this List<GcpCloudAccountProjectDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountProjectDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountProjectDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types