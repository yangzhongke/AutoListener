using AutoListener.Core;
namespace AutoListener.TestConsoleApp1
{
    [EnableAutoListener]
    public partial class Person
    {
        public partial int Age { get; set; }
       public partial string Name { get; set; }

       public event Action<string> OnPropertyChanged;
    }
}
