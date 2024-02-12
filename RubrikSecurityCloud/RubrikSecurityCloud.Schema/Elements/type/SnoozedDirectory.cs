// SnoozedDirectory.cs
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
    #region SnoozedDirectory
    public class SnoozedDirectory: BaseType
    {
        #region members

        //      C# -> AnomalyFalsePositiveType? FalsePositiveType
        // GraphQL -> falsePositiveType: AnomalyFalsePositiveType! (enum)
        [JsonProperty("falsePositiveType")]
        public AnomalyFalsePositiveType? FalsePositiveType { get; set; }

        //      C# -> SnoozeStatus? Status
        // GraphQL -> status: SnoozeStatus! (enum)
        [JsonProperty("status")]
        public SnoozeStatus? Status { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        [JsonProperty("directory")]
        public System.String? Directory { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? OtherReason
        // GraphQL -> otherReason: String! (scalar)
        [JsonProperty("otherReason")]
        public System.String? OtherReason { get; set; }

        //      C# -> System.String? UserAccount
        // GraphQL -> userAccount: String! (scalar)
        [JsonProperty("userAccount")]
        public System.String? UserAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnoozedDirectory";
    }

    public SnoozedDirectory Set(
        AnomalyFalsePositiveType? FalsePositiveType = null,
        SnoozeStatus? Status = null,
        DateTime? CreatedDate = null,
        System.String? Directory = null,
        DateTime? ExpirationDate = null,
        System.String? OtherReason = null,
        System.String? UserAccount = null
    ) 
    {
        if ( FalsePositiveType != null ) {
            this.FalsePositiveType = FalsePositiveType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( Directory != null ) {
            this.Directory = Directory;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( OtherReason != null ) {
            this.OtherReason = OtherReason;
        }
        if ( UserAccount != null ) {
            this.UserAccount = UserAccount;
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
        //      C# -> AnomalyFalsePositiveType? FalsePositiveType
        // GraphQL -> falsePositiveType: AnomalyFalsePositiveType! (enum)
        if (this.FalsePositiveType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "falsePositiveType\n" ;
            } else {
                s += ind + "falsePositiveType\n" ;
            }
        }
        //      C# -> SnoozeStatus? Status
        // GraphQL -> status: SnoozeStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (this.CreatedDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDate\n" ;
            } else {
                s += ind + "createdDate\n" ;
            }
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directory\n" ;
            } else {
                s += ind + "directory\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.String? OtherReason
        // GraphQL -> otherReason: String! (scalar)
        if (this.OtherReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "otherReason\n" ;
            } else {
                s += ind + "otherReason\n" ;
            }
        }
        //      C# -> System.String? UserAccount
        // GraphQL -> userAccount: String! (scalar)
        if (this.UserAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userAccount\n" ;
            } else {
                s += ind + "userAccount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnomalyFalsePositiveType? FalsePositiveType
        // GraphQL -> falsePositiveType: AnomalyFalsePositiveType! (enum)
        if (ec.Includes("falsePositiveType",true))
        {
            if(this.FalsePositiveType == null) {

                this.FalsePositiveType = new AnomalyFalsePositiveType();

            } else {


            }
        }
        else if (this.FalsePositiveType != null && ec.Excludes("falsePositiveType",true))
        {
            this.FalsePositiveType = null;
        }
        //      C# -> SnoozeStatus? Status
        // GraphQL -> status: SnoozeStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SnoozeStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (ec.Includes("createdDate",true))
        {
            if(this.CreatedDate == null) {

                this.CreatedDate = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDate != null && ec.Excludes("createdDate",true))
        {
            this.CreatedDate = null;
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (ec.Includes("directory",true))
        {
            if(this.Directory == null) {

                this.Directory = "FETCH";

            } else {


            }
        }
        else if (this.Directory != null && ec.Excludes("directory",true))
        {
            this.Directory = null;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
        //      C# -> System.String? OtherReason
        // GraphQL -> otherReason: String! (scalar)
        if (ec.Includes("otherReason",true))
        {
            if(this.OtherReason == null) {

                this.OtherReason = "FETCH";

            } else {


            }
        }
        else if (this.OtherReason != null && ec.Excludes("otherReason",true))
        {
            this.OtherReason = null;
        }
        //      C# -> System.String? UserAccount
        // GraphQL -> userAccount: String! (scalar)
        if (ec.Includes("userAccount",true))
        {
            if(this.UserAccount == null) {

                this.UserAccount = "FETCH";

            } else {


            }
        }
        else if (this.UserAccount != null && ec.Excludes("userAccount",true))
        {
            this.UserAccount = null;
        }
    }


    #endregion

    } // class SnoozedDirectory
    
    #endregion

    public static class ListSnoozedDirectoryExtensions
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
            this List<SnoozedDirectory> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SnoozedDirectory> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnoozedDirectory> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnoozedDirectory());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnoozedDirectory> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types