// PolicyViolationsByResource.cs
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
    #region PolicyViolationsByResource
    public class PolicyViolationsByResource: BaseType
    {
        #region members

        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        [JsonProperty("resourceType")]
        public PolicyResourceType? ResourceType { get; set; }

        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        [JsonProperty("severity")]
        public Severity? Severity { get; set; }

        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        [JsonProperty("activeViolationsCount")]
        public System.Int32? ActiveViolationsCount { get; set; }

        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        [JsonProperty("criticalSeverityViolationCount")]
        public System.Int32? CriticalSeverityViolationCount { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        [JsonProperty("resourceMetadata")]
        public ResourceMetadata? ResourceMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyViolationsByResource";
    }

    public PolicyViolationsByResource Set(
        PolicyResourceType? ResourceType = null,
        Severity? Severity = null,
        System.Int32? ActiveViolationsCount = null,
        System.Int32? CriticalSeverityViolationCount = null,
        System.String? ResourceId = null,
        ResourceMetadata? ResourceMetadata = null
    ) 
    {
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ActiveViolationsCount != null ) {
            this.ActiveViolationsCount = ActiveViolationsCount;
        }
        if ( CriticalSeverityViolationCount != null ) {
            this.CriticalSeverityViolationCount = CriticalSeverityViolationCount;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceMetadata != null ) {
            this.ResourceMetadata = ResourceMetadata;
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
        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        if (this.ActiveViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeViolationsCount\n" ;
            } else {
                s += ind + "activeViolationsCount\n" ;
            }
        }
        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        if (this.CriticalSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "criticalSeverityViolationCount\n" ;
            } else {
                s += ind + "criticalSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        if (this.ResourceMetadata != null) {
            var fspec = this.ResourceMetadata.AsFieldSpec(conf.Child("resourceMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new PolicyResourceType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new Severity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        if (ec.Includes("activeViolationsCount",true))
        {
            if(this.ActiveViolationsCount == null) {

                this.ActiveViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveViolationsCount != null && ec.Excludes("activeViolationsCount",true))
        {
            this.ActiveViolationsCount = null;
        }
        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        if (ec.Includes("criticalSeverityViolationCount",true))
        {
            if(this.CriticalSeverityViolationCount == null) {

                this.CriticalSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.CriticalSeverityViolationCount != null && ec.Excludes("criticalSeverityViolationCount",true))
        {
            this.CriticalSeverityViolationCount = null;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        if (ec.Includes("resourceMetadata",false))
        {
            if(this.ResourceMetadata == null) {

                this.ResourceMetadata = new ResourceMetadata();
                this.ResourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("resourceMetadata"));

            } else {

                this.ResourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("resourceMetadata"));

            }
        }
        else if (this.ResourceMetadata != null && ec.Excludes("resourceMetadata",false))
        {
            this.ResourceMetadata = null;
        }
    }


    #endregion

    } // class PolicyViolationsByResource
    
    #endregion

    public static class ListPolicyViolationsByResourceExtensions
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
            this List<PolicyViolationsByResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyViolationsByResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyViolationsByResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyViolationsByResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyViolationsByResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types