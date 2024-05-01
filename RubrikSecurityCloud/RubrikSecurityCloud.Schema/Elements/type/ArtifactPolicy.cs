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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ArtifactPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArtifactPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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