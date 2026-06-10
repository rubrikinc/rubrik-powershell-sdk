// AzureAdAccessReviewScheduleDefinition.cs
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
    #region AzureAdAccessReviewScheduleDefinition
    public class AzureAdAccessReviewScheduleDefinition: BaseType
    {
        #region members

        //      C# -> AzureAdAccessReviewFallbackAction? FallbackAction
        // GraphQL -> fallbackAction: AzureAdAccessReviewFallbackAction! (enum)
        [JsonProperty("fallbackAction")]
        public AzureAdAccessReviewFallbackAction? FallbackAction { get; set; }

        //      C# -> AzureAdAccessReviewRecurrence? Recurrence
        // GraphQL -> recurrence: AzureAdAccessReviewRecurrence! (enum)
        [JsonProperty("recurrence")]
        public AzureAdAccessReviewRecurrence? Recurrence { get; set; }

        //      C# -> AzureAdObjectType? ResourceType
        // GraphQL -> resourceType: AzureAdObjectType! (enum)
        [JsonProperty("resourceType")]
        public AzureAdObjectType? ResourceType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: UUID (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        [JsonProperty("resourceName")]
        public System.String? ResourceName { get; set; }

        //      C# -> List<AzureAdAccessReviewReviewer>? Reviewers
        // GraphQL -> reviewers: [AzureAdAccessReviewReviewer!]! (type)
        [JsonProperty("reviewers")]
        public List<AzureAdAccessReviewReviewer>? Reviewers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdAccessReviewScheduleDefinition";
    }

    public AzureAdAccessReviewScheduleDefinition Set(
        AzureAdAccessReviewFallbackAction? FallbackAction = null,
        AzureAdAccessReviewRecurrence? Recurrence = null,
        AzureAdObjectType? ResourceType = null,
        System.String? DisplayName = null,
        DateTime? EndDate = null,
        System.String? ResourceId = null,
        System.String? ResourceName = null,
        List<AzureAdAccessReviewReviewer>? Reviewers = null
    ) 
    {
        if ( FallbackAction != null ) {
            this.FallbackAction = FallbackAction;
        }
        if ( Recurrence != null ) {
            this.Recurrence = Recurrence;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceName != null ) {
            this.ResourceName = ResourceName;
        }
        if ( Reviewers != null ) {
            this.Reviewers = Reviewers;
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
        //      C# -> AzureAdAccessReviewFallbackAction? FallbackAction
        // GraphQL -> fallbackAction: AzureAdAccessReviewFallbackAction! (enum)
        if (this.FallbackAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fallbackAction\n" ;
            } else {
                s += ind + "fallbackAction\n" ;
            }
        }
        //      C# -> AzureAdAccessReviewRecurrence? Recurrence
        // GraphQL -> recurrence: AzureAdAccessReviewRecurrence! (enum)
        if (this.Recurrence != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recurrence\n" ;
            } else {
                s += ind + "recurrence\n" ;
            }
        }
        //      C# -> AzureAdObjectType? ResourceType
        // GraphQL -> resourceType: AzureAdObjectType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDate\n" ;
            } else {
                s += ind + "endDate\n" ;
            }
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: UUID (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceName\n" ;
            } else {
                s += ind + "resourceName\n" ;
            }
        }
        //      C# -> List<AzureAdAccessReviewReviewer>? Reviewers
        // GraphQL -> reviewers: [AzureAdAccessReviewReviewer!]! (type)
        if (this.Reviewers != null) {
            var fspec = this.Reviewers.AsFieldSpec(conf.Child("reviewers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reviewers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdAccessReviewFallbackAction? FallbackAction
        // GraphQL -> fallbackAction: AzureAdAccessReviewFallbackAction! (enum)
        if (ec.Includes("fallbackAction",true))
        {
            if(this.FallbackAction == null) {

                this.FallbackAction = new AzureAdAccessReviewFallbackAction();

            } else {


            }
        }
        else if (this.FallbackAction != null && ec.Excludes("fallbackAction",true))
        {
            this.FallbackAction = null;
        }
        //      C# -> AzureAdAccessReviewRecurrence? Recurrence
        // GraphQL -> recurrence: AzureAdAccessReviewRecurrence! (enum)
        if (ec.Includes("recurrence",true))
        {
            if(this.Recurrence == null) {

                this.Recurrence = new AzureAdAccessReviewRecurrence();

            } else {


            }
        }
        else if (this.Recurrence != null && ec.Excludes("recurrence",true))
        {
            this.Recurrence = null;
        }
        //      C# -> AzureAdObjectType? ResourceType
        // GraphQL -> resourceType: AzureAdObjectType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new AzureAdObjectType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (ec.Includes("endDate",true))
        {
            if(this.EndDate == null) {

                this.EndDate = new DateTime();

            } else {


            }
        }
        else if (this.EndDate != null && ec.Excludes("endDate",true))
        {
            this.EndDate = null;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: UUID (scalar)
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
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (ec.Includes("resourceName",true))
        {
            if(this.ResourceName == null) {

                this.ResourceName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceName != null && ec.Excludes("resourceName",true))
        {
            this.ResourceName = null;
        }
        //      C# -> List<AzureAdAccessReviewReviewer>? Reviewers
        // GraphQL -> reviewers: [AzureAdAccessReviewReviewer!]! (type)
        if (ec.Includes("reviewers",false))
        {
            if(this.Reviewers == null) {

                this.Reviewers = new List<AzureAdAccessReviewReviewer>();
                this.Reviewers.ApplyExploratoryFieldSpec(ec.NewChild("reviewers"));

            } else {

                this.Reviewers.ApplyExploratoryFieldSpec(ec.NewChild("reviewers"));

            }
        }
        else if (this.Reviewers != null && ec.Excludes("reviewers",false))
        {
            this.Reviewers = null;
        }
    }


    #endregion

    } // class AzureAdAccessReviewScheduleDefinition
    
    #endregion

    public static class ListAzureAdAccessReviewScheduleDefinitionExtensions
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
            this List<AzureAdAccessReviewScheduleDefinition> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdAccessReviewScheduleDefinition> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdAccessReviewScheduleDefinition> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdAccessReviewScheduleDefinition());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdAccessReviewScheduleDefinition> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types