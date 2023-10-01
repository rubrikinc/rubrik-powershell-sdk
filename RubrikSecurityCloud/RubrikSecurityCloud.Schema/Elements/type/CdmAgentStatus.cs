// CdmAgentStatus.cs
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
    #region CdmAgentStatus
    public class CdmAgentStatus: BaseType
    {
        #region members

        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        [JsonProperty("agentStatus")]
        public System.String? AgentStatus { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmAgentStatus";
    }

    public CdmAgentStatus Set(
        System.String? AgentStatus = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( DisconnectReason != null ) {
            this.DisconnectReason = DisconnectReason;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        if (this.AgentStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agentStatus\n" ;
            } else {
                s += ind + "agentStatus\n" ;
            }
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disconnectReason\n" ;
            } else {
                s += ind + "disconnectReason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        if (ec.Includes("agentStatus",true))
        {
            if(this.AgentStatus == null) {

                this.AgentStatus = "FETCH";

            } else {


            }
        }
        else if (this.AgentStatus != null && ec.Excludes("agentStatus",true))
        {
            this.AgentStatus = null;
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (ec.Includes("disconnectReason",true))
        {
            if(this.DisconnectReason == null) {

                this.DisconnectReason = "FETCH";

            } else {


            }
        }
        else if (this.DisconnectReason != null && ec.Excludes("disconnectReason",true))
        {
            this.DisconnectReason = null;
        }
    }


    #endregion

    } // class CdmAgentStatus
    
    #endregion

    public static class ListCdmAgentStatusExtensions
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
            this List<CdmAgentStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CdmAgentStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmAgentStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmAgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmAgentStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types