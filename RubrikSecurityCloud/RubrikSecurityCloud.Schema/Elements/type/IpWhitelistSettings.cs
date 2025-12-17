// IpWhitelistSettings.cs
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
    #region IpWhitelistSettings
    public class IpWhitelistSettings: BaseType
    {
        #region members

        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        [JsonProperty("mode")]
        public WhitelistModeEnum? Mode { get; set; }

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> System.Boolean? IsInheritedFromGlobal
        // GraphQL -> isInheritedFromGlobal: Boolean! (scalar)
        [JsonProperty("isInheritedFromGlobal")]
        public System.Boolean? IsInheritedFromGlobal { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IpWhitelistSettings";
    }

    public IpWhitelistSettings Set(
        WhitelistModeEnum? Mode = null,
        System.Boolean? Enabled = null,
        System.Boolean? IsInheritedFromGlobal = null
    ) 
    {
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( IsInheritedFromGlobal != null ) {
            this.IsInheritedFromGlobal = IsInheritedFromGlobal;
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
        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
            }
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsInheritedFromGlobal
        // GraphQL -> isInheritedFromGlobal: Boolean! (scalar)
        if (this.IsInheritedFromGlobal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInheritedFromGlobal\n" ;
            } else {
                s += ind + "isInheritedFromGlobal\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = new WhitelistModeEnum();

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> System.Boolean? IsInheritedFromGlobal
        // GraphQL -> isInheritedFromGlobal: Boolean! (scalar)
        if (ec.Includes("isInheritedFromGlobal",true))
        {
            if(this.IsInheritedFromGlobal == null) {

                this.IsInheritedFromGlobal = true;

            } else {


            }
        }
        else if (this.IsInheritedFromGlobal != null && ec.Excludes("isInheritedFromGlobal",true))
        {
            this.IsInheritedFromGlobal = null;
        }
    }


    #endregion

    } // class IpWhitelistSettings
    
    #endregion

    public static class ListIpWhitelistSettingsExtensions
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
            this List<IpWhitelistSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IpWhitelistSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IpWhitelistSettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IpWhitelistSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IpWhitelistSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types