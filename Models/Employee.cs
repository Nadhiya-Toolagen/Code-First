using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Models{

public class Employee{
    public int id{get;set;}
    public string name{get;set;} 
    public int age {get;set;}
    public int salary {get;set;}
}
}