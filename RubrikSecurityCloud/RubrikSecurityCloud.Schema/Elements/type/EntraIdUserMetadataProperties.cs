// EntraIdUserMetadataProperties.cs
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
    #region EntraIdUserMetadataProperties
 
    public class EntraIdUserMetadataProperties: BaseType, PrincipalMetadata
    {
        #region members

        //      C# -> MfaStrength? MfaStrength
        // GraphQL -> mfaStrength: MfaStrength! (enum)
        [JsonProperty("mfaStrength")]
        public MfaStrength? MfaStrength { get; set; }

        //      C# -> System.String? OnPremSid
        // GraphQL -> onPremSid: String! (scalar)
        [JsonProperty("onPremSid")]
        public System.String? OnPremSid { get; set; }

        //      C# -> System.Int64? PwdLastSet
        // GraphQL -> pwdLastSet: Long! (scalar)
        [JsonProperty("pwdLastSet")]
        public System.Int64? PwdLastSet { get; set; }

        //      C# -> System.Boolean? TerminatedEmployee
        // GraphQL -> terminatedEmployee: Boolean! (scalar)
        [JsonProperty("terminatedEmployee")]
        public System.Boolean? TerminatedEmployee { get; set; }

        //      C# -> List<EntraIdUserShadowMetadataAdminProperties>? ShadowAdmins
        // GraphQL -> shadowAdmins: [EntraIdUserShadowMetadataAdminProperties!]! (type)
        [JsonProperty("shadowAdmins")]
        public List<EntraIdUserShadowMetadataAdminProperties>? ShadowAdmins { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDUserMetadataProperties";
    }

    public EntraIdUserMetadataProperties Set(
        MfaStrength? MfaStrength = null,
        System.String? OnPremSid = null,
        System.Int64? PwdLastSet = null,
        System.Boolean? TerminatedEmployee = null,
        List<EntraIdUserShadowMetadataAdminProperties>? ShadowAdmins = null
    ) 
    {
        if ( MfaStrength != null ) {
            this.MfaStrength = MfaStrength;
        }
        if ( OnPremSid != null ) {
            this.OnPremSid = OnPremSid;
        }
        if ( PwdLastSet != null ) {
            this.PwdLastSet = PwdLastSet;
        }
        if ( TerminatedEmployee != null ) {
            this.TerminatedEmployee = TerminatedEmployee;
        }
        if ( ShadowAdmins != null ) {
            this.ShadowAdmins = ShadowAdmins;
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
        //      C# -> MfaStrength? MfaStrength
        // GraphQL -> mfaStrength: MfaStrength! (enum)
        if (this.MfaStrength != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaStrength\n" ;
            } else {
                s += ind + "mfaStrength\n" ;
            }
        }
        //      C# -> System.String? OnPremSid
        // GraphQL -> onPremSid: String! (scalar)
        if (this.OnPremSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremSid\n" ;
            } else {
                s += ind + "onPremSid\n" ;
            }
        }
        //      C# -> System.Int64? PwdLastSet
        // GraphQL -> pwdLastSet: Long! (scalar)
        if (this.PwdLastSet != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pwdLastSet\n" ;
            } else {
                s += ind + "pwdLastSet\n" ;
            }
        }
        //      C# -> System.Boolean? TerminatedEmployee
        // GraphQL -> terminatedEmployee: Boolean! (scalar)
        if (this.TerminatedEmployee != null) {
            if (conf.Flat) {
                s += conf.Prefix + "terminatedEmployee\n" ;
            } else {
                s += ind + "terminatedEmployee\n" ;
            }
        }
        //      C# -> List<EntraIdUserShadowMetadataAdminProperties>? ShadowAdmins
        // GraphQL -> shadowAdmins: [EntraIdUserShadowMetadataAdminProperties!]! (type)
        if (this.ShadowAdmins != null) {
            var fspec = this.ShadowAdmins.AsFieldSpec(conf.Child("shadowAdmins"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "shadowAdmins" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MfaStrength? MfaStrength
        // GraphQL -> mfaStrength: MfaStrength! (enum)
        if (ec.Includes("mfaStrength",true))
        {
            if(this.MfaStrength == null) {

                this.MfaStrength = new MfaStrength();

            } else {


            }
        }
        else if (this.MfaStrength != null && ec.Excludes("mfaStrength",true))
        {
            this.MfaStrength = null;
        }
        //      C# -> System.String? OnPremSid
        // GraphQL -> onPremSid: String! (scalar)
        if (ec.Includes("onPremSid",true))
        {
            if(this.OnPremSid == null) {

                this.OnPremSid = "FETCH";

            } else {


            }
        }
        else if (this.OnPremSid != null && ec.Excludes("onPremSid",true))
        {
            this.OnPremSid = null;
        }
        //      C# -> System.Int64? PwdLastSet
        // GraphQL -> pwdLastSet: Long! (scalar)
        if (ec.Includes("pwdLastSet",true))
        {
            if(this.PwdLastSet == null) {

                this.PwdLastSet = new System.Int64();

            } else {


            }
        }
        else if (this.PwdLastSet != null && ec.Excludes("pwdLastSet",true))
        {
            this.PwdLastSet = null;
        }
        //      C# -> System.Boolean? TerminatedEmployee
        // GraphQL -> terminatedEmployee: Boolean! (scalar)
        if (ec.Includes("terminatedEmployee",true))
        {
            if(this.TerminatedEmployee == null) {

                this.TerminatedEmployee = true;

            } else {


            }
        }
        else if (this.TerminatedEmployee != null && ec.Excludes("terminatedEmployee",true))
        {
            this.TerminatedEmployee = null;
        }
        //      C# -> List<EntraIdUserShadowMetadataAdminProperties>? ShadowAdmins
        // GraphQL -> shadowAdmins: [EntraIdUserShadowMetadataAdminProperties!]! (type)
        if (ec.Includes("shadowAdmins",false))
        {
            if(this.ShadowAdmins == null) {

                this.ShadowAdmins = new List<EntraIdUserShadowMetadataAdminProperties>();
                this.ShadowAdmins.ApplyExploratoryFieldSpec(ec.NewChild("shadowAdmins"));

            } else {

                this.ShadowAdmins.ApplyExploratoryFieldSpec(ec.NewChild("shadowAdmins"));

            }
        }
        else if (this.ShadowAdmins != null && ec.Excludes("shadowAdmins",false))
        {
            this.ShadowAdmins = null;
        }
    }


    #endregion

    } // class EntraIdUserMetadataProperties
    
    #endregion

    public static class ListEntraIdUserMetadataPropertiesExtensions
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
            this List<EntraIdUserMetadataProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdUserMetadataProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdUserMetadataProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdUserMetadataProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdUserMetadataProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types