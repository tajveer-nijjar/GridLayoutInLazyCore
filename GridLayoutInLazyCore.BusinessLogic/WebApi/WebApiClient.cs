using GridLayoutInLazyCore.Model.Dto;
using LazyCore.Foundation;
using LazyCore.Foundation.Web;
using Newtonsoft.Json;
using ProductX.BusinessLogic.EnvironmentManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductX.BusinessLogic.WebApi
{
    public class WebApiClient : IWebApiClient
    {
        private readonly IEnvironmentManager _environmentManager;
        private readonly IDeviceInfo _deviceInfo;
        private readonly IRestClientFactory _restClientFactory;

        private const double _longTimeOutSeconds = 40;

        public WebApiClient(IEnvironmentManager environmentManager, IDeviceInfo deviceInfo, IRestClientFactory restClientFactory)
        {
            _environmentManager = environmentManager;
            _deviceInfo = deviceInfo;
            _restClientFactory = restClientFactory;
        }

        public async Task<ValidationResponse> Validate()
        {
            Uri uri = new Uri("https://api.vimeo.com/tutorial");
            //uri = _environmentManager.FormatUriForSelectedEnvironment("tutorial");

            var result = await GetAsync<ValidationResponse>(uri);

            return result;
        }

        public async Task GetVideosOfAUser(long userId)
        {
           
        }

        public async Task<TResponse> PostAsync<TResponse>(Uri uri, object data)
        {
            if (!_deviceInfo.IsWwwReachable)
            {
                throw new TaskCanceledException("Ass");
            }

            var client = _restClientFactory.Create();
            return await client.PostAsync<TResponse>(uri, data);
        }

        private async Task<TResponse> GetAsync<TResponse>(Uri uri)
        {
            if (!_deviceInfo.IsWwwReachable)
            {
                throw new TaskCanceledException("Ass");
            }
            var client = _restClientFactory.Create();
            client.AddHeader("Authorization", "Bearer 686d8b1cb9aed775f933af6de095dd7b");
            return await client.GetAsync<TResponse>(uri);
        }

        /// <inheritdoc />
        //public async Task<TResponse> PostRawAsync<TResponse>(Uri uri, byte[] attachmentData)
        //{
        //    using (var client = new HttpClient())
        //    {

        //        using (Stream reader = new MemoryStream(attachmentData))
        //        {
        //            StreamContent content = new StreamContent(reader);

        //            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

        //            using (var response = await client.PostAsync(uri, content))
        //            {
        //                response.EnsureSuccessStatusCode();

        //                var responseString = await response.Content.ReadAsStringAsync();

        //                return JsonConvert.DeserializeObject<TResponse>(responseString);
        //            }
        //        }
        //    }
        //}
    }
}
