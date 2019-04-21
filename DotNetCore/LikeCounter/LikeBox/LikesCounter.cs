using System;
namespace LikeCounter.LikeBox
{
    // Observer
    public class LikesCounter
    {
        private readonly ILikeNumberProvider likeNumberProvider;

        public void Update(int number)
        {
            Console.WriteLine(number);
        }
        public LikesCounter(ProductAnalysis product)
        {
            product.Add(this);
        }

    }
}
