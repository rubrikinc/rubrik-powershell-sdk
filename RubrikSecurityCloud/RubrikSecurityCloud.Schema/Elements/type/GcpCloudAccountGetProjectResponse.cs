// GcpCloudAccountGetProjectResponse.cs
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
    #region GcpCloudAccountGetProjectResponse
    public class GcpCloudAccountGetProjectResponse: BaseType
    {
        #region members

        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        [JsonProperty("credentialsManagedBy")]
        public CredentialsManagedBy? CredentialsManagedBy { get; set; }

        //      C# -> List<GcpFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [GcpFeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<GcpFeatureDetail>? FeatureDetails { get; set; }

        //      C# -> GcpProject? Project
        // GraphQL -> project: GcpProject (type)
        [JsonProperty("project")]
        public GcpProject? Project { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountGetProjectResponse";
    }

    public GcpCloudAccountGetProjectResponse Set(
        CredentialsManagedBy? CredentialsManagedBy = null,
        List<GcpFeatureDetail>? FeatureDetails = null,
        GcpProject? Project = null
    ) 
    {
        if ( CredentialsManagedBy != null ) {
            this.CredentialsManagedBy = CredentialsManagedBy;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        if (this.CredentialsManagedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "credentialsManagedBy\n" ;
            } else {
                s += ind + "credentialsManagedBy\n" ;
            }
        }
        //      C# -> List<GcpFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [GcpFeatureDetail!]! (type)
        if (this.FeatureDetails != null) {
            var fspec = this.FeatureDetails.AsFieldSpec(conf.Child("featureDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GcpProject? Project
        // GraphQL -> project: GcpProject (type)
        if (this.Project != null) {
            var fspec = this.Project.AsFieldSpec(conf.Child("project"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "project" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        if (ec.Includes("credentialsManagedBy",true))
        {
            if(this.CredentialsManagedBy == null) {

                this.CredentialsManagedBy = new CredentialsManagedBy();

            } else {


            }
        }
        else if (this.CredentialsManagedBy != null && ec.Excludes("credentialsManagedBy",true))
        {
            this.CredentialsManagedBy = null;
        }
        //      C# -> List<GcpFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [GcpFeatureDetail!]! (type)
        if (ec.Includes("featureDetails",false))
        {
            if(this.FeatureDetails == null) {

                this.FeatureDetails = new List<GcpFeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            } else {

                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            }
        }
        else if (this.FeatureDetails != null && ec.Excludes("featureDetails",false))
        {
            this.FeatureDetails = null;
        }
        //      C# -> GcpProject? Project
        // GraphQL -> project: GcpProject (type)
        if (ec.Includes("project",false))
        {
            if(this.Project == null) {

                this.Project = new GcpProject();
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

    } // class GcpCloudAccountGetProjectResponse
    
    #endregion

    public static class ListGcpCloudAccountGetProjectResponseExtensions
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
            this List<GcpCloudAccountGetProjectResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountGetProjectResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountGetProjectResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountGetProjectResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountGetProjectResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types