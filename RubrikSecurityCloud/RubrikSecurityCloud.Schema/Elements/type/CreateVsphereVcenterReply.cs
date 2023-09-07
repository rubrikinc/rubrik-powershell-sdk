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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter != null) {
            s += ind + "isHotAddProxyEnabledForOnPremVcenter\n" ;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        if (this.IsVmc != null) {
            s += ind + "isVmc\n" ;
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter == null && ec.Includes("isHotAddProxyEnabledForOnPremVcenter",true))
        {
            this.IsHotAddProxyEnabledForOnPremVcenter = true;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        if (this.IsVmc == null && ec.Includes("isVmc",true))
        {
            this.IsVmc = true;
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && ec.Includes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<CreateVsphereVcenterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types