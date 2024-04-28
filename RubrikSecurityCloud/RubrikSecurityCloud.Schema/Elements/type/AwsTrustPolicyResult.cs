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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "artifacts" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<AwsTrustPolicyResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsTrustPolicyResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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