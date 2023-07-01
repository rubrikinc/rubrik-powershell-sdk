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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SyslogFacilityTypeEnum? Facility
        // GraphQL -> facility: SyslogFacilityTypeEnum! (enum)
        if (this.Facility != null) {
            s += ind + "facility\n" ;
        }
        //      C# -> SyslogSeverityTypeEnum? Severity
        // GraphQL -> severity: SyslogSeverityTypeEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SyslogFacilityTypeEnum? Facility
        // GraphQL -> facility: SyslogFacilityTypeEnum! (enum)
        if (this.Facility == null && Exploration.Includes(parent + ".facility", true))
        {
            this.Facility = new SyslogFacilityTypeEnum();
        }
        //      C# -> SyslogSeverityTypeEnum? Severity
        // GraphQL -> severity: SyslogSeverityTypeEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new SyslogSeverityTypeEnum();
        }
    }


    #endregion

    } // class SyslogSetting
    
    #endregion

    public static class ListSyslogSettingExtensions
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
            this List<SyslogSetting> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SyslogSetting> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogSetting());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types