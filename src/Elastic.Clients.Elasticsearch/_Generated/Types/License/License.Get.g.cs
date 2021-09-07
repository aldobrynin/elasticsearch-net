// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.License.Get
{
	public partial class LicenseInformation
	{
		[JsonPropertyName("expiry_date")]
		public Elastic.Clients.Elasticsearch.DateString ExpiryDate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("expiry_date_in_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis ExpiryDateInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("issue_date")]
		public Elastic.Clients.Elasticsearch.DateString IssueDate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("issue_date_in_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis IssueDateInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("issued_to")]
		public string IssuedTo
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("issuer")]
		public string Issuer
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_nodes")]
		public long MaxNodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_resource_units")]
		public int? MaxResourceUnits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("start_date_in_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis StartDateInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Elastic.Clients.Elasticsearch.License.LicenseStatus Status
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.License.LicenseType Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("uid")]
		public Elastic.Clients.Elasticsearch.Uuid Uid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}