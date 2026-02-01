// IntuneCompliancePolicyAction.cs
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
    #region IntuneCompliancePolicyAction
    public class IntuneCompliancePolicyAction: BaseType
    {
        #region members

        //      C# -> IntuneComplianceActionType? Type
        // GraphQL -> type: IntuneComplianceActionType! (enum)
        [JsonProperty("type")]
        public IntuneComplianceActionType? Type { get; set; }

        //      C# -> System.Int64? GracePeriodHours
        // GraphQL -> gracePeriodHours: Long! (scalar)
        [JsonProperty("gracePeriodHours")]
        public System.Int64? GracePeriodHours { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NotificationTemplateId
        // GraphQL -> notificationTemplateId: String (scalar)
        [JsonProperty("notificationTemplateId")]
        public System.String? NotificationTemplateId { get; set; }

        //      C# -> System.String? NotificationTemplateName
        // GraphQL -> notificationTemplateName: String (scalar)
        [JsonProperty("notificationTemplateName")]
        public System.String? NotificationTemplateName { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.Int64? RecipientCount
        // GraphQL -> recipientCount: Long (scalar)
        [JsonProperty("recipientCount")]
        public System.Int64? RecipientCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneCompliancePolicyAction";
    }

    public IntuneCompliancePolicyAction Set(
        IntuneComplianceActionType? Type = null,
        System.Int64? GracePeriodHours = null,
        System.String? Id = null,
        System.String? NotificationTemplateId = null,
        System.String? NotificationTemplateName = null,
        System.String? PolicyId = null,
        System.Int64? RecipientCount = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( GracePeriodHours != null ) {
            this.GracePeriodHours = GracePeriodHours;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( NotificationTemplateId != null ) {
            this.NotificationTemplateId = NotificationTemplateId;
        }
        if ( NotificationTemplateName != null ) {
            this.NotificationTemplateName = NotificationTemplateName;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( RecipientCount != null ) {
            this.RecipientCount = RecipientCount;
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
        //      C# -> IntuneComplianceActionType? Type
        // GraphQL -> type: IntuneComplianceActionType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.Int64? GracePeriodHours
        // GraphQL -> gracePeriodHours: Long! (scalar)
        if (this.GracePeriodHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gracePeriodHours\n" ;
            } else {
                s += ind + "gracePeriodHours\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? NotificationTemplateId
        // GraphQL -> notificationTemplateId: String (scalar)
        if (this.NotificationTemplateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notificationTemplateId\n" ;
            } else {
                s += ind + "notificationTemplateId\n" ;
            }
        }
        //      C# -> System.String? NotificationTemplateName
        // GraphQL -> notificationTemplateName: String (scalar)
        if (this.NotificationTemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notificationTemplateName\n" ;
            } else {
                s += ind + "notificationTemplateName\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.Int64? RecipientCount
        // GraphQL -> recipientCount: Long (scalar)
        if (this.RecipientCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recipientCount\n" ;
            } else {
                s += ind + "recipientCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneComplianceActionType? Type
        // GraphQL -> type: IntuneComplianceActionType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new IntuneComplianceActionType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.Int64? GracePeriodHours
        // GraphQL -> gracePeriodHours: Long! (scalar)
        if (ec.Includes("gracePeriodHours",true))
        {
            if(this.GracePeriodHours == null) {

                this.GracePeriodHours = new System.Int64();

            } else {


            }
        }
        else if (this.GracePeriodHours != null && ec.Excludes("gracePeriodHours",true))
        {
            this.GracePeriodHours = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? NotificationTemplateId
        // GraphQL -> notificationTemplateId: String (scalar)
        if (ec.Includes("notificationTemplateId",true))
        {
            if(this.NotificationTemplateId == null) {

                this.NotificationTemplateId = "FETCH";

            } else {


            }
        }
        else if (this.NotificationTemplateId != null && ec.Excludes("notificationTemplateId",true))
        {
            this.NotificationTemplateId = null;
        }
        //      C# -> System.String? NotificationTemplateName
        // GraphQL -> notificationTemplateName: String (scalar)
        if (ec.Includes("notificationTemplateName",true))
        {
            if(this.NotificationTemplateName == null) {

                this.NotificationTemplateName = "FETCH";

            } else {


            }
        }
        else if (this.NotificationTemplateName != null && ec.Excludes("notificationTemplateName",true))
        {
            this.NotificationTemplateName = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
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
        //      C# -> System.Int64? RecipientCount
        // GraphQL -> recipientCount: Long (scalar)
        if (ec.Includes("recipientCount",true))
        {
            if(this.RecipientCount == null) {

                this.RecipientCount = new System.Int64();

            } else {


            }
        }
        else if (this.RecipientCount != null && ec.Excludes("recipientCount",true))
        {
            this.RecipientCount = null;
        }
    }


    #endregion

    } // class IntuneCompliancePolicyAction
    
    #endregion

    public static class ListIntuneCompliancePolicyActionExtensions
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
            this List<IntuneCompliancePolicyAction> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneCompliancePolicyAction> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneCompliancePolicyAction> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneCompliancePolicyAction());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneCompliancePolicyAction> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types