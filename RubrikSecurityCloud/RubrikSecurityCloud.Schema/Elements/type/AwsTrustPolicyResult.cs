// AwsTrustPolicyResult.cs
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
    #region AwsTrustPolicyResult
    public class AwsTrustPolicyResult: BaseType
    {
        #region members

        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        [JsonProperty("awsNativeId")]
        public System.String? AwsNativeId { get; set; }

        //      C# -> List<ArtifactPolicy>? Artifacts
        // GraphQL -> artifacts: [ArtifactPolicy!]! (type)
        [JsonProperty("artifacts")]
        public List<ArtifactPolicy>? Artifacts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsTrustPolicyResult";
    }

    public AwsTrustPolicyResult Set(
        System.String? AwsNativeId = null,
        List<ArtifactPolicy>? Artifacts = null
    ) 
    {
        if ( AwsNativeId != null ) {
            this.AwsNativeId = AwsNativeId;
        }
        if ( Artifacts != null ) {
            this.Artifacts = Artifacts;
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
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeId\n" ;
            } else {
                s += ind + "awsNativeId\n" ;
            }
        }
        //      C# -> List<ArtifactPolicy>? Artifacts
        // GraphQL -> artifacts: [ArtifactPolicy!]! (type)
        if (this.Artifacts != null) {
            var fspec = this.Artifacts.AsFieldSpec(conf.Child("artifacts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "artifacts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (ec.Includes("awsNativeId",true))
        {
            if(this.AwsNativeId == null) {

                this.AwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AwsNativeId != null && ec.Excludes("awsNativeId",true))
        {
            this.AwsNativeId = null;
        }
        //      C# -> List<ArtifactPolicy>? Artifacts
        // GraphQL -> artifacts: [ArtifactPolicy!]! (type)
        if (ec.Includes("artifacts",false))
        {
            if(this.Artifacts == null) {

                this.Artifacts = new List<ArtifactPolicy>();
                this.Artifacts.ApplyExploratoryFieldSpec(ec.NewChild("artifacts"));

            } else {

                this.Artifacts.ApplyExploratoryFieldSpec(ec.NewChild("artifacts"));

            }
        }
        else if (this.Artifacts != null && ec.Excludes("artifacts",false))
        {
            this.Artifacts = null;
        }
    }


    #endregion

    } // class AwsTrustPolicyResult
    
    #endregion

    public static class ListAwsTrustPolicyResultExtensions
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
            this List<AwsTrustPolicyResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsTrustPolicyResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsTrustPolicyResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsTrustPolicyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types