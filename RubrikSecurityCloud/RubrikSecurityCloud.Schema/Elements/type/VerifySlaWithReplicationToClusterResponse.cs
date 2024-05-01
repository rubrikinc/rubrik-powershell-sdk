// VerifySlaWithReplicationToClusterResponse.cs
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
    #region VerifySlaWithReplicationToClusterResponse
    public class VerifySlaWithReplicationToClusterResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        [JsonProperty("isActiveSla")]
        public System.Boolean? IsActiveSla { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VerifySlaWithReplicationToClusterResponse";
    }

    public VerifySlaWithReplicationToClusterResponse Set(
        System.Boolean? IsActiveSla = null
    ) 
    {
        if ( IsActiveSla != null ) {
            this.IsActiveSla = IsActiveSla;
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
        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        if (this.IsActiveSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActiveSla\n" ;
            } else {
                s += ind + "isActiveSla\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        if (ec.Includes("isActiveSla",true))
        {
            if(this.IsActiveSla == null) {

                this.IsActiveSla = true;

            } else {


            }
        }
        else if (this.IsActiveSla != null && ec.Excludes("isActiveSla",true))
        {
            this.IsActiveSla = null;
        }
    }


    #endregion

    } // class VerifySlaWithReplicationToClusterResponse
    
    #endregion

    public static class ListVerifySlaWithReplicationToClusterResponseExtensions
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
            this List<VerifySlaWithReplicationToClusterResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VerifySlaWithReplicationToClusterResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VerifySlaWithReplicationToClusterResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VerifySlaWithReplicationToClusterResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VerifySlaWithReplicationToClusterResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types