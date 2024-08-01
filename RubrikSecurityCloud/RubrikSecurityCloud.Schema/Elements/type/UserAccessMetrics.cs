// UserAccessMetrics.cs
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
    #region UserAccessMetrics
    public class UserAccessMetrics: BaseType
    {
        #region members

        //      C# -> System.Boolean? ActiveDirectorySnapshotExists
        // GraphQL -> activeDirectorySnapshotExists: Boolean! (scalar)
        [JsonProperty("activeDirectorySnapshotExists")]
        public System.Boolean? ActiveDirectorySnapshotExists { get; set; }

        //      C# -> System.Boolean? ContentAnalysisResultsExists
        // GraphQL -> contentAnalysisResultsExists: Boolean! (scalar)
        [JsonProperty("contentAnalysisResultsExists")]
        public System.Boolean? ContentAnalysisResultsExists { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserAccessMetrics";
    }

    public UserAccessMetrics Set(
        System.Boolean? ActiveDirectorySnapshotExists = null,
        System.Boolean? ContentAnalysisResultsExists = null
    ) 
    {
        if ( ActiveDirectorySnapshotExists != null ) {
            this.ActiveDirectorySnapshotExists = ActiveDirectorySnapshotExists;
        }
        if ( ContentAnalysisResultsExists != null ) {
            this.ContentAnalysisResultsExists = ContentAnalysisResultsExists;
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
        //      C# -> System.Boolean? ActiveDirectorySnapshotExists
        // GraphQL -> activeDirectorySnapshotExists: Boolean! (scalar)
        if (this.ActiveDirectorySnapshotExists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeDirectorySnapshotExists\n" ;
            } else {
                s += ind + "activeDirectorySnapshotExists\n" ;
            }
        }
        //      C# -> System.Boolean? ContentAnalysisResultsExists
        // GraphQL -> contentAnalysisResultsExists: Boolean! (scalar)
        if (this.ContentAnalysisResultsExists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contentAnalysisResultsExists\n" ;
            } else {
                s += ind + "contentAnalysisResultsExists\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? ActiveDirectorySnapshotExists
        // GraphQL -> activeDirectorySnapshotExists: Boolean! (scalar)
        if (ec.Includes("activeDirectorySnapshotExists",true))
        {
            if(this.ActiveDirectorySnapshotExists == null) {

                this.ActiveDirectorySnapshotExists = true;

            } else {


            }
        }
        else if (this.ActiveDirectorySnapshotExists != null && ec.Excludes("activeDirectorySnapshotExists",true))
        {
            this.ActiveDirectorySnapshotExists = null;
        }
        //      C# -> System.Boolean? ContentAnalysisResultsExists
        // GraphQL -> contentAnalysisResultsExists: Boolean! (scalar)
        if (ec.Includes("contentAnalysisResultsExists",true))
        {
            if(this.ContentAnalysisResultsExists == null) {

                this.ContentAnalysisResultsExists = true;

            } else {


            }
        }
        else if (this.ContentAnalysisResultsExists != null && ec.Excludes("contentAnalysisResultsExists",true))
        {
            this.ContentAnalysisResultsExists = null;
        }
    }


    #endregion

    } // class UserAccessMetrics
    
    #endregion

    public static class ListUserAccessMetricsExtensions
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
            this List<UserAccessMetrics> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserAccessMetrics> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserAccessMetrics> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAccessMetrics());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserAccessMetrics> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types