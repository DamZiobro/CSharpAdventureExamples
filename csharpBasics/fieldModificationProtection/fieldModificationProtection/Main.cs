using System;

namespace fieldModificationProtection
{

    class TestClass {
        //IV - constructor of our class - readonly field can be modified here
        public TestClass(){
            modificableField *= 2; //V   - no compilation error - can be modificable anywhere withing TestClass
            readonlyField *= 2;    //VI  - no compilation error - can be modify only within constructor 
            //constField *=2;      //VII - compilation error - cannot be modify anywhere
        }

        //IVa - additional field for modification values of private fields
        public void modifyFields(){
            modificableField *= 2; //VII   - no compilation error - can be modificable anywhere withing TestClass
            //readonlyField *= 2;    //IX  - compilation error - can be modify only within constructor
            //constField *=2;      //X - compilation error - cannot be modify anywhere
        }

        //I - modificabel field
        private int modificableField = 1;

        //II - read-only field 
        private readonly int readonlyField = 5;

        //III - const field 
        private const int constField = 10;

    }

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("fieldModificationProtection example");
		}
	}
}
