// CloudAccountsTprReqChangesTemplate.cs
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
    #region CloudAccountsTprReqChangesTemplate
 
    public class CloudAccountsTprReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        [JsonProperty("cloudVendor")]
        public CloudVendor? CloudVendor { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [String!]! (scalar)
        [JsonProperty("cloudAccountIds")]
        public List<System.String>? CloudAccountIds { get; set; }

        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        [JsonProperty("requestedAction")]
        public System.String? RequestedAction { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<CloudAccountDetail>? CloudAccountsDetails
        // GraphQL -> cloudAccountsDetails: [CloudAccountDetail!]! (type)
        [JsonProperty("cloudAccountsDetails")]
        public List<CloudAccountDetail>? CloudAccountsDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountsTprReqChangesTemplate";
    }

    public CloudAccountsTprReqChangesTemplate Set(
        CloudVendor? CloudVendor = null,
        List<CloudAccountFeature>? Features = null,
        List<System.String>? CloudAccountIds = null,
        System.String? RequestedAction = null,
        System.String? TemplateName = null,
        List<CloudAccountDetail>? CloudAccountsDetails = null
    ) 
    {
        if ( CloudVendor != null ) {
            this.CloudVendor = CloudVendor;
        }
        if ( Features != null ) {
            this.Features = Features;
        }
        if ( CloudAccountIds != null ) {
            this.CloudAccountIds = CloudAccountIds;
        }
        if ( RequestedAction != null ) {
            this.RequestedAction = RequestedAction;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( CloudAccountsDetails != null ) {
            this.CloudAccountsDetails = CloudAccountsDetails;
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
        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        if (this.CloudVendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudVendor\n" ;
            } else {
                s += ind + "cloudVendor\n" ;
            }
        }
        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        if (this.Features != null) {
            if (conf.Flat) {
                s += conf.Prefix + "features\n" ;
            } else {
                s += ind + "features\n" ;
            }
        }
        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [String!]! (scalar)
        if (this.CloudAccountIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountIds\n" ;
            } else {
                s += ind + "cloudAccountIds\n" ;
            }
        }
        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        if (this.RequestedAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedAction\n" ;
            } else {
                s += ind + "requestedAction\n" ;
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
        //      C# -> List<CloudAccountDetail>? CloudAccountsDetails
        // GraphQL -> cloudAccountsDetails: [CloudAccountDetail!]! (type)
        if (this.CloudAccountsDetails != null) {
            var fspec = this.CloudAccountsDetails.AsFieldSpec(conf.Child("cloudAccountsDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccountsDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        if (ec.Includes("cloudVendor",true))
        {
            if(this.CloudVendor == null) {

                this.CloudVendor = new CloudVendor();

            } else {


            }
        }
        else if (this.CloudVendor != null && ec.Excludes("cloudVendor",true))
        {
            this.CloudVendor = null;
        }
        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        if (ec.Includes("features",true))
        {
            if(this.Features == null) {

                this.Features = new List<CloudAccountFeature>();

            } else {


            }
        }
        else if (this.Features != null && ec.Excludes("features",true))
        {
            this.Features = null;
        }
        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [String!]! (scalar)
        if (ec.Includes("cloudAccountIds",true))
        {
            if(this.CloudAccountIds == null) {

                this.CloudAccountIds = new List<System.String>();

            } else {


            }
        }
        else if (this.CloudAccountIds != null && ec.Excludes("cloudAccountIds",true))
        {
            this.CloudAccountIds = null;
        }
        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        if (ec.Includes("requestedAction",true))
        {
            if(this.RequestedAction == null) {

                this.RequestedAction = "FETCH";

            } else {


            }
        }
        else if (this.RequestedAction != null && ec.Excludes("requestedAction",true))
        {
            this.RequestedAction = null;
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
        //      C# -> List<CloudAccountDetail>? CloudAccountsDetails
        // GraphQL -> cloudAccountsDetails: [CloudAccountDetail!]! (type)
        if (ec.Includes("cloudAccountsDetails",false))
        {
            if(this.CloudAccountsDetails == null) {

                this.CloudAccountsDetails = new List<CloudAccountDetail>();
                this.CloudAccountsDetails.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountsDetails"));

            } else {

                this.CloudAccountsDetails.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountsDetails"));

            }
        }
        else if (this.CloudAccountsDetails != null && ec.Excludes("cloudAccountsDetails",false))
        {
            this.CloudAccountsDetails = null;
        }
    }


    #endregion

    } // class CloudAccountsTprReqChangesTemplate
    
    #endregion

    public static class ListCloudAccountsTprReqChangesTemplateExtensions
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
            this List<CloudAccountsTprReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountsTprReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountsTprReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountsTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountsTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types