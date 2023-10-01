// ArtifactsToDelete.cs
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
    #region ArtifactsToDelete
    public class ArtifactsToDelete: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> List<ExternalArtifactMapReply>? ArtifactsToDeleteField
        // GraphQL -> artifactsToDelete: [ExternalArtifactMapReply!]! (type)
        [JsonProperty("artifactsToDelete")]
        public List<ExternalArtifactMapReply>? ArtifactsToDeleteField { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArtifactsToDelete";
    }

    public ArtifactsToDelete Set(
        CloudAccountFeature? Feature = null,
        List<ExternalArtifactMapReply>? ArtifactsToDeleteField = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( ArtifactsToDeleteField != null ) {
            this.ArtifactsToDeleteField = ArtifactsToDeleteField;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> List<ExternalArtifactMapReply>? ArtifactsToDeleteField
        // GraphQL -> artifactsToDelete: [ExternalArtifactMapReply!]! (type)
        if (this.ArtifactsToDeleteField != null) {
            var fspec = this.ArtifactsToDeleteField.AsFieldSpec(conf.Child("artifactsToDelete"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "artifactsToDelete {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> List<ExternalArtifactMapReply>? ArtifactsToDeleteField
        // GraphQL -> artifactsToDelete: [ExternalArtifactMapReply!]! (type)
        if (ec.Includes("artifactsToDelete",false))
        {
            if(this.ArtifactsToDeleteField == null) {

                this.ArtifactsToDeleteField = new List<ExternalArtifactMapReply>();
                this.ArtifactsToDeleteField.ApplyExploratoryFieldSpec(ec.NewChild("artifactsToDelete"));

            } else {

                this.ArtifactsToDeleteField.ApplyExploratoryFieldSpec(ec.NewChild("artifactsToDelete"));

            }
        }
        else if (this.ArtifactsToDeleteField != null && ec.Excludes("artifactsToDelete",false))
        {
            this.ArtifactsToDeleteField = null;
        }
    }


    #endregion

    } // class ArtifactsToDelete
    
    #endregion

    public static class ListArtifactsToDeleteExtensions
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
            this List<ArtifactsToDelete> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ArtifactsToDelete> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArtifactsToDelete> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArtifactsToDelete());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArtifactsToDelete> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types