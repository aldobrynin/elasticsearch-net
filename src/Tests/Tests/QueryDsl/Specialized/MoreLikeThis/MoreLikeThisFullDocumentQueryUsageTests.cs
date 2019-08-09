﻿using System.Collections.Generic;
using System.Linq;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.Integration;
using static Nest.Infer;

namespace Tests.QueryDsl.Specialized.MoreLikeThis
{
	public class MoreLikeThisFullDocumentQueryUsageTests : QueryDslUsageTestsBase
	{
		public MoreLikeThisFullDocumentQueryUsageTests(ReadOnlyCluster i, EndpointUsage usage) : base(i, usage) { }

		protected override QueryContainer QueryInitializer => new MoreLikeThisQuery
		{
			Like = new List<Like>
			{
				new LikeDocument<Project>(Project.Instance) { Routing = Project.Instance.Name },
				"some long text"
			}
		};

		protected override object QueryJson => new
		{
			more_like_this = new
			{
				like = new object[]
				{
					new
					{
						_index = "project",
						_type = "doc",
						doc = Project.InstanceAnonymous,
						_routing = Project.Instance.Name
					},
					"some long text"
				}
			}
		};

		protected override QueryContainer QueryFluent(QueryContainerDescriptor<Project> q) => q
			.MoreLikeThis(sn => sn
				.Like(l => l
					.Document(d => d
						.Document(Project.Instance)
						.Routing(Project.Instance.Name)
					)
					.Text("some long text")
				)
			);
	}
}
