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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        if (this.FeatureDetail != null) {
            s += ind + "featureDetail {\n" + this.FeatureDetail.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        if (this.Project != null) {
            s += ind + "project {\n" + this.Project.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
        {
            this.FeatureDetail = new GcpCloudAccountFeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(parent + ".featureDetail");
        }
        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        if (this.Project == null && Exploration.Includes(parent + ".project"))
        {
            this.Project = new GcpCloudAccountProject();
            this.Project.ApplyExploratoryFieldSpec(parent + ".project");
        }
    }


    #endregion

    } // class GcpCloudAccountProjectDetail
    
    #endregion

    public static class ListGcpCloudAccountProjectDetailExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<GcpCloudAccountProjectDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types