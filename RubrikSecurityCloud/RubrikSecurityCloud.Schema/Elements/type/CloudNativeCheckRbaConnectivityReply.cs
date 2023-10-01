// CloudNativeCheckRbaConnectivityReply.cs
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
    #region CloudNativeCheckRbaConnectivityReply
    public class CloudNativeCheckRbaConnectivityReply: BaseType
    {
        #region members

        //      C# -> List<Failure>? Failures
        // GraphQL -> failures: [Failure!]! (type)
        [JsonProperty("failures")]
        public List<Failure>? Failures { get; set; }

        //      C# -> List<Success>? Successes
        // GraphQL -> successes: [Success!]! (type)
        [JsonProperty("successes")]
        public List<Success>? Successes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeCheckRbaConnectivityReply";
    }

    public CloudNativeCheckRbaConnectivityReply Set(
        List<Failure>? Failures = null,
        List<Success>? Successes = null
    ) 
    {
        if ( Failures != null ) {
            this.Failures = Failures;
        }
        if ( Successes != null ) {
            this.Successes = Successes;
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
        //      C# -> List<Failure>? Failures
        // GraphQL -> failures: [Failure!]! (type)
        if (this.Failures != null) {
            var fspec = this.Failures.AsFieldSpec(conf.Child("failures"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failures {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Success>? Successes
        // GraphQL -> successes: [Success!]! (type)
        if (this.Successes != null) {
            var fspec = this.Successes.AsFieldSpec(conf.Child("successes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "successes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Failure>? Failures
        // GraphQL -> failures: [Failure!]! (type)
        if (ec.Includes("failures",false))
        {
            if(this.Failures == null) {

                this.Failures = new List<Failure>();
                this.Failures.ApplyExploratoryFieldSpec(ec.NewChild("failures"));

            } else {

                this.Failures.ApplyExploratoryFieldSpec(ec.NewChild("failures"));

            }
        }
        else if (this.Failures != null && ec.Excludes("failures",false))
        {
            this.Failures = null;
        }
        //      C# -> List<Success>? Successes
        // GraphQL -> successes: [Success!]! (type)
        if (ec.Includes("successes",false))
        {
            if(this.Successes == null) {

                this.Successes = new List<Success>();
                this.Successes.ApplyExploratoryFieldSpec(ec.NewChild("successes"));

            } else {

                this.Successes.ApplyExploratoryFieldSpec(ec.NewChild("successes"));

            }
        }
        else if (this.Successes != null && ec.Excludes("successes",false))
        {
            this.Successes = null;
        }
    }


    #endregion

    } // class CloudNativeCheckRbaConnectivityReply
    
    #endregion

    public static class ListCloudNativeCheckRbaConnectivityReplyExtensions
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
            this List<CloudNativeCheckRbaConnectivityReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CloudNativeCheckRbaConnectivityReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeCheckRbaConnectivityReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeCheckRbaConnectivityReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeCheckRbaConnectivityReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types