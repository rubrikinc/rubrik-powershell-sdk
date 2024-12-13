// AuditSubscription.cs
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
    #region AuditSubscription
    public class AuditSubscription: BaseType
    {
        #region members

        //      C# -> List<AuditType>? AuditTypes
        // GraphQL -> auditTypes: [AuditType!]! (enum)
        [JsonProperty("auditTypes")]
        public List<AuditType>? AuditTypes { get; set; }

        //      C# -> List<AuditObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [AuditObjectType!]! (enum)
        [JsonProperty("objectTypes")]
        public List<AuditObjectType>? ObjectTypes { get; set; }

        //      C# -> List<AuditSeverity>? Severities
        // GraphQL -> severities: [AuditSeverity!]! (enum)
        [JsonProperty("severities")]
        public List<AuditSeverity>? Severities { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllAudits")]
        public System.Boolean? IsSubscribedToAllAudits { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllObjectTypes
        // GraphQL -> isSubscribedToAllObjectTypes: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllObjectTypes")]
        public System.Boolean? IsSubscribedToAllObjectTypes { get; set; }

        //      C# -> TemplateInfo? TemplateInfo
        // GraphQL -> templateInfo: TemplateInfo (type)
        [JsonProperty("templateInfo")]
        public TemplateInfo? TemplateInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuditSubscription";
    }

    public AuditSubscription Set(
        List<AuditType>? AuditTypes = null,
        List<AuditObjectType>? ObjectTypes = null,
        List<AuditSeverity>? Severities = null,
        System.Boolean? IsSubscribedToAllAudits = null,
        System.Boolean? IsSubscribedToAllObjectTypes = null,
        TemplateInfo? TemplateInfo = null
    ) 
    {
        if ( AuditTypes != null ) {
            this.AuditTypes = AuditTypes;
        }
        if ( ObjectTypes != null ) {
            this.ObjectTypes = ObjectTypes;
        }
        if ( Severities != null ) {
            this.Severities = Severities;
        }
        if ( IsSubscribedToAllAudits != null ) {
            this.IsSubscribedToAllAudits = IsSubscribedToAllAudits;
        }
        if ( IsSubscribedToAllObjectTypes != null ) {
            this.IsSubscribedToAllObjectTypes = IsSubscribedToAllObjectTypes;
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
        //      C# -> List<AuditType>? AuditTypes
        // GraphQL -> auditTypes: [AuditType!]! (enum)
        if (this.AuditTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "auditTypes\n" ;
            } else {
                s += ind + "auditTypes\n" ;
            }
        }
        //      C# -> List<AuditObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [AuditObjectType!]! (enum)
        if (this.ObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectTypes\n" ;
            } else {
                s += ind + "objectTypes\n" ;
            }
        }
        //      C# -> List<AuditSeverity>? Severities
        // GraphQL -> severities: [AuditSeverity!]! (enum)
        if (this.Severities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severities\n" ;
            } else {
                s += ind + "severities\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (this.IsSubscribedToAllAudits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribedToAllAudits\n" ;
            } else {
                s += ind + "isSubscribedToAllAudits\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubscribedToAllObjectTypes
        // GraphQL -> isSubscribedToAllObjectTypes: Boolean! (scalar)
        if (this.IsSubscribedToAllObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribedToAllObjectTypes\n" ;
            } else {
                s += ind + "isSubscribedToAllObjectTypes\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AuditType>? AuditTypes
        // GraphQL -> auditTypes: [AuditType!]! (enum)
        if (ec.Includes("auditTypes",true))
        {
            if(this.AuditTypes == null) {

                this.AuditTypes = new List<AuditType>();

            } else {


            }
        }
        else if (this.AuditTypes != null && ec.Excludes("auditTypes",true))
        {
            this.AuditTypes = null;
        }
        //      C# -> List<AuditObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [AuditObjectType!]! (enum)
        if (ec.Includes("objectTypes",true))
        {
            if(this.ObjectTypes == null) {

                this.ObjectTypes = new List<AuditObjectType>();

            } else {


            }
        }
        else if (this.ObjectTypes != null && ec.Excludes("objectTypes",true))
        {
            this.ObjectTypes = null;
        }
        //      C# -> List<AuditSeverity>? Severities
        // GraphQL -> severities: [AuditSeverity!]! (enum)
        if (ec.Includes("severities",true))
        {
            if(this.Severities == null) {

                this.Severities = new List<AuditSeverity>();

            } else {


            }
        }
        else if (this.Severities != null && ec.Excludes("severities",true))
        {
            this.Severities = null;
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (ec.Includes("isSubscribedToAllAudits",true))
        {
            if(this.IsSubscribedToAllAudits == null) {

                this.IsSubscribedToAllAudits = true;

            } else {


            }
        }
        else if (this.IsSubscribedToAllAudits != null && ec.Excludes("isSubscribedToAllAudits",true))
        {
            this.IsSubscribedToAllAudits = null;
        }
        //      C# -> System.Boolean? IsSubscribedToAllObjectTypes
        // GraphQL -> isSubscribedToAllObjectTypes: Boolean! (scalar)
        if (ec.Includes("isSubscribedToAllObjectTypes",true))
        {
            if(this.IsSubscribedToAllObjectTypes == null) {

                this.IsSubscribedToAllObjectTypes = true;

            } else {


            }
        }
        else if (this.IsSubscribedToAllObjectTypes != null && ec.Excludes("isSubscribedToAllObjectTypes",true))
        {
            this.IsSubscribedToAllObjectTypes = null;
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

    } // class AuditSubscription
    
    #endregion

    public static class ListAuditSubscriptionExtensions
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
            this List<AuditSubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AuditSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AuditSubscription> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuditSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AuditSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types