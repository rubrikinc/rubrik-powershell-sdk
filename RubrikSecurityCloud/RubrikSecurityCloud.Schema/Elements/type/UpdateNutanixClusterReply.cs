// UpdateNutanixClusterReply.cs
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
    #region UpdateNutanixClusterReply
    public class UpdateNutanixClusterReply: BaseType
    {
        #region members

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        [JsonProperty("nutanixClusterSummary")]
        public NutanixClusterSummary? NutanixClusterSummary { get; set; }


        #endregion

    #region methods

    public UpdateNutanixClusterReply Set(
        System.String? CaCerts = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        NutanixClusterSummary? NutanixClusterSummary = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( NutanixClusterSummary != null ) {
            this.NutanixClusterSummary = NutanixClusterSummary;
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
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        if (this.CaCerts != null) {
            s += ind + "caCerts\n" ;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        if (this.NutanixClusterSummary != null) {
            var fspec = this.NutanixClusterSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nutanixClusterSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts", true))
        {
            this.CaCerts = "FETCH";
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new RefreshableObjectConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        if (this.NutanixClusterSummary == null && Exploration.Includes(parent + ".nutanixClusterSummary"))
        {
            this.NutanixClusterSummary = new NutanixClusterSummary();
            this.NutanixClusterSummary.ApplyExploratoryFieldSpec(parent + ".nutanixClusterSummary");
        }
    }


    #endregion

    } // class UpdateNutanixClusterReply
    
    #endregion

    public static class ListUpdateNutanixClusterReplyExtensions
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
            this List<UpdateNutanixClusterReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNutanixClusterReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNutanixClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types