﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student_class.Interfaces
{
    interface IComparablle<Student>
    {
        int CompareTo(Student other);
    }
}
