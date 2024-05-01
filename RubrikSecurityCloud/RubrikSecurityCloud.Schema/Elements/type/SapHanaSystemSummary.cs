// SapHanaSystemSummary.cs
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
    #region SapHanaSystemSummary
    public class SapHanaSystemSummary: BaseType
    {
        #region members

        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        [JsonProperty("containerType")]
        public SapHanaSystemSummaryContainerType? ContainerType { get; set; }

        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        [JsonProperty("status")]
        public SapHanaSystemSummaryStatus? Status { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        [JsonProperty("instanceNumber")]
        public System.String? InstanceNumber { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        [JsonProperty("hosts")]
        public List<SapHanaHost>? Hosts { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        [JsonProperty("sslInfo")]
        public SapHanaSslInfo? SslInfo { get; set; }

        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        [JsonProperty("systemInfo")]
        public SapHanaSystemInfo? SystemInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemSummary";
    }

    public SapHanaSystemSummary Set(
        SapHanaSystemSummaryContainerType? ContainerType = null,
        SapHanaSystemSummaryStatus? Status = null,
        System.String? Id = null,
        System.String? InstanceNumber = null,
        System.Boolean? IsArchived = null,
        DateTime? LastRefreshTime = null,
        System.Int32? NumDbs = null,
        System.String? Sid = null,
        System.String? StatusMessage = null,
        System.String? Username = null,
        List<SapHanaHost>? Hosts = null,
        SlaAssignable? SlaAssignable = null,
        SapHanaSslInfo? SslInfo = null,
        SapHanaSystemInfo? SystemInfo = null
    ) 
    {
        if ( ContainerType != null ) {
            this.ContainerType = ContainerType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InstanceNumber != null ) {
            this.InstanceNumber = InstanceNumber;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( SslInfo != null ) {
            this.SslInfo = SslInfo;
        }
        if ( SystemInfo != null ) {
            this.SystemInfo = SystemInfo;
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
        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        if (this.ContainerType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containerType\n" ;
            } else {
                s += ind + "containerType\n" ;
            }
        }
        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        if (this.InstanceNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceNumber\n" ;
            } else {
                s += ind + "instanceNumber\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
            }
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDbs\n" ;
            } else {
                s += ind + "numDbs\n" ;
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
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        if (this.Hosts != null) {
            var fspec = this.Hosts.AsFieldSpec(conf.Child("hosts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hosts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        if (this.SslInfo != null) {
            var fspec = this.SslInfo.AsFieldSpec(conf.Child("sslInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sslInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        if (this.SystemInfo != null) {
            var fspec = this.SystemInfo.AsFieldSpec(conf.Child("systemInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "systemInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        if (ec.Includes("containerType",true))
        {
            if(this.ContainerType == null) {

                this.ContainerType = new SapHanaSystemSummaryContainerType();

            } else {


            }
        }
        else if (this.ContainerType != null && ec.Excludes("containerType",true))
        {
            this.ContainerType = null;
        }
        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SapHanaSystemSummaryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        if (ec.Includes("instanceNumber",true))
        {
            if(this.InstanceNumber == null) {

                this.InstanceNumber = "FETCH";

            } else {


            }
        }
        else if (this.InstanceNumber != null && ec.Excludes("instanceNumber",true))
        {
            this.InstanceNumber = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (ec.Includes("numDbs",true))
        {
            if(this.NumDbs == null) {

                this.NumDbs = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDbs != null && ec.Excludes("numDbs",true))
        {
            this.NumDbs = null;
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
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        if (ec.Includes("hosts",false))
        {
            if(this.Hosts == null) {

                this.Hosts = new List<SapHanaHost>();
                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            } else {

                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            }
        }
        else if (this.Hosts != null && ec.Excludes("hosts",false))
        {
            this.Hosts = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        if (ec.Includes("sslInfo",false))
        {
            if(this.SslInfo == null) {

                this.SslInfo = new SapHanaSslInfo();
                this.SslInfo.ApplyExploratoryFieldSpec(ec.NewChild("sslInfo"));

            } else {

                this.SslInfo.ApplyExploratoryFieldSpec(ec.NewChild("sslInfo"));

            }
        }
        else if (this.SslInfo != null && ec.Excludes("sslInfo",false))
        {
            this.SslInfo = null;
        }
        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        if (ec.Includes("systemInfo",false))
        {
            if(this.SystemInfo == null) {

                this.SystemInfo = new SapHanaSystemInfo();
                this.SystemInfo.ApplyExploratoryFieldSpec(ec.NewChild("systemInfo"));

            } else {

                this.SystemInfo.ApplyExploratoryFieldSpec(ec.NewChild("systemInfo"));

            }
        }
        else if (this.SystemInfo != null && ec.Excludes("systemInfo",false))
        {
            this.SystemInfo = null;
        }
    }


    #endregion

    } // class SapHanaSystemSummary
    
    #endregion

    public static class ListSapHanaSystemSummaryExtensions
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
            this List<SapHanaSystemSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaSystemSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaSystemSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types