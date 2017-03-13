using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_FacebookPosts
{
    class FacebookPosts
    {
        static void Main()
        {
            var like = new Dictionary<string, int>();
            var dislike = new Dictionary<string, int>();
            var comment = new Dictionary<string, Dictionary<string, List<string>>>();

            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("drop the media"))
            {
                var tokens = inputLine.Split(' ');

                if (tokens[0] == "post") 
                {
                    if (!like.ContainsKey(tokens[1]))
                    {
                        like[tokens[1]] = 0;
                    }
                    if (!dislike.ContainsKey(tokens[1]))
                    {
                        dislike[tokens[1]] = 0;
                    }
                    if (!comment.ContainsKey(tokens[1]))
                    {
                        comment[tokens[1]] = new Dictionary<string, List<string>>();
                    }
                }
                // ---------------------------------------- likes and dislikes
                if (tokens[0] == "like")
                {
                    like[tokens[1]]++;
                }
                if (tokens[0] == "dislike")
                {
                    dislike[tokens[1]]++;
                }

                if (tokens[0] == "comment") // ------------ comments
                {
                    if (tokens.Length > 2)
                    {
                        if (!comment[tokens[1]].ContainsKey(tokens[2]))
                        {
                            comment[tokens[1]][tokens[2]] = new List<string>();
                        }

                    }

                    if (tokens.Length > 3)
                    {
                        for (int i = 3; i < tokens.Length; i++)
                        {
                            comment[tokens[1]][tokens[2]].Add(tokens[i]);
                        }
                        
                    }
                }


                inputLine = Console.ReadLine();

            }// end of while

            foreach (var items in comment)
            {
                var key = items.Key;

                if (dislike.ContainsKey(key) && like.ContainsKey(key))
                {
                    Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}",key, like[key], dislike[key]);
                    Console.WriteLine("Comments:");
                }
                
                if (items.Value.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var item in comment[key])
                    {
                        var user = item.Key;
                        var userComment = item.Value;

                        Console.WriteLine("*  {0}: {1}", user, string.Join(" ",userComment));
                    }
                }
            }
        }
    }
}
