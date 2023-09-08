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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ApplicationCallbackUrl
        // GraphQL -> applicationCallbackUrl: String! (scalar)
        if (this.ApplicationCallbackUrl != null) {
            s += ind + "applicationCallbackUrl\n" ;
        }
        //      C# -> System.String? EncryptionCertificate
        // GraphQL -> encryptionCertificate: String! (scalar)
        if (this.EncryptionCertificate != null) {
            s += ind + "encryptionCertificate\n" ;
        }
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (this.SigningCertificate != null) {
            s += ind + "signingCertificate\n" ;
        }
        //      C# -> System.String? SpEntityId
        // GraphQL -> spEntityId: String! (scalar)
        if (this.SpEntityId != null) {
            s += ind + "spEntityId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApplicationCallbackUrl
        // GraphQL -> applicationCallbackUrl: String! (scalar)
        if (this.ApplicationCallbackUrl == null && ec.Includes("applicationCallbackUrl",true))
        {
            this.ApplicationCallbackUrl = "FETCH";
        }
        //      C# -> System.String? EncryptionCertificate
        // GraphQL -> encryptionCertificate: String! (scalar)
        if (this.EncryptionCertificate == null && ec.Includes("encryptionCertificate",true))
        {
            this.EncryptionCertificate = "FETCH";
        }
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (this.SigningCertificate == null && ec.Includes("signingCertificate",true))
        {
            this.SigningCertificate = "FETCH";
        }
        //      C# -> System.String? SpEntityId
        // GraphQL -> spEntityId: String! (scalar)
        if (this.SpEntityId == null && ec.Includes("spEntityId",true))
        {
            this.SpEntityId = "FETCH";
        }
    }


    #endregion

    } // class GetSpExplicitReply
    
    #endregion

    public static class ListGetSpExplicitReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<GetSpExplicitReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<GetSpExplicitReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types