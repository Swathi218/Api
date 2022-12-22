using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace newapplication
{
 class Program
 {
   HttpClient client = new HttpClient();
    
     static async Task Main(string[] args)
    {
      Program program = new Program();
    await program.GetTodoItems();

   }
   private async Task GetTodoItems()
    {
      string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");

                Console.WriteLine(response);


            List<Todo> todo = JsonConvert.DeserializeObject<List<Todo>>(response);

          foreach( var item in todo)
        {

         Console.WriteLine(item.title);
    }

    }

    }
    class Todo
    {
      public int UserId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string Completed { get; set; }

    }
    }