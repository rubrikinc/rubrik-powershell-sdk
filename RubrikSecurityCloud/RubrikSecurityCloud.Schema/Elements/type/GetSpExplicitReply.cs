// GetSpExplicitReply.cs
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
    #region GetSpExplicitReply
    public class GetSpExplicitReply: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationCallbackUrl
        // GraphQL -> applicationCallbackUrl: String! (scalar)
        [JsonProperty("applicationCallbackUrl")]
        public System.String? ApplicationCallbackUrl { get; set; }

        //      C# -> System.String? EncryptionCertificate
        // GraphQL -> encryptionCertificate: String! (scalar)
        [JsonProperty("encryptionCertificate")]
        public System.String? EncryptionCertificate { get; set; }

        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        [JsonProperty("signingCertificate")]
        public System.String? SigningCertificate { get; set; }

        //      C# -> System.String? SpEntityId
        // GraphQL -> spEntityId: String! (scalar)
        [JsonProperty("spEntityId")]
        public System.String? SpEntityId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSPExplicitReply";
    }

    public GetSpExplicitReply Set(
        System.String? ApplicationCallbackUrl = null,
        System.String? EncryptionCertificate = null,
        System.String? SigningCertificate = null,
        System.String? SpEntityId = null
    ) 
    {
        if ( ApplicationCallbackUrl != null ) {
            this.ApplicationCallbackUrl = ApplicationCallbackUrl;
        }
        if ( EncryptionCertificate != null ) {
            this.EncryptionCertificate = EncryptionCertificate;
        }
        if ( SigningCertificate != null ) {
            this.SigningCertificate = SigningCertificate;
        }
        if ( SpEntityId != null ) {
            this.SpEntityId = SpEntityId;
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
        //      C# -> System.String? ApplicationCallbackUrl
        // GraphQL -> applicationCallbackUrl: String! (scalar)
        if (this.ApplicationCallbackUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationCallbackUrl\n" ;
            } else {
                s += ind + "applicationCallbackUrl\n" ;
            }
        }
        //      C# -> System.String? EncryptionCertificate
        // GraphQL -> encryptionCertificate: String! (scalar)
        if (this.EncryptionCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionCertificate\n" ;
            } else {
                s += ind + "encryptionCertificate\n" ;
            }
        }
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (this.SigningCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signingCertificate\n" ;
            } else {
                s += ind + "signingCertificate\n" ;
            }
        }
        //      C# -> System.String? SpEntityId
        // GraphQL -> spEntityId: String! (scalar)
        if (this.SpEntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "spEntityId\n" ;
            } else {
                s += ind + "spEntityId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApplicationCallbackUrl
        // GraphQL -> applicationCallbackUrl: String! (scalar)
        if (ec.Includes("applicationCallbackUrl",true))
        {
            if(this.ApplicationCallbackUrl == null) {

                this.ApplicationCallbackUrl = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationCallbackUrl != null && ec.Excludes("applicationCallbackUrl",true))
        {
            this.ApplicationCallbackUrl = null;
        }
        //      C# -> System.String? EncryptionCertificate
        // GraphQL -> encryptionCertificate: String! (scalar)
        if (ec.Includes("encryptionCertificate",true))
        {
            if(this.EncryptionCertificate == null) {

                this.EncryptionCertificate = "FETCH";

            } else {


            }
        }
        else if (this.EncryptionCertificate != null && ec.Excludes("encryptionCertificate",true))
        {
            this.EncryptionCertificate = null;
        }
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (ec.Includes("signingCertificate",true))
        {
            if(this.SigningCertificate == null) {

                this.SigningCertificate = "FETCH";

            } else {


            }
        }
        else if (this.SigningCertificate != null && ec.Excludes("signingCertificate",true))
        {
            this.SigningCertificate = null;
        }
        //      C# -> System.String? SpEntityId
        // GraphQL -> spEntityId: String! (scalar)
        if (ec.Includes("spEntityId",true))
        {
            if(this.SpEntityId == null) {

                this.SpEntityId = "FETCH";

            } else {


            }
        }
        else if (this.SpEntityId != null && ec.Excludes("spEntityId",true))
        {
            this.SpEntityId = null;
        }
    }


    #endregion

    } // class GetSpExplicitReply
    
    #endregion

    public static class ListGetSpExplicitReplyExtensions
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
            this List<GetSpExplicitReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSpExplicitReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSpExplicitReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSpExplicitReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSpExplicitReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types