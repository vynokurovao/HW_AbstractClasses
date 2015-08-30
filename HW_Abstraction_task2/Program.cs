﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Abstraction_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();
            player.Record();
            (player as IRecordable).Pause();
            (player as IRecordable).Stop();
            Console.ReadKey();
        }
    }
}
