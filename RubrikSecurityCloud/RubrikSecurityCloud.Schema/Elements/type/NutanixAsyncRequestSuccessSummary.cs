// NutanixAsyncRequestSuccessSummary.cs
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
    #region NutanixAsyncRequestSuccessSummary
    public class NutanixAsyncRequestSuccessSummary: BaseType
    {
        #region members

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixAsyncRequestSuccessSummary";
    }

    public NutanixAsyncRequestSuccessSummary Set(
        System.String? VmId = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = "FETCH";
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(parent + ".asyncRequestStatus");
        }
    }


    #endregion

    } // class NutanixAsyncRequestSuccessSummary
    
    #endregion

    public static class ListNutanixAsyncRequestSuccessSummaryExtensions
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
            this List<NutanixAsyncRequestSuccessSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixAsyncRequestSuccessSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixAsyncRequestSuccessSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types