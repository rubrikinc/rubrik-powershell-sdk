// CreateVsphereVcenterReply.cs
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
    #region CreateVsphereVcenterReply
    public class CreateVsphereVcenterReply: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        [JsonProperty("isHotAddProxyEnabledForOnPremVcenter")]
        public System.Boolean? IsHotAddProxyEnabledForOnPremVcenter { get; set; }

        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        [JsonProperty("isVmc")]
        public System.Boolean? IsVmc { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateVsphereVcenterReply";
    }

    public CreateVsphereVcenterReply Set(
        System.String? Id = null,
        System.Boolean? IsHotAddProxyEnabledForOnPremVcenter = null,
        System.Boolean? IsVmc = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHotAddProxyEnabledForOnPremVcenter != null ) {
            this.IsHotAddProxyEnabledForOnPremVcenter = IsHotAddProxyEnabledForOnPremVcenter;
        }
        if ( IsVmc != null ) {
            this.IsVmc = IsVmc;
        }
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHotAddProxyEnabledForOnPremVcenter\n" ;
            } else {
                s += ind + "isHotAddProxyEnabledForOnPremVcenter\n" ;
            }
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        if (this.IsVmc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVmc\n" ;
            } else {
                s += ind + "isVmc\n" ;
            }
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(conf.Child("asyncRequestStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (ec.Includes("isHotAddProxyEnabledForOnPremVcenter",true))
        {
            if(this.IsHotAddProxyEnabledForOnPremVcenter == null) {

                this.IsHotAddProxyEnabledForOnPremVcenter = true;

            } else {


            }
        }
        else if (this.IsHotAddProxyEnabledForOnPremVcenter != null && ec.Excludes("isHotAddProxyEnabledForOnPremVcenter",true))
        {
            this.IsHotAddProxyEnabledForOnPremVcenter = null;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        if (ec.Includes("isVmc",true))
        {
            if(this.IsVmc == null) {

                this.IsVmc = true;

            } else {


            }
        }
        else if (this.IsVmc != null && ec.Excludes("isVmc",true))
        {
            this.IsVmc = null;
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (ec.Includes("asyncRequestStatus",false))
        {
            if(this.AsyncRequestStatus == null) {

                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            } else {

                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            }
        }
        else if (this.AsyncRequestStatus != null && ec.Excludes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = null;
        }
    }


    #endregion

    } // class CreateVsphereVcenterReply
    
    #endregion

    public static class ListCreateVsphereVcenterReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CreateVsphereVcenterReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateVsphereVcenterReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateVsphereVcenterReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateVsphereVcenterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateVsphereVcenterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types