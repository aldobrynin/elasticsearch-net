/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.Eql.Status
{
	public class EqlSearchStatusUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await GET("/_eql/search/status/search_id")
			.Fluent(c => c.Eql.SearchStatus("search_id", f => f))
			.Request(c => c.Eql.SearchStatus(new EqlSearchStatusRequest("search_id")))
			.FluentAsync(c => c.Eql.SearchStatusAsync("search_id", f => f))
			.RequestAsync(c => c.Eql.SearchStatusAsync(new EqlSearchStatusRequest("search_id")));
	}
}