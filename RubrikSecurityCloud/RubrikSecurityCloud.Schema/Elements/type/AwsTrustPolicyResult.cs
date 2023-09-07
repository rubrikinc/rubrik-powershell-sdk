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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId != null) {
            s += ind + "awsNativeId\n" ;
        }
        //      C# -> List<ArtifactPolicy>? Artifacts
        // GraphQL -> artifacts: [ArtifactPolicy!]! (type)
        if (this.Artifacts != null) {
            var fspec = this.Artifacts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "artifacts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId == null && ec.Includes("awsNativeId",true))
        {
            this.AwsNativeId = "FETCH";
        }
        //      C# -> List<ArtifactPolicy>? Artifacts
        // GraphQL -> artifacts: [ArtifactPolicy!]! (type)
        if (this.Artifacts == null && ec.Includes("artifacts",false))
        {
            this.Artifacts = new List<ArtifactPolicy>();
            this.Artifacts.ApplyExploratoryFieldSpec(ec.NewChild("artifacts"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<AwsTrustPolicyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types