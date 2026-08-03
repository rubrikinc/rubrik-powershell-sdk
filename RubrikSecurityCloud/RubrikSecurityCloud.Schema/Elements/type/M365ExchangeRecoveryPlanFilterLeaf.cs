// M365ExchangeRecoveryPlanFilterLeaf.cs
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
    #region M365ExchangeRecoveryPlanFilterLeaf
    public class M365ExchangeRecoveryPlanFilterLeaf: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDraft
        // GraphQL -> isDraft: Boolean (scalar)
        [JsonProperty("isDraft")]
        public System.Boolean? IsDraft { get; set; }

        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean (scalar)
        [JsonProperty("isRead")]
        public System.Boolean? IsRead { get; set; }

        //      C# -> M365StringListFilter? Importance
        // GraphQL -> importance: M365StringListFilter (type)
        [JsonProperty("importance")]
        public M365StringListFilter? Importance { get; set; }

        //      C# -> M365StringListFilter? Sender
        // GraphQL -> sender: M365StringListFilter (type)
        [JsonProperty("sender")]
        public M365StringListFilter? Sender { get; set; }

        //      C# -> M365StringListFilter? ToRecipients
        // GraphQL -> toRecipients: M365StringListFilter (type)
        [JsonProperty("toRecipients")]
        public M365StringListFilter? ToRecipients { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365ExchangeRecoveryPlanFilterLeaf";
    }

    public M365ExchangeRecoveryPlanFilterLeaf Set(
        System.Boolean? IsDraft = null,
        System.Boolean? IsRead = null,
        M365StringListFilter? Importance = null,
        M365StringListFilter? Sender = null,
        M365StringListFilter? ToRecipients = null
    ) 
    {
        if ( IsDraft != null ) {
            this.IsDraft = IsDraft;
        }
        if ( IsRead != null ) {
            this.IsRead = IsRead;
        }
        if ( Importance != null ) {
            this.Importance = Importance;
        }
        if ( Sender != null ) {
            this.Sender = Sender;
        }
        if ( ToRecipients != null ) {
            this.ToRecipients = ToRecipients;
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
        //      C# -> System.Boolean? IsDraft
        // GraphQL -> isDraft: Boolean (scalar)
        if (this.IsDraft != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDraft\n" ;
            } else {
                s += ind + "isDraft\n" ;
            }
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean (scalar)
        if (this.IsRead != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRead\n" ;
            } else {
                s += ind + "isRead\n" ;
            }
        }
        //      C# -> M365StringListFilter? Importance
        // GraphQL -> importance: M365StringListFilter (type)
        if (this.Importance != null) {
            var fspec = this.Importance.AsFieldSpec(conf.Child("importance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "importance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365StringListFilter? Sender
        // GraphQL -> sender: M365StringListFilter (type)
        if (this.Sender != null) {
            var fspec = this.Sender.AsFieldSpec(conf.Child("sender"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sender" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365StringListFilter? ToRecipients
        // GraphQL -> toRecipients: M365StringListFilter (type)
        if (this.ToRecipients != null) {
            var fspec = this.ToRecipients.AsFieldSpec(conf.Child("toRecipients"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "toRecipients" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDraft
        // GraphQL -> isDraft: Boolean (scalar)
        if (ec.Includes("isDraft",true))
        {
            if(this.IsDraft == null) {

                this.IsDraft = true;

            } else {


            }
        }
        else if (this.IsDraft != null && ec.Excludes("isDraft",true))
        {
            this.IsDraft = null;
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean (scalar)
        if (ec.Includes("isRead",true))
        {
            if(this.IsRead == null) {

                this.IsRead = true;

            } else {


            }
        }
        else if (this.IsRead != null && ec.Excludes("isRead",true))
        {
            this.IsRead = null;
        }
        //      C# -> M365StringListFilter? Importance
        // GraphQL -> importance: M365StringListFilter (type)
        if (ec.Includes("importance",false))
        {
            if(this.Importance == null) {

                this.Importance = new M365StringListFilter();
                this.Importance.ApplyExploratoryFieldSpec(ec.NewChild("importance"));

            } else {

                this.Importance.ApplyExploratoryFieldSpec(ec.NewChild("importance"));

            }
        }
        else if (this.Importance != null && ec.Excludes("importance",false))
        {
            this.Importance = null;
        }
        //      C# -> M365StringListFilter? Sender
        // GraphQL -> sender: M365StringListFilter (type)
        if (ec.Includes("sender",false))
        {
            if(this.Sender == null) {

                this.Sender = new M365StringListFilter();
                this.Sender.ApplyExploratoryFieldSpec(ec.NewChild("sender"));

            } else {

                this.Sender.ApplyExploratoryFieldSpec(ec.NewChild("sender"));

            }
        }
        else if (this.Sender != null && ec.Excludes("sender",false))
        {
            this.Sender = null;
        }
        //      C# -> M365StringListFilter? ToRecipients
        // GraphQL -> toRecipients: M365StringListFilter (type)
        if (ec.Includes("toRecipients",false))
        {
            if(this.ToRecipients == null) {

                this.ToRecipients = new M365StringListFilter();
                this.ToRecipients.ApplyExploratoryFieldSpec(ec.NewChild("toRecipients"));

            } else {

                this.ToRecipients.ApplyExploratoryFieldSpec(ec.NewChild("toRecipients"));

            }
        }
        else if (this.ToRecipients != null && ec.Excludes("toRecipients",false))
        {
            this.ToRecipients = null;
        }
    }


    #endregion

    } // class M365ExchangeRecoveryPlanFilterLeaf
    
    #endregion

    public static class ListM365ExchangeRecoveryPlanFilterLeafExtensions
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
            this List<M365ExchangeRecoveryPlanFilterLeaf> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365ExchangeRecoveryPlanFilterLeaf> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365ExchangeRecoveryPlanFilterLeaf> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365ExchangeRecoveryPlanFilterLeaf());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365ExchangeRecoveryPlanFilterLeaf> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types