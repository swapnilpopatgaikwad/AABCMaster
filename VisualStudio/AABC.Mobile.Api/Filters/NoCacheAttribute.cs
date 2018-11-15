﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace AABC.Mobile.Api.Filters
{
	public class NoCacheAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			if (actionExecutedContext.Response != null)
			{
				actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue { NoCache = true, Private = true };
			}
		}
	}
}
