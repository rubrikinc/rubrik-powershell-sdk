// AwsArtifactsToDelete.cs
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
    #region AwsArtifactsToDelete
    public class AwsArtifactsToDelete: BaseType
    {
        #region members

        //      C# -> List<ArtifactsToDelete>? ArtifactsToDelete
        // GraphQL -> artifactsToDelete: [ArtifactsToDelete!]! (type)
        [JsonProperty("artifactsToDelete")]
        public List<ArtifactsToDelete>? ArtifactsToDelete { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsArtifactsToDelete";
    }

    public AwsArtifactsToDelete Set(
        List<ArtifactsToDelete>? ArtifactsToDelete = null
    ) 
    {
        if ( ArtifactsToDelete != null ) {
            this.ArtifactsToDelete = ArtifactsToDelete;
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
        //      C# -> List<ArtifactsToDelete>? ArtifactsToDelete
        // GraphQL -> artifactsToDelete: [ArtifactsToDelete!]! (type)
        if (this.ArtifactsToDelete != null) {
            var fspec = this.ArtifactsToDelete.AsFieldSpec(conf.Child("artifactsToDelete"));
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
        //      C# -> List<ArtifactsToDelete>? ArtifactsToDelete
        // GraphQL -> artifactsToDelete: [ArtifactsToDelete!]! (type)
        if (ec.Includes("artifactsToDelete",false))
        {
            if(this.ArtifactsToDelete == null) {

                this.ArtifactsToDelete = new List<ArtifactsToDelete>();
                this.ArtifactsToDelete.ApplyExploratoryFieldSpec(ec.NewChild("artifactsToDelete"));

            } else {

                this.ArtifactsToDelete.ApplyExploratoryFieldSpec(ec.NewChild("artifactsToDelete"));

            }
        }
        else if (this.ArtifactsToDelete != null && ec.Excludes("artifactsToDelete",false))
        {
            this.ArtifactsToDelete = null;
        }
    }


    #endregion

    } // class AwsArtifactsToDelete
    
    #endregion

    public static class ListAwsArtifactsToDeleteExtensions
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
            this List<AwsArtifactsToDelete> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsArtifactsToDelete> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsArtifactsToDelete());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsArtifactsToDelete> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types