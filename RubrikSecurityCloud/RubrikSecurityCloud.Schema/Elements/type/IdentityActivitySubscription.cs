// IdentityActivitySubscription.cs
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
    #region IdentityActivitySubscription
    public class IdentityActivitySubscription: BaseType
    {
        #region members

        //      C# -> List<LambdaEventActionType>? ActionTypes
        // GraphQL -> actionTypes: [LambdaEventActionType!]! (enum)
        [JsonProperty("actionTypes")]
        public List<LambdaEventActionType>? ActionTypes { get; set; }

        //      C# -> List<EventProvider>? ActivityProviders
        // GraphQL -> activityProviders: [EventProvider!]! (enum)
        [JsonProperty("activityProviders")]
        public List<EventProvider>? ActivityProviders { get; set; }

        //      C# -> TemplateInfo? TemplateInfo
        // GraphQL -> templateInfo: TemplateInfo (type)
        [JsonProperty("templateInfo")]
        public TemplateInfo? TemplateInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityActivitySubscription";
    }

    public IdentityActivitySubscription Set(
        List<LambdaEventActionType>? ActionTypes = null,
        List<EventProvider>? ActivityProviders = null,
        TemplateInfo? TemplateInfo = null
    ) 
    {
        if ( ActionTypes != null ) {
            this.ActionTypes = ActionTypes;
        }
        if ( ActivityProviders != null ) {
            this.ActivityProviders = ActivityProviders;
        }
        if ( TemplateInfo != null ) {
            this.TemplateInfo = TemplateInfo;
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
        //      C# -> List<LambdaEventActionType>? ActionTypes
        // GraphQL -> actionTypes: [LambdaEventActionType!]! (enum)
        if (this.ActionTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionTypes\n" ;
            } else {
                s += ind + "actionTypes\n" ;
            }
        }
        //      C# -> List<EventProvider>? ActivityProviders
        // GraphQL -> activityProviders: [EventProvider!]! (enum)
        if (this.ActivityProviders != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityProviders\n" ;
            } else {
                s += ind + "activityProviders\n" ;
            }
        }
        //      C# -> TemplateInfo? TemplateInfo
        // GraphQL -> templateInfo: TemplateInfo (type)
        if (this.TemplateInfo != null) {
            var fspec = this.TemplateInfo.AsFieldSpec(conf.Child("templateInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "templateInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<LambdaEventActionType>? ActionTypes
        // GraphQL -> actionTypes: [LambdaEventActionType!]! (enum)
        if (ec.Includes("actionTypes",true))
        {
            if(this.ActionTypes == null) {

                this.ActionTypes = new List<LambdaEventActionType>();

            } else {


            }
        }
        else if (this.ActionTypes != null && ec.Excludes("actionTypes",true))
        {
            this.ActionTypes = null;
        }
        //      C# -> List<EventProvider>? ActivityProviders
        // GraphQL -> activityProviders: [EventProvider!]! (enum)
        if (ec.Includes("activityProviders",true))
        {
            if(this.ActivityProviders == null) {

                this.ActivityProviders = new List<EventProvider>();

            } else {


            }
        }
        else if (this.ActivityProviders != null && ec.Excludes("activityProviders",true))
        {
            this.ActivityProviders = null;
        }
        //      C# -> TemplateInfo? TemplateInfo
        // GraphQL -> templateInfo: TemplateInfo (type)
        if (ec.Includes("templateInfo",false))
        {
            if(this.TemplateInfo == null) {

                this.TemplateInfo = new TemplateInfo();
                this.TemplateInfo.ApplyExploratoryFieldSpec(ec.NewChild("templateInfo"));

            } else {

                this.TemplateInfo.ApplyExploratoryFieldSpec(ec.NewChild("templateInfo"));

            }
        }
        else if (this.TemplateInfo != null && ec.Excludes("templateInfo",false))
        {
            this.TemplateInfo = null;
        }
    }


    #endregion

    } // class IdentityActivitySubscription
    
    #endregion

    public static class ListIdentityActivitySubscriptionExtensions
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
            this List<IdentityActivitySubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityActivitySubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityActivitySubscription> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityActivitySubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityActivitySubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types