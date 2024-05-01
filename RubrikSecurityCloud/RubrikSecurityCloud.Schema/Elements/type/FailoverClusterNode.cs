// FailoverClusterNode.cs
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
    #region FailoverClusterNode
    public class FailoverClusterNode: BaseType
    {
        #region members

        //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterNodeConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterNode";
    }

    public FailoverClusterNode Set(
        FailoverClusterNodeConnectionStatus? ConnectionStatus = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? OperatingSystem = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
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
        //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (this.OperatingSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystem\n" ;
            } else {
                s += ind + "operatingSystem\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new FailoverClusterNodeConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (ec.Includes("operatingSystem",true))
        {
            if(this.OperatingSystem == null) {

                this.OperatingSystem = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystem != null && ec.Excludes("operatingSystem",true))
        {
            this.OperatingSystem = null;
        }
    }


    #endregion

    } // class FailoverClusterNode
    
    #endregion

    public static class ListFailoverClusterNodeExtensions
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
            this List<FailoverClusterNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types