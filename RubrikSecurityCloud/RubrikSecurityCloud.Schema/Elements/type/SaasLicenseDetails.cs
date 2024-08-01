// SaasLicenseDetails.cs
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
    #region SaasLicenseDetails
    public class SaasLicenseDetails: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        [JsonProperty("licenseName")]
        public System.String? LicenseName { get; set; }

        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        [JsonProperty("licensedUsers")]
        public System.Int32? LicensedUsers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasLicenseDetails";
    }

    public SaasLicenseDetails Set(
        DateTime? ExpirationTime = null,
        System.String? LicenseName = null,
        System.Int32? LicensedUsers = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( LicenseName != null ) {
            this.LicenseName = LicenseName;
        }
        if ( LicensedUsers != null ) {
            this.LicensedUsers = LicensedUsers;
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
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
            }
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        if (this.LicenseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "licenseName\n" ;
            } else {
                s += ind + "licenseName\n" ;
            }
        }
        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        if (this.LicensedUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "licensedUsers\n" ;
            } else {
                s += ind + "licensedUsers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        if (ec.Includes("licenseName",true))
        {
            if(this.LicenseName == null) {

                this.LicenseName = "FETCH";

            } else {


            }
        }
        else if (this.LicenseName != null && ec.Excludes("licenseName",true))
        {
            this.LicenseName = null;
        }
        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        if (ec.Includes("licensedUsers",true))
        {
            if(this.LicensedUsers == null) {

                this.LicensedUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.LicensedUsers != null && ec.Excludes("licensedUsers",true))
        {
            this.LicensedUsers = null;
        }
    }


    #endregion

    } // class SaasLicenseDetails
    
    #endregion

    public static class ListSaasLicenseDetailsExtensions
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
            this List<SaasLicenseDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasLicenseDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasLicenseDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasLicenseDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasLicenseDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types