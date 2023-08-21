// ArtifactPolicy.cs
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
    #region ArtifactPolicy
    public class ArtifactPolicy: BaseType
    {
        #region members

        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        [JsonProperty("externalArtifactKey")]
        public AwsCloudExternalArtifact? ExternalArtifactKey { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.String? TrustPolicyDoc
        // GraphQL -> trustPolicyDoc: String! (scalar)
        [JsonProperty("trustPolicyDoc")]
        public System.String? TrustPolicyDoc { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArtifactPolicy";
    }

    public ArtifactPolicy Set(
        AwsCloudExternalArtifact? ExternalArtifactKey = null,
        System.String? ErrorMessage = null,
        System.String? TrustPolicyDoc = null
    ) 
    {
        if ( ExternalArtifactKey != null ) {
            this.ExternalArtifactKey = ExternalArtifactKey;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( TrustPolicyDoc != null ) {
            this.TrustPolicyDoc = TrustPolicyDoc;
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
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (this.ExternalArtifactKey != null) {
            s += ind + "externalArtifactKey\n" ;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        //      C# -> System.String? TrustPolicyDoc
        // GraphQL -> trustPolicyDoc: String! (scalar)
        if (this.TrustPolicyDoc != null) {
            s += ind + "trustPolicyDoc\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (this.ExternalArtifactKey == null && Exploration.Includes(parent + ".externalArtifactKey", true))
        {
            this.ExternalArtifactKey = new AwsCloudExternalArtifact();
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage", true))
        {
            this.ErrorMessage = "FETCH";
        }
        //      C# -> System.String? TrustPolicyDoc
        // GraphQL -> trustPolicyDoc: String! (scalar)
        if (this.TrustPolicyDoc == null && Exploration.Includes(parent + ".trustPolicyDoc", true))
        {
            this.TrustPolicyDoc = "FETCH";
        }
    }


    #endregion

    } // class ArtifactPolicy
    
    #endregion

    public static class ListArtifactPolicyExtensions
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
            this List<ArtifactPolicy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArtifactPolicy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArtifactPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types