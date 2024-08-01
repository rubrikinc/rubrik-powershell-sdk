// ActivitySummary.cs
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
    #region ActivitySummary
    public class ActivitySummary: BaseType
    {
        #region members

        //      C# -> System.Int64? NumDeleteOperations
        // GraphQL -> numDeleteOperations: Long! (scalar)
        [JsonProperty("numDeleteOperations")]
        public System.Int64? NumDeleteOperations { get; set; }

        //      C# -> System.Int64? NumDeniedOperations
        // GraphQL -> numDeniedOperations: Long! (scalar)
        [JsonProperty("numDeniedOperations")]
        public System.Int64? NumDeniedOperations { get; set; }

        //      C# -> System.Int64? NumFilesInteracted
        // GraphQL -> numFilesInteracted: Long! (scalar)
        [JsonProperty("numFilesInteracted")]
        public System.Int64? NumFilesInteracted { get; set; }

        //      C# -> System.Int64? NumFilesModified
        // GraphQL -> numFilesModified: Long! (scalar)
        [JsonProperty("numFilesModified")]
        public System.Int64? NumFilesModified { get; set; }

        //      C# -> System.Int64? NumFilesRead
        // GraphQL -> numFilesRead: Long! (scalar)
        [JsonProperty("numFilesRead")]
        public System.Int64? NumFilesRead { get; set; }

        //      C# -> System.Int64? NumFilesUnaccessed
        // GraphQL -> numFilesUnaccessed: Long! (scalar)
        [JsonProperty("numFilesUnaccessed")]
        public System.Int64? NumFilesUnaccessed { get; set; }

        //      C# -> System.Int64? NumReadOperations
        // GraphQL -> numReadOperations: Long! (scalar)
        [JsonProperty("numReadOperations")]
        public System.Int64? NumReadOperations { get; set; }

        //      C# -> System.Int64? NumTotalActivities
        // GraphQL -> numTotalActivities: Long! (scalar)
        [JsonProperty("numTotalActivities")]
        public System.Int64? NumTotalActivities { get; set; }

        //      C# -> System.Int64? NumTotalOperations
        // GraphQL -> numTotalOperations: Long! (scalar)
        [JsonProperty("numTotalOperations")]
        public System.Int64? NumTotalOperations { get; set; }

        //      C# -> System.Int64? NumWriteOperations
        // GraphQL -> numWriteOperations: Long! (scalar)
        [JsonProperty("numWriteOperations")]
        public System.Int64? NumWriteOperations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivitySummary";
    }

    public ActivitySummary Set(
        System.Int64? NumDeleteOperations = null,
        System.Int64? NumDeniedOperations = null,
        System.Int64? NumFilesInteracted = null,
        System.Int64? NumFilesModified = null,
        System.Int64? NumFilesRead = null,
        System.Int64? NumFilesUnaccessed = null,
        System.Int64? NumReadOperations = null,
        System.Int64? NumTotalActivities = null,
        System.Int64? NumTotalOperations = null,
        System.Int64? NumWriteOperations = null
    ) 
    {
        if ( NumDeleteOperations != null ) {
            this.NumDeleteOperations = NumDeleteOperations;
        }
        if ( NumDeniedOperations != null ) {
            this.NumDeniedOperations = NumDeniedOperations;
        }
        if ( NumFilesInteracted != null ) {
            this.NumFilesInteracted = NumFilesInteracted;
        }
        if ( NumFilesModified != null ) {
            this.NumFilesModified = NumFilesModified;
        }
        if ( NumFilesRead != null ) {
            this.NumFilesRead = NumFilesRead;
        }
        if ( NumFilesUnaccessed != null ) {
            this.NumFilesUnaccessed = NumFilesUnaccessed;
        }
        if ( NumReadOperations != null ) {
            this.NumReadOperations = NumReadOperations;
        }
        if ( NumTotalActivities != null ) {
            this.NumTotalActivities = NumTotalActivities;
        }
        if ( NumTotalOperations != null ) {
            this.NumTotalOperations = NumTotalOperations;
        }
        if ( NumWriteOperations != null ) {
            this.NumWriteOperations = NumWriteOperations;
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
        //      C# -> System.Int64? NumDeleteOperations
        // GraphQL -> numDeleteOperations: Long! (scalar)
        if (this.NumDeleteOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDeleteOperations\n" ;
            } else {
                s += ind + "numDeleteOperations\n" ;
            }
        }
        //      C# -> System.Int64? NumDeniedOperations
        // GraphQL -> numDeniedOperations: Long! (scalar)
        if (this.NumDeniedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDeniedOperations\n" ;
            } else {
                s += ind + "numDeniedOperations\n" ;
            }
        }
        //      C# -> System.Int64? NumFilesInteracted
        // GraphQL -> numFilesInteracted: Long! (scalar)
        if (this.NumFilesInteracted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFilesInteracted\n" ;
            } else {
                s += ind + "numFilesInteracted\n" ;
            }
        }
        //      C# -> System.Int64? NumFilesModified
        // GraphQL -> numFilesModified: Long! (scalar)
        if (this.NumFilesModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFilesModified\n" ;
            } else {
                s += ind + "numFilesModified\n" ;
            }
        }
        //      C# -> System.Int64? NumFilesRead
        // GraphQL -> numFilesRead: Long! (scalar)
        if (this.NumFilesRead != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFilesRead\n" ;
            } else {
                s += ind + "numFilesRead\n" ;
            }
        }
        //      C# -> System.Int64? NumFilesUnaccessed
        // GraphQL -> numFilesUnaccessed: Long! (scalar)
        if (this.NumFilesUnaccessed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFilesUnaccessed\n" ;
            } else {
                s += ind + "numFilesUnaccessed\n" ;
            }
        }
        //      C# -> System.Int64? NumReadOperations
        // GraphQL -> numReadOperations: Long! (scalar)
        if (this.NumReadOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numReadOperations\n" ;
            } else {
                s += ind + "numReadOperations\n" ;
            }
        }
        //      C# -> System.Int64? NumTotalActivities
        // GraphQL -> numTotalActivities: Long! (scalar)
        if (this.NumTotalActivities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numTotalActivities\n" ;
            } else {
                s += ind + "numTotalActivities\n" ;
            }
        }
        //      C# -> System.Int64? NumTotalOperations
        // GraphQL -> numTotalOperations: Long! (scalar)
        if (this.NumTotalOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numTotalOperations\n" ;
            } else {
                s += ind + "numTotalOperations\n" ;
            }
        }
        //      C# -> System.Int64? NumWriteOperations
        // GraphQL -> numWriteOperations: Long! (scalar)
        if (this.NumWriteOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWriteOperations\n" ;
            } else {
                s += ind + "numWriteOperations\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? NumDeleteOperations
        // GraphQL -> numDeleteOperations: Long! (scalar)
        if (ec.Includes("numDeleteOperations",true))
        {
            if(this.NumDeleteOperations == null) {

                this.NumDeleteOperations = new System.Int64();

            } else {


            }
        }
        else if (this.NumDeleteOperations != null && ec.Excludes("numDeleteOperations",true))
        {
            this.NumDeleteOperations = null;
        }
        //      C# -> System.Int64? NumDeniedOperations
        // GraphQL -> numDeniedOperations: Long! (scalar)
        if (ec.Includes("numDeniedOperations",true))
        {
            if(this.NumDeniedOperations == null) {

                this.NumDeniedOperations = new System.Int64();

            } else {


            }
        }
        else if (this.NumDeniedOperations != null && ec.Excludes("numDeniedOperations",true))
        {
            this.NumDeniedOperations = null;
        }
        //      C# -> System.Int64? NumFilesInteracted
        // GraphQL -> numFilesInteracted: Long! (scalar)
        if (ec.Includes("numFilesInteracted",true))
        {
            if(this.NumFilesInteracted == null) {

                this.NumFilesInteracted = new System.Int64();

            } else {


            }
        }
        else if (this.NumFilesInteracted != null && ec.Excludes("numFilesInteracted",true))
        {
            this.NumFilesInteracted = null;
        }
        //      C# -> System.Int64? NumFilesModified
        // GraphQL -> numFilesModified: Long! (scalar)
        if (ec.Includes("numFilesModified",true))
        {
            if(this.NumFilesModified == null) {

                this.NumFilesModified = new System.Int64();

            } else {


            }
        }
        else if (this.NumFilesModified != null && ec.Excludes("numFilesModified",true))
        {
            this.NumFilesModified = null;
        }
        //      C# -> System.Int64? NumFilesRead
        // GraphQL -> numFilesRead: Long! (scalar)
        if (ec.Includes("numFilesRead",true))
        {
            if(this.NumFilesRead == null) {

                this.NumFilesRead = new System.Int64();

            } else {


            }
        }
        else if (this.NumFilesRead != null && ec.Excludes("numFilesRead",true))
        {
            this.NumFilesRead = null;
        }
        //      C# -> System.Int64? NumFilesUnaccessed
        // GraphQL -> numFilesUnaccessed: Long! (scalar)
        if (ec.Includes("numFilesUnaccessed",true))
        {
            if(this.NumFilesUnaccessed == null) {

                this.NumFilesUnaccessed = new System.Int64();

            } else {


            }
        }
        else if (this.NumFilesUnaccessed != null && ec.Excludes("numFilesUnaccessed",true))
        {
            this.NumFilesUnaccessed = null;
        }
        //      C# -> System.Int64? NumReadOperations
        // GraphQL -> numReadOperations: Long! (scalar)
        if (ec.Includes("numReadOperations",true))
        {
            if(this.NumReadOperations == null) {

                this.NumReadOperations = new System.Int64();

            } else {


            }
        }
        else if (this.NumReadOperations != null && ec.Excludes("numReadOperations",true))
        {
            this.NumReadOperations = null;
        }
        //      C# -> System.Int64? NumTotalActivities
        // GraphQL -> numTotalActivities: Long! (scalar)
        if (ec.Includes("numTotalActivities",true))
        {
            if(this.NumTotalActivities == null) {

                this.NumTotalActivities = new System.Int64();

            } else {


            }
        }
        else if (this.NumTotalActivities != null && ec.Excludes("numTotalActivities",true))
        {
            this.NumTotalActivities = null;
        }
        //      C# -> System.Int64? NumTotalOperations
        // GraphQL -> numTotalOperations: Long! (scalar)
        if (ec.Includes("numTotalOperations",true))
        {
            if(this.NumTotalOperations == null) {

                this.NumTotalOperations = new System.Int64();

            } else {


            }
        }
        else if (this.NumTotalOperations != null && ec.Excludes("numTotalOperations",true))
        {
            this.NumTotalOperations = null;
        }
        //      C# -> System.Int64? NumWriteOperations
        // GraphQL -> numWriteOperations: Long! (scalar)
        if (ec.Includes("numWriteOperations",true))
        {
            if(this.NumWriteOperations == null) {

                this.NumWriteOperations = new System.Int64();

            } else {


            }
        }
        else if (this.NumWriteOperations != null && ec.Excludes("numWriteOperations",true))
        {
            this.NumWriteOperations = null;
        }
    }


    #endregion

    } // class ActivitySummary
    
    #endregion

    public static class ListActivitySummaryExtensions
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
            this List<ActivitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types