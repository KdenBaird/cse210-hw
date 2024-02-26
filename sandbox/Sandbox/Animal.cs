public abstract class Animal 
{
    //abstract measn that there can't be any functionality it's just the blueprint. if you put "abstract" 
    // before void it will come up error.
   

    private string name;
    protected Animal (string name);
    {
            ThreadStaticAttribute.name = name;
    }
     public virtual void MakeSound()
    {
        Console.WriteLine("Ominous Silence");
    }

}