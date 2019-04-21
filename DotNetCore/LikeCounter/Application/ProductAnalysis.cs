using LikeCounter.LikeBox;
using System.Collections.Generic;
namespace LikeCounter
{
    // Subject
    public class ProductAnalysis : ILikeNumberProvider
    {
        private List<LikesCounter> counters = new List<LikesCounter>();
        private int likesNumber = 0;

        public void Add(LikesCounter counter) 
        {
            counters.Add(counter);
        }

        public void LikeProduct()
        {
            likesNumber++;

            foreach(var counter in counters)
            {
                counter.Update(likesNumber);
            }
        }

        public int GetNumberLikes()
        {
            return likesNumber;
        }
    }
}
