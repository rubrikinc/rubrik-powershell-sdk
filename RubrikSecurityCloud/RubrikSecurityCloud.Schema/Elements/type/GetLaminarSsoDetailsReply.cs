// GetLaminarSsoDetailsReply.cs
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
    #region GetLaminarSsoDetailsReply
    public class GetLaminarSsoDetailsReply: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationUrl
        // GraphQL -> applicationUrl: String! (scalar)
        [JsonProperty("applicationUrl")]
        public System.String? ApplicationUrl { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? LaminarTenant
        // GraphQL -> laminarTenant: String! (scalar)
        [JsonProperty("laminarTenant")]
        public System.String? LaminarTenant { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetLaminarSSODetailsReply";
    }

    public GetLaminarSsoDetailsReply Set(
        System.String? ApplicationUrl = null,
        System.String? ClusterId = null,
        System.String? LaminarTenant = null
    ) 
    {
        if ( ApplicationUrl != null ) {
            this.ApplicationUrl = ApplicationUrl;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( LaminarTenant != null ) {
            this.LaminarTenant = LaminarTenant;
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
        //      C# -> System.String? ApplicationUrl
        // GraphQL -> applicationUrl: String! (scalar)
        if (this.ApplicationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationUrl\n" ;
            } else {
                s += ind + "applicationUrl\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? LaminarTenant
        // GraphQL -> laminarTenant: String! (scalar)
        if (this.LaminarTenant != null) {
            if (conf.Flat) {
                s += conf.Prefix + "laminarTenant\n" ;
            } else {
                s += ind + "laminarTenant\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ApplicationUrl
        // GraphQL -> applicationUrl: String! (scalar)
        if (ec.Includes("applicationUrl",true))
        {
            if(this.ApplicationUrl == null) {

                this.ApplicationUrl = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationUrl != null && ec.Excludes("applicationUrl",true))
        {
            this.ApplicationUrl = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? LaminarTenant
        // GraphQL -> laminarTenant: String! (scalar)
        if (ec.Includes("laminarTenant",true))
        {
            if(this.LaminarTenant == null) {

                this.LaminarTenant = "FETCH";

            } else {


            }
        }
        else if (this.LaminarTenant != null && ec.Excludes("laminarTenant",true))
        {
            this.LaminarTenant = null;
        }
    }


    #endregion

    } // class GetLaminarSsoDetailsReply
    
    #endregion

    public static class ListGetLaminarSsoDetailsReplyExtensions
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
            this List<GetLaminarSsoDetailsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetLaminarSsoDetailsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetLaminarSsoDetailsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetLaminarSsoDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetLaminarSsoDetailsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types