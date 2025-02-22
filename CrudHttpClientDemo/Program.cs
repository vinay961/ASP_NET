using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// Define a class for Post data
public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}

// Define a service for CRUD operations
public class CrudService
{
    private readonly HttpClient _httpClient;
    private const string BASE_URL = "https://jsonplaceholder.typicode.com/posts";

    public CrudService()
    {
        _httpClient = new HttpClient();
    }

    // Read (GET) - Fetch posts
    public async Task<List<Post>> GetPostsAsync()
    {
        HttpResponseMessage response = await _httpClient.GetAsync(BASE_URL);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Post>>(responseBody);
    }

    // Create (POST) - Add a new post
    public async Task<Post> CreatePostAsync(Post newPost)
    {
        string jsonContent = JsonSerializer.Serialize(newPost);
        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync(BASE_URL, content);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Post>(responseBody);
    }

    // Update (PUT) - Modify an existing post
    public async Task<Post> UpdatePostAsync(int postId, Post updatedPost)
    {
        string jsonContent = JsonSerializer.Serialize(updatedPost);
        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PutAsync($"{BASE_URL}/{postId}", content);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Post>(responseBody);
    }

    // Delete (DELETE) - Remove a post
    public async Task<bool> DeletePostAsync(int postId)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync($"{BASE_URL}/{postId}");
        return response.IsSuccessStatusCode;
    }
}

// Main Program to test CRUD operations
class Program
{
    static async Task Main()
    {
        CrudService crudService = new CrudService();

        // Read (GET) - Fetch Posts
        Console.WriteLine("Fetching posts...");
        var posts = await crudService.GetPostsAsync();
        foreach (var post in posts)
        {
            Console.WriteLine($"{post.Id}: {post.Title}");
            if (post.Id == 5) break; // Show only 5 posts
        }

        // Create (POST) - Add a New Post
        Console.WriteLine("\nCreating a new post...");
        Post newPost = new Post { UserId = 1, Title = "New Post Title", Body = "This is a new post" };
        Post createdPost = await crudService.CreatePostAsync(newPost);
        Console.WriteLine($"Created Post ID: {createdPost.Id}, Title: {createdPost.Title}");

        // Update (PUT) - Modify an Existing Post
        Console.WriteLine("\nUpdating Post ID 1...");
        Post updatedPost = new Post { UserId = 1, Id = 1, Title = "Updated Title", Body = "Updated body content" };
        Post result = await crudService.UpdatePostAsync(1, updatedPost);
        Console.WriteLine($"Updated Post: {result.Title}");

        // Delete (DELETE) - Remove a Post
        Console.WriteLine("\nDeleting Post ID 1...");
        bool isDeleted = await crudService.DeletePostAsync(1);
        Console.WriteLine($"Post deleted: {isDeleted}");
    }
}
