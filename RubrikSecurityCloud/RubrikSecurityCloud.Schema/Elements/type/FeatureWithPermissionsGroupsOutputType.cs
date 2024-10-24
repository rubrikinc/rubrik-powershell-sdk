// FeatureWithPermissionsGroupsOutputType.cs
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
    #region FeatureWithPermissionsGroupsOutputType
    public class FeatureWithPermissionsGroupsOutputType: BaseType
    {
        #region members

        //      C# -> List<CloudAccountFeature>? FeatureType
        // GraphQL -> featureType: [CloudAccountFeature!]! (enum)
        [JsonProperty("featureType")]
        public List<CloudAccountFeature>? FeatureType { get; set; }

        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        [JsonProperty("permissionsGroups")]
        public List<PermissionsGroup>? PermissionsGroups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeatureWithPermissionsGroupsOutputType";
    }

    public FeatureWithPermissionsGroupsOutputType Set(
        List<CloudAccountFeature>? FeatureType = null,
        List<PermissionsGroup>? PermissionsGroups = null
    ) 
    {
        if ( FeatureType != null ) {
            this.FeatureType = FeatureType;
        }
        if ( PermissionsGroups != null ) {
            this.PermissionsGroups = PermissionsGroups;
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
        //      C# -> List<CloudAccountFeature>? FeatureType
        // GraphQL -> featureType: [CloudAccountFeature!]! (enum)
        if (this.FeatureType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "featureType\n" ;
            } else {
                s += ind + "featureType\n" ;
            }
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        if (this.PermissionsGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroups\n" ;
            } else {
                s += ind + "permissionsGroups\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudAccountFeature>? FeatureType
        // GraphQL -> featureType: [CloudAccountFeature!]! (enum)
        if (ec.Includes("featureType",true))
        {
            if(this.FeatureType == null) {

                this.FeatureType = new List<CloudAccountFeature>();

            } else {


            }
        }
        else if (this.FeatureType != null && ec.Excludes("featureType",true))
        {
            this.FeatureType = null;
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        if (ec.Includes("permissionsGroups",true))
        {
            if(this.PermissionsGroups == null) {

                this.PermissionsGroups = new List<PermissionsGroup>();

            } else {


            }
        }
        else if (this.PermissionsGroups != null && ec.Excludes("permissionsGroups",true))
        {
            this.PermissionsGroups = null;
        }
    }


    #endregion

    } // class FeatureWithPermissionsGroupsOutputType
    
    #endregion

    public static class ListFeatureWithPermissionsGroupsOutputTypeExtensions
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
            this List<FeatureWithPermissionsGroupsOutputType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FeatureWithPermissionsGroupsOutputType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FeatureWithPermissionsGroupsOutputType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureWithPermissionsGroupsOutputType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FeatureWithPermissionsGroupsOutputType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types