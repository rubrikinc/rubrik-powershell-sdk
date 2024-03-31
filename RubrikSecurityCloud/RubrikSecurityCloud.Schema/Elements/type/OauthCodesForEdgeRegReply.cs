// OauthCodesForEdgeRegReply.cs
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
    #region OauthCodesForEdgeRegReply
    public class OauthCodesForEdgeRegReply: BaseType
    {
        #region members

        //      C# -> System.String? CdmOvaLink
        // GraphQL -> cdmOvaLink: String! (scalar)
        [JsonProperty("cdmOvaLink")]
        public System.String? CdmOvaLink { get; set; }

        //      C# -> System.String? WindowsToolLink
        // GraphQL -> windowsToolLink: String! (scalar)
        [JsonProperty("windowsToolLink")]
        public System.String? WindowsToolLink { get; set; }

        //      C# -> List<OauthAccessToken>? RegistrationCodes
        // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
        [JsonProperty("registrationCodes")]
        public List<OauthAccessToken>? RegistrationCodes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OauthCodesForEdgeRegReply";
    }

    public OauthCodesForEdgeRegReply Set(
        System.String? CdmOvaLink = null,
        System.String? WindowsToolLink = null,
        List<OauthAccessToken>? RegistrationCodes = null
    ) 
    {
        if ( CdmOvaLink != null ) {
            this.CdmOvaLink = CdmOvaLink;
        }
        if ( WindowsToolLink != null ) {
            this.WindowsToolLink = WindowsToolLink;
        }
        if ( RegistrationCodes != null ) {
            this.RegistrationCodes = RegistrationCodes;
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
        //      C# -> System.String? CdmOvaLink
        // GraphQL -> cdmOvaLink: String! (scalar)
        if (this.CdmOvaLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmOvaLink\n" ;
            } else {
                s += ind + "cdmOvaLink\n" ;
            }
        }
        //      C# -> System.String? WindowsToolLink
        // GraphQL -> windowsToolLink: String! (scalar)
        if (this.WindowsToolLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowsToolLink\n" ;
            } else {
                s += ind + "windowsToolLink\n" ;
            }
        }
        //      C# -> List<OauthAccessToken>? RegistrationCodes
        // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
        if (this.RegistrationCodes != null) {
            var fspec = this.RegistrationCodes.AsFieldSpec(conf.Child("registrationCodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "registrationCodes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmOvaLink
        // GraphQL -> cdmOvaLink: String! (scalar)
        if (ec.Includes("cdmOvaLink",true))
        {
            if(this.CdmOvaLink == null) {

                this.CdmOvaLink = "FETCH";

            } else {


            }
        }
        else if (this.CdmOvaLink != null && ec.Excludes("cdmOvaLink",true))
        {
            this.CdmOvaLink = null;
        }
        //      C# -> System.String? WindowsToolLink
        // GraphQL -> windowsToolLink: String! (scalar)
        if (ec.Includes("windowsToolLink",true))
        {
            if(this.WindowsToolLink == null) {

                this.WindowsToolLink = "FETCH";

            } else {


            }
        }
        else if (this.WindowsToolLink != null && ec.Excludes("windowsToolLink",true))
        {
            this.WindowsToolLink = null;
        }
        //      C# -> List<OauthAccessToken>? RegistrationCodes
        // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
        if (ec.Includes("registrationCodes",false))
        {
            if(this.RegistrationCodes == null) {

                this.RegistrationCodes = new List<OauthAccessToken>();
                this.RegistrationCodes.ApplyExploratoryFieldSpec(ec.NewChild("registrationCodes"));

            } else {

                this.RegistrationCodes.ApplyExploratoryFieldSpec(ec.NewChild("registrationCodes"));

            }
        }
        else if (this.RegistrationCodes != null && ec.Excludes("registrationCodes",false))
        {
            this.RegistrationCodes = null;
        }
    }


    #endregion

    } // class OauthCodesForEdgeRegReply
    
    #endregion

    public static class ListOauthCodesForEdgeRegReplyExtensions
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
            this List<OauthCodesForEdgeRegReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OauthCodesForEdgeRegReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OauthCodesForEdgeRegReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OauthCodesForEdgeRegReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OauthCodesForEdgeRegReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types