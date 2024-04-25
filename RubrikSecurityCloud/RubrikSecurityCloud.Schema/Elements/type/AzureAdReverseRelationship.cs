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

        //      C# -> List<RelatedObjectsType>? RelatedObjects
        // GraphQL -> relatedObjects: [RelatedObjectsType!]! (type)
        [JsonProperty("relatedObjects")]
        public List<RelatedObjectsType>? RelatedObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdReverseRelationship";
    }

    public AzureAdReverseRelationship Set(
        AzureAdReverseRelationshipType? Type = null,
        List<System.String>? RelatedObjectIds = null,
        List<RelatedObjectsType>? RelatedObjects = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( RelatedObjectIds != null ) {
            this.RelatedObjectIds = RelatedObjectIds;
        }
        if ( RelatedObjects != null ) {
            this.RelatedObjects = RelatedObjects;
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
        //      C# -> List<RelatedObjectsType>? RelatedObjects
        // GraphQL -> relatedObjects: [RelatedObjectsType!]! (type)
        if (this.RelatedObjects != null) {
            var fspec = this.RelatedObjects.AsFieldSpec(conf.Child("relatedObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relatedObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> List<RelatedObjectsType>? RelatedObjects
        // GraphQL -> relatedObjects: [RelatedObjectsType!]! (type)
        if (ec.Includes("relatedObjects",false))
        {
            if(this.RelatedObjects == null) {

                this.RelatedObjects = new List<RelatedObjectsType>();
                this.RelatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("relatedObjects"));

            } else {

                this.RelatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("relatedObjects"));

            }
        }
        else if (this.RelatedObjects != null && ec.Excludes("relatedObjects",false))
        {
            this.RelatedObjects = null;
        }
    }


    #endregion

    } // class AzureAdReverseRelationship
    
    #endregion

    public static class ListAzureAdReverseRelationshipExtensions
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
            this List<AzureAdReverseRelationship> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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