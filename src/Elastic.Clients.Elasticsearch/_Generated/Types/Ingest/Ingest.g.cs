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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class AppendProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("allow_duplicates")]
		public bool? AllowDuplicates { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("value")]
		public IEnumerable<object> Value { get; set; }
	}

	public partial class AttachmentProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("indexed_chars")]
		public long? IndexedChars { get; set; }

		[JsonPropertyName("indexed_chars_field")]
		public Elastic.Clients.Elasticsearch.Field? IndexedCharsField { get; set; }

		[JsonPropertyName("properties")]
		public IEnumerable<string>? Properties { get; set; }

		[JsonPropertyName("resource_name")]
		public string? ResourceName { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class BytesProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class CircleProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("error_distance")]
		public double ErrorDistance { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool IgnoreMissing { get; set; }

		[JsonPropertyName("shape_type")]
		public Elastic.Clients.Elasticsearch.Ingest.ShapeType ShapeType { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class ConvertProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }

		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Ingest.ConvertType Type { get; set; }
	}

	public partial class CsvProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("empty_value")]
		public object EmptyValue { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("quote")]
		public string? Quote { get; set; }

		[JsonPropertyName("separator")]
		public string? Separator { get; set; }

		[JsonPropertyName("target_fields")]
		public Elastic.Clients.Elasticsearch.Fields TargetFields { get; set; }

		[JsonPropertyName("trim")]
		public bool Trim { get; set; }
	}

	public partial class DateIndexNameProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("date_formats")]
		public IEnumerable<string> DateFormats { get; set; }

		[JsonPropertyName("date_rounding")]
		public Union<string, Elastic.Clients.Elasticsearch.Ingest.DateRounding> DateRounding { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("index_name_format")]
		public string IndexNameFormat { get; set; }

		[JsonPropertyName("index_name_prefix")]
		public string IndexNamePrefix { get; set; }

		[JsonPropertyName("locale")]
		public string Locale { get; set; }

		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }
	}

	public partial class DateProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("formats")]
		public IEnumerable<string> Formats { get; set; }

		[JsonPropertyName("locale")]
		public string? Locale { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

		[JsonPropertyName("timezone")]
		public string? Timezone { get; set; }
	}

	public partial class DissectProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("append_separator")]
		public string AppendSeparator { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool IgnoreMissing { get; set; }

		[JsonPropertyName("pattern")]
		public string Pattern { get; set; }
	}

	public partial class DotExpanderProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("path")]
		public string? Path { get; set; }
	}

	public partial class DropProcessor : Ingest.ProcessorBase
	{
	}

	public partial class EnrichProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("max_matches")]
		public int? MaxMatches { get; set; }

		[JsonPropertyName("override")]
		public bool? Override { get; set; }

		[JsonPropertyName("policy_name")]
		public string PolicyName { get; set; }

		[JsonPropertyName("shape_relation")]
		public Elastic.Clients.Elasticsearch.GeoShapeRelation? ShapeRelation { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class FailProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("message")]
		public string Message { get; set; }
	}

	public partial class ForeachProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("processor")]
		public Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer Processor { get; set; }
	}

	public partial class GeoIpProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("database_file")]
		public string DatabaseFile { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("first_only")]
		public bool FirstOnly { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool IgnoreMissing { get; set; }

		[JsonPropertyName("properties")]
		public IEnumerable<string> Properties { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class GrokProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("pattern_definitions")]
		public Dictionary<string, string> PatternDefinitions { get; set; }

		[JsonPropertyName("patterns")]
		public IEnumerable<string> Patterns { get; set; }

		[JsonPropertyName("trace_match")]
		public bool? TraceMatch { get; set; }
	}

	public partial class GsubProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("pattern")]
		public string Pattern { get; set; }

		[JsonPropertyName("replacement")]
		public string Replacement { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class InferenceConfig
	{
		[JsonPropertyName("regression")]
		public Elastic.Clients.Elasticsearch.Ingest.InferenceConfigRegression? Regression { get; set; }
	}

	public partial class InferenceConfigRegression
	{
		[JsonPropertyName("results_field")]
		public string ResultsField { get; set; }
	}

	public partial class InferenceProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field_map")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMap { get; set; }

		[JsonPropertyName("inference_config")]
		public Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfig { get; set; }

		[JsonPropertyName("model_id")]
		public Elastic.Clients.Elasticsearch.Id ModelId { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class JoinProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("separator")]
		public string Separator { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class JsonProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("add_to_root")]
		public bool AddToRoot { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class KeyValueProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("exclude_keys")]
		public IEnumerable<string>? ExcludeKeys { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("field_split")]
		public string FieldSplit { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("include_keys")]
		public IEnumerable<string>? IncludeKeys { get; set; }

		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonPropertyName("strip_brackets")]
		public bool? StripBrackets { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

		[JsonPropertyName("trim_key")]
		public string? TrimKey { get; set; }

		[JsonPropertyName("trim_value")]
		public string? TrimValue { get; set; }

		[JsonPropertyName("value_split")]
		public string ValueSplit { get; set; }
	}

	public partial class LowercaseProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class Pipeline
	{
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("on_failure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailure { get; set; }

		[JsonPropertyName("processors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? Processors { get; set; }

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version { get; set; }
	}

	public partial class PipelineConfig
	{
		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processors")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer> Processors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PipelineProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; set; }
	}

	public partial class ProcessorBase
	{
		[JsonPropertyName("if")]
		public string? If { get; set; }

		[JsonPropertyName("ignore_failure")]
		public bool? IgnoreFailure { get; set; }

		[JsonPropertyName("on_failure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailure { get; set; }

		[JsonPropertyName("tag")]
		public string? Tag { get; set; }
	}

	public partial class ProcessorContainer
	{
		[JsonPropertyName("append")]
		public Elastic.Clients.Elasticsearch.Ingest.AppendProcessor? Append { get; set; }

		[JsonPropertyName("attachment")]
		public Elastic.Clients.Elasticsearch.Ingest.AttachmentProcessor? Attachment { get; set; }

		[JsonPropertyName("bytes")]
		public Elastic.Clients.Elasticsearch.Ingest.BytesProcessor? Bytes { get; set; }

		[JsonPropertyName("circle")]
		public Elastic.Clients.Elasticsearch.Ingest.CircleProcessor? Circle { get; set; }

		[JsonPropertyName("convert")]
		public Elastic.Clients.Elasticsearch.Ingest.ConvertProcessor? Convert { get; set; }

		[JsonPropertyName("csv")]
		public Elastic.Clients.Elasticsearch.Ingest.CsvProcessor? Csv { get; set; }

		[JsonPropertyName("date")]
		public Elastic.Clients.Elasticsearch.Ingest.DateProcessor? Date { get; set; }

		[JsonPropertyName("date_index_name")]
		public Elastic.Clients.Elasticsearch.Ingest.DateIndexNameProcessor? DateIndexName { get; set; }

		[JsonPropertyName("dissect")]
		public Elastic.Clients.Elasticsearch.Ingest.DissectProcessor? Dissect { get; set; }

		[JsonPropertyName("dot_expander")]
		public Elastic.Clients.Elasticsearch.Ingest.DotExpanderProcessor? DotExpander { get; set; }

		[JsonPropertyName("drop")]
		public Elastic.Clients.Elasticsearch.Ingest.DropProcessor? Drop { get; set; }

		[JsonPropertyName("enrich")]
		public Elastic.Clients.Elasticsearch.Ingest.EnrichProcessor? Enrich { get; set; }

		[JsonPropertyName("fail")]
		public Elastic.Clients.Elasticsearch.Ingest.FailProcessor? Fail { get; set; }

		[JsonPropertyName("foreach")]
		public Elastic.Clients.Elasticsearch.Ingest.ForeachProcessor? Foreach { get; set; }

		[JsonPropertyName("geoip")]
		public Elastic.Clients.Elasticsearch.Ingest.GeoIpProcessor? Geoip { get; set; }

		[JsonPropertyName("grok")]
		public Elastic.Clients.Elasticsearch.Ingest.GrokProcessor? Grok { get; set; }

		[JsonPropertyName("gsub")]
		public Elastic.Clients.Elasticsearch.Ingest.GsubProcessor? Gsub { get; set; }

		[JsonPropertyName("inference")]
		public Elastic.Clients.Elasticsearch.Ingest.InferenceProcessor? Inference { get; set; }

		[JsonPropertyName("join")]
		public Elastic.Clients.Elasticsearch.Ingest.JoinProcessor? Join { get; set; }

		[JsonPropertyName("json")]
		public Elastic.Clients.Elasticsearch.Ingest.JsonProcessor? Json { get; set; }

		[JsonPropertyName("kv")]
		public Elastic.Clients.Elasticsearch.Ingest.KeyValueProcessor? Kv { get; set; }

		[JsonPropertyName("lowercase")]
		public Elastic.Clients.Elasticsearch.Ingest.LowercaseProcessor? Lowercase { get; set; }

		[JsonPropertyName("pipeline")]
		public Elastic.Clients.Elasticsearch.Ingest.PipelineProcessor? Pipeline { get; set; }

		[JsonPropertyName("remove")]
		public Elastic.Clients.Elasticsearch.Ingest.RemoveProcessor? Remove { get; set; }

		[JsonPropertyName("rename")]
		public Elastic.Clients.Elasticsearch.Ingest.RenameProcessor? Rename { get; set; }

		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonPropertyName("set")]
		public Elastic.Clients.Elasticsearch.Ingest.SetProcessor? Set { get; set; }

		[JsonPropertyName("set_security_user")]
		public Elastic.Clients.Elasticsearch.Ingest.SetSecurityUserProcessor? SetSecurityUser { get; set; }

		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Ingest.SortProcessor? Sort { get; set; }

		[JsonPropertyName("split")]
		public Elastic.Clients.Elasticsearch.Ingest.SplitProcessor? Split { get; set; }

		[JsonPropertyName("trim")]
		public Elastic.Clients.Elasticsearch.Ingest.TrimProcessor? Trim { get; set; }

		[JsonPropertyName("uppercase")]
		public Elastic.Clients.Elasticsearch.Ingest.UppercaseProcessor? Uppercase { get; set; }

		[JsonPropertyName("urldecode")]
		public Elastic.Clients.Elasticsearch.Ingest.UrlDecodeProcessor? Urldecode { get; set; }

		[JsonPropertyName("user_agent")]
		public Elastic.Clients.Elasticsearch.Ingest.UserAgentProcessor? UserAgent { get; set; }
	}

	public partial class RemoveProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Fields Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }
	}

	public partial class RenameProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class SetProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("override")]
		public bool? Override { get; set; }

		[JsonPropertyName("value")]
		public object Value { get; set; }
	}

	public partial class SetSecurityUserProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("properties")]
		public IEnumerable<string>? Properties { get; set; }
	}

	public partial class SortProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortOrder Order { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public partial class SplitProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("preserve_trailing")]
		public bool? PreserveTrailing { get; set; }

		[JsonPropertyName("separator")]
		public string Separator { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class TrimProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class UppercaseProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class UrlDecodeProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public partial class UserAgentProcessor : Ingest.ProcessorBase
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("ignore_missing")]
		public bool IgnoreMissing { get; set; }

		[JsonPropertyName("options")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.UserAgentProperty> Options { get; set; }

		[JsonPropertyName("regex_file")]
		public string RegexFile { get; set; }

		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}
}