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

        //      C# -> List<TprRule>? Actions
        // GraphQL -> actions: [TprRule!]! (enum)
        [JsonProperty("actions")]
        public List<TprRule>? Actions { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

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

        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        [JsonProperty("quorumRequirement")]
        public System.Int32? QuorumRequirement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomTprPolicy";
    }

    public CustomTprPolicy Set(
        List<TprRule>? Actions = null,
        System.String? Description = null,
        System.Int32? NumberOfObjectTypes = null,
        System.Int32? NumberOfProtectableObjects = null,
        System.String? OrgId = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        System.Int32? QuorumRequirement = null
    ) 
    {
        if ( Actions != null ) {
            this.Actions = Actions;
        }
        if ( Description != null ) {
            this.Description = Description;
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
        if ( QuorumRequirement != null ) {
            this.QuorumRequirement = QuorumRequirement;
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
        //      C# -> List<TprRule>? Actions
        // GraphQL -> actions: [TprRule!]! (enum)
        if (this.Actions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actions\n" ;
            } else {
                s += ind + "actions\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Int32? NumberOfObjectTypes
        // GraphQL -> numberOfObjectTypes: Int! (scalar)
        if (this.NumberOfObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numberOfObjectTypes\n" ;
            } else {
                s += ind + "numberOfObjectTypes\n" ;
            }
        }
        //      C# -> System.Int32? NumberOfProtectableObjects
        // GraphQL -> numberOfProtectableObjects: Int! (scalar)
        if (this.NumberOfProtectableObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numberOfProtectableObjects\n" ;
            } else {
                s += ind + "numberOfProtectableObjects\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
            }
        }
        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        if (this.QuorumRequirement != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quorumRequirement\n" ;
            } else {
                s += ind + "quorumRequirement\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<TprRule>? Actions
        // GraphQL -> actions: [TprRule!]! (enum)
        if (ec.Includes("actions",true))
        {
            if(this.Actions == null) {

                this.Actions = new List<TprRule>();

            } else {


            }
        }
        else if (this.Actions != null && ec.Excludes("actions",true))
        {
            this.Actions = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Int32? NumberOfObjectTypes
        // GraphQL -> numberOfObjectTypes: Int! (scalar)
        if (ec.Includes("numberOfObjectTypes",true))
        {
            if(this.NumberOfObjectTypes == null) {

                this.NumberOfObjectTypes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumberOfObjectTypes != null && ec.Excludes("numberOfObjectTypes",true))
        {
            this.NumberOfObjectTypes = null;
        }
        //      C# -> System.Int32? NumberOfProtectableObjects
        // GraphQL -> numberOfProtectableObjects: Int! (scalar)
        if (ec.Includes("numberOfProtectableObjects",true))
        {
            if(this.NumberOfProtectableObjects == null) {

                this.NumberOfProtectableObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumberOfProtectableObjects != null && ec.Excludes("numberOfProtectableObjects",true))
        {
            this.NumberOfProtectableObjects = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
        }
        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        if (ec.Includes("quorumRequirement",true))
        {
            if(this.QuorumRequirement == null) {

                this.QuorumRequirement = Int32.MinValue;

            } else {


            }
        }
        else if (this.QuorumRequirement != null && ec.Excludes("quorumRequirement",true))
        {
            this.QuorumRequirement = null;
        }
    }


    #endregion

    } // class CustomTprPolicy
    
    #endregion

    public static class ListCustomTprPolicyExtensions
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
            this List<CustomTprPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomTprPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomTprPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomTprPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomTprPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types