// LinkedEntity.cs
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
    #region LinkedEntity
    public class LinkedEntity: BaseType
    {
        #region members

        //      C# -> PrincipalRiskySummaryPrincipalType? EntityType
        // GraphQL -> entityType: PrincipalRiskySummaryPrincipalType! (enum)
        [JsonProperty("entityType")]
        public PrincipalRiskySummaryPrincipalType? EntityType { get; set; }

        //      C# -> LinkedEntityLinkType? LinkType
        // GraphQL -> linkType: LinkedEntityLinkType! (enum)
        [JsonProperty("linkType")]
        public LinkedEntityLinkType? LinkType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? Enforced
        // GraphQL -> enforced: Boolean! (scalar)
        [JsonProperty("enforced")]
        public System.Boolean? Enforced { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.Boolean? LinkEnabled
        // GraphQL -> linkEnabled: Boolean! (scalar)
        [JsonProperty("linkEnabled")]
        public System.Boolean? LinkEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LinkedEntity";
    }

    public LinkedEntity Set(
        PrincipalRiskySummaryPrincipalType? EntityType = null,
        LinkedEntityLinkType? LinkType = null,
        System.String? DisplayName = null,
        System.Boolean? Enforced = null,
        System.String? EntityId = null,
        System.Boolean? LinkEnabled = null
    ) 
    {
        if ( EntityType != null ) {
            this.EntityType = EntityType;
        }
        if ( LinkType != null ) {
            this.LinkType = LinkType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Enforced != null ) {
            this.Enforced = Enforced;
        }
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( LinkEnabled != null ) {
            this.LinkEnabled = LinkEnabled;
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
        //      C# -> PrincipalRiskySummaryPrincipalType? EntityType
        // GraphQL -> entityType: PrincipalRiskySummaryPrincipalType! (enum)
        if (this.EntityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityType\n" ;
            } else {
                s += ind + "entityType\n" ;
            }
        }
        //      C# -> LinkedEntityLinkType? LinkType
        // GraphQL -> linkType: LinkedEntityLinkType! (enum)
        if (this.LinkType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "linkType\n" ;
            } else {
                s += ind + "linkType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Boolean? Enforced
        // GraphQL -> enforced: Boolean! (scalar)
        if (this.Enforced != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enforced\n" ;
            } else {
                s += ind + "enforced\n" ;
            }
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityId\n" ;
            } else {
                s += ind + "entityId\n" ;
            }
        }
        //      C# -> System.Boolean? LinkEnabled
        // GraphQL -> linkEnabled: Boolean! (scalar)
        if (this.LinkEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "linkEnabled\n" ;
            } else {
                s += ind + "linkEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PrincipalRiskySummaryPrincipalType? EntityType
        // GraphQL -> entityType: PrincipalRiskySummaryPrincipalType! (enum)
        if (ec.Includes("entityType",true))
        {
            if(this.EntityType == null) {

                this.EntityType = new PrincipalRiskySummaryPrincipalType();

            } else {


            }
        }
        else if (this.EntityType != null && ec.Excludes("entityType",true))
        {
            this.EntityType = null;
        }
        //      C# -> LinkedEntityLinkType? LinkType
        // GraphQL -> linkType: LinkedEntityLinkType! (enum)
        if (ec.Includes("linkType",true))
        {
            if(this.LinkType == null) {

                this.LinkType = new LinkedEntityLinkType();

            } else {


            }
        }
        else if (this.LinkType != null && ec.Excludes("linkType",true))
        {
            this.LinkType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Boolean? Enforced
        // GraphQL -> enforced: Boolean! (scalar)
        if (ec.Includes("enforced",true))
        {
            if(this.Enforced == null) {

                this.Enforced = true;

            } else {


            }
        }
        else if (this.Enforced != null && ec.Excludes("enforced",true))
        {
            this.Enforced = null;
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (ec.Includes("entityId",true))
        {
            if(this.EntityId == null) {

                this.EntityId = "FETCH";

            } else {


            }
        }
        else if (this.EntityId != null && ec.Excludes("entityId",true))
        {
            this.EntityId = null;
        }
        //      C# -> System.Boolean? LinkEnabled
        // GraphQL -> linkEnabled: Boolean! (scalar)
        if (ec.Includes("linkEnabled",true))
        {
            if(this.LinkEnabled == null) {

                this.LinkEnabled = true;

            } else {


            }
        }
        else if (this.LinkEnabled != null && ec.Excludes("linkEnabled",true))
        {
            this.LinkEnabled = null;
        }
    }


    #endregion

    } // class LinkedEntity
    
    #endregion

    public static class ListLinkedEntityExtensions
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
            this List<LinkedEntity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LinkedEntity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LinkedEntity> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LinkedEntity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LinkedEntity> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types