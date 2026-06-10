// PolicyTypeInfo.cs
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
    #region PolicyTypeInfo
    public class PolicyTypeInfo: BaseType
    {
        #region members

        //      C# -> IdentityEventPolicyInfo? IdentityEventPolicyInfo
        // GraphQL -> identityEventPolicyInfo: IdentityEventPolicyInfo (type)
        [JsonProperty("identityEventPolicyInfo")]
        public IdentityEventPolicyInfo? IdentityEventPolicyInfo { get; set; }

        //      C# -> IdentityPolicyInfo? IdentityPolicyInfo
        // GraphQL -> identityPolicyInfo: IdentityPolicyInfo (type)
        [JsonProperty("identityPolicyInfo")]
        public IdentityPolicyInfo? IdentityPolicyInfo { get; set; }

        //      C# -> IdpPolicyInfo? IdpPolicyInfo
        // GraphQL -> idpPolicyInfo: IdpPolicyInfo (type)
        [JsonProperty("idpPolicyInfo")]
        public IdpPolicyInfo? IdpPolicyInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyTypeInfo";
    }

    public PolicyTypeInfo Set(
        IdentityEventPolicyInfo? IdentityEventPolicyInfo = null,
        IdentityPolicyInfo? IdentityPolicyInfo = null,
        IdpPolicyInfo? IdpPolicyInfo = null
    ) 
    {
        if ( IdentityEventPolicyInfo != null ) {
            this.IdentityEventPolicyInfo = IdentityEventPolicyInfo;
        }
        if ( IdentityPolicyInfo != null ) {
            this.IdentityPolicyInfo = IdentityPolicyInfo;
        }
        if ( IdpPolicyInfo != null ) {
            this.IdpPolicyInfo = IdpPolicyInfo;
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
        //      C# -> IdentityEventPolicyInfo? IdentityEventPolicyInfo
        // GraphQL -> identityEventPolicyInfo: IdentityEventPolicyInfo (type)
        if (this.IdentityEventPolicyInfo != null) {
            var fspec = this.IdentityEventPolicyInfo.AsFieldSpec(conf.Child("identityEventPolicyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "identityEventPolicyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IdentityPolicyInfo? IdentityPolicyInfo
        // GraphQL -> identityPolicyInfo: IdentityPolicyInfo (type)
        if (this.IdentityPolicyInfo != null) {
            var fspec = this.IdentityPolicyInfo.AsFieldSpec(conf.Child("identityPolicyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "identityPolicyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IdpPolicyInfo? IdpPolicyInfo
        // GraphQL -> idpPolicyInfo: IdpPolicyInfo (type)
        if (this.IdpPolicyInfo != null) {
            var fspec = this.IdpPolicyInfo.AsFieldSpec(conf.Child("idpPolicyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "idpPolicyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdentityEventPolicyInfo? IdentityEventPolicyInfo
        // GraphQL -> identityEventPolicyInfo: IdentityEventPolicyInfo (type)
        if (ec.Includes("identityEventPolicyInfo",false))
        {
            if(this.IdentityEventPolicyInfo == null) {

                this.IdentityEventPolicyInfo = new IdentityEventPolicyInfo();
                this.IdentityEventPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityEventPolicyInfo"));

            } else {

                this.IdentityEventPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityEventPolicyInfo"));

            }
        }
        else if (this.IdentityEventPolicyInfo != null && ec.Excludes("identityEventPolicyInfo",false))
        {
            this.IdentityEventPolicyInfo = null;
        }
        //      C# -> IdentityPolicyInfo? IdentityPolicyInfo
        // GraphQL -> identityPolicyInfo: IdentityPolicyInfo (type)
        if (ec.Includes("identityPolicyInfo",false))
        {
            if(this.IdentityPolicyInfo == null) {

                this.IdentityPolicyInfo = new IdentityPolicyInfo();
                this.IdentityPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityPolicyInfo"));

            } else {

                this.IdentityPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityPolicyInfo"));

            }
        }
        else if (this.IdentityPolicyInfo != null && ec.Excludes("identityPolicyInfo",false))
        {
            this.IdentityPolicyInfo = null;
        }
        //      C# -> IdpPolicyInfo? IdpPolicyInfo
        // GraphQL -> idpPolicyInfo: IdpPolicyInfo (type)
        if (ec.Includes("idpPolicyInfo",false))
        {
            if(this.IdpPolicyInfo == null) {

                this.IdpPolicyInfo = new IdpPolicyInfo();
                this.IdpPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("idpPolicyInfo"));

            } else {

                this.IdpPolicyInfo.ApplyExploratoryFieldSpec(ec.NewChild("idpPolicyInfo"));

            }
        }
        else if (this.IdpPolicyInfo != null && ec.Excludes("idpPolicyInfo",false))
        {
            this.IdpPolicyInfo = null;
        }
    }


    #endregion

    } // class PolicyTypeInfo
    
    #endregion

    public static class ListPolicyTypeInfoExtensions
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
            this List<PolicyTypeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyTypeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyTypeInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyTypeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyTypeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types