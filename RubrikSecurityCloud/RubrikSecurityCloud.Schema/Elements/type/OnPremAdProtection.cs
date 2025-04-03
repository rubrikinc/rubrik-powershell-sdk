// OnPremAdProtection.cs
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
    #region OnPremAdProtection
    public class OnPremAdProtection: BaseType
    {
        #region members

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Boolean? IsOnPremAdConnected
        // GraphQL -> isOnPremAdConnected: Boolean! (scalar)
        [JsonProperty("isOnPremAdConnected")]
        public System.Boolean? IsOnPremAdConnected { get; set; }

        //      C# -> System.Boolean? IsOnPremAdProtected
        // GraphQL -> isOnPremAdProtected: Boolean! (scalar)
        [JsonProperty("isOnPremAdProtected")]
        public System.Boolean? IsOnPremAdProtected { get; set; }

        //      C# -> System.Int32? NumSyncedGroups
        // GraphQL -> numSyncedGroups: Int! (scalar)
        [JsonProperty("numSyncedGroups")]
        public System.Int32? NumSyncedGroups { get; set; }

        //      C# -> System.Int32? NumSyncedUsers
        // GraphQL -> numSyncedUsers: Int! (scalar)
        [JsonProperty("numSyncedUsers")]
        public System.Int32? NumSyncedUsers { get; set; }

        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        [JsonProperty("onPremAdSecurityId")]
        public System.String? OnPremAdSecurityId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OnPremAdProtection";
    }

    public OnPremAdProtection Set(
        System.String? DomainName = null,
        System.Boolean? IsOnPremAdConnected = null,
        System.Boolean? IsOnPremAdProtected = null,
        System.Int32? NumSyncedGroups = null,
        System.Int32? NumSyncedUsers = null,
        System.String? OnPremAdSecurityId = null
    ) 
    {
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( IsOnPremAdConnected != null ) {
            this.IsOnPremAdConnected = IsOnPremAdConnected;
        }
        if ( IsOnPremAdProtected != null ) {
            this.IsOnPremAdProtected = IsOnPremAdProtected;
        }
        if ( NumSyncedGroups != null ) {
            this.NumSyncedGroups = NumSyncedGroups;
        }
        if ( NumSyncedUsers != null ) {
            this.NumSyncedUsers = NumSyncedUsers;
        }
        if ( OnPremAdSecurityId != null ) {
            this.OnPremAdSecurityId = OnPremAdSecurityId;
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
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnPremAdConnected
        // GraphQL -> isOnPremAdConnected: Boolean! (scalar)
        if (this.IsOnPremAdConnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnPremAdConnected\n" ;
            } else {
                s += ind + "isOnPremAdConnected\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnPremAdProtected
        // GraphQL -> isOnPremAdProtected: Boolean! (scalar)
        if (this.IsOnPremAdProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnPremAdProtected\n" ;
            } else {
                s += ind + "isOnPremAdProtected\n" ;
            }
        }
        //      C# -> System.Int32? NumSyncedGroups
        // GraphQL -> numSyncedGroups: Int! (scalar)
        if (this.NumSyncedGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSyncedGroups\n" ;
            } else {
                s += ind + "numSyncedGroups\n" ;
            }
        }
        //      C# -> System.Int32? NumSyncedUsers
        // GraphQL -> numSyncedUsers: Int! (scalar)
        if (this.NumSyncedUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSyncedUsers\n" ;
            } else {
                s += ind + "numSyncedUsers\n" ;
            }
        }
        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        if (this.OnPremAdSecurityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremAdSecurityId\n" ;
            } else {
                s += ind + "onPremAdSecurityId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.Boolean? IsOnPremAdConnected
        // GraphQL -> isOnPremAdConnected: Boolean! (scalar)
        if (ec.Includes("isOnPremAdConnected",true))
        {
            if(this.IsOnPremAdConnected == null) {

                this.IsOnPremAdConnected = true;

            } else {


            }
        }
        else if (this.IsOnPremAdConnected != null && ec.Excludes("isOnPremAdConnected",true))
        {
            this.IsOnPremAdConnected = null;
        }
        //      C# -> System.Boolean? IsOnPremAdProtected
        // GraphQL -> isOnPremAdProtected: Boolean! (scalar)
        if (ec.Includes("isOnPremAdProtected",true))
        {
            if(this.IsOnPremAdProtected == null) {

                this.IsOnPremAdProtected = true;

            } else {


            }
        }
        else if (this.IsOnPremAdProtected != null && ec.Excludes("isOnPremAdProtected",true))
        {
            this.IsOnPremAdProtected = null;
        }
        //      C# -> System.Int32? NumSyncedGroups
        // GraphQL -> numSyncedGroups: Int! (scalar)
        if (ec.Includes("numSyncedGroups",true))
        {
            if(this.NumSyncedGroups == null) {

                this.NumSyncedGroups = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSyncedGroups != null && ec.Excludes("numSyncedGroups",true))
        {
            this.NumSyncedGroups = null;
        }
        //      C# -> System.Int32? NumSyncedUsers
        // GraphQL -> numSyncedUsers: Int! (scalar)
        if (ec.Includes("numSyncedUsers",true))
        {
            if(this.NumSyncedUsers == null) {

                this.NumSyncedUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSyncedUsers != null && ec.Excludes("numSyncedUsers",true))
        {
            this.NumSyncedUsers = null;
        }
        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        if (ec.Includes("onPremAdSecurityId",true))
        {
            if(this.OnPremAdSecurityId == null) {

                this.OnPremAdSecurityId = "FETCH";

            } else {


            }
        }
        else if (this.OnPremAdSecurityId != null && ec.Excludes("onPremAdSecurityId",true))
        {
            this.OnPremAdSecurityId = null;
        }
    }


    #endregion

    } // class OnPremAdProtection
    
    #endregion

    public static class ListOnPremAdProtectionExtensions
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
            this List<OnPremAdProtection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OnPremAdProtection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OnPremAdProtection> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OnPremAdProtection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OnPremAdProtection> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types