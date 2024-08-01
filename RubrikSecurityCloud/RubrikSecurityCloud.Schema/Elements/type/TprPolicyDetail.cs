// TprPolicyDetail.cs
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
    #region TprPolicyDetail
    public class TprPolicyDetail: BaseType
    {
        #region members

        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        [JsonProperty("policyScope")]
        public TprPolicyScope? PolicyScope { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        [JsonProperty("createdBy")]
        public UserSummary? CreatedBy { get; set; }

        //      C# -> List<ServiceAccountClient>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [ServiceAccountClient!]! (type)
        [JsonProperty("exemptServiceAccounts")]
        public List<ServiceAccountClient>? ExemptServiceAccounts { get; set; }

        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        [JsonProperty("policyRules")]
        public List<TprPolicyRule>? PolicyRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprPolicyDetail";
    }

    public TprPolicyDetail Set(
        TprPolicyScope? PolicyScope = null,
        DateTime? CreatedAt = null,
        System.String? Description = null,
        System.String? Name = null,
        System.String? PolicyId = null,
        UserSummary? CreatedBy = null,
        List<ServiceAccountClient>? ExemptServiceAccounts = null,
        List<TprPolicyRule>? PolicyRules = null
    ) 
    {
        if ( PolicyScope != null ) {
            this.PolicyScope = PolicyScope;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( ExemptServiceAccounts != null ) {
            this.ExemptServiceAccounts = ExemptServiceAccounts;
        }
        if ( PolicyRules != null ) {
            this.PolicyRules = PolicyRules;
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
        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        if (this.PolicyScope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyScope\n" ;
            } else {
                s += ind + "policyScope\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        if (this.CreatedBy != null) {
            var fspec = this.CreatedBy.AsFieldSpec(conf.Child("createdBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "createdBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ServiceAccountClient>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [ServiceAccountClient!]! (type)
        if (this.ExemptServiceAccounts != null) {
            var fspec = this.ExemptServiceAccounts.AsFieldSpec(conf.Child("exemptServiceAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exemptServiceAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        if (this.PolicyRules != null) {
            var fspec = this.PolicyRules.AsFieldSpec(conf.Child("policyRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyRules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        if (ec.Includes("policyScope",true))
        {
            if(this.PolicyScope == null) {

                this.PolicyScope = new TprPolicyScope();

            } else {


            }
        }
        else if (this.PolicyScope != null && ec.Excludes("policyScope",true))
        {
            this.PolicyScope = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        if (ec.Includes("createdBy",false))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = new UserSummary();
                this.CreatedBy.ApplyExploratoryFieldSpec(ec.NewChild("createdBy"));

            } else {

                this.CreatedBy.ApplyExploratoryFieldSpec(ec.NewChild("createdBy"));

            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",false))
        {
            this.CreatedBy = null;
        }
        //      C# -> List<ServiceAccountClient>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [ServiceAccountClient!]! (type)
        if (ec.Includes("exemptServiceAccounts",false))
        {
            if(this.ExemptServiceAccounts == null) {

                this.ExemptServiceAccounts = new List<ServiceAccountClient>();
                this.ExemptServiceAccounts.ApplyExploratoryFieldSpec(ec.NewChild("exemptServiceAccounts"));

            } else {

                this.ExemptServiceAccounts.ApplyExploratoryFieldSpec(ec.NewChild("exemptServiceAccounts"));

            }
        }
        else if (this.ExemptServiceAccounts != null && ec.Excludes("exemptServiceAccounts",false))
        {
            this.ExemptServiceAccounts = null;
        }
        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        if (ec.Includes("policyRules",false))
        {
            if(this.PolicyRules == null) {

                this.PolicyRules = new List<TprPolicyRule>();
                this.PolicyRules.ApplyExploratoryFieldSpec(ec.NewChild("policyRules"));

            } else {

                this.PolicyRules.ApplyExploratoryFieldSpec(ec.NewChild("policyRules"));

            }
        }
        else if (this.PolicyRules != null && ec.Excludes("policyRules",false))
        {
            this.PolicyRules = null;
        }
    }


    #endregion

    } // class TprPolicyDetail
    
    #endregion

    public static class ListTprPolicyDetailExtensions
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
            this List<TprPolicyDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprPolicyDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprPolicyDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprPolicyDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprPolicyDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types