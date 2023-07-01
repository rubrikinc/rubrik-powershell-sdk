// GetMountDetailsReply.cs
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
    #region GetMountDetailsReply
    public class GetMountDetailsReply: BaseType
    {
        #region members

        //      C# -> List<LiveMountDetails>? MountDetails
        // GraphQL -> mountDetails: [LiveMountDetails!]! (type)
        [JsonProperty("mountDetails")]
        public List<LiveMountDetails>? MountDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetMountDetailsReply";
    }

    public GetMountDetailsReply Set(
        List<LiveMountDetails>? MountDetails = null
    ) 
    {
        if ( MountDetails != null ) {
            this.MountDetails = MountDetails;
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
        //      C# -> List<LiveMountDetails>? MountDetails
        // GraphQL -> mountDetails: [LiveMountDetails!]! (type)
        if (this.MountDetails != null) {
            var fspec = this.MountDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mountDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<LiveMountDetails>? MountDetails
        // GraphQL -> mountDetails: [LiveMountDetails!]! (type)
        if (this.MountDetails == null && Exploration.Includes(parent + ".mountDetails"))
        {
            this.MountDetails = new List<LiveMountDetails>();
            this.MountDetails.ApplyExploratoryFieldSpec(parent + ".mountDetails");
        }
    }


    #endregion

    } // class GetMountDetailsReply
    
    #endregion

    public static class ListGetMountDetailsReplyExtensions
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
            this List<GetMountDetailsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetMountDetailsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetMountDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types