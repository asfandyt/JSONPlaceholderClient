/*
 * This program references the JSON Placeholder API
 * Link: https://jsonplaceholder.typicode.com
 * Available endpoints: /posts, /comments, /albums, /photos, /todos, /users
 * Routes: GET -> /posts, /posts/1, /posts/1/comments, /comments?postId=1, 	/posts?userId=1
 * Routes: POST -> /posts | POST/PUT/PATCH/DELETE -> /posts/1
 * Notes:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JSONPlaceholderClient.Basic.Models;

namespace JSONPlaceholderClient.Basic
{
    class Program
    {
        // HttpClient is static to avoid overloading sockets
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            // Setting up the client
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            // Getting Posts from API
            var posts = await GetPostsAsync("/posts/1");

            Console.WriteLine(posts);

            Console.ReadLine();
        }

        static async Task<Post> GetPostsAsync(string path)
        {
            Post posts = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                // Deserializing response content based on Post model
                posts = await response.Content.ReadAsAsync<Post>();
            }

            return posts;
        }
    }
}
