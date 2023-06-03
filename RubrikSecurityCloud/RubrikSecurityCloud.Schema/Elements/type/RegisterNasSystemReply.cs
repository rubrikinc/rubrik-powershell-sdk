// RegisterNasSystemReply.cs
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
    #region RegisterNasSystemReply
    public class RegisterNasSystemReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        [JsonProperty("nasDiscoverJobStatus")]
        public AsyncRequestStatus? NasDiscoverJobStatus { get; set; }

        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        [JsonProperty("nasSystemSummary")]
        public UpdateNasSystemReply? NasSystemSummary { get; set; }


        #endregion

    #region methods

    public RegisterNasSystemReply Set(
        AsyncRequestStatus? NasDiscoverJobStatus = null,
        UpdateNasSystemReply? NasSystemSummary = null
    ) 
    {
        if ( NasDiscoverJobStatus != null ) {
            this.NasDiscoverJobStatus = NasDiscoverJobStatus;
        }
        if ( NasSystemSummary != null ) {
            this.NasSystemSummary = NasSystemSummary;
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
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (this.NasDiscoverJobStatus != null) {
            s += ind + "nasDiscoverJobStatus {\n" + this.NasDiscoverJobStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        if (this.NasSystemSummary != null) {
            s += ind + "nasSystemSummary {\n" + this.NasSystemSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (this.NasDiscoverJobStatus == null && Exploration.Includes(parent + ".nasDiscoverJobStatus"))
        {
            this.NasDiscoverJobStatus = new AsyncRequestStatus();
            this.NasDiscoverJobStatus.ApplyExploratoryFieldSpec(parent + ".nasDiscoverJobStatus");
        }
        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        if (this.NasSystemSummary == null && Exploration.Includes(parent + ".nasSystemSummary"))
        {
            this.NasSystemSummary = new UpdateNasSystemReply();
            this.NasSystemSummary.ApplyExploratoryFieldSpec(parent + ".nasSystemSummary");
        }
    }


    #endregion

    } // class RegisterNasSystemReply
    
    #endregion

    public static class ListRegisterNasSystemReplyExtensions
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
            this List<RegisterNasSystemReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RegisterNasSystemReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RegisterNasSystemReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types