// ReleaseThreatHuntMatchesFromQuarantineReply.cs
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
    #region ReleaseThreatHuntMatchesFromQuarantineReply
    public class ReleaseThreatHuntMatchesFromQuarantineReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsReleaseFromQuarantineSuccessful
        // GraphQL -> isReleaseFromQuarantineSuccessful: Boolean! (scalar)
        [JsonProperty("isReleaseFromQuarantineSuccessful")]
        public System.Boolean? IsReleaseFromQuarantineSuccessful { get; set; }


        #endregion

    #region methods

    public ReleaseThreatHuntMatchesFromQuarantineReply Set(
        System.Boolean? IsReleaseFromQuarantineSuccessful = null
    ) 
    {
        if ( IsReleaseFromQuarantineSuccessful != null ) {
            this.IsReleaseFromQuarantineSuccessful = IsReleaseFromQuarantineSuccessful;
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
        //      C# -> System.Boolean? IsReleaseFromQuarantineSuccessful
        // GraphQL -> isReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (this.IsReleaseFromQuarantineSuccessful != null) {
            s += ind + "isReleaseFromQuarantineSuccessful\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsReleaseFromQuarantineSuccessful
        // GraphQL -> isReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (this.IsReleaseFromQuarantineSuccessful == null && Exploration.Includes(parent + ".isReleaseFromQuarantineSuccessful", true))
        {
            this.IsReleaseFromQuarantineSuccessful = true;
        }
    }


    #endregion

    } // class ReleaseThreatHuntMatchesFromQuarantineReply
    
    #endregion

    public static class ListReleaseThreatHuntMatchesFromQuarantineReplyExtensions
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
            this List<ReleaseThreatHuntMatchesFromQuarantineReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReleaseThreatHuntMatchesFromQuarantineReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReleaseThreatHuntMatchesFromQuarantineReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types