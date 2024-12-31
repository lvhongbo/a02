using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public Person(int id,string name,int age) {
            Id = id;
            Name = name;
            Age = age;
        }

        public Person() 
        {
            Id = 0;
            Name = string.Empty;
            Age = 0;
        }

        public string Info()
        {
            return string.Format("个人信息 名字:{0},编号:{1},年龄:{2}", Name, Id, Age);
        }

    }
}
