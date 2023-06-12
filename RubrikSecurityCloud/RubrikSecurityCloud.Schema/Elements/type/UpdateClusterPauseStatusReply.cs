// UpdateClusterPauseStatusReply.cs
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
    #region UpdateClusterPauseStatusReply
    public class UpdateClusterPauseStatusReply: BaseType
    {
        #region members

        //      C# -> List<ClusterPauseStatusResult>? PauseStatuses
        // GraphQL -> pauseStatuses: [ClusterPauseStatusResult!] (type)
        [JsonProperty("pauseStatuses")]
        public List<ClusterPauseStatusResult>? PauseStatuses { get; set; }


        #endregion

    #region methods

    public UpdateClusterPauseStatusReply Set(
        List<ClusterPauseStatusResult>? PauseStatuses = null
    ) 
    {
        if ( PauseStatuses != null ) {
            this.PauseStatuses = PauseStatuses;
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
        //      C# -> List<ClusterPauseStatusResult>? PauseStatuses
        // GraphQL -> pauseStatuses: [ClusterPauseStatusResult!] (type)
        if (this.PauseStatuses != null) {
            var fspec = this.PauseStatuses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pauseStatuses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ClusterPauseStatusResult>? PauseStatuses
        // GraphQL -> pauseStatuses: [ClusterPauseStatusResult!] (type)
        if (this.PauseStatuses == null && Exploration.Includes(parent + ".pauseStatuses"))
        {
            this.PauseStatuses = new List<ClusterPauseStatusResult>();
            this.PauseStatuses.ApplyExploratoryFieldSpec(parent + ".pauseStatuses");
        }
    }


    #endregion

    } // class UpdateClusterPauseStatusReply
    
    #endregion

    public static class ListUpdateClusterPauseStatusReplyExtensions
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
            this List<UpdateClusterPauseStatusReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateClusterPauseStatusReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateClusterPauseStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types