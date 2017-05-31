using System;
using System.Collections.Generic;


    class Generic_List
    {



        static void Main(string[] args)
        {

            //System.Collections.Generic.List<String> listOfStrings = new System.Collections.Generic.List<String>();
            List<String> listOfStrings = new List<String>();
            
            listOfStrings.Add("hello");
            listOfStrings.Add("world");
            listOfStrings.Add("again");


            foreach(String s in listOfStrings){
                Console.WriteLine( s + "");
            }

            listOfStrings.Sort();

            foreach(String i in listOfStrings){
                Console.WriteLine("sorted: " + i);

            }

            if (listOfStrings.Contains("hello")){
                Console.WriteLine("Yep");
            }else{
                Console.WriteLine("Nah");
            }


            

		
      

        }
    
}
