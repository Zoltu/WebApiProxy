using System.Diagnostics.Contracts;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiProxy
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			SetupCrossOriginRequests(config);
			SetupRoutes(config);
		}

		private static void SetupCrossOriginRequests(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);
		}

		private static void SetupRoutes(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			config.MapHttpAttributeRoutes();
		}
	}
}
