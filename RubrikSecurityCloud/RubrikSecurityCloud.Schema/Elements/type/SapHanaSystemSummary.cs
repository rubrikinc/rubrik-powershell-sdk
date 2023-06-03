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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        if (this.ContainerType != null) {
            s += ind + "containerType\n" ;
        }
        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        if (this.InstanceNumber != null) {
            s += ind + "instanceNumber\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            s += ind + "lastRefreshTime\n" ;
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs != null) {
            s += ind + "numDbs\n" ;
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid != null) {
            s += ind + "sid\n" ;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage != null) {
            s += ind + "statusMessage\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        if (this.Hosts != null) {
            s += ind + "hosts {\n" + this.Hosts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        if (this.SslInfo != null) {
            s += ind + "sslInfo {\n" + this.SslInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        if (this.SystemInfo != null) {
            s += ind + "systemInfo {\n" + this.SystemInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        if (this.ContainerType == null && Exploration.Includes(parent + ".containerType", true))
        {
            this.ContainerType = new SapHanaSystemSummaryContainerType();
        }
        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new SapHanaSystemSummaryStatus();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        if (this.InstanceNumber == null && Exploration.Includes(parent + ".instanceNumber", true))
        {
            this.InstanceNumber = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime", true))
        {
            this.LastRefreshTime = new DateTime();
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs == null && Exploration.Includes(parent + ".numDbs", true))
        {
            this.NumDbs = new System.Int32();
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid == null && Exploration.Includes(parent + ".sid", true))
        {
            this.Sid = new System.String("FETCH");
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage", true))
        {
            this.StatusMessage = new System.String("FETCH");
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
        {
            this.Hosts = new List<SapHanaHost>();
            this.Hosts.ApplyExploratoryFieldSpec(parent + ".hosts");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        if (this.SslInfo == null && Exploration.Includes(parent + ".sslInfo"))
        {
            this.SslInfo = new SapHanaSslInfo();
            this.SslInfo.ApplyExploratoryFieldSpec(parent + ".sslInfo");
        }
        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        if (this.SystemInfo == null && Exploration.Includes(parent + ".systemInfo"))
        {
            this.SystemInfo = new SapHanaSystemInfo();
            this.SystemInfo.ApplyExploratoryFieldSpec(parent + ".systemInfo");
        }
    }


    #endregion

    } // class SapHanaSystemSummary
    
    #endregion

    public static class ListSapHanaSystemSummaryExtensions
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
            this List<SapHanaSystemSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types