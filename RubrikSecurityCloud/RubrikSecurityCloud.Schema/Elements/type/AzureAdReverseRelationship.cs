// AzureAdReverseRelationship.cs
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
    #region AzureAdReverseRelationship
    public class AzureAdReverseRelationship: BaseType
    {
        #region members

        //      C# -> AzureAdReverseRelationshipType? Type
        // GraphQL -> type: AzureAdReverseRelationshipType! (enum)
        [JsonProperty("type")]
        public AzureAdReverseRelationshipType? Type { get; set; }

        //      C# -> List<System.String>? RelatedObjectIds
        // GraphQL -> relatedObjectIds: [UUID!]! (scalar)
        [JsonProperty("relatedObjectIds")]
        public List<System.String>? RelatedObjectIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdReverseRelationship";
    }

    public AzureAdReverseRelationship Set(
        AzureAdReverseRelationshipType? Type = null,
        List<System.String>? RelatedObjectIds = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( RelatedObjectIds != null ) {
            this.RelatedObjectIds = RelatedObjectIds;
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
        //      C# -> AzureAdReverseRelationshipType? Type
        // GraphQL -> type: AzureAdReverseRelationshipType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> List<System.String>? RelatedObjectIds
        // GraphQL -> relatedObjectIds: [UUID!]! (scalar)
        if (this.RelatedObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relatedObjectIds\n" ;
            } else {
                s += ind + "relatedObjectIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureAdReverseRelationshipType? Type
        // GraphQL -> type: AzureAdReverseRelationshipType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new AzureAdReverseRelationshipType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> List<System.String>? RelatedObjectIds
        // GraphQL -> relatedObjectIds: [UUID!]! (scalar)
        if (ec.Includes("relatedObjectIds",true))
        {
            if(this.RelatedObjectIds == null) {

                this.RelatedObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RelatedObjectIds != null && ec.Excludes("relatedObjectIds",true))
        {
            this.RelatedObjectIds = null;
        }
    }


    #endregion

    } // class AzureAdReverseRelationship
    
    #endregion

    public static class ListAzureAdReverseRelationshipExtensions
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
            this List<AzureAdReverseRelationship> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureAdReverseRelationship> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdReverseRelationship> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdReverseRelationship());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdReverseRelationship> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types