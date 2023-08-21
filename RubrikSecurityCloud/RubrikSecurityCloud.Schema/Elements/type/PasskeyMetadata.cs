// PasskeyMetadata.cs
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
    #region PasskeyMetadata
    public class PasskeyMetadata: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsPasskeyEnabled
        // GraphQL -> isPasskeyEnabled: Boolean! (scalar)
        [JsonProperty("isPasskeyEnabled")]
        public System.Boolean? IsPasskeyEnabled { get; set; }

        //      C# -> List<PasskeyCredentialMetadata>? CredentialsMetadata
        // GraphQL -> credentialsMetadata: [PasskeyCredentialMetadata!]! (type)
        [JsonProperty("credentialsMetadata")]
        public List<PasskeyCredentialMetadata>? CredentialsMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PasskeyMetadata";
    }

    public PasskeyMetadata Set(
        System.Boolean? IsPasskeyEnabled = null,
        List<PasskeyCredentialMetadata>? CredentialsMetadata = null
    ) 
    {
        if ( IsPasskeyEnabled != null ) {
            this.IsPasskeyEnabled = IsPasskeyEnabled;
        }
        if ( CredentialsMetadata != null ) {
            this.CredentialsMetadata = CredentialsMetadata;
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
        //      C# -> System.Boolean? IsPasskeyEnabled
        // GraphQL -> isPasskeyEnabled: Boolean! (scalar)
        if (this.IsPasskeyEnabled != null) {
            s += ind + "isPasskeyEnabled\n" ;
        }
        //      C# -> List<PasskeyCredentialMetadata>? CredentialsMetadata
        // GraphQL -> credentialsMetadata: [PasskeyCredentialMetadata!]! (type)
        if (this.CredentialsMetadata != null) {
            var fspec = this.CredentialsMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "credentialsMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsPasskeyEnabled
        // GraphQL -> isPasskeyEnabled: Boolean! (scalar)
        if (this.IsPasskeyEnabled == null && Exploration.Includes(parent + ".isPasskeyEnabled", true))
        {
            this.IsPasskeyEnabled = true;
        }
        //      C# -> List<PasskeyCredentialMetadata>? CredentialsMetadata
        // GraphQL -> credentialsMetadata: [PasskeyCredentialMetadata!]! (type)
        if (this.CredentialsMetadata == null && Exploration.Includes(parent + ".credentialsMetadata"))
        {
            this.CredentialsMetadata = new List<PasskeyCredentialMetadata>();
            this.CredentialsMetadata.ApplyExploratoryFieldSpec(parent + ".credentialsMetadata");
        }
    }


    #endregion

    } // class PasskeyMetadata
    
    #endregion

    public static class ListPasskeyMetadataExtensions
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
            this List<PasskeyMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PasskeyMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PasskeyMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types