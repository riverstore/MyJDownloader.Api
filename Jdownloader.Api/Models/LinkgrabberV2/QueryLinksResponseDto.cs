﻿using System;

namespace Jdownloader.Api.Models.LinkgrabberV2
{
	public class QueryLinksResponseDto
	{
		public AvailableLinkStateType AvailableLinkState { get; set; }

		public long BytesTotal { get; set; }

		public string Comment { get; set; }

		public string DownloadPassword { get; set; }

		public bool Enabled { get; set; }

		public string Host { get; set; }

		public long Id { get; set; }

		public string Name { get; set; }

		public long PackageId { get; set; }

		public PriorityType Priority { get; set; }

		public string Url { get; set; }
	}
}