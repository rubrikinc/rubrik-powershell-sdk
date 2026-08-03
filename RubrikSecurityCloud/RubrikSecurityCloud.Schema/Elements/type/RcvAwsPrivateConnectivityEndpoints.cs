// RcvAwsPrivateConnectivityEndpoints.cs
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
    #region RcvAwsPrivateConnectivityEndpoints
    public class RcvAwsPrivateConnectivityEndpoints: BaseType
    {
        #region members

        //      C# -> System.String? S3EndpointHost
        // GraphQL -> s3EndpointHost: String (scalar)
        [JsonProperty("s3EndpointHost")]
        public System.String? S3EndpointHost { get; set; }

        //      C# -> System.String? StsEndpointHost
        // GraphQL -> stsEndpointHost: String (scalar)
        [JsonProperty("stsEndpointHost")]
        public System.String? StsEndpointHost { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvAwsPrivateConnectivityEndpoints";
    }

    public RcvAwsPrivateConnectivityEndpoints Set(
        System.String? S3EndpointHost = null,
        System.String? StsEndpointHost = null
    ) 
    {
        if ( S3EndpointHost != null ) {
            this.S3EndpointHost = S3EndpointHost;
        }
        if ( StsEndpointHost != null ) {
            this.StsEndpointHost = StsEndpointHost;
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
        //      C# -> System.String? S3EndpointHost
        // GraphQL -> s3EndpointHost: String (scalar)
        if (this.S3EndpointHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3EndpointHost\n" ;
            } else {
                s += ind + "s3EndpointHost\n" ;
            }
        }
        //      C# -> System.String? StsEndpointHost
        // GraphQL -> stsEndpointHost: String (scalar)
        if (this.StsEndpointHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stsEndpointHost\n" ;
            } else {
                s += ind + "stsEndpointHost\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? S3EndpointHost
        // GraphQL -> s3EndpointHost: String (scalar)
        if (ec.Includes("s3EndpointHost",true))
        {
            if(this.S3EndpointHost == null) {

                this.S3EndpointHost = "FETCH";

            } else {


            }
        }
        else if (this.S3EndpointHost != null && ec.Excludes("s3EndpointHost",true))
        {
            this.S3EndpointHost = null;
        }
        //      C# -> System.String? StsEndpointHost
        // GraphQL -> stsEndpointHost: String (scalar)
        if (ec.Includes("stsEndpointHost",true))
        {
            if(this.StsEndpointHost == null) {

                this.StsEndpointHost = "FETCH";

            } else {


            }
        }
        else if (this.StsEndpointHost != null && ec.Excludes("stsEndpointHost",true))
        {
            this.StsEndpointHost = null;
        }
    }


    #endregion

    } // class RcvAwsPrivateConnectivityEndpoints
    
    #endregion

    public static class ListRcvAwsPrivateConnectivityEndpointsExtensions
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
            this List<RcvAwsPrivateConnectivityEndpoints> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvAwsPrivateConnectivityEndpoints> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvAwsPrivateConnectivityEndpoints> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvAwsPrivateConnectivityEndpoints());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvAwsPrivateConnectivityEndpoints> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types