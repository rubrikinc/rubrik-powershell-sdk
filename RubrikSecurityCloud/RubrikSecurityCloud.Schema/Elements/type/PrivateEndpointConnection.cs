// PrivateEndpointConnection.cs
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
    #region PrivateEndpointConnection
    public class PrivateEndpointConnection: BaseType
    {
        #region members

        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        [JsonProperty("privateEndpointConnectionStatus")]
        public PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus { get; set; }

        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        [JsonProperty("privateEndpointId")]
        public System.String? PrivateEndpointId { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrivateEndpointConnection";
    }

    public PrivateEndpointConnection Set(
        PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus = null,
        System.String? PrivateEndpointId = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( PrivateEndpointConnectionStatus != null ) {
            this.PrivateEndpointConnectionStatus = PrivateEndpointConnectionStatus;
        }
        if ( PrivateEndpointId != null ) {
            this.PrivateEndpointId = PrivateEndpointId;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        if (this.PrivateEndpointConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privateEndpointConnectionStatus\n" ;
            } else {
                s += ind + "privateEndpointConnectionStatus\n" ;
            }
        }
        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        if (this.PrivateEndpointId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privateEndpointId\n" ;
            } else {
                s += ind + "privateEndpointId\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        if (ec.Includes("privateEndpointConnectionStatus",true))
        {
            if(this.PrivateEndpointConnectionStatus == null) {

                this.PrivateEndpointConnectionStatus = new PrivateEndpointConnectionStatus();

            } else {


            }
        }
        else if (this.PrivateEndpointConnectionStatus != null && ec.Excludes("privateEndpointConnectionStatus",true))
        {
            this.PrivateEndpointConnectionStatus = null;
        }
        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        if (ec.Includes("privateEndpointId",true))
        {
            if(this.PrivateEndpointId == null) {

                this.PrivateEndpointId = "FETCH";

            } else {


            }
        }
        else if (this.PrivateEndpointId != null && ec.Excludes("privateEndpointId",true))
        {
            this.PrivateEndpointId = null;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
    }


    #endregion

    } // class PrivateEndpointConnection
    
    #endregion

    public static class ListPrivateEndpointConnectionExtensions
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
            this List<PrivateEndpointConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrivateEndpointConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrivateEndpointConnection> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrivateEndpointConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrivateEndpointConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types