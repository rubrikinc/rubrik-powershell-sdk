// IdentityInfo.cs
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
    #region IdentityInfo
    public class IdentityInfo: BaseType
    {
        #region members

        //      C# -> PrincipalRiskySummaryPrincipalType? IdentityType
        // GraphQL -> identityType: PrincipalRiskySummaryPrincipalType! (enum)
        [JsonProperty("identityType")]
        public PrincipalRiskySummaryPrincipalType? IdentityType { get; set; }

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        [JsonProperty("privilegeType")]
        public PrivilegeType? PrivilegeType { get; set; }

        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        [JsonProperty("status")]
        public IdentityStatus? Status { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        [JsonProperty("entityName")]
        public System.String? EntityName { get; set; }

        //      C# -> System.String? IdentityName
        // GraphQL -> identityName: String! (scalar)
        [JsonProperty("identityName")]
        public System.String? IdentityName { get; set; }

        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        [JsonProperty("uniqueIdentifier")]
        public System.String? UniqueIdentifier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityInfo";
    }

    public IdentityInfo Set(
        PrincipalRiskySummaryPrincipalType? IdentityType = null,
        IdpType? IdpType = null,
        PrivilegeType? PrivilegeType = null,
        IdentityStatus? Status = null,
        System.String? EntityId = null,
        System.String? EntityName = null,
        System.String? IdentityName = null,
        System.String? UniqueIdentifier = null
    ) 
    {
        if ( IdentityType != null ) {
            this.IdentityType = IdentityType;
        }
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( PrivilegeType != null ) {
            this.PrivilegeType = PrivilegeType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( EntityName != null ) {
            this.EntityName = EntityName;
        }
        if ( IdentityName != null ) {
            this.IdentityName = IdentityName;
        }
        if ( UniqueIdentifier != null ) {
            this.UniqueIdentifier = UniqueIdentifier;
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
        //      C# -> PrincipalRiskySummaryPrincipalType? IdentityType
        // GraphQL -> identityType: PrincipalRiskySummaryPrincipalType! (enum)
        if (this.IdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityType\n" ;
            } else {
                s += ind + "identityType\n" ;
            }
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (this.PrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privilegeType\n" ;
            } else {
                s += ind + "privilegeType\n" ;
            }
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (this.EntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityName\n" ;
            } else {
                s += ind + "entityName\n" ;
            }
        }
        //      C# -> System.String? IdentityName
        // GraphQL -> identityName: String! (scalar)
        if (this.IdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityName\n" ;
            } else {
                s += ind + "identityName\n" ;
            }
        }
        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        if (this.UniqueIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueIdentifier\n" ;
            } else {
                s += ind + "uniqueIdentifier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PrincipalRiskySummaryPrincipalType? IdentityType
        // GraphQL -> identityType: PrincipalRiskySummaryPrincipalType! (enum)
        if (ec.Includes("identityType",true))
        {
            if(this.IdentityType == null) {

                this.IdentityType = new PrincipalRiskySummaryPrincipalType();

            } else {


            }
        }
        else if (this.IdentityType != null && ec.Excludes("identityType",true))
        {
            this.IdentityType = null;
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (ec.Includes("privilegeType",true))
        {
            if(this.PrivilegeType == null) {

                this.PrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.PrivilegeType != null && ec.Excludes("privilegeType",true))
        {
            this.PrivilegeType = null;
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new IdentityStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (ec.Includes("entityName",true))
        {
            if(this.EntityName == null) {

                this.EntityName = "FETCH";

            } else {


            }
        }
        else if (this.EntityName != null && ec.Excludes("entityName",true))
        {
            this.EntityName = null;
        }
        //      C# -> System.String? IdentityName
        // GraphQL -> identityName: String! (scalar)
        if (ec.Includes("identityName",true))
        {
            if(this.IdentityName == null) {

                this.IdentityName = "FETCH";

            } else {


            }
        }
        else if (this.IdentityName != null && ec.Excludes("identityName",true))
        {
            this.IdentityName = null;
        }
        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        if (ec.Includes("uniqueIdentifier",true))
        {
            if(this.UniqueIdentifier == null) {

                this.UniqueIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.UniqueIdentifier != null && ec.Excludes("uniqueIdentifier",true))
        {
            this.UniqueIdentifier = null;
        }
    }


    #endregion

    } // class IdentityInfo
    
    #endregion

    public static class ListIdentityInfoExtensions
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
            this List<IdentityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types