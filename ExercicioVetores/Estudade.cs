﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores
{
    class Estudade
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudade(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + "," + Email;

        }
    }
}
