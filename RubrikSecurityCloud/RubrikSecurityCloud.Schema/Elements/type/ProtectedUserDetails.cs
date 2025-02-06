// ProtectedUserDetails.cs
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
    #region ProtectedUserDetails
    public class ProtectedUserDetails: BaseType
    {
        #region members

        //      C# -> System.Int32? ResourceMailboxProtected
        // GraphQL -> resourceMailboxProtected: Int (scalar)
        [JsonProperty("resourceMailboxProtected")]
        public System.Int32? ResourceMailboxProtected { get; set; }

        //      C# -> System.Int32? SharedMailboxProtected
        // GraphQL -> sharedMailboxProtected: Int (scalar)
        [JsonProperty("sharedMailboxProtected")]
        public System.Int32? SharedMailboxProtected { get; set; }

        //      C# -> System.Int32? UnlicensedOnedriveProtected
        // GraphQL -> unlicensedOnedriveProtected: Int (scalar)
        [JsonProperty("unlicensedOnedriveProtected")]
        public System.Int32? UnlicensedOnedriveProtected { get; set; }

        //      C# -> System.Int32? UnlicensedResourceMailboxProtected
        // GraphQL -> unlicensedResourceMailboxProtected: Int (scalar)
        [JsonProperty("unlicensedResourceMailboxProtected")]
        public System.Int32? UnlicensedResourceMailboxProtected { get; set; }

        //      C# -> System.Int32? UnlicensedSharedMailboxProtected
        // GraphQL -> unlicensedSharedMailboxProtected: Int (scalar)
        [JsonProperty("unlicensedSharedMailboxProtected")]
        public System.Int32? UnlicensedSharedMailboxProtected { get; set; }

        //      C# -> System.Int32? UnlicensedUserMailboxProtected
        // GraphQL -> unlicensedUserMailboxProtected: Int (scalar)
        [JsonProperty("unlicensedUserMailboxProtected")]
        public System.Int32? UnlicensedUserMailboxProtected { get; set; }

        //      C# -> System.Int32? UserMailboxProtected
        // GraphQL -> userMailboxProtected: Int (scalar)
        [JsonProperty("userMailboxProtected")]
        public System.Int32? UserMailboxProtected { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectedUserDetails";
    }

    public ProtectedUserDetails Set(
        System.Int32? ResourceMailboxProtected = null,
        System.Int32? SharedMailboxProtected = null,
        System.Int32? UnlicensedOnedriveProtected = null,
        System.Int32? UnlicensedResourceMailboxProtected = null,
        System.Int32? UnlicensedSharedMailboxProtected = null,
        System.Int32? UnlicensedUserMailboxProtected = null,
        System.Int32? UserMailboxProtected = null
    ) 
    {
        if ( ResourceMailboxProtected != null ) {
            this.ResourceMailboxProtected = ResourceMailboxProtected;
        }
        if ( SharedMailboxProtected != null ) {
            this.SharedMailboxProtected = SharedMailboxProtected;
        }
        if ( UnlicensedOnedriveProtected != null ) {
            this.UnlicensedOnedriveProtected = UnlicensedOnedriveProtected;
        }
        if ( UnlicensedResourceMailboxProtected != null ) {
            this.UnlicensedResourceMailboxProtected = UnlicensedResourceMailboxProtected;
        }
        if ( UnlicensedSharedMailboxProtected != null ) {
            this.UnlicensedSharedMailboxProtected = UnlicensedSharedMailboxProtected;
        }
        if ( UnlicensedUserMailboxProtected != null ) {
            this.UnlicensedUserMailboxProtected = UnlicensedUserMailboxProtected;
        }
        if ( UserMailboxProtected != null ) {
            this.UserMailboxProtected = UserMailboxProtected;
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
        //      C# -> System.Int32? ResourceMailboxProtected
        // GraphQL -> resourceMailboxProtected: Int (scalar)
        if (this.ResourceMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceMailboxProtected\n" ;
            } else {
                s += ind + "resourceMailboxProtected\n" ;
            }
        }
        //      C# -> System.Int32? SharedMailboxProtected
        // GraphQL -> sharedMailboxProtected: Int (scalar)
        if (this.SharedMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharedMailboxProtected\n" ;
            } else {
                s += ind + "sharedMailboxProtected\n" ;
            }
        }
        //      C# -> System.Int32? UnlicensedOnedriveProtected
        // GraphQL -> unlicensedOnedriveProtected: Int (scalar)
        if (this.UnlicensedOnedriveProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlicensedOnedriveProtected\n" ;
            } else {
                s += ind + "unlicensedOnedriveProtected\n" ;
            }
        }
        //      C# -> System.Int32? UnlicensedResourceMailboxProtected
        // GraphQL -> unlicensedResourceMailboxProtected: Int (scalar)
        if (this.UnlicensedResourceMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlicensedResourceMailboxProtected\n" ;
            } else {
                s += ind + "unlicensedResourceMailboxProtected\n" ;
            }
        }
        //      C# -> System.Int32? UnlicensedSharedMailboxProtected
        // GraphQL -> unlicensedSharedMailboxProtected: Int (scalar)
        if (this.UnlicensedSharedMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlicensedSharedMailboxProtected\n" ;
            } else {
                s += ind + "unlicensedSharedMailboxProtected\n" ;
            }
        }
        //      C# -> System.Int32? UnlicensedUserMailboxProtected
        // GraphQL -> unlicensedUserMailboxProtected: Int (scalar)
        if (this.UnlicensedUserMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlicensedUserMailboxProtected\n" ;
            } else {
                s += ind + "unlicensedUserMailboxProtected\n" ;
            }
        }
        //      C# -> System.Int32? UserMailboxProtected
        // GraphQL -> userMailboxProtected: Int (scalar)
        if (this.UserMailboxProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userMailboxProtected\n" ;
            } else {
                s += ind + "userMailboxProtected\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ResourceMailboxProtected
        // GraphQL -> resourceMailboxProtected: Int (scalar)
        if (ec.Includes("resourceMailboxProtected",true))
        {
            if(this.ResourceMailboxProtected == null) {

                this.ResourceMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceMailboxProtected != null && ec.Excludes("resourceMailboxProtected",true))
        {
            this.ResourceMailboxProtected = null;
        }
        //      C# -> System.Int32? SharedMailboxProtected
        // GraphQL -> sharedMailboxProtected: Int (scalar)
        if (ec.Includes("sharedMailboxProtected",true))
        {
            if(this.SharedMailboxProtected == null) {

                this.SharedMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.SharedMailboxProtected != null && ec.Excludes("sharedMailboxProtected",true))
        {
            this.SharedMailboxProtected = null;
        }
        //      C# -> System.Int32? UnlicensedOnedriveProtected
        // GraphQL -> unlicensedOnedriveProtected: Int (scalar)
        if (ec.Includes("unlicensedOnedriveProtected",true))
        {
            if(this.UnlicensedOnedriveProtected == null) {

                this.UnlicensedOnedriveProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnlicensedOnedriveProtected != null && ec.Excludes("unlicensedOnedriveProtected",true))
        {
            this.UnlicensedOnedriveProtected = null;
        }
        //      C# -> System.Int32? UnlicensedResourceMailboxProtected
        // GraphQL -> unlicensedResourceMailboxProtected: Int (scalar)
        if (ec.Includes("unlicensedResourceMailboxProtected",true))
        {
            if(this.UnlicensedResourceMailboxProtected == null) {

                this.UnlicensedResourceMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnlicensedResourceMailboxProtected != null && ec.Excludes("unlicensedResourceMailboxProtected",true))
        {
            this.UnlicensedResourceMailboxProtected = null;
        }
        //      C# -> System.Int32? UnlicensedSharedMailboxProtected
        // GraphQL -> unlicensedSharedMailboxProtected: Int (scalar)
        if (ec.Includes("unlicensedSharedMailboxProtected",true))
        {
            if(this.UnlicensedSharedMailboxProtected == null) {

                this.UnlicensedSharedMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnlicensedSharedMailboxProtected != null && ec.Excludes("unlicensedSharedMailboxProtected",true))
        {
            this.UnlicensedSharedMailboxProtected = null;
        }
        //      C# -> System.Int32? UnlicensedUserMailboxProtected
        // GraphQL -> unlicensedUserMailboxProtected: Int (scalar)
        if (ec.Includes("unlicensedUserMailboxProtected",true))
        {
            if(this.UnlicensedUserMailboxProtected == null) {

                this.UnlicensedUserMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnlicensedUserMailboxProtected != null && ec.Excludes("unlicensedUserMailboxProtected",true))
        {
            this.UnlicensedUserMailboxProtected = null;
        }
        //      C# -> System.Int32? UserMailboxProtected
        // GraphQL -> userMailboxProtected: Int (scalar)
        if (ec.Includes("userMailboxProtected",true))
        {
            if(this.UserMailboxProtected == null) {

                this.UserMailboxProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UserMailboxProtected != null && ec.Excludes("userMailboxProtected",true))
        {
            this.UserMailboxProtected = null;
        }
    }


    #endregion

    } // class ProtectedUserDetails
    
    #endregion

    public static class ListProtectedUserDetailsExtensions
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
            this List<ProtectedUserDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProtectedUserDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectedUserDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectedUserDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectedUserDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types