// AwsAuthServerDetail.cs
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
    #region AwsAuthServerDetail
    public class AwsAuthServerDetail: BaseType
    {
        #region members

        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        [JsonProperty("authServerAwsRegions")]
        public List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions { get; set; }

        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        [JsonProperty("authServerCaCertId")]
        public System.Int64? AuthServerCaCertId { get; set; }

        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        [JsonProperty("authServerHostName")]
        public System.String? AuthServerHostName { get; set; }

        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        [JsonProperty("authServerUserClientCertId")]
        public System.Int64? AuthServerUserClientCertId { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsAuthServerDetail";
    }

    public AwsAuthServerDetail Set(
        List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions = null,
        System.String? Agency = null,
        System.Int64? AuthServerCaCertId = null,
        System.String? AuthServerHostName = null,
        System.Int64? AuthServerUserClientCertId = null,
        System.String? RoleName = null
    ) 
    {
        if ( AuthServerAwsRegions != null ) {
            this.AuthServerAwsRegions = AuthServerAwsRegions;
        }
        if ( Agency != null ) {
            this.Agency = Agency;
        }
        if ( AuthServerCaCertId != null ) {
            this.AuthServerCaCertId = AuthServerCaCertId;
        }
        if ( AuthServerHostName != null ) {
            this.AuthServerHostName = AuthServerHostName;
        }
        if ( AuthServerUserClientCertId != null ) {
            this.AuthServerUserClientCertId = AuthServerUserClientCertId;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
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
        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        if (this.AuthServerAwsRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerAwsRegions\n" ;
            } else {
                s += ind + "authServerAwsRegions\n" ;
            }
        }
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (this.Agency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agency\n" ;
            } else {
                s += ind + "agency\n" ;
            }
        }
        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        if (this.AuthServerCaCertId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerCaCertId\n" ;
            } else {
                s += ind + "authServerCaCertId\n" ;
            }
        }
        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        if (this.AuthServerHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerHostName\n" ;
            } else {
                s += ind + "authServerHostName\n" ;
            }
        }
        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        if (this.AuthServerUserClientCertId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerUserClientCertId\n" ;
            } else {
                s += ind + "authServerUserClientCertId\n" ;
            }
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleName\n" ;
            } else {
                s += ind + "roleName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        if (ec.Includes("authServerAwsRegions",true))
        {
            if(this.AuthServerAwsRegions == null) {

                this.AuthServerAwsRegions = new List<AwsAuthServerBasedCloudAccountRegion>();

            } else {


            }
        }
        else if (this.AuthServerAwsRegions != null && ec.Excludes("authServerAwsRegions",true))
        {
            this.AuthServerAwsRegions = null;
        }
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (ec.Includes("agency",true))
        {
            if(this.Agency == null) {

                this.Agency = "FETCH";

            } else {


            }
        }
        else if (this.Agency != null && ec.Excludes("agency",true))
        {
            this.Agency = null;
        }
        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        if (ec.Includes("authServerCaCertId",true))
        {
            if(this.AuthServerCaCertId == null) {

                this.AuthServerCaCertId = new System.Int64();

            } else {


            }
        }
        else if (this.AuthServerCaCertId != null && ec.Excludes("authServerCaCertId",true))
        {
            this.AuthServerCaCertId = null;
        }
        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        if (ec.Includes("authServerHostName",true))
        {
            if(this.AuthServerHostName == null) {

                this.AuthServerHostName = "FETCH";

            } else {


            }
        }
        else if (this.AuthServerHostName != null && ec.Excludes("authServerHostName",true))
        {
            this.AuthServerHostName = null;
        }
        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        if (ec.Includes("authServerUserClientCertId",true))
        {
            if(this.AuthServerUserClientCertId == null) {

                this.AuthServerUserClientCertId = new System.Int64();

            } else {


            }
        }
        else if (this.AuthServerUserClientCertId != null && ec.Excludes("authServerUserClientCertId",true))
        {
            this.AuthServerUserClientCertId = null;
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (ec.Includes("roleName",true))
        {
            if(this.RoleName == null) {

                this.RoleName = "FETCH";

            } else {


            }
        }
        else if (this.RoleName != null && ec.Excludes("roleName",true))
        {
            this.RoleName = null;
        }
    }


    #endregion

    } // class AwsAuthServerDetail
    
    #endregion

    public static class ListAwsAuthServerDetailExtensions
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
            this List<AwsAuthServerDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsAuthServerDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsAuthServerDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsAuthServerDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsAuthServerDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types