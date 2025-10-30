// AzureAdRelatedItemCount.cs
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
    #region AzureAdRelatedItemCount
    public class AzureAdRelatedItemCount: BaseType
    {
        #region members

        //      C# -> AzureAdRelationshipEnumType? RelatedItemType
        // GraphQL -> relatedItemType: AzureAdRelationshipEnumType! (enum)
        [JsonProperty("relatedItemType")]
        public AzureAdRelationshipEnumType? RelatedItemType { get; set; }

        //      C# -> AzureAdRelationshipEnumType? RelationshipType
        // GraphQL -> relationshipType: AzureAdRelationshipEnumType! (enum)
        [JsonProperty("relationshipType")]
        public AzureAdRelationshipEnumType? RelationshipType { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdRelatedItemCount";
    }

    public AzureAdRelatedItemCount Set(
        AzureAdRelationshipEnumType? RelatedItemType = null,
        AzureAdRelationshipEnumType? RelationshipType = null,
        System.Int32? Count = null
    ) 
    {
        if ( RelatedItemType != null ) {
            this.RelatedItemType = RelatedItemType;
        }
        if ( RelationshipType != null ) {
            this.RelationshipType = RelationshipType;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> AzureAdRelationshipEnumType? RelatedItemType
        // GraphQL -> relatedItemType: AzureAdRelationshipEnumType! (enum)
        if (this.RelatedItemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relatedItemType\n" ;
            } else {
                s += ind + "relatedItemType\n" ;
            }
        }
        //      C# -> AzureAdRelationshipEnumType? RelationshipType
        // GraphQL -> relationshipType: AzureAdRelationshipEnumType! (enum)
        if (this.RelationshipType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relationshipType\n" ;
            } else {
                s += ind + "relationshipType\n" ;
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdRelationshipEnumType? RelatedItemType
        // GraphQL -> relatedItemType: AzureAdRelationshipEnumType! (enum)
        if (ec.Includes("relatedItemType",true))
        {
            if(this.RelatedItemType == null) {

                this.RelatedItemType = new AzureAdRelationshipEnumType();

            } else {


            }
        }
        else if (this.RelatedItemType != null && ec.Excludes("relatedItemType",true))
        {
            this.RelatedItemType = null;
        }
        //      C# -> AzureAdRelationshipEnumType? RelationshipType
        // GraphQL -> relationshipType: AzureAdRelationshipEnumType! (enum)
        if (ec.Includes("relationshipType",true))
        {
            if(this.RelationshipType == null) {

                this.RelationshipType = new AzureAdRelationshipEnumType();

            } else {


            }
        }
        else if (this.RelationshipType != null && ec.Excludes("relationshipType",true))
        {
            this.RelationshipType = null;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
    }


    #endregion

    } // class AzureAdRelatedItemCount
    
    #endregion

    public static class ListAzureAdRelatedItemCountExtensions
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
            this List<AzureAdRelatedItemCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdRelatedItemCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdRelatedItemCount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdRelatedItemCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdRelatedItemCount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types