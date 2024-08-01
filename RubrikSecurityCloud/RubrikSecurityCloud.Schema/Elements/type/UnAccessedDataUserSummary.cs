// UnAccessedDataUserSummary.cs
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
    #region UnAccessedDataUserSummary
    public class UnAccessedDataUserSummary: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumAccessedSensitiveFiles
        // GraphQL -> numAccessedSensitiveFiles: Int! (scalar)
        [JsonProperty("numAccessedSensitiveFiles")]
        public System.Int32? NumAccessedSensitiveFiles { get; set; }

        //      C# -> System.Int32? NumUnaccessedSensitiveFiles
        // GraphQL -> numUnaccessedSensitiveFiles: Int! (scalar)
        [JsonProperty("numUnaccessedSensitiveFiles")]
        public System.Int32? NumUnaccessedSensitiveFiles { get; set; }

        //      C# -> System.Single? PercentageUnaccessedSensitiveFiles
        // GraphQL -> percentageUnaccessedSensitiveFiles: Float! (scalar)
        [JsonProperty("percentageUnaccessedSensitiveFiles")]
        public System.Single? PercentageUnaccessedSensitiveFiles { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> System.Int32? TotalAccessibleSensitiveFiles
        // GraphQL -> totalAccessibleSensitiveFiles: Int! (scalar)
        [JsonProperty("totalAccessibleSensitiveFiles")]
        public System.Int32? TotalAccessibleSensitiveFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnAccessedDataUserSummary";
    }

    public UnAccessedDataUserSummary Set(
        System.String? Name = null,
        System.Int32? NumAccessedSensitiveFiles = null,
        System.Int32? NumUnaccessedSensitiveFiles = null,
        System.Single? PercentageUnaccessedSensitiveFiles = null,
        System.String? Sid = null,
        System.Int32? TotalAccessibleSensitiveFiles = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumAccessedSensitiveFiles != null ) {
            this.NumAccessedSensitiveFiles = NumAccessedSensitiveFiles;
        }
        if ( NumUnaccessedSensitiveFiles != null ) {
            this.NumUnaccessedSensitiveFiles = NumUnaccessedSensitiveFiles;
        }
        if ( PercentageUnaccessedSensitiveFiles != null ) {
            this.PercentageUnaccessedSensitiveFiles = PercentageUnaccessedSensitiveFiles;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
        }
        if ( TotalAccessibleSensitiveFiles != null ) {
            this.TotalAccessibleSensitiveFiles = TotalAccessibleSensitiveFiles;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumAccessedSensitiveFiles
        // GraphQL -> numAccessedSensitiveFiles: Int! (scalar)
        if (this.NumAccessedSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numAccessedSensitiveFiles\n" ;
            } else {
                s += ind + "numAccessedSensitiveFiles\n" ;
            }
        }
        //      C# -> System.Int32? NumUnaccessedSensitiveFiles
        // GraphQL -> numUnaccessedSensitiveFiles: Int! (scalar)
        if (this.NumUnaccessedSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numUnaccessedSensitiveFiles\n" ;
            } else {
                s += ind + "numUnaccessedSensitiveFiles\n" ;
            }
        }
        //      C# -> System.Single? PercentageUnaccessedSensitiveFiles
        // GraphQL -> percentageUnaccessedSensitiveFiles: Float! (scalar)
        if (this.PercentageUnaccessedSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "percentageUnaccessedSensitiveFiles\n" ;
            } else {
                s += ind + "percentageUnaccessedSensitiveFiles\n" ;
            }
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sid\n" ;
            } else {
                s += ind + "sid\n" ;
            }
        }
        //      C# -> System.Int32? TotalAccessibleSensitiveFiles
        // GraphQL -> totalAccessibleSensitiveFiles: Int! (scalar)
        if (this.TotalAccessibleSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAccessibleSensitiveFiles\n" ;
            } else {
                s += ind + "totalAccessibleSensitiveFiles\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.Int32? NumAccessedSensitiveFiles
        // GraphQL -> numAccessedSensitiveFiles: Int! (scalar)
        if (ec.Includes("numAccessedSensitiveFiles",true))
        {
            if(this.NumAccessedSensitiveFiles == null) {

                this.NumAccessedSensitiveFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumAccessedSensitiveFiles != null && ec.Excludes("numAccessedSensitiveFiles",true))
        {
            this.NumAccessedSensitiveFiles = null;
        }
        //      C# -> System.Int32? NumUnaccessedSensitiveFiles
        // GraphQL -> numUnaccessedSensitiveFiles: Int! (scalar)
        if (ec.Includes("numUnaccessedSensitiveFiles",true))
        {
            if(this.NumUnaccessedSensitiveFiles == null) {

                this.NumUnaccessedSensitiveFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumUnaccessedSensitiveFiles != null && ec.Excludes("numUnaccessedSensitiveFiles",true))
        {
            this.NumUnaccessedSensitiveFiles = null;
        }
        //      C# -> System.Single? PercentageUnaccessedSensitiveFiles
        // GraphQL -> percentageUnaccessedSensitiveFiles: Float! (scalar)
        if (ec.Includes("percentageUnaccessedSensitiveFiles",true))
        {
            if(this.PercentageUnaccessedSensitiveFiles == null) {

                this.PercentageUnaccessedSensitiveFiles = new System.Single();

            } else {


            }
        }
        else if (this.PercentageUnaccessedSensitiveFiles != null && ec.Excludes("percentageUnaccessedSensitiveFiles",true))
        {
            this.PercentageUnaccessedSensitiveFiles = null;
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (ec.Includes("sid",true))
        {
            if(this.Sid == null) {

                this.Sid = "FETCH";

            } else {


            }
        }
        else if (this.Sid != null && ec.Excludes("sid",true))
        {
            this.Sid = null;
        }
        //      C# -> System.Int32? TotalAccessibleSensitiveFiles
        // GraphQL -> totalAccessibleSensitiveFiles: Int! (scalar)
        if (ec.Includes("totalAccessibleSensitiveFiles",true))
        {
            if(this.TotalAccessibleSensitiveFiles == null) {

                this.TotalAccessibleSensitiveFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalAccessibleSensitiveFiles != null && ec.Excludes("totalAccessibleSensitiveFiles",true))
        {
            this.TotalAccessibleSensitiveFiles = null;
        }
    }


    #endregion

    } // class UnAccessedDataUserSummary
    
    #endregion

    public static class ListUnAccessedDataUserSummaryExtensions
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
            this List<UnAccessedDataUserSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UnAccessedDataUserSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnAccessedDataUserSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnAccessedDataUserSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnAccessedDataUserSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types