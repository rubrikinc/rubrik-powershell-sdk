// IdentityEventTarget.cs
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
    #region IdentityEventTarget
    public class IdentityEventTarget: BaseType
    {
        #region members

        //      C# -> ViolationPrincipalType? IdentityType
        // GraphQL -> identityType: ViolationPrincipalType! (enum)
        [JsonProperty("identityType")]
        public ViolationPrincipalType? IdentityType { get; set; }

        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        [JsonProperty("privilegeType")]
        public PrivilegeType? PrivilegeType { get; set; }

        //      C# -> System.String? IdentityId
        // GraphQL -> identityId: String! (scalar)
        [JsonProperty("identityId")]
        public System.String? IdentityId { get; set; }

        //      C# -> System.String? IdentityName
        // GraphQL -> identityName: String! (scalar)
        [JsonProperty("identityName")]
        public System.String? IdentityName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityEventTarget";
    }

    public IdentityEventTarget Set(
        ViolationPrincipalType? IdentityType = null,
        PrivilegeType? PrivilegeType = null,
        System.String? IdentityId = null,
        System.String? IdentityName = null
    ) 
    {
        if ( IdentityType != null ) {
            this.IdentityType = IdentityType;
        }
        if ( PrivilegeType != null ) {
            this.PrivilegeType = PrivilegeType;
        }
        if ( IdentityId != null ) {
            this.IdentityId = IdentityId;
        }
        if ( IdentityName != null ) {
            this.IdentityName = IdentityName;
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
        //      C# -> ViolationPrincipalType? IdentityType
        // GraphQL -> identityType: ViolationPrincipalType! (enum)
        if (this.IdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityType\n" ;
            } else {
                s += ind + "identityType\n" ;
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
        //      C# -> System.String? IdentityId
        // GraphQL -> identityId: String! (scalar)
        if (this.IdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityId\n" ;
            } else {
                s += ind + "identityId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationPrincipalType? IdentityType
        // GraphQL -> identityType: ViolationPrincipalType! (enum)
        if (ec.Includes("identityType",true))
        {
            if(this.IdentityType == null) {

                this.IdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.IdentityType != null && ec.Excludes("identityType",true))
        {
            this.IdentityType = null;
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
        //      C# -> System.String? IdentityId
        // GraphQL -> identityId: String! (scalar)
        if (ec.Includes("identityId",true))
        {
            if(this.IdentityId == null) {

                this.IdentityId = "FETCH";

            } else {


            }
        }
        else if (this.IdentityId != null && ec.Excludes("identityId",true))
        {
            this.IdentityId = null;
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
    }


    #endregion

    } // class IdentityEventTarget
    
    #endregion

    public static class ListIdentityEventTargetExtensions
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
            this List<IdentityEventTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityEventTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityEventTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityEventTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityEventTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types