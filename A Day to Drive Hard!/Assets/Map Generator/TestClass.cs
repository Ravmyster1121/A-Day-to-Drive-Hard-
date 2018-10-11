﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite4Unity3d;


//
//Is purely a test class, will be deleted once finished
//
public class TestClass
{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return string.Format("[Person: Id={0}, Name={1},  Surname={2}, Age={3}]", Id, Name, Surname, Age);
    }
}