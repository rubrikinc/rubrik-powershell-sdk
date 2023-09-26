// PermissionPolicy.cs
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
    #region PermissionPolicy
    public class PermissionPolicy: BaseType
    {
        #region members

        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        [JsonProperty("externalArtifactKey")]
        public AwsCloudExternalArtifact? ExternalArtifactKey { get; set; }

        //      C# -> List<System.String>? AwsManagedPolicies
        // GraphQL -> awsManagedPolicies: [String!]! (scalar)
        [JsonProperty("awsManagedPolicies")]
        public List<System.String>? AwsManagedPolicies { get; set; }

        //      C# -> List<CustomerManagedPolicy>? CustomerManagedPolicies
        // GraphQL -> customerManagedPolicies: [CustomerManagedPolicy!]! (type)
        [JsonProperty("customerManagedPolicies")]
        public List<CustomerManagedPolicy>? CustomerManagedPolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PermissionPolicy";
    }

    public PermissionPolicy Set(
        AwsCloudExternalArtifact? ExternalArtifactKey = null,
        List<System.String>? AwsManagedPolicies = null,
        List<CustomerManagedPolicy>? CustomerManagedPolicies = null
    ) 
    {
        if ( ExternalArtifactKey != null ) {
            this.ExternalArtifactKey = ExternalArtifactKey;
        }
        if ( AwsManagedPolicies != null ) {
            this.AwsManagedPolicies = AwsManagedPolicies;
        }
        if ( CustomerManagedPolicies != null ) {
            this.CustomerManagedPolicies = CustomerManagedPolicies;
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
        //      C# -> List<System.String>? AwsManagedPolicies
        // GraphQL -> awsManagedPolicies: [String!]! (scalar)
        if (this.AwsManagedPolicies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsManagedPolicies\n" ;
            } else {
                s += ind + "awsManagedPolicies\n" ;
            }
        }
        //      C# -> List<CustomerManagedPolicy>? CustomerManagedPolicies
        // GraphQL -> customerManagedPolicies: [CustomerManagedPolicy!]! (type)
        if (this.CustomerManagedPolicies != null) {
            var fspec = this.CustomerManagedPolicies.AsFieldSpec(conf.Child("customerManagedPolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "customerManagedPolicies {\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> List<System.String>? AwsManagedPolicies
        // GraphQL -> awsManagedPolicies: [String!]! (scalar)
        if (ec.Includes("awsManagedPolicies",true))
        {
            if(this.AwsManagedPolicies == null) {

                this.AwsManagedPolicies = new List<System.String>();

            } else {


            }
        }
        else if (this.AwsManagedPolicies != null && ec.Excludes("awsManagedPolicies",true))
        {
            this.AwsManagedPolicies = null;
        }
        //      C# -> List<CustomerManagedPolicy>? CustomerManagedPolicies
        // GraphQL -> customerManagedPolicies: [CustomerManagedPolicy!]! (type)
        if (ec.Includes("customerManagedPolicies",false))
        {
            if(this.CustomerManagedPolicies == null) {

                this.CustomerManagedPolicies = new List<CustomerManagedPolicy>();
                this.CustomerManagedPolicies.ApplyExploratoryFieldSpec(ec.NewChild("customerManagedPolicies"));

            } else {

                this.CustomerManagedPolicies.ApplyExploratoryFieldSpec(ec.NewChild("customerManagedPolicies"));

            }
        }
        else if (this.CustomerManagedPolicies != null && ec.Excludes("customerManagedPolicies",false))
        {
            this.CustomerManagedPolicies = null;
        }
    }


    #endregion

    } // class PermissionPolicy
    
    #endregion

    public static class ListPermissionPolicyExtensions
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
            this List<PermissionPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PermissionPolicy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PermissionPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PermissionPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types