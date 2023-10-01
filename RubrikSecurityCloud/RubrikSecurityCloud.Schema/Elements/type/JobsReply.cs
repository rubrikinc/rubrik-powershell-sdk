// JobsReply.cs
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
    #region JobsReply
    public class JobsReply: BaseType
    {
        #region members

        //      C# -> List<JobReply>? Jobs
        // GraphQL -> jobs: [JobReply!]! (type)
        [JsonProperty("jobs")]
        public List<JobReply>? Jobs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JobsReply";
    }

    public JobsReply Set(
        List<JobReply>? Jobs = null
    ) 
    {
        if ( Jobs != null ) {
            this.Jobs = Jobs;
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
        //      C# -> List<JobReply>? Jobs
        // GraphQL -> jobs: [JobReply!]! (type)
        if (this.Jobs != null) {
            var fspec = this.Jobs.AsFieldSpec(conf.Child("jobs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "jobs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<JobReply>? Jobs
        // GraphQL -> jobs: [JobReply!]! (type)
        if (ec.Includes("jobs",false))
        {
            if(this.Jobs == null) {

                this.Jobs = new List<JobReply>();
                this.Jobs.ApplyExploratoryFieldSpec(ec.NewChild("jobs"));

            } else {

                this.Jobs.ApplyExploratoryFieldSpec(ec.NewChild("jobs"));

            }
        }
        else if (this.Jobs != null && ec.Excludes("jobs",false))
        {
            this.Jobs = null;
        }
    }


    #endregion

    } // class JobsReply
    
    #endregion

    public static class ListJobsReplyExtensions
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
            this List<JobsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<JobsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<JobsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new JobsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<JobsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types