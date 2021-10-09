using Microsoft.VisualStudio.Services.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TakeHomeAssignment.Controllers;
using TakeHomeAssignment.Data;

namespace TakeHomeAssignment.HttpClients
{
    public class BaseClient
    {
        protected HttpClient HttpClient { get; }

        public BaseClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public BaseClient(HttpClient httpClient, Uri uri) : this(httpClient)
        {
            HttpClient.BaseAddress = uri;
        }

        public async Task<T> GetAsync<T>(string path, string contentType = "application/json")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, path);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

            var response = await HttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
   
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                response.EnsureSuccessStatusCode();

                using (var streamReader = new StreamReader(stream))
                {
                    using (var jsonReader = new JsonTextReader(streamReader))
                    {
                        var serializer = new Newtonsoft.Json.JsonSerializer();

                        return serializer.Deserialize<T>(jsonReader);
                    }
                }
            }

        }
    }
}
