﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SubSync.Tests")]
namespace SubSync
{
    class Program
    {
        static void Main(string[] args)
        {
            SubSyncLib.Program.Main(args);
        }
    }
}
