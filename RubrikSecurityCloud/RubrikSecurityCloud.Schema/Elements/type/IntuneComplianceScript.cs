// IntuneComplianceScript.cs
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
    #region IntuneComplianceScript
    public class IntuneComplianceScript: BaseType
    {
        #region members

        //      C# -> IntuneCompliancePolicyPlatform? OperatingSystem
        // GraphQL -> operatingSystem: IntuneCompliancePolicyPlatform! (enum)
        [JsonProperty("operatingSystem")]
        public IntuneCompliancePolicyPlatform? OperatingSystem { get; set; }

        //      C# -> IntuneComplianceScriptType? ScriptType
        // GraphQL -> scriptType: IntuneComplianceScriptType! (enum)
        [JsonProperty("scriptType")]
        public IntuneComplianceScriptType? ScriptType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        [JsonProperty("lastModifiedTime")]
        public DateTime? LastModifiedTime { get; set; }

        //      C# -> System.Boolean? ReadOnly
        // GraphQL -> readOnly: Boolean! (scalar)
        [JsonProperty("readOnly")]
        public System.Boolean? ReadOnly { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneComplianceScript";
    }

    public IntuneComplianceScript Set(
        IntuneCompliancePolicyPlatform? OperatingSystem = null,
        IntuneComplianceScriptType? ScriptType = null,
        System.String? DisplayName = null,
        DateTime? LastModifiedTime = null,
        System.Boolean? ReadOnly = null
    ) 
    {
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( ScriptType != null ) {
            this.ScriptType = ScriptType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( ReadOnly != null ) {
            this.ReadOnly = ReadOnly;
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
        //      C# -> IntuneCompliancePolicyPlatform? OperatingSystem
        // GraphQL -> operatingSystem: IntuneCompliancePolicyPlatform! (enum)
        if (this.OperatingSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystem\n" ;
            } else {
                s += ind + "operatingSystem\n" ;
            }
        }
        //      C# -> IntuneComplianceScriptType? ScriptType
        // GraphQL -> scriptType: IntuneComplianceScriptType! (enum)
        if (this.ScriptType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scriptType\n" ;
            } else {
                s += ind + "scriptType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (this.LastModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedTime\n" ;
            } else {
                s += ind + "lastModifiedTime\n" ;
            }
        }
        //      C# -> System.Boolean? ReadOnly
        // GraphQL -> readOnly: Boolean! (scalar)
        if (this.ReadOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "readOnly\n" ;
            } else {
                s += ind + "readOnly\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneCompliancePolicyPlatform? OperatingSystem
        // GraphQL -> operatingSystem: IntuneCompliancePolicyPlatform! (enum)
        if (ec.Includes("operatingSystem",true))
        {
            if(this.OperatingSystem == null) {

                this.OperatingSystem = new IntuneCompliancePolicyPlatform();

            } else {


            }
        }
        else if (this.OperatingSystem != null && ec.Excludes("operatingSystem",true))
        {
            this.OperatingSystem = null;
        }
        //      C# -> IntuneComplianceScriptType? ScriptType
        // GraphQL -> scriptType: IntuneComplianceScriptType! (enum)
        if (ec.Includes("scriptType",true))
        {
            if(this.ScriptType == null) {

                this.ScriptType = new IntuneComplianceScriptType();

            } else {


            }
        }
        else if (this.ScriptType != null && ec.Excludes("scriptType",true))
        {
            this.ScriptType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (ec.Includes("lastModifiedTime",true))
        {
            if(this.LastModifiedTime == null) {

                this.LastModifiedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastModifiedTime != null && ec.Excludes("lastModifiedTime",true))
        {
            this.LastModifiedTime = null;
        }
        //      C# -> System.Boolean? ReadOnly
        // GraphQL -> readOnly: Boolean! (scalar)
        if (ec.Includes("readOnly",true))
        {
            if(this.ReadOnly == null) {

                this.ReadOnly = true;

            } else {


            }
        }
        else if (this.ReadOnly != null && ec.Excludes("readOnly",true))
        {
            this.ReadOnly = null;
        }
    }


    #endregion

    } // class IntuneComplianceScript
    
    #endregion

    public static class ListIntuneComplianceScriptExtensions
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
            this List<IntuneComplianceScript> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneComplianceScript> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneComplianceScript> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneComplianceScript());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneComplianceScript> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types