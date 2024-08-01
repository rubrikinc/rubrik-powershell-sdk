// BrowseFileUsersActivityResult.cs
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
    #region BrowseFileUsersActivityResult
    public class BrowseFileUsersActivityResult: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.Int32? AccessStatsAppends
        // GraphQL -> accessStatsAppends: Int! (scalar)
        [JsonProperty("accessStatsAppends")]
        public System.Int32? AccessStatsAppends { get; set; }

        //      C# -> System.Int32? AccessStatsDeletes
        // GraphQL -> accessStatsDeletes: Int! (scalar)
        [JsonProperty("accessStatsDeletes")]
        public System.Int32? AccessStatsDeletes { get; set; }

        //      C# -> System.Int32? AccessStatsDenied
        // GraphQL -> accessStatsDenied: Int! (scalar)
        [JsonProperty("accessStatsDenied")]
        public System.Int32? AccessStatsDenied { get; set; }

        //      C# -> System.Int32? AccessStatsReads
        // GraphQL -> accessStatsReads: Int! (scalar)
        [JsonProperty("accessStatsReads")]
        public System.Int32? AccessStatsReads { get; set; }

        //      C# -> System.Int32? AccessStatsTotal
        // GraphQL -> accessStatsTotal: Int! (scalar)
        [JsonProperty("accessStatsTotal")]
        public System.Int32? AccessStatsTotal { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> UserPath? UserPath
        // GraphQL -> userPath: UserPath (type)
        [JsonProperty("userPath")]
        public UserPath? UserPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BrowseFileUsersActivityResult";
    }

    public BrowseFileUsersActivityResult Set(
        RiskLevelType? Risk = null,
        System.Int32? AccessStatsAppends = null,
        System.Int32? AccessStatsDeletes = null,
        System.Int32? AccessStatsDenied = null,
        System.Int32? AccessStatsReads = null,
        System.Int32? AccessStatsTotal = null,
        System.String? PaginationId = null,
        System.String? UserName = null,
        UserPath? UserPath = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( AccessStatsAppends != null ) {
            this.AccessStatsAppends = AccessStatsAppends;
        }
        if ( AccessStatsDeletes != null ) {
            this.AccessStatsDeletes = AccessStatsDeletes;
        }
        if ( AccessStatsDenied != null ) {
            this.AccessStatsDenied = AccessStatsDenied;
        }
        if ( AccessStatsReads != null ) {
            this.AccessStatsReads = AccessStatsReads;
        }
        if ( AccessStatsTotal != null ) {
            this.AccessStatsTotal = AccessStatsTotal;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( UserPath != null ) {
            this.UserPath = UserPath;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
            }
        }
        //      C# -> System.Int32? AccessStatsAppends
        // GraphQL -> accessStatsAppends: Int! (scalar)
        if (this.AccessStatsAppends != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatsAppends\n" ;
            } else {
                s += ind + "accessStatsAppends\n" ;
            }
        }
        //      C# -> System.Int32? AccessStatsDeletes
        // GraphQL -> accessStatsDeletes: Int! (scalar)
        if (this.AccessStatsDeletes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatsDeletes\n" ;
            } else {
                s += ind + "accessStatsDeletes\n" ;
            }
        }
        //      C# -> System.Int32? AccessStatsDenied
        // GraphQL -> accessStatsDenied: Int! (scalar)
        if (this.AccessStatsDenied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatsDenied\n" ;
            } else {
                s += ind + "accessStatsDenied\n" ;
            }
        }
        //      C# -> System.Int32? AccessStatsReads
        // GraphQL -> accessStatsReads: Int! (scalar)
        if (this.AccessStatsReads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatsReads\n" ;
            } else {
                s += ind + "accessStatsReads\n" ;
            }
        }
        //      C# -> System.Int32? AccessStatsTotal
        // GraphQL -> accessStatsTotal: Int! (scalar)
        if (this.AccessStatsTotal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatsTotal\n" ;
            } else {
                s += ind + "accessStatsTotal\n" ;
            }
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paginationId\n" ;
            } else {
                s += ind + "paginationId\n" ;
            }
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (this.UserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userName\n" ;
            } else {
                s += ind + "userName\n" ;
            }
        }
        //      C# -> UserPath? UserPath
        // GraphQL -> userPath: UserPath (type)
        if (this.UserPath != null) {
            var fspec = this.UserPath.AsFieldSpec(conf.Child("userPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "userPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
        }
        //      C# -> System.Int32? AccessStatsAppends
        // GraphQL -> accessStatsAppends: Int! (scalar)
        if (ec.Includes("accessStatsAppends",true))
        {
            if(this.AccessStatsAppends == null) {

                this.AccessStatsAppends = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccessStatsAppends != null && ec.Excludes("accessStatsAppends",true))
        {
            this.AccessStatsAppends = null;
        }
        //      C# -> System.Int32? AccessStatsDeletes
        // GraphQL -> accessStatsDeletes: Int! (scalar)
        if (ec.Includes("accessStatsDeletes",true))
        {
            if(this.AccessStatsDeletes == null) {

                this.AccessStatsDeletes = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccessStatsDeletes != null && ec.Excludes("accessStatsDeletes",true))
        {
            this.AccessStatsDeletes = null;
        }
        //      C# -> System.Int32? AccessStatsDenied
        // GraphQL -> accessStatsDenied: Int! (scalar)
        if (ec.Includes("accessStatsDenied",true))
        {
            if(this.AccessStatsDenied == null) {

                this.AccessStatsDenied = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccessStatsDenied != null && ec.Excludes("accessStatsDenied",true))
        {
            this.AccessStatsDenied = null;
        }
        //      C# -> System.Int32? AccessStatsReads
        // GraphQL -> accessStatsReads: Int! (scalar)
        if (ec.Includes("accessStatsReads",true))
        {
            if(this.AccessStatsReads == null) {

                this.AccessStatsReads = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccessStatsReads != null && ec.Excludes("accessStatsReads",true))
        {
            this.AccessStatsReads = null;
        }
        //      C# -> System.Int32? AccessStatsTotal
        // GraphQL -> accessStatsTotal: Int! (scalar)
        if (ec.Includes("accessStatsTotal",true))
        {
            if(this.AccessStatsTotal == null) {

                this.AccessStatsTotal = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccessStatsTotal != null && ec.Excludes("accessStatsTotal",true))
        {
            this.AccessStatsTotal = null;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (ec.Includes("paginationId",true))
        {
            if(this.PaginationId == null) {

                this.PaginationId = "FETCH";

            } else {


            }
        }
        else if (this.PaginationId != null && ec.Excludes("paginationId",true))
        {
            this.PaginationId = null;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (ec.Includes("userName",true))
        {
            if(this.UserName == null) {

                this.UserName = "FETCH";

            } else {


            }
        }
        else if (this.UserName != null && ec.Excludes("userName",true))
        {
            this.UserName = null;
        }
        //      C# -> UserPath? UserPath
        // GraphQL -> userPath: UserPath (type)
        if (ec.Includes("userPath",false))
        {
            if(this.UserPath == null) {

                this.UserPath = new UserPath();
                this.UserPath.ApplyExploratoryFieldSpec(ec.NewChild("userPath"));

            } else {

                this.UserPath.ApplyExploratoryFieldSpec(ec.NewChild("userPath"));

            }
        }
        else if (this.UserPath != null && ec.Excludes("userPath",false))
        {
            this.UserPath = null;
        }
    }


    #endregion

    } // class BrowseFileUsersActivityResult
    
    #endregion

    public static class ListBrowseFileUsersActivityResultExtensions
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
            this List<BrowseFileUsersActivityResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BrowseFileUsersActivityResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BrowseFileUsersActivityResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BrowseFileUsersActivityResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BrowseFileUsersActivityResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types