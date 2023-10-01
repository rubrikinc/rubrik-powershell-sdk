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
            this List<VerifySlaWithReplicationToClusterResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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