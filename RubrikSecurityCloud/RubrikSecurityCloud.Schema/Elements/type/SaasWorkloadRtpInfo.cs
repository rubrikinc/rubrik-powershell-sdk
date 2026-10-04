// SaasWorkloadRtpInfo.cs
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
    #region SaasWorkloadRtpInfo
    public class SaasWorkloadRtpInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? CaptureIntervalMins
        // GraphQL -> captureIntervalMins: Int! (scalar)
        [JsonProperty("captureIntervalMins")]
        public System.Int32? CaptureIntervalMins { get; set; }

        //      C# -> System.Int32? CaptureRetentionDays
        // GraphQL -> captureRetentionDays: Int! (scalar)
        [JsonProperty("captureRetentionDays")]
        public System.Int32? CaptureRetentionDays { get; set; }

        //      C# -> System.Boolean? IsRtpEnabled
        // GraphQL -> isRtpEnabled: Boolean! (scalar)
        [JsonProperty("isRtpEnabled")]
        public System.Boolean? IsRtpEnabled { get; set; }

        //      C# -> System.Boolean? IsRtpRestoreEnabled
        // GraphQL -> isRtpRestoreEnabled: Boolean! (scalar)
        [JsonProperty("isRtpRestoreEnabled")]
        public System.Boolean? IsRtpRestoreEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasWorkloadRtpInfo";
    }

    public SaasWorkloadRtpInfo Set(
        System.Int32? CaptureIntervalMins = null,
        System.Int32? CaptureRetentionDays = null,
        System.Boolean? IsRtpEnabled = null,
        System.Boolean? IsRtpRestoreEnabled = null
    ) 
    {
        if ( CaptureIntervalMins != null ) {
            this.CaptureIntervalMins = CaptureIntervalMins;
        }
        if ( CaptureRetentionDays != null ) {
            this.CaptureRetentionDays = CaptureRetentionDays;
        }
        if ( IsRtpEnabled != null ) {
            this.IsRtpEnabled = IsRtpEnabled;
        }
        if ( IsRtpRestoreEnabled != null ) {
            this.IsRtpRestoreEnabled = IsRtpRestoreEnabled;
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
        //      C# -> System.Int32? CaptureIntervalMins
        // GraphQL -> captureIntervalMins: Int! (scalar)
        if (this.CaptureIntervalMins != null) {
            if (conf.Flat) {
                s += conf.Prefix + "captureIntervalMins\n" ;
            } else {
                s += ind + "captureIntervalMins\n" ;
            }
        }
        //      C# -> System.Int32? CaptureRetentionDays
        // GraphQL -> captureRetentionDays: Int! (scalar)
        if (this.CaptureRetentionDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "captureRetentionDays\n" ;
            } else {
                s += ind + "captureRetentionDays\n" ;
            }
        }
        //      C# -> System.Boolean? IsRtpEnabled
        // GraphQL -> isRtpEnabled: Boolean! (scalar)
        if (this.IsRtpEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRtpEnabled\n" ;
            } else {
                s += ind + "isRtpEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsRtpRestoreEnabled
        // GraphQL -> isRtpRestoreEnabled: Boolean! (scalar)
        if (this.IsRtpRestoreEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRtpRestoreEnabled\n" ;
            } else {
                s += ind + "isRtpRestoreEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? CaptureIntervalMins
        // GraphQL -> captureIntervalMins: Int! (scalar)
        if (ec.Includes("captureIntervalMins",true))
        {
            if(this.CaptureIntervalMins == null) {

                this.CaptureIntervalMins = Int32.MinValue;

            } else {


            }
        }
        else if (this.CaptureIntervalMins != null && ec.Excludes("captureIntervalMins",true))
        {
            this.CaptureIntervalMins = null;
        }
        //      C# -> System.Int32? CaptureRetentionDays
        // GraphQL -> captureRetentionDays: Int! (scalar)
        if (ec.Includes("captureRetentionDays",true))
        {
            if(this.CaptureRetentionDays == null) {

                this.CaptureRetentionDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.CaptureRetentionDays != null && ec.Excludes("captureRetentionDays",true))
        {
            this.CaptureRetentionDays = null;
        }
        //      C# -> System.Boolean? IsRtpEnabled
        // GraphQL -> isRtpEnabled: Boolean! (scalar)
        if (ec.Includes("isRtpEnabled",true))
        {
            if(this.IsRtpEnabled == null) {

                this.IsRtpEnabled = true;

            } else {


            }
        }
        else if (this.IsRtpEnabled != null && ec.Excludes("isRtpEnabled",true))
        {
            this.IsRtpEnabled = null;
        }
        //      C# -> System.Boolean? IsRtpRestoreEnabled
        // GraphQL -> isRtpRestoreEnabled: Boolean! (scalar)
        if (ec.Includes("isRtpRestoreEnabled",true))
        {
            if(this.IsRtpRestoreEnabled == null) {

                this.IsRtpRestoreEnabled = true;

            } else {


            }
        }
        else if (this.IsRtpRestoreEnabled != null && ec.Excludes("isRtpRestoreEnabled",true))
        {
            this.IsRtpRestoreEnabled = null;
        }
    }


    #endregion

    } // class SaasWorkloadRtpInfo
    
    #endregion

    public static class ListSaasWorkloadRtpInfoExtensions
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
            this List<SaasWorkloadRtpInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasWorkloadRtpInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasWorkloadRtpInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasWorkloadRtpInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasWorkloadRtpInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types