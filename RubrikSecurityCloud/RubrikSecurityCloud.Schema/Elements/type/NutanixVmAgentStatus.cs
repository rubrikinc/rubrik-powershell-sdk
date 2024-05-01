// NutanixVmAgentStatus.cs
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
    #region NutanixVmAgentStatus
    public class NutanixVmAgentStatus: BaseType
    {
        #region members

        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public NutanixVmAgentConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmAgentStatus";
    }

    public NutanixVmAgentStatus Set(
        NutanixVmAgentConnectionStatus? ConnectionStatus = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
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
        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new NutanixVmAgentConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
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

    } // class NutanixVmAgentStatus
    
    #endregion

    public static class ListNutanixVmAgentStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<NutanixVmAgentStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmAgentStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmAgentStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmAgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmAgentStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types