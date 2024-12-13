// EventSubscription.cs
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
    #region EventSubscription
    public class EventSubscription: BaseType
    {
        #region members

        //      C# -> List<EventType>? EventTypes
        // GraphQL -> eventTypes: [EventType!]! (enum)
        [JsonProperty("eventTypes")]
        public List<EventType>? EventTypes { get; set; }

        //      C# -> List<EventObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [EventObjectType!]! (enum)
        [JsonProperty("objectTypes")]
        public List<EventObjectType>? ObjectTypes { get; set; }

        //      C# -> List<EventSeverity>? Severities
        // GraphQL -> severities: [EventSeverity!]! (enum)
        [JsonProperty("severities")]
        public List<EventSeverity>? Severities { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllEvents")]
        public System.Boolean? IsSubscribedToAllEvents { get; set; }

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
        return "EventSubscription";
    }

    public EventSubscription Set(
        List<EventType>? EventTypes = null,
        List<EventObjectType>? ObjectTypes = null,
        List<EventSeverity>? Severities = null,
        System.Boolean? IsSubscribedToAllEvents = null,
        System.Boolean? IsSubscribedToAllObjectTypes = null,
        TemplateInfo? TemplateInfo = null
    ) 
    {
        if ( EventTypes != null ) {
            this.EventTypes = EventTypes;
        }
        if ( ObjectTypes != null ) {
            this.ObjectTypes = ObjectTypes;
        }
        if ( Severities != null ) {
            this.Severities = Severities;
        }
        if ( IsSubscribedToAllEvents != null ) {
            this.IsSubscribedToAllEvents = IsSubscribedToAllEvents;
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
        //      C# -> List<EventType>? EventTypes
        // GraphQL -> eventTypes: [EventType!]! (enum)
        if (this.EventTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTypes\n" ;
            } else {
                s += ind + "eventTypes\n" ;
            }
        }
        //      C# -> List<EventObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [EventObjectType!]! (enum)
        if (this.ObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectTypes\n" ;
            } else {
                s += ind + "objectTypes\n" ;
            }
        }
        //      C# -> List<EventSeverity>? Severities
        // GraphQL -> severities: [EventSeverity!]! (enum)
        if (this.Severities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severities\n" ;
            } else {
                s += ind + "severities\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (this.IsSubscribedToAllEvents != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribedToAllEvents\n" ;
            } else {
                s += ind + "isSubscribedToAllEvents\n" ;
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
        //      C# -> List<EventType>? EventTypes
        // GraphQL -> eventTypes: [EventType!]! (enum)
        if (ec.Includes("eventTypes",true))
        {
            if(this.EventTypes == null) {

                this.EventTypes = new List<EventType>();

            } else {


            }
        }
        else if (this.EventTypes != null && ec.Excludes("eventTypes",true))
        {
            this.EventTypes = null;
        }
        //      C# -> List<EventObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [EventObjectType!]! (enum)
        if (ec.Includes("objectTypes",true))
        {
            if(this.ObjectTypes == null) {

                this.ObjectTypes = new List<EventObjectType>();

            } else {


            }
        }
        else if (this.ObjectTypes != null && ec.Excludes("objectTypes",true))
        {
            this.ObjectTypes = null;
        }
        //      C# -> List<EventSeverity>? Severities
        // GraphQL -> severities: [EventSeverity!]! (enum)
        if (ec.Includes("severities",true))
        {
            if(this.Severities == null) {

                this.Severities = new List<EventSeverity>();

            } else {


            }
        }
        else if (this.Severities != null && ec.Excludes("severities",true))
        {
            this.Severities = null;
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (ec.Includes("isSubscribedToAllEvents",true))
        {
            if(this.IsSubscribedToAllEvents == null) {

                this.IsSubscribedToAllEvents = true;

            } else {


            }
        }
        else if (this.IsSubscribedToAllEvents != null && ec.Excludes("isSubscribedToAllEvents",true))
        {
            this.IsSubscribedToAllEvents = null;
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

    } // class EventSubscription
    
    #endregion

    public static class ListEventSubscriptionExtensions
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
            this List<EventSubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EventSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EventSubscription> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EventSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EventSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types