// PasskeyConfig.cs
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
    #region PasskeyConfig
    public class PasskeyConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? MaxPasskeysAllowed
        // GraphQL -> maxPasskeysAllowed: Int! (scalar)
        [JsonProperty("maxPasskeysAllowed")]
        public System.Int32? MaxPasskeysAllowed { get; set; }

        //      C# -> System.Boolean? PasskeysAllowed
        // GraphQL -> passkeysAllowed: Boolean! (scalar)
        [JsonProperty("passkeysAllowed")]
        public System.Boolean? PasskeysAllowed { get; set; }

        //      C# -> System.Boolean? PasswordlessLoginAllowed
        // GraphQL -> passwordlessLoginAllowed: Boolean! (scalar)
        [JsonProperty("passwordlessLoginAllowed")]
        public System.Boolean? PasswordlessLoginAllowed { get; set; }

        //      C# -> System.Boolean? PlatformPasskeyAllowed
        // GraphQL -> platformPasskeyAllowed: Boolean! (scalar)
        [JsonProperty("platformPasskeyAllowed")]
        public System.Boolean? PlatformPasskeyAllowed { get; set; }

        //      C# -> System.Boolean? RoamingPasskeyAllowed
        // GraphQL -> roamingPasskeyAllowed: Boolean! (scalar)
        [JsonProperty("roamingPasskeyAllowed")]
        public System.Boolean? RoamingPasskeyAllowed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PasskeyConfig";
    }

    public PasskeyConfig Set(
        System.Int32? MaxPasskeysAllowed = null,
        System.Boolean? PasskeysAllowed = null,
        System.Boolean? PasswordlessLoginAllowed = null,
        System.Boolean? PlatformPasskeyAllowed = null,
        System.Boolean? RoamingPasskeyAllowed = null
    ) 
    {
        if ( MaxPasskeysAllowed != null ) {
            this.MaxPasskeysAllowed = MaxPasskeysAllowed;
        }
        if ( PasskeysAllowed != null ) {
            this.PasskeysAllowed = PasskeysAllowed;
        }
        if ( PasswordlessLoginAllowed != null ) {
            this.PasswordlessLoginAllowed = PasswordlessLoginAllowed;
        }
        if ( PlatformPasskeyAllowed != null ) {
            this.PlatformPasskeyAllowed = PlatformPasskeyAllowed;
        }
        if ( RoamingPasskeyAllowed != null ) {
            this.RoamingPasskeyAllowed = RoamingPasskeyAllowed;
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
        //      C# -> System.Int32? MaxPasskeysAllowed
        // GraphQL -> maxPasskeysAllowed: Int! (scalar)
        if (this.MaxPasskeysAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxPasskeysAllowed\n" ;
            } else {
                s += ind + "maxPasskeysAllowed\n" ;
            }
        }
        //      C# -> System.Boolean? PasskeysAllowed
        // GraphQL -> passkeysAllowed: Boolean! (scalar)
        if (this.PasskeysAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passkeysAllowed\n" ;
            } else {
                s += ind + "passkeysAllowed\n" ;
            }
        }
        //      C# -> System.Boolean? PasswordlessLoginAllowed
        // GraphQL -> passwordlessLoginAllowed: Boolean! (scalar)
        if (this.PasswordlessLoginAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passwordlessLoginAllowed\n" ;
            } else {
                s += ind + "passwordlessLoginAllowed\n" ;
            }
        }
        //      C# -> System.Boolean? PlatformPasskeyAllowed
        // GraphQL -> platformPasskeyAllowed: Boolean! (scalar)
        if (this.PlatformPasskeyAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformPasskeyAllowed\n" ;
            } else {
                s += ind + "platformPasskeyAllowed\n" ;
            }
        }
        //      C# -> System.Boolean? RoamingPasskeyAllowed
        // GraphQL -> roamingPasskeyAllowed: Boolean! (scalar)
        if (this.RoamingPasskeyAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roamingPasskeyAllowed\n" ;
            } else {
                s += ind + "roamingPasskeyAllowed\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? MaxPasskeysAllowed
        // GraphQL -> maxPasskeysAllowed: Int! (scalar)
        if (ec.Includes("maxPasskeysAllowed",true))
        {
            if(this.MaxPasskeysAllowed == null) {

                this.MaxPasskeysAllowed = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxPasskeysAllowed != null && ec.Excludes("maxPasskeysAllowed",true))
        {
            this.MaxPasskeysAllowed = null;
        }
        //      C# -> System.Boolean? PasskeysAllowed
        // GraphQL -> passkeysAllowed: Boolean! (scalar)
        if (ec.Includes("passkeysAllowed",true))
        {
            if(this.PasskeysAllowed == null) {

                this.PasskeysAllowed = true;

            } else {


            }
        }
        else if (this.PasskeysAllowed != null && ec.Excludes("passkeysAllowed",true))
        {
            this.PasskeysAllowed = null;
        }
        //      C# -> System.Boolean? PasswordlessLoginAllowed
        // GraphQL -> passwordlessLoginAllowed: Boolean! (scalar)
        if (ec.Includes("passwordlessLoginAllowed",true))
        {
            if(this.PasswordlessLoginAllowed == null) {

                this.PasswordlessLoginAllowed = true;

            } else {


            }
        }
        else if (this.PasswordlessLoginAllowed != null && ec.Excludes("passwordlessLoginAllowed",true))
        {
            this.PasswordlessLoginAllowed = null;
        }
        //      C# -> System.Boolean? PlatformPasskeyAllowed
        // GraphQL -> platformPasskeyAllowed: Boolean! (scalar)
        if (ec.Includes("platformPasskeyAllowed",true))
        {
            if(this.PlatformPasskeyAllowed == null) {

                this.PlatformPasskeyAllowed = true;

            } else {


            }
        }
        else if (this.PlatformPasskeyAllowed != null && ec.Excludes("platformPasskeyAllowed",true))
        {
            this.PlatformPasskeyAllowed = null;
        }
        //      C# -> System.Boolean? RoamingPasskeyAllowed
        // GraphQL -> roamingPasskeyAllowed: Boolean! (scalar)
        if (ec.Includes("roamingPasskeyAllowed",true))
        {
            if(this.RoamingPasskeyAllowed == null) {

                this.RoamingPasskeyAllowed = true;

            } else {


            }
        }
        else if (this.RoamingPasskeyAllowed != null && ec.Excludes("roamingPasskeyAllowed",true))
        {
            this.RoamingPasskeyAllowed = null;
        }
    }


    #endregion

    } // class PasskeyConfig
    
    #endregion

    public static class ListPasskeyConfigExtensions
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
            this List<PasskeyConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PasskeyConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PasskeyConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PasskeyConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PasskeyConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types