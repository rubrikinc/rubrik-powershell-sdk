// SyslogSetting.cs
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
    #region SyslogSetting
    public class SyslogSetting: BaseType
    {
        #region members

        //      C# -> SyslogFacilityTypeEnum? Facility
        // GraphQL -> facility: SyslogFacilityTypeEnum! (enum)
        [JsonProperty("facility")]
        public SyslogFacilityTypeEnum? Facility { get; set; }

        //      C# -> SyslogSeverityTypeEnum? Severity
        // GraphQL -> severity: SyslogSeverityTypeEnum! (enum)
        [JsonProperty("severity")]
        public SyslogSeverityTypeEnum? Severity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogSetting";
    }

    public SyslogSetting Set(
        SyslogFacilityTypeEnum? Facility = null,
        SyslogSeverityTypeEnum? Severity = null
    ) 
    {
        if ( Facility != null ) {
            this.Facility = Facility;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
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
        //      C# -> SyslogFacilityTypeEnum? Facility
        // GraphQL -> facility: SyslogFacilityTypeEnum! (enum)
        if (this.Facility != null) {
            if (conf.Flat) {
                s += conf.Prefix + "facility\n" ;
            } else {
                s += ind + "facility\n" ;
            }
        }
        //      C# -> SyslogSeverityTypeEnum? Severity
        // GraphQL -> severity: SyslogSeverityTypeEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SyslogFacilityTypeEnum? Facility
        // GraphQL -> facility: SyslogFacilityTypeEnum! (enum)
        if (ec.Includes("facility",true))
        {
            if(this.Facility == null) {

                this.Facility = new SyslogFacilityTypeEnum();

            } else {


            }
        }
        else if (this.Facility != null && ec.Excludes("facility",true))
        {
            this.Facility = null;
        }
        //      C# -> SyslogSeverityTypeEnum? Severity
        // GraphQL -> severity: SyslogSeverityTypeEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new SyslogSeverityTypeEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
    }


    #endregion

    } // class SyslogSetting
    
    #endregion

    public static class ListSyslogSettingExtensions
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
            this List<SyslogSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SyslogSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SyslogSetting> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SyslogSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types