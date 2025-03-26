// GetMfaSettingReply.cs
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
    #region GetMfaSettingReply
    public class GetMfaSettingReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        [JsonProperty("isTotpEnforcedGlobal")]
        public System.Boolean? IsTotpEnforcedGlobal { get; set; }

        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        [JsonProperty("isTotpGlobalEnforceLocked")]
        public System.Boolean? IsTotpGlobalEnforceLocked { get; set; }

        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        [JsonProperty("isTotpMandatory")]
        public System.Boolean? IsTotpMandatory { get; set; }

        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        [JsonProperty("mandatoryTotpEnforcementDate")]
        public DateTime? MandatoryTotpEnforcementDate { get; set; }

        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        [JsonProperty("mfaRememberHours")]
        public System.Int32? MfaRememberHours { get; set; }

        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        [JsonProperty("totpReminderHours")]
        public System.Int32? TotpReminderHours { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetMfaSettingReply";
    }

    public GetMfaSettingReply Set(
        System.Boolean? IsTotpEnforcedGlobal = null,
        System.Boolean? IsTotpGlobalEnforceLocked = null,
        System.Boolean? IsTotpMandatory = null,
        DateTime? MandatoryTotpEnforcementDate = null,
        System.Int32? MfaRememberHours = null,
        System.Int32? TotpReminderHours = null
    ) 
    {
        if ( IsTotpEnforcedGlobal != null ) {
            this.IsTotpEnforcedGlobal = IsTotpEnforcedGlobal;
        }
        if ( IsTotpGlobalEnforceLocked != null ) {
            this.IsTotpGlobalEnforceLocked = IsTotpGlobalEnforceLocked;
        }
        if ( IsTotpMandatory != null ) {
            this.IsTotpMandatory = IsTotpMandatory;
        }
        if ( MandatoryTotpEnforcementDate != null ) {
            this.MandatoryTotpEnforcementDate = MandatoryTotpEnforcementDate;
        }
        if ( MfaRememberHours != null ) {
            this.MfaRememberHours = MfaRememberHours;
        }
        if ( TotpReminderHours != null ) {
            this.TotpReminderHours = TotpReminderHours;
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
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        if (this.IsTotpEnforcedGlobal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTotpEnforcedGlobal\n" ;
            } else {
                s += ind + "isTotpEnforcedGlobal\n" ;
            }
        }
        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        if (this.IsTotpGlobalEnforceLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTotpGlobalEnforceLocked\n" ;
            } else {
                s += ind + "isTotpGlobalEnforceLocked\n" ;
            }
        }
        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        if (this.IsTotpMandatory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTotpMandatory\n" ;
            } else {
                s += ind + "isTotpMandatory\n" ;
            }
        }
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mandatoryTotpEnforcementDate\n" ;
            } else {
                s += ind + "mandatoryTotpEnforcementDate\n" ;
            }
        }
        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        if (this.MfaRememberHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaRememberHours\n" ;
            } else {
                s += ind + "mfaRememberHours\n" ;
            }
        }
        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        if (this.TotpReminderHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totpReminderHours\n" ;
            } else {
                s += ind + "totpReminderHours\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        if (ec.Includes("isTotpEnforcedGlobal",true))
        {
            if(this.IsTotpEnforcedGlobal == null) {

                this.IsTotpEnforcedGlobal = true;

            } else {


            }
        }
        else if (this.IsTotpEnforcedGlobal != null && ec.Excludes("isTotpEnforcedGlobal",true))
        {
            this.IsTotpEnforcedGlobal = null;
        }
        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        if (ec.Includes("isTotpGlobalEnforceLocked",true))
        {
            if(this.IsTotpGlobalEnforceLocked == null) {

                this.IsTotpGlobalEnforceLocked = true;

            } else {


            }
        }
        else if (this.IsTotpGlobalEnforceLocked != null && ec.Excludes("isTotpGlobalEnforceLocked",true))
        {
            this.IsTotpGlobalEnforceLocked = null;
        }
        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        if (ec.Includes("isTotpMandatory",true))
        {
            if(this.IsTotpMandatory == null) {

                this.IsTotpMandatory = true;

            } else {


            }
        }
        else if (this.IsTotpMandatory != null && ec.Excludes("isTotpMandatory",true))
        {
            this.IsTotpMandatory = null;
        }
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (ec.Includes("mandatoryTotpEnforcementDate",true))
        {
            if(this.MandatoryTotpEnforcementDate == null) {

                this.MandatoryTotpEnforcementDate = new DateTime();

            } else {


            }
        }
        else if (this.MandatoryTotpEnforcementDate != null && ec.Excludes("mandatoryTotpEnforcementDate",true))
        {
            this.MandatoryTotpEnforcementDate = null;
        }
        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        if (ec.Includes("mfaRememberHours",true))
        {
            if(this.MfaRememberHours == null) {

                this.MfaRememberHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.MfaRememberHours != null && ec.Excludes("mfaRememberHours",true))
        {
            this.MfaRememberHours = null;
        }
        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        if (ec.Includes("totpReminderHours",true))
        {
            if(this.TotpReminderHours == null) {

                this.TotpReminderHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotpReminderHours != null && ec.Excludes("totpReminderHours",true))
        {
            this.TotpReminderHours = null;
        }
    }


    #endregion

    } // class GetMfaSettingReply
    
    #endregion

    public static class ListGetMfaSettingReplyExtensions
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
            this List<GetMfaSettingReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetMfaSettingReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetMfaSettingReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetMfaSettingReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetMfaSettingReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types