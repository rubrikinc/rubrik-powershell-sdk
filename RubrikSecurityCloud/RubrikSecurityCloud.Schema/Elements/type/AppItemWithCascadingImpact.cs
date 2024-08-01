// AppItemWithCascadingImpact.cs
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
    #region AppItemWithCascadingImpact
    public class AppItemWithCascadingImpact: BaseType
    {
        #region members

        //      C# -> RelationshipType? RelationshipType
        // GraphQL -> relationshipType: RelationshipType! (enum)
        [JsonProperty("relationshipType")]
        public RelationshipType? RelationshipType { get; set; }

        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        [JsonProperty("appItemTypeDisplayName")]
        public System.String? AppItemTypeDisplayName { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        [JsonProperty("isOptionalToRestore")]
        public System.Boolean? IsOptionalToRestore { get; set; }

        //      C# -> List<System.String>? ItemKeys
        // GraphQL -> itemKeys: [String!]! (scalar)
        [JsonProperty("itemKeys")]
        public List<System.String>? ItemKeys { get; set; }

        //      C# -> System.String? PathIdentifier
        // GraphQL -> pathIdentifier: String (scalar)
        [JsonProperty("pathIdentifier")]
        public System.String? PathIdentifier { get; set; }

        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        [JsonProperty("cascadedItems")]
        public List<AppItemWithCascadingImpact>? CascadedItems { get; set; }

        //      C# -> List<CascadingImpactKeys>? ItemsWithActionType
        // GraphQL -> itemsWithActionType: [cascadingImpactKeys!]! (type)
        [JsonProperty("itemsWithActionType")]
        public List<CascadingImpactKeys>? ItemsWithActionType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppItemWithCascadingImpact";
    }

    public AppItemWithCascadingImpact Set(
        RelationshipType? RelationshipType = null,
        System.String? AppItemTypeDisplayName = null,
        System.String? AppItemTypeToken = null,
        System.Int32? Count = null,
        System.Boolean? IsOptionalToRestore = null,
        List<System.String>? ItemKeys = null,
        System.String? PathIdentifier = null,
        List<AppItemWithCascadingImpact>? CascadedItems = null,
        List<CascadingImpactKeys>? ItemsWithActionType = null
    ) 
    {
        if ( RelationshipType != null ) {
            this.RelationshipType = RelationshipType;
        }
        if ( AppItemTypeDisplayName != null ) {
            this.AppItemTypeDisplayName = AppItemTypeDisplayName;
        }
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( IsOptionalToRestore != null ) {
            this.IsOptionalToRestore = IsOptionalToRestore;
        }
        if ( ItemKeys != null ) {
            this.ItemKeys = ItemKeys;
        }
        if ( PathIdentifier != null ) {
            this.PathIdentifier = PathIdentifier;
        }
        if ( CascadedItems != null ) {
            this.CascadedItems = CascadedItems;
        }
        if ( ItemsWithActionType != null ) {
            this.ItemsWithActionType = ItemsWithActionType;
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
        //      C# -> RelationshipType? RelationshipType
        // GraphQL -> relationshipType: RelationshipType! (enum)
        if (this.RelationshipType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relationshipType\n" ;
            } else {
                s += ind + "relationshipType\n" ;
            }
        }
        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        if (this.AppItemTypeDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appItemTypeDisplayName\n" ;
            } else {
                s += ind + "appItemTypeDisplayName\n" ;
            }
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appItemTypeToken\n" ;
            } else {
                s += ind + "appItemTypeToken\n" ;
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
        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        if (this.IsOptionalToRestore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOptionalToRestore\n" ;
            } else {
                s += ind + "isOptionalToRestore\n" ;
            }
        }
        //      C# -> List<System.String>? ItemKeys
        // GraphQL -> itemKeys: [String!]! (scalar)
        if (this.ItemKeys != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemKeys\n" ;
            } else {
                s += ind + "itemKeys\n" ;
            }
        }
        //      C# -> System.String? PathIdentifier
        // GraphQL -> pathIdentifier: String (scalar)
        if (this.PathIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pathIdentifier\n" ;
            } else {
                s += ind + "pathIdentifier\n" ;
            }
        }
        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        if (this.CascadedItems != null) {
            var fspec = this.CascadedItems.AsFieldSpec(conf.Child("cascadedItems"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cascadedItems" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CascadingImpactKeys>? ItemsWithActionType
        // GraphQL -> itemsWithActionType: [cascadingImpactKeys!]! (type)
        if (this.ItemsWithActionType != null) {
            var fspec = this.ItemsWithActionType.AsFieldSpec(conf.Child("itemsWithActionType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "itemsWithActionType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RelationshipType? RelationshipType
        // GraphQL -> relationshipType: RelationshipType! (enum)
        if (ec.Includes("relationshipType",true))
        {
            if(this.RelationshipType == null) {

                this.RelationshipType = new RelationshipType();

            } else {


            }
        }
        else if (this.RelationshipType != null && ec.Excludes("relationshipType",true))
        {
            this.RelationshipType = null;
        }
        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        if (ec.Includes("appItemTypeDisplayName",true))
        {
            if(this.AppItemTypeDisplayName == null) {

                this.AppItemTypeDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.AppItemTypeDisplayName != null && ec.Excludes("appItemTypeDisplayName",true))
        {
            this.AppItemTypeDisplayName = null;
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (ec.Includes("appItemTypeToken",true))
        {
            if(this.AppItemTypeToken == null) {

                this.AppItemTypeToken = "FETCH";

            } else {


            }
        }
        else if (this.AppItemTypeToken != null && ec.Excludes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = null;
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
        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        if (ec.Includes("isOptionalToRestore",true))
        {
            if(this.IsOptionalToRestore == null) {

                this.IsOptionalToRestore = true;

            } else {


            }
        }
        else if (this.IsOptionalToRestore != null && ec.Excludes("isOptionalToRestore",true))
        {
            this.IsOptionalToRestore = null;
        }
        //      C# -> List<System.String>? ItemKeys
        // GraphQL -> itemKeys: [String!]! (scalar)
        if (ec.Includes("itemKeys",true))
        {
            if(this.ItemKeys == null) {

                this.ItemKeys = new List<System.String>();

            } else {


            }
        }
        else if (this.ItemKeys != null && ec.Excludes("itemKeys",true))
        {
            this.ItemKeys = null;
        }
        //      C# -> System.String? PathIdentifier
        // GraphQL -> pathIdentifier: String (scalar)
        if (ec.Includes("pathIdentifier",true))
        {
            if(this.PathIdentifier == null) {

                this.PathIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.PathIdentifier != null && ec.Excludes("pathIdentifier",true))
        {
            this.PathIdentifier = null;
        }
        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        if (ec.Includes("cascadedItems",false))
        {
            if(this.CascadedItems == null) {

                this.CascadedItems = new List<AppItemWithCascadingImpact>();
                this.CascadedItems.ApplyExploratoryFieldSpec(ec.NewChild("cascadedItems"));

            } else {

                this.CascadedItems.ApplyExploratoryFieldSpec(ec.NewChild("cascadedItems"));

            }
        }
        else if (this.CascadedItems != null && ec.Excludes("cascadedItems",false))
        {
            this.CascadedItems = null;
        }
        //      C# -> List<CascadingImpactKeys>? ItemsWithActionType
        // GraphQL -> itemsWithActionType: [cascadingImpactKeys!]! (type)
        if (ec.Includes("itemsWithActionType",false))
        {
            if(this.ItemsWithActionType == null) {

                this.ItemsWithActionType = new List<CascadingImpactKeys>();
                this.ItemsWithActionType.ApplyExploratoryFieldSpec(ec.NewChild("itemsWithActionType"));

            } else {

                this.ItemsWithActionType.ApplyExploratoryFieldSpec(ec.NewChild("itemsWithActionType"));

            }
        }
        else if (this.ItemsWithActionType != null && ec.Excludes("itemsWithActionType",false))
        {
            this.ItemsWithActionType = null;
        }
    }


    #endregion

    } // class AppItemWithCascadingImpact
    
    #endregion

    public static class ListAppItemWithCascadingImpactExtensions
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
            this List<AppItemWithCascadingImpact> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppItemWithCascadingImpact> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppItemWithCascadingImpact> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppItemWithCascadingImpact());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppItemWithCascadingImpact> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types