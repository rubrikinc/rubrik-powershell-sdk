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
            this List<EnableDisableAppConsistencyReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EnableDisableAppConsistencyReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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