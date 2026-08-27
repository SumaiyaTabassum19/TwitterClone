using TwitterClone.Domain.Entities;

namespace TwitterClone.Test
{
    public class TestClass_10
    {
        public void Run()
        {
            Tweet likeableTweet = new Tweet("This is another tweet!");

            Console.WriteLine(likeableTweet.CanBeLiked());

            var maxTweetLength = 200;

            Console.WriteLine($"Maximum tweet length: {maxTweetLength}");
        }
    }
}