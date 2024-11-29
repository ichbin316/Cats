namespace Cats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            
            Cats miso = new Cats("miso");

            Console.ReadKey();

            miso.speak();

            bool sleeping = true;


            if (sleeping == true) { 
                
                miso.nap();
            }  
            

            Console.ReadKey();
            

        }
    }
    class Cats

    {
        // Everything that exist needs a name 
        public string name;
        public Cats(string myname)
        {
            name = myname;

        }

        // A cat needs a voice!
        public void speak()
        {

            Console.WriteLine("hello my name is " + name);



        }

        public void nap()
        {

            Console.WriteLine(name + " is sleeping");
        }




    }
}

