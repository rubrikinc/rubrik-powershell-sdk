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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        if (this.IsTotpEnforcedGlobal != null) {
            s += ind + "isTotpEnforcedGlobal\n" ;
        }
        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        if (this.IsTotpGlobalEnforceLocked != null) {
            s += ind + "isTotpGlobalEnforceLocked\n" ;
        }
        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        if (this.IsTotpMandatory != null) {
            s += ind + "isTotpMandatory\n" ;
        }
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate != null) {
            s += ind + "mandatoryTotpEnforcementDate\n" ;
        }
        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        if (this.MfaRememberHours != null) {
            s += ind + "mfaRememberHours\n" ;
        }
        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        if (this.TotpReminderHours != null) {
            s += ind + "totpReminderHours\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        if (this.IsTotpEnforcedGlobal == null && Exploration.Includes(parent + ".isTotpEnforcedGlobal", true))
        {
            this.IsTotpEnforcedGlobal = true;
        }
        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        if (this.IsTotpGlobalEnforceLocked == null && Exploration.Includes(parent + ".isTotpGlobalEnforceLocked", true))
        {
            this.IsTotpGlobalEnforceLocked = true;
        }
        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        if (this.IsTotpMandatory == null && Exploration.Includes(parent + ".isTotpMandatory", true))
        {
            this.IsTotpMandatory = true;
        }
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate == null && Exploration.Includes(parent + ".mandatoryTotpEnforcementDate", true))
        {
            this.MandatoryTotpEnforcementDate = new DateTime();
        }
        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        if (this.MfaRememberHours == null && Exploration.Includes(parent + ".mfaRememberHours", true))
        {
            this.MfaRememberHours = Int32.MinValue;
        }
        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        if (this.TotpReminderHours == null && Exploration.Includes(parent + ".totpReminderHours", true))
        {
            this.TotpReminderHours = Int32.MinValue;
        }
    }


    #endregion

    } // class GetMfaSettingReply
    
    #endregion

    public static class ListGetMfaSettingReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<GetMfaSettingReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetMfaSettingReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetMfaSettingReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types