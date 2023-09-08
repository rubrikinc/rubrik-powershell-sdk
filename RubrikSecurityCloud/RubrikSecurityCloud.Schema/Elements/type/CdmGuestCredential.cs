// CdmGuestCredential.cs
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
    #region CdmGuestCredential
    public class CdmGuestCredential: BaseType
    {
        #region members

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CreateGuestCredentialReply? Detail
        // GraphQL -> detail: CreateGuestCredentialReply! (type)
        [JsonProperty("detail")]
        public CreateGuestCredentialReply? Detail { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmGuestCredential";
    }

    public CdmGuestCredential Set(
        Cluster? Cluster = null,
        CreateGuestCredentialReply? Detail = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Detail != null ) {
            this.Detail = Detail;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CreateGuestCredentialReply? Detail
        // GraphQL -> detail: CreateGuestCredentialReply! (type)
        if (this.Detail != null) {
            var fspec = this.Detail.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "detail {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> CreateGuestCredentialReply? Detail
        // GraphQL -> detail: CreateGuestCredentialReply! (type)
        if (this.Detail == null && ec.Includes("detail",false))
        {
            this.Detail = new CreateGuestCredentialReply();
            this.Detail.ApplyExploratoryFieldSpec(ec.NewChild("detail"));
        }
    }


    #endregion

    } // class CdmGuestCredential
    
    #endregion

    public static class ListCdmGuestCredentialExtensions
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
            this List<CdmGuestCredential> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmGuestCredential> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmGuestCredential());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CdmGuestCredential> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types