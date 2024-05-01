// StartClusterReportMigrationJobReply.cs
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
    #region StartClusterReportMigrationJobReply
    public class StartClusterReportMigrationJobReply: BaseType
    {
        #region members

        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        [JsonProperty("jobInstanceId")]
        public System.String? JobInstanceId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartClusterReportMigrationJobReply";
    }

    public StartClusterReportMigrationJobReply Set(
        System.String? JobInstanceId = null
    ) 
    {
        if ( JobInstanceId != null ) {
            this.JobInstanceId = JobInstanceId;
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
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (this.JobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobInstanceId\n" ;
            } else {
                s += ind + "jobInstanceId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (ec.Includes("jobInstanceId",true))
        {
            if(this.JobInstanceId == null) {

                this.JobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.JobInstanceId != null && ec.Excludes("jobInstanceId",true))
        {
            this.JobInstanceId = null;
        }
    }


    #endregion

    } // class StartClusterReportMigrationJobReply
    
    #endregion

    public static class ListStartClusterReportMigrationJobReplyExtensions
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
            this List<StartClusterReportMigrationJobReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartClusterReportMigrationJobReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartClusterReportMigrationJobReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartClusterReportMigrationJobReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartClusterReportMigrationJobReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types