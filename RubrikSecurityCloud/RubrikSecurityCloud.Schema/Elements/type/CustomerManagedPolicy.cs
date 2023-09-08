// CustomerManagedPolicy.cs
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
    #region CustomerManagedPolicy
    public class CustomerManagedPolicy: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.String? PolicyDocumentJson
        // GraphQL -> policyDocumentJson: String! (scalar)
        [JsonProperty("policyDocumentJson")]
        public System.String? PolicyDocumentJson { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomerManagedPolicy";
    }

    public CustomerManagedPolicy Set(
        CloudAccountFeature? Feature = null,
        System.String? PolicyDocumentJson = null,
        System.String? PolicyName = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( PolicyDocumentJson != null ) {
            this.PolicyDocumentJson = PolicyDocumentJson;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            s += ind + "feature\n" ;
        }
        //      C# -> System.String? PolicyDocumentJson
        // GraphQL -> policyDocumentJson: String! (scalar)
        if (this.PolicyDocumentJson != null) {
            s += ind + "policyDocumentJson\n" ;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            s += ind + "policyName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature == null && ec.Includes("feature",true))
        {
            this.Feature = new CloudAccountFeature();
        }
        //      C# -> System.String? PolicyDocumentJson
        // GraphQL -> policyDocumentJson: String! (scalar)
        if (this.PolicyDocumentJson == null && ec.Includes("policyDocumentJson",true))
        {
            this.PolicyDocumentJson = "FETCH";
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName == null && ec.Includes("policyName",true))
        {
            this.PolicyName = "FETCH";
        }
    }


    #endregion

    } // class CustomerManagedPolicy
    
    #endregion

    public static class ListCustomerManagedPolicyExtensions
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
            this List<CustomerManagedPolicy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CustomerManagedPolicy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomerManagedPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CustomerManagedPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types