// CustomTprPolicy.cs
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
    #region CustomTprPolicy
    public class CustomTprPolicy: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Int32? NumberOfActions
        // GraphQL -> numberOfActions: Int! (scalar)
        [JsonProperty("numberOfActions")]
        public System.Int32? NumberOfActions { get; set; }

        //      C# -> System.Int32? NumberOfObjectTypes
        // GraphQL -> numberOfObjectTypes: Int! (scalar)
        [JsonProperty("numberOfObjectTypes")]
        public System.Int32? NumberOfObjectTypes { get; set; }

        //      C# -> System.Int32? NumberOfProtectableObjects
        // GraphQL -> numberOfProtectableObjects: Int! (scalar)
        [JsonProperty("numberOfProtectableObjects")]
        public System.Int32? NumberOfProtectableObjects { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomTprPolicy";
    }

    public CustomTprPolicy Set(
        System.String? Description = null,
        System.Int32? NumberOfActions = null,
        System.Int32? NumberOfObjectTypes = null,
        System.Int32? NumberOfProtectableObjects = null,
        System.String? OrgId = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( NumberOfActions != null ) {
            this.NumberOfActions = NumberOfActions;
        }
        if ( NumberOfObjectTypes != null ) {
            this.NumberOfObjectTypes = NumberOfObjectTypes;
        }
        if ( NumberOfProtectableObjects != null ) {
            this.NumberOfProtectableObjects = NumberOfProtectableObjects;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.Int32? NumberOfActions
        // GraphQL -> numberOfActions: Int! (scalar)
        if (this.NumberOfActions != null) {
            s += ind + "numberOfActions\n" ;
        }
        //      C# -> System.Int32? NumberOfObjectTypes
        // GraphQL -> numberOfObjectTypes: Int! (scalar)
        if (this.NumberOfObjectTypes != null) {
            s += ind + "numberOfObjectTypes\n" ;
        }
        //      C# -> System.Int32? NumberOfProtectableObjects
        // GraphQL -> numberOfProtectableObjects: Int! (scalar)
        if (this.NumberOfProtectableObjects != null) {
            s += ind + "numberOfProtectableObjects\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            s += ind + "policyName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.Int32? NumberOfActions
        // GraphQL -> numberOfActions: Int! (scalar)
        if (this.NumberOfActions == null && Exploration.Includes(parent + ".numberOfActions", true))
        {
            this.NumberOfActions = Int32.MinValue;
        }
        //      C# -> System.Int32? NumberOfObjectTypes
        // GraphQL -> numberOfObjectTypes: Int! (scalar)
        if (this.NumberOfObjectTypes == null && Exploration.Includes(parent + ".numberOfObjectTypes", true))
        {
            this.NumberOfObjectTypes = Int32.MinValue;
        }
        //      C# -> System.Int32? NumberOfProtectableObjects
        // GraphQL -> numberOfProtectableObjects: Int! (scalar)
        if (this.NumberOfProtectableObjects == null && Exploration.Includes(parent + ".numberOfProtectableObjects", true))
        {
            this.NumberOfProtectableObjects = Int32.MinValue;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = "FETCH";
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName == null && Exploration.Includes(parent + ".policyName", true))
        {
            this.PolicyName = "FETCH";
        }
    }


    #endregion

    } // class CustomTprPolicy
    
    #endregion

    public static class ListCustomTprPolicyExtensions
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
            this List<CustomTprPolicy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CustomTprPolicy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomTprPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types