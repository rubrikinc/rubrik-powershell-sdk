// PrincipalSummaryAdditionalMetadata.cs
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
    #region PrincipalSummaryAdditionalMetadata
    public class PrincipalSummaryAdditionalMetadata: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasOldPassword
        // GraphQL -> hasOldPassword: Boolean! (scalar)
        [JsonProperty("hasOldPassword")]
        public System.Boolean? HasOldPassword { get; set; }

        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        [JsonProperty("isDisabled")]
        public System.Boolean? IsDisabled { get; set; }

        //      C# -> IdpSpecificMetadata? IdpSpecificMetadata
        // GraphQL -> idpSpecificMetadata: IdpSpecificMetadata (union)
        [JsonProperty("idpSpecificMetadata")]
        public IdpSpecificMetadata? IdpSpecificMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalSummaryAdditionalMetadata";
    }

    public PrincipalSummaryAdditionalMetadata Set(
        System.Boolean? HasOldPassword = null,
        System.Boolean? IsDisabled = null,
        IdpSpecificMetadata? IdpSpecificMetadata = null
    ) 
    {
        if ( HasOldPassword != null ) {
            this.HasOldPassword = HasOldPassword;
        }
        if ( IsDisabled != null ) {
            this.IsDisabled = IsDisabled;
        }
        if ( IdpSpecificMetadata != null ) {
            this.IdpSpecificMetadata = IdpSpecificMetadata;
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
        //      C# -> System.Boolean? HasOldPassword
        // GraphQL -> hasOldPassword: Boolean! (scalar)
        if (this.HasOldPassword != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasOldPassword\n" ;
            } else {
                s += ind + "hasOldPassword\n" ;
            }
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (this.IsDisabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDisabled\n" ;
            } else {
                s += ind + "isDisabled\n" ;
            }
        }
        //      C# -> IdpSpecificMetadata? IdpSpecificMetadata
        // GraphQL -> idpSpecificMetadata: IdpSpecificMetadata (union)
        if (this.IdpSpecificMetadata != null) {
            var fspec = this.IdpSpecificMetadata.AsFieldSpec(conf.Child("idpSpecificMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "idpSpecificMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? HasOldPassword
        // GraphQL -> hasOldPassword: Boolean! (scalar)
        if (ec.Includes("hasOldPassword",true))
        {
            if(this.HasOldPassword == null) {

                this.HasOldPassword = true;

            } else {


            }
        }
        else if (this.HasOldPassword != null && ec.Excludes("hasOldPassword",true))
        {
            this.HasOldPassword = null;
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (ec.Includes("isDisabled",true))
        {
            if(this.IsDisabled == null) {

                this.IsDisabled = true;

            } else {


            }
        }
        else if (this.IsDisabled != null && ec.Excludes("isDisabled",true))
        {
            this.IsDisabled = null;
        }
        //      C# -> IdpSpecificMetadata? IdpSpecificMetadata
        // GraphQL -> idpSpecificMetadata: IdpSpecificMetadata (union)
        if (ec.Includes("idpSpecificMetadata",false))
        {
            if(this.IdpSpecificMetadata == null) {

                var impls = new List<IdpSpecificMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("idpSpecificMetadata"));
                this.IdpSpecificMetadata = (IdpSpecificMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<IdpSpecificMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("idpSpecificMetadata"));
                this.IdpSpecificMetadata = (IdpSpecificMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.IdpSpecificMetadata != null && ec.Excludes("idpSpecificMetadata",false))
        {
            this.IdpSpecificMetadata = null;
        }
    }


    #endregion

    } // class PrincipalSummaryAdditionalMetadata
    
    #endregion

    public static class ListPrincipalSummaryAdditionalMetadataExtensions
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
            this List<PrincipalSummaryAdditionalMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalSummaryAdditionalMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalSummaryAdditionalMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalSummaryAdditionalMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalSummaryAdditionalMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types