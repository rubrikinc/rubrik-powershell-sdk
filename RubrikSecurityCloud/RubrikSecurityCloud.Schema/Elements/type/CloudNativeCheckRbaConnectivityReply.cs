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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<Failure>? Failures
        // GraphQL -> failures: [Failure!]! (type)
        if (this.Failures != null) {
            var fspec = this.Failures.AsFieldSpec(conf.Child("failures"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failures" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Success>? Successes
        // GraphQL -> successes: [Success!]! (type)
        if (this.Successes != null) {
            var fspec = this.Successes.AsFieldSpec(conf.Child("successes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "successes" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CloudNativeCheckRbaConnectivityReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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