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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            s += ind + "feature\n" ;
        }
        //      C# -> List<ExternalArtifactMapReply>? ArtifactsToDeleteField
        // GraphQL -> artifactsToDelete: [ExternalArtifactMapReply!]! (type)
        if (this.ArtifactsToDeleteField != null) {
            var fspec = this.ArtifactsToDeleteField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "artifactsToDelete {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature == null && ec.Includes("feature",true))
        {
            this.Feature = new CloudAccountFeature();
        }
        //      C# -> List<ExternalArtifactMapReply>? ArtifactsToDeleteField
        // GraphQL -> artifactsToDelete: [ExternalArtifactMapReply!]! (type)
        if (this.ArtifactsToDeleteField == null && ec.Includes("artifactsToDelete",false))
        {
            this.ArtifactsToDeleteField = new List<ExternalArtifactMapReply>();
            this.ArtifactsToDeleteField.ApplyExploratoryFieldSpec(ec.NewChild("artifactsToDelete"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ArtifactsToDelete> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types