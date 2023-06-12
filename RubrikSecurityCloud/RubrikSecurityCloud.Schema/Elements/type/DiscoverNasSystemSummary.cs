// DiscoverNasSystemSummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region DiscoverNasSystemSummary
    public class DiscoverNasSystemSummary: BaseType
    {
        #region members

        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        [JsonProperty("nasSystemId")]
        public System.String? NasSystemId { get; set; }

        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        [JsonProperty("nasDiscoverJobStatus")]
        public AsyncRequestStatus? NasDiscoverJobStatus { get; set; }


        #endregion

    #region methods

    public DiscoverNasSystemSummary Set(
        System.String? NasSystemId = null,
        AsyncRequestStatus? NasDiscoverJobStatus = null
    ) 
    {
        if ( NasSystemId != null ) {
            this.NasSystemId = NasSystemId;
        }
        if ( NasDiscoverJobStatus != null ) {
            this.NasDiscoverJobStatus = NasDiscoverJobStatus;
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
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (this.NasSystemId != null) {
            s += ind + "nasSystemId\n" ;
        }
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (this.NasDiscoverJobStatus != null) {
            var fspec = this.NasDiscoverJobStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nasDiscoverJobStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (this.NasSystemId == null && Exploration.Includes(parent + ".nasSystemId", true))
        {
            this.NasSystemId = "FETCH";
        }
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (this.NasDiscoverJobStatus == null && Exploration.Includes(parent + ".nasDiscoverJobStatus"))
        {
            this.NasDiscoverJobStatus = new AsyncRequestStatus();
            this.NasDiscoverJobStatus.ApplyExploratoryFieldSpec(parent + ".nasDiscoverJobStatus");
        }
    }


    #endregion

    } // class DiscoverNasSystemSummary
    
    #endregion

    public static class ListDiscoverNasSystemSummaryExtensions
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
            this List<DiscoverNasSystemSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DiscoverNasSystemSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DiscoverNasSystemSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types