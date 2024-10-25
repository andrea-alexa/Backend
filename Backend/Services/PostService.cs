﻿using Backend.DTOs;
using System.Text.Json;

namespace Backend.Services
{
    public class PostService : IPostService
    {
        private HttpClient _httpClient;

        public PostService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<PostDto>> Get()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1/comments";
            var result = await _httpClient.GetAsync(url);

            var body = await result.Content.ReadAsStringAsync();

            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var post = JsonSerializer.Deserialize<IEnumerable<PostDto>>(body);
            return post;
        }
    }
}
