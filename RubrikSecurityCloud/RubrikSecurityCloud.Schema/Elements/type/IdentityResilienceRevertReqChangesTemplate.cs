// IdentityResilienceRevertReqChangesTemplate.cs
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
    #region IdentityResilienceRevertReqChangesTemplate
 
    public class IdentityResilienceRevertReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? DomainControllerFid
        // GraphQL -> domainControllerFid: String! (scalar)
        [JsonProperty("domainControllerFid")]
        public System.String? DomainControllerFid { get; set; }

        //      C# -> System.String? RemediationType
        // GraphQL -> remediationType: String! (scalar)
        [JsonProperty("remediationType")]
        public System.String? RemediationType { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        [JsonProperty("targetIds")]
        public List<System.String>? TargetIds { get; set; }

        //      C# -> System.String? TargetType
        // GraphQL -> targetType: String! (scalar)
        [JsonProperty("targetType")]
        public System.String? TargetType { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityResilienceRevertReqChangesTemplate";
    }

    public IdentityResilienceRevertReqChangesTemplate Set(
        System.String? DomainControllerFid = null,
        System.String? RemediationType = null,
        System.String? ResourceId = null,
        List<System.String>? TargetIds = null,
        System.String? TargetType = null,
        System.String? TemplateName = null
    ) 
    {
        if ( DomainControllerFid != null ) {
            this.DomainControllerFid = DomainControllerFid;
        }
        if ( RemediationType != null ) {
            this.RemediationType = RemediationType;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( TargetIds != null ) {
            this.TargetIds = TargetIds;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
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
        //      C# -> System.String? DomainControllerFid
        // GraphQL -> domainControllerFid: String! (scalar)
        if (this.DomainControllerFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainControllerFid\n" ;
            } else {
                s += ind + "domainControllerFid\n" ;
            }
        }
        //      C# -> System.String? RemediationType
        // GraphQL -> remediationType: String! (scalar)
        if (this.RemediationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationType\n" ;
            } else {
                s += ind + "remediationType\n" ;
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
        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        if (this.TargetIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIds\n" ;
            } else {
                s += ind + "targetIds\n" ;
            }
        }
        //      C# -> System.String? TargetType
        // GraphQL -> targetType: String! (scalar)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DomainControllerFid
        // GraphQL -> domainControllerFid: String! (scalar)
        if (ec.Includes("domainControllerFid",true))
        {
            if(this.DomainControllerFid == null) {

                this.DomainControllerFid = "FETCH";

            } else {


            }
        }
        else if (this.DomainControllerFid != null && ec.Excludes("domainControllerFid",true))
        {
            this.DomainControllerFid = null;
        }
        //      C# -> System.String? RemediationType
        // GraphQL -> remediationType: String! (scalar)
        if (ec.Includes("remediationType",true))
        {
            if(this.RemediationType == null) {

                this.RemediationType = "FETCH";

            } else {


            }
        }
        else if (this.RemediationType != null && ec.Excludes("remediationType",true))
        {
            this.RemediationType = null;
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
        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        if (ec.Includes("targetIds",true))
        {
            if(this.TargetIds == null) {

                this.TargetIds = new List<System.String>();

            } else {


            }
        }
        else if (this.TargetIds != null && ec.Excludes("targetIds",true))
        {
            this.TargetIds = null;
        }
        //      C# -> System.String? TargetType
        // GraphQL -> targetType: String! (scalar)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = "FETCH";

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
    }


    #endregion

    } // class IdentityResilienceRevertReqChangesTemplate
    
    #endregion

    public static class ListIdentityResilienceRevertReqChangesTemplateExtensions
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
            this List<IdentityResilienceRevertReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityResilienceRevertReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityResilienceRevertReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityResilienceRevertReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityResilienceRevertReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types