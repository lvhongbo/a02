using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal() 
        {
            Name = "None";
        }

        public virtual string MakeSound()
        {
            return "未知的叫声";
        }

        public string Info()
        {
            return "此动物是："+Name+",叫声："+MakeSound();
        }
    }

    public class Dog:Animal 
    {
        public Dog()
        {
            Name = "狗";
        }

        public override string MakeSound()
        {
            return "汪~汪";
        }
    }

    public class Cat : Animal 
    {
        public Cat()
        {
            Name = "猫";
        }

        public override string MakeSound()
        {
            return "喵~喵";
        }
    }
}
