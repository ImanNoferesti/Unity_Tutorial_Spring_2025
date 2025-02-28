namespace NoteDirectory;

public class Math
{
    public int A;
    public int B;
    public int C;
    
    public Math()
    {
        
    }
    

    public Math(int a, int b, int c)
    {
        this.A = a;
        this.B = b;
        this.C = c;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    
}