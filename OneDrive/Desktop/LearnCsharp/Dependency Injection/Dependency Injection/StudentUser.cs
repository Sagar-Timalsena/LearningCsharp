﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class StudentUser : IUserInterface
    {
        public void PrintUser()
        {
            Console.WriteLine("This is Student User");
        }
    }
}
