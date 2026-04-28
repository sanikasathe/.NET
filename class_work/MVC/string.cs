class strings{
    public static void Main(){
        string txt = "Hello world!!";
        System.Console.WriteLine(txt);
        System.Console.WriteLine();

        //methods
        System.Console.WriteLine("ToUpper() method : ");
        string upper =  txt.ToUpper();
        System.Console.WriteLine(upper);
        System.Console.WriteLine();

        System.Console.WriteLine("ToLower() method : ");
        string lower = txt.ToLower();
        System.Console.WriteLine(lower);
        System.Console.WriteLine();

        //String concatenation
        System.Console.WriteLine("String concatenation : ");
        string firstName = "Sanika";
        string lastName = " sathe";
        string name = firstName + lastName;
        System.Console.WriteLine(name);
        System.Console.WriteLine();

        System.Console.WriteLine("string.Concat() :  ");
        string name1 = string.Concat(firstName + lastName);
        System.Console.WriteLine(name1);
        System.Console.WriteLine();

        //Accessing string
        System.Console.WriteLine("Get Specific chracter : ");
        System.Console.WriteLine(name[0]);
        System.Console.WriteLine();

        System.Console.WriteLine("IndexOf(): ");
        System.Console.WriteLine(name.IndexOf("C"));
        System.Console.WriteLine();

      


    }
}
