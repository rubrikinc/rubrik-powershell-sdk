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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> System.String? PolicyDocumentJson
        // GraphQL -> policyDocumentJson: String! (scalar)
        if (this.PolicyDocumentJson != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyDocumentJson\n" ;
            } else {
                s += ind + "policyDocumentJson\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> System.String? PolicyDocumentJson
        // GraphQL -> policyDocumentJson: String! (scalar)
        if (ec.Includes("policyDocumentJson",true))
        {
            if(this.PolicyDocumentJson == null) {

                this.PolicyDocumentJson = "FETCH";

            } else {


            }
        }
        else if (this.PolicyDocumentJson != null && ec.Excludes("policyDocumentJson",true))
        {
            this.PolicyDocumentJson = null;
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
    }


    #endregion

    } // class CustomerManagedPolicy
    
    #endregion

    public static class ListCustomerManagedPolicyExtensions
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
            this List<CustomerManagedPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomerManagedPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomerManagedPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomerManagedPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomerManagedPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types