// HealthPolicyStatus.cs
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
    #region HealthPolicyStatus
    public class HealthPolicyStatus: BaseType
    {
        #region members

        //      C# -> HardwareHealthPolicyName? PolicyName
        // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
        [JsonProperty("policyName")]
        public HardwareHealthPolicyName? PolicyName { get; set; }

        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        [JsonProperty("isHealthy")]
        public System.Boolean? IsHealthy { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HealthPolicyStatus";
    }

    public HealthPolicyStatus Set(
        HardwareHealthPolicyName? PolicyName = null,
        System.Boolean? IsHealthy = null,
        System.String? Message = null
    ) 
    {
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( IsHealthy != null ) {
            this.IsHealthy = IsHealthy;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> HardwareHealthPolicyName? PolicyName
        // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
        if (this.PolicyName != null) {
            s += ind + "policyName\n" ;
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy != null) {
            s += ind + "isHealthy\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HardwareHealthPolicyName? PolicyName
        // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
        if (this.PolicyName == null && Exploration.Includes(parent + ".policyName", true))
        {
            this.PolicyName = new HardwareHealthPolicyName();
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy == null && Exploration.Includes(parent + ".isHealthy", true))
        {
            this.IsHealthy = true;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class HealthPolicyStatus
    
    #endregion

    public static class ListHealthPolicyStatusExtensions
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
            this List<HealthPolicyStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HealthPolicyStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HealthPolicyStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types