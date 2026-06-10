// DeleteSnapshotsTprReqChangesTemplate.cs
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
    #region DeleteSnapshotsTprReqChangesTemplate
 
    public class DeleteSnapshotsTprReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<TprSnapshotInfo>? SnapshotInfos
        // GraphQL -> snapshotInfos: [TprSnapshotInfo!]! (type)
        [JsonProperty("snapshotInfos")]
        public List<TprSnapshotInfo>? SnapshotInfos { get; set; }

        //      C# -> List<SnapshotLocationSummary>? SnapshotLocations
        // GraphQL -> snapshotLocations: [SnapshotLocationSummary!]! (type)
        [JsonProperty("snapshotLocations")]
        public List<SnapshotLocationSummary>? SnapshotLocations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteSnapshotsTprReqChangesTemplate";
    }

    public DeleteSnapshotsTprReqChangesTemplate Set(
        System.String? TemplateName = null,
        List<TprSnapshotInfo>? SnapshotInfos = null,
        List<SnapshotLocationSummary>? SnapshotLocations = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( SnapshotInfos != null ) {
            this.SnapshotInfos = SnapshotInfos;
        }
        if ( SnapshotLocations != null ) {
            this.SnapshotLocations = SnapshotLocations;
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
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        //      C# -> List<TprSnapshotInfo>? SnapshotInfos
        // GraphQL -> snapshotInfos: [TprSnapshotInfo!]! (type)
        if (this.SnapshotInfos != null) {
            var fspec = this.SnapshotInfos.AsFieldSpec(conf.Child("snapshotInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotLocationSummary>? SnapshotLocations
        // GraphQL -> snapshotLocations: [SnapshotLocationSummary!]! (type)
        if (this.SnapshotLocations != null) {
            var fspec = this.SnapshotLocations.AsFieldSpec(conf.Child("snapshotLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotLocations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
        //      C# -> List<TprSnapshotInfo>? SnapshotInfos
        // GraphQL -> snapshotInfos: [TprSnapshotInfo!]! (type)
        if (ec.Includes("snapshotInfos",false))
        {
            if(this.SnapshotInfos == null) {

                this.SnapshotInfos = new List<TprSnapshotInfo>();
                this.SnapshotInfos.ApplyExploratoryFieldSpec(ec.NewChild("snapshotInfos"));

            } else {

                this.SnapshotInfos.ApplyExploratoryFieldSpec(ec.NewChild("snapshotInfos"));

            }
        }
        else if (this.SnapshotInfos != null && ec.Excludes("snapshotInfos",false))
        {
            this.SnapshotInfos = null;
        }
        //      C# -> List<SnapshotLocationSummary>? SnapshotLocations
        // GraphQL -> snapshotLocations: [SnapshotLocationSummary!]! (type)
        if (ec.Includes("snapshotLocations",false))
        {
            if(this.SnapshotLocations == null) {

                this.SnapshotLocations = new List<SnapshotLocationSummary>();
                this.SnapshotLocations.ApplyExploratoryFieldSpec(ec.NewChild("snapshotLocations"));

            } else {

                this.SnapshotLocations.ApplyExploratoryFieldSpec(ec.NewChild("snapshotLocations"));

            }
        }
        else if (this.SnapshotLocations != null && ec.Excludes("snapshotLocations",false))
        {
            this.SnapshotLocations = null;
        }
    }


    #endregion

    } // class DeleteSnapshotsTprReqChangesTemplate
    
    #endregion

    public static class ListDeleteSnapshotsTprReqChangesTemplateExtensions
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
            this List<DeleteSnapshotsTprReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeleteSnapshotsTprReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteSnapshotsTprReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteSnapshotsTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteSnapshotsTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types