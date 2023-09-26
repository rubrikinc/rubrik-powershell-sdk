// EnableDisableAppConsistencyReply.cs
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
    #region EnableDisableAppConsistencyReply
    public class EnableDisableAppConsistencyReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        [JsonProperty("failedWorkloadIds")]
        public List<System.String>? FailedWorkloadIds { get; set; }

        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        [JsonProperty("successWorkloadIds")]
        public List<System.String>? SuccessWorkloadIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EnableDisableAppConsistencyReply";
    }

    public EnableDisableAppConsistencyReply Set(
        List<System.String>? FailedWorkloadIds = null,
        List<System.String>? SuccessWorkloadIds = null
    ) 
    {
        if ( FailedWorkloadIds != null ) {
            this.FailedWorkloadIds = FailedWorkloadIds;
        }
        if ( SuccessWorkloadIds != null ) {
            this.SuccessWorkloadIds = SuccessWorkloadIds;
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
        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        if (this.FailedWorkloadIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedWorkloadIds\n" ;
            } else {
                s += ind + "failedWorkloadIds\n" ;
            }
        }
        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        if (this.SuccessWorkloadIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successWorkloadIds\n" ;
            } else {
                s += ind + "successWorkloadIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        if (ec.Includes("failedWorkloadIds",true))
        {
            if(this.FailedWorkloadIds == null) {

                this.FailedWorkloadIds = new List<System.String>();

            } else {


            }
        }
        else if (this.FailedWorkloadIds != null && ec.Excludes("failedWorkloadIds",true))
        {
            this.FailedWorkloadIds = null;
        }
        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        if (ec.Includes("successWorkloadIds",true))
        {
            if(this.SuccessWorkloadIds == null) {

                this.SuccessWorkloadIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SuccessWorkloadIds != null && ec.Excludes("successWorkloadIds",true))
        {
            this.SuccessWorkloadIds = null;
        }
    }


    #endregion

    } // class EnableDisableAppConsistencyReply
    
    #endregion

    public static class ListEnableDisableAppConsistencyReplyExtensions
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
            this List<EnableDisableAppConsistencyReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EnableDisableAppConsistencyReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EnableDisableAppConsistencyReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EnableDisableAppConsistencyReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types