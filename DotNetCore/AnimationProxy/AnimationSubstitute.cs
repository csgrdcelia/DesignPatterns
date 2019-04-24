namespace AnimationProxy
{
    public class AnimationSubstitute : IAnimation
    {
        public Photo Photo { get; set; }
        public Film Film { get; set; }
        public AnimationSubstitute() 
        {

        }

        public void Show() 
        {
            if(Film == null)
                Photo.Show();
            else
                Film.Show();
        }

        public void Clic()
        {
            if(Film == null)
                Film = new Film();
            Film.Run();
        }
        
    }
}