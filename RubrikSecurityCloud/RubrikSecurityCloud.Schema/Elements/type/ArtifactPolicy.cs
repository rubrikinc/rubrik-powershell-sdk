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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (this.ExternalArtifactKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalArtifactKey\n" ;
            } else {
                s += ind + "externalArtifactKey\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.String? TrustPolicyDoc
        // GraphQL -> trustPolicyDoc: String! (scalar)
        if (this.TrustPolicyDoc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustPolicyDoc\n" ;
            } else {
                s += ind + "trustPolicyDoc\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (ec.Includes("externalArtifactKey",true))
        {
            if(this.ExternalArtifactKey == null) {

                this.ExternalArtifactKey = new AwsCloudExternalArtifact();

            } else {


            }
        }
        else if (this.ExternalArtifactKey != null && ec.Excludes("externalArtifactKey",true))
        {
            this.ExternalArtifactKey = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.String? TrustPolicyDoc
        // GraphQL -> trustPolicyDoc: String! (scalar)
        if (ec.Includes("trustPolicyDoc",true))
        {
            if(this.TrustPolicyDoc == null) {

                this.TrustPolicyDoc = "FETCH";

            } else {


            }
        }
        else if (this.TrustPolicyDoc != null && ec.Excludes("trustPolicyDoc",true))
        {
            this.TrustPolicyDoc = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArtifactPolicy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArtifactPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArtifactPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types