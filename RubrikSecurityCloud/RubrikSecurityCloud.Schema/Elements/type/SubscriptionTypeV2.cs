// SubscriptionTypeV2.cs
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
    #region SubscriptionTypeV2
    public class SubscriptionTypeV2: BaseType
    {
        #region members

        //      C# -> AuditSubscription? AuditSubscription
        // GraphQL -> auditSubscription: AuditSubscription (type)
        [JsonProperty("auditSubscription")]
        public AuditSubscription? AuditSubscription { get; set; }

        //      C# -> EventSubscription? EventSubscription
        // GraphQL -> eventSubscription: EventSubscription (type)
        [JsonProperty("eventSubscription")]
        public EventSubscription? EventSubscription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SubscriptionTypeV2";
    }

    public SubscriptionTypeV2 Set(
        AuditSubscription? AuditSubscription = null,
        EventSubscription? EventSubscription = null
    ) 
    {
        if ( AuditSubscription != null ) {
            this.AuditSubscription = AuditSubscription;
        }
        if ( EventSubscription != null ) {
            this.EventSubscription = EventSubscription;
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
        //      C# -> AuditSubscription? AuditSubscription
        // GraphQL -> auditSubscription: AuditSubscription (type)
        if (this.AuditSubscription != null) {
            var fspec = this.AuditSubscription.AsFieldSpec(conf.Child("auditSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "auditSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EventSubscription? EventSubscription
        // GraphQL -> eventSubscription: EventSubscription (type)
        if (this.EventSubscription != null) {
            var fspec = this.EventSubscription.AsFieldSpec(conf.Child("eventSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "eventSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AuditSubscription? AuditSubscription
        // GraphQL -> auditSubscription: AuditSubscription (type)
        if (ec.Includes("auditSubscription",false))
        {
            if(this.AuditSubscription == null) {

                this.AuditSubscription = new AuditSubscription();
                this.AuditSubscription.ApplyExploratoryFieldSpec(ec.NewChild("auditSubscription"));

            } else {

                this.AuditSubscription.ApplyExploratoryFieldSpec(ec.NewChild("auditSubscription"));

            }
        }
        else if (this.AuditSubscription != null && ec.Excludes("auditSubscription",false))
        {
            this.AuditSubscription = null;
        }
        //      C# -> EventSubscription? EventSubscription
        // GraphQL -> eventSubscription: EventSubscription (type)
        if (ec.Includes("eventSubscription",false))
        {
            if(this.EventSubscription == null) {

                this.EventSubscription = new EventSubscription();
                this.EventSubscription.ApplyExploratoryFieldSpec(ec.NewChild("eventSubscription"));

            } else {

                this.EventSubscription.ApplyExploratoryFieldSpec(ec.NewChild("eventSubscription"));

            }
        }
        else if (this.EventSubscription != null && ec.Excludes("eventSubscription",false))
        {
            this.EventSubscription = null;
        }
    }


    #endregion

    } // class SubscriptionTypeV2
    
    #endregion

    public static class ListSubscriptionTypeV2Extensions
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
            this List<SubscriptionTypeV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SubscriptionTypeV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SubscriptionTypeV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SubscriptionTypeV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SubscriptionTypeV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types