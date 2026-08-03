// OnPremAdPrincipalMetadata.cs
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
    #region OnPremAdPrincipalMetadata
 
    public class OnPremAdPrincipalMetadata: BaseType, IdpSpecificMetadata
    {
        #region members

        //      C# -> List<OnPremAdSupportedEncryptionTypes>? SupEncTypes
        // GraphQL -> supEncTypes: [OnPremAdSupportedEncryptionTypes!]! (enum)
        [JsonProperty("supEncTypes")]
        public List<OnPremAdSupportedEncryptionTypes>? SupEncTypes { get; set; }

        //      C# -> System.Boolean? IsPasswordCompliant
        // GraphQL -> isPasswordCompliant: Boolean! (scalar)
        [JsonProperty("isPasswordCompliant")]
        public System.Boolean? IsPasswordCompliant { get; set; }

        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        [JsonProperty("managedBy")]
        public List<System.String>? ManagedBy { get; set; }

        //      C# -> System.Int32? MgdPasswdInterval
        // GraphQL -> mgdPasswdInterval: Int! (scalar)
        [JsonProperty("mgdPasswdInterval")]
        public System.Int32? MgdPasswdInterval { get; set; }

        //      C# -> OnPremAdPrincipalTypeSpecificMetadata? OnpremAdPrincipalTypeSpecificMetadata
        // GraphQL -> onpremAdPrincipalTypeSpecificMetadata: OnPremAdPrincipalTypeSpecificMetadata (union)
        [JsonProperty("onpremAdPrincipalTypeSpecificMetadata")]
        public OnPremAdPrincipalTypeSpecificMetadata? OnpremAdPrincipalTypeSpecificMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OnPremAdPrincipalMetadata";
    }

    public OnPremAdPrincipalMetadata Set(
        List<OnPremAdSupportedEncryptionTypes>? SupEncTypes = null,
        System.Boolean? IsPasswordCompliant = null,
        List<System.String>? ManagedBy = null,
        System.Int32? MgdPasswdInterval = null,
        OnPremAdPrincipalTypeSpecificMetadata? OnpremAdPrincipalTypeSpecificMetadata = null
    ) 
    {
        if ( SupEncTypes != null ) {
            this.SupEncTypes = SupEncTypes;
        }
        if ( IsPasswordCompliant != null ) {
            this.IsPasswordCompliant = IsPasswordCompliant;
        }
        if ( ManagedBy != null ) {
            this.ManagedBy = ManagedBy;
        }
        if ( MgdPasswdInterval != null ) {
            this.MgdPasswdInterval = MgdPasswdInterval;
        }
        if ( OnpremAdPrincipalTypeSpecificMetadata != null ) {
            this.OnpremAdPrincipalTypeSpecificMetadata = OnpremAdPrincipalTypeSpecificMetadata;
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
        //      C# -> List<OnPremAdSupportedEncryptionTypes>? SupEncTypes
        // GraphQL -> supEncTypes: [OnPremAdSupportedEncryptionTypes!]! (enum)
        if (this.SupEncTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supEncTypes\n" ;
            } else {
                s += ind + "supEncTypes\n" ;
            }
        }
        //      C# -> System.Boolean? IsPasswordCompliant
        // GraphQL -> isPasswordCompliant: Boolean! (scalar)
        if (this.IsPasswordCompliant != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPasswordCompliant\n" ;
            } else {
                s += ind + "isPasswordCompliant\n" ;
            }
        }
        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        if (this.ManagedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedBy\n" ;
            } else {
                s += ind + "managedBy\n" ;
            }
        }
        //      C# -> System.Int32? MgdPasswdInterval
        // GraphQL -> mgdPasswdInterval: Int! (scalar)
        if (this.MgdPasswdInterval != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mgdPasswdInterval\n" ;
            } else {
                s += ind + "mgdPasswdInterval\n" ;
            }
        }
        //      C# -> OnPremAdPrincipalTypeSpecificMetadata? OnpremAdPrincipalTypeSpecificMetadata
        // GraphQL -> onpremAdPrincipalTypeSpecificMetadata: OnPremAdPrincipalTypeSpecificMetadata (union)
        if (this.OnpremAdPrincipalTypeSpecificMetadata != null) {
            var fspec = this.OnpremAdPrincipalTypeSpecificMetadata.AsFieldSpec(conf.Child("onpremAdPrincipalTypeSpecificMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onpremAdPrincipalTypeSpecificMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<OnPremAdSupportedEncryptionTypes>? SupEncTypes
        // GraphQL -> supEncTypes: [OnPremAdSupportedEncryptionTypes!]! (enum)
        if (ec.Includes("supEncTypes",true))
        {
            if(this.SupEncTypes == null) {

                this.SupEncTypes = new List<OnPremAdSupportedEncryptionTypes>();

            } else {


            }
        }
        else if (this.SupEncTypes != null && ec.Excludes("supEncTypes",true))
        {
            this.SupEncTypes = null;
        }
        //      C# -> System.Boolean? IsPasswordCompliant
        // GraphQL -> isPasswordCompliant: Boolean! (scalar)
        if (ec.Includes("isPasswordCompliant",true))
        {
            if(this.IsPasswordCompliant == null) {

                this.IsPasswordCompliant = true;

            } else {


            }
        }
        else if (this.IsPasswordCompliant != null && ec.Excludes("isPasswordCompliant",true))
        {
            this.IsPasswordCompliant = null;
        }
        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        if (ec.Includes("managedBy",true))
        {
            if(this.ManagedBy == null) {

                this.ManagedBy = new List<System.String>();

            } else {


            }
        }
        else if (this.ManagedBy != null && ec.Excludes("managedBy",true))
        {
            this.ManagedBy = null;
        }
        //      C# -> System.Int32? MgdPasswdInterval
        // GraphQL -> mgdPasswdInterval: Int! (scalar)
        if (ec.Includes("mgdPasswdInterval",true))
        {
            if(this.MgdPasswdInterval == null) {

                this.MgdPasswdInterval = Int32.MinValue;

            } else {


            }
        }
        else if (this.MgdPasswdInterval != null && ec.Excludes("mgdPasswdInterval",true))
        {
            this.MgdPasswdInterval = null;
        }
        //      C# -> OnPremAdPrincipalTypeSpecificMetadata? OnpremAdPrincipalTypeSpecificMetadata
        // GraphQL -> onpremAdPrincipalTypeSpecificMetadata: OnPremAdPrincipalTypeSpecificMetadata (union)
        if (ec.Includes("onpremAdPrincipalTypeSpecificMetadata",false))
        {
            if(this.OnpremAdPrincipalTypeSpecificMetadata == null) {

                var impls = new List<OnPremAdPrincipalTypeSpecificMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("onpremAdPrincipalTypeSpecificMetadata"));
                this.OnpremAdPrincipalTypeSpecificMetadata = (OnPremAdPrincipalTypeSpecificMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<OnPremAdPrincipalTypeSpecificMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("onpremAdPrincipalTypeSpecificMetadata"));
                this.OnpremAdPrincipalTypeSpecificMetadata = (OnPremAdPrincipalTypeSpecificMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.OnpremAdPrincipalTypeSpecificMetadata != null && ec.Excludes("onpremAdPrincipalTypeSpecificMetadata",false))
        {
            this.OnpremAdPrincipalTypeSpecificMetadata = null;
        }
    }


    #endregion

    } // class OnPremAdPrincipalMetadata
    
    #endregion

    public static class ListOnPremAdPrincipalMetadataExtensions
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
            this List<OnPremAdPrincipalMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OnPremAdPrincipalMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OnPremAdPrincipalMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OnPremAdPrincipalMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OnPremAdPrincipalMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types