// CdmUpgradeRecommendationReply.cs
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
    #region CdmUpgradeRecommendationReply
    public class CdmUpgradeRecommendationReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        [JsonProperty("isRecommended")]
        public System.Boolean? IsRecommended { get; set; }

        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        [JsonProperty("status")]
        public StatusResponse? Status { get; set; }


        #endregion

    #region methods

    public CdmUpgradeRecommendationReply Set(
        System.Boolean? IsRecommended = null,
        StatusResponse? Status = null
    ) 
    {
        if ( IsRecommended != null ) {
            this.IsRecommended = IsRecommended;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (this.IsRecommended != null) {
            s += ind + "isRecommended\n" ;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status != null) {
            s += ind + "status {\n" + this.Status.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (this.IsRecommended == null && Exploration.Includes(parent + ".isRecommended", true))
        {
            this.IsRecommended = true;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new StatusResponse();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
        }
    }


    #endregion

    } // class CdmUpgradeRecommendationReply
    
    #endregion

    public static class ListCdmUpgradeRecommendationReplyExtensions
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
            this List<CdmUpgradeRecommendationReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeRecommendationReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeRecommendationReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types