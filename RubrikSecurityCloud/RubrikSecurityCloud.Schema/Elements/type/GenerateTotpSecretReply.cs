// GenerateTotpSecretReply.cs
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
    #region GenerateTotpSecretReply
    public class GenerateTotpSecretReply: BaseType
    {
        #region members

        //      C# -> System.String? Secret
        // GraphQL -> secret: String! (scalar)
        [JsonProperty("secret")]
        public System.String? Secret { get; set; }

        //      C# -> System.String? SecretUri
        // GraphQL -> secretUri: String! (scalar)
        [JsonProperty("secretUri")]
        public System.String? SecretUri { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GenerateTotpSecretReply";
    }

    public GenerateTotpSecretReply Set(
        System.String? Secret = null,
        System.String? SecretUri = null
    ) 
    {
        if ( Secret != null ) {
            this.Secret = Secret;
        }
        if ( SecretUri != null ) {
            this.SecretUri = SecretUri;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Secret
        // GraphQL -> secret: String! (scalar)
        if (this.Secret != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secret\n" ;
            } else {
                s += ind + "secret\n" ;
            }
        }
        //      C# -> System.String? SecretUri
        // GraphQL -> secretUri: String! (scalar)
        if (this.SecretUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secretUri\n" ;
            } else {
                s += ind + "secretUri\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Secret
        // GraphQL -> secret: String! (scalar)
        if (ec.Includes("secret",true))
        {
            if(this.Secret == null) {

                this.Secret = "FETCH";

            } else {


            }
        }
        else if (this.Secret != null && ec.Excludes("secret",true))
        {
            this.Secret = null;
        }
        //      C# -> System.String? SecretUri
        // GraphQL -> secretUri: String! (scalar)
        if (ec.Includes("secretUri",true))
        {
            if(this.SecretUri == null) {

                this.SecretUri = "FETCH";

            } else {


            }
        }
        else if (this.SecretUri != null && ec.Excludes("secretUri",true))
        {
            this.SecretUri = null;
        }
    }


    #endregion

    } // class GenerateTotpSecretReply
    
    #endregion

    public static class ListGenerateTotpSecretReplyExtensions
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
            this List<GenerateTotpSecretReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GenerateTotpSecretReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GenerateTotpSecretReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GenerateTotpSecretReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types