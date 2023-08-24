namespace Association_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            Child child = new Child();
            child.Father = father;
            father.Child = child;
            
        }
    }
}