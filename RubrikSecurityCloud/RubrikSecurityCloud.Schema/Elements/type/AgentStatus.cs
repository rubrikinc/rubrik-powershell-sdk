// AgentStatus.cs
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
    #region AgentStatus
    public class AgentStatus: BaseType
    {
        #region members

        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        [JsonProperty("agentStatus")]
        public AgentConnectionStatus? AgentStatusField { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AgentStatus";
    }

    public AgentStatus Set(
        AgentConnectionStatus? AgentStatusField = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( AgentStatusField != null ) {
            this.AgentStatusField = AgentStatusField;
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
        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        if (this.AgentStatusField != null) {
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
        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        if (ec.Includes("agentStatus",true))
        {
            if(this.AgentStatusField == null) {

                this.AgentStatusField = new AgentConnectionStatus();

            } else {


            }
        }
        else if (this.AgentStatusField != null && ec.Excludes("agentStatus",true))
        {
            this.AgentStatusField = null;
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

    } // class AgentStatus
    
    #endregion

    public static class ListAgentStatusExtensions
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
            this List<AgentStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AgentStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AgentStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AgentStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types