using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiProxy.Controllers
{
	public class ProxyController : ApiController
	{
		[HttpGet]
		[Route("stripe/checkout.js")]
		public async Task<HttpResponseMessage> StripeCheckout()
		{
			var response = await new HttpClient().GetAsync("https://checkout.stripe.com/checkout.js");
			response.Headers.Add("Access-Control-Allow-Origin", "*");
			return response;
		}
	}
}
