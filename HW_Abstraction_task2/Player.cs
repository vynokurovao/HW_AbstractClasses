using System;

namespace HW_Abstraction_task2
{
    public class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("The music is playing now");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("The playing process is paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("The playing process is stopped");
        }

        public void Record()
        {
            Console.WriteLine("The player is recording now");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("The recording process is paused");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine( "The recording process is stopped");
        }
        
    }
}
