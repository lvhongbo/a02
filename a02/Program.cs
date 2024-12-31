
using a02;

#region MyRegion
//Person tom = new Person(10001, "Tom", 20);
//Person jerry = new Person(10002, "Jerry", 18);

//Console.WriteLine(tom.Info());
//Console.WriteLine(jerry.Info());
#endregion

#region Animal
//List<Animal> animals = new List<Animal>();

//for (int i = 0; i < 10; i++)
//{
//    Dog dog = new Dog();
//    dog.Name = "小狗" + i;
//    animals.Add(dog);
//}

//for (int i = 0;i < 5; i++)
//{
//    Cat cat = new Cat();
//    cat.Name = "小猫" + i;
//    animals.Add(cat);
//}

//Animal a = new Animal();
//animals.Add(a);

//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal.Info());
//    if (animal is Cat)
//        Console.WriteLine(animal.Name+"是一只猫");
//    else if (animal is Dog)
//        Console.WriteLine(animal.Name + "是一只狗");
//    else
//        Console.WriteLine(animal.Name + "是未知的动物");

//    Console.WriteLine();

//}
#endregion

#region FileRead Write
//DateTime t1 = DateTime.Now;

//FileTools.WriteTextFile("d:/abcd.txt");


//DateTime t2 = DateTime.Now;
//Console.WriteLine("运行了:" + (t2 - t1).TotalSeconds + "秒");
#endregion

CallDataProcess.GenerateData("d:/call_data.txt");

