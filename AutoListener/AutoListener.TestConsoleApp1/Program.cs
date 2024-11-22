using AutoListener.TestConsoleApp1;

Person person = new Person();

person.OnPropertyChanged += (prop) => Console.WriteLine($"Property {prop} changed");
person.Age++;
