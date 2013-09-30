using System;

namespace fieldPropertyDifference
{
    public class TestClass {
        //I - field declaration
        int testField;

        //II - property having default get and set methods
        public int TestProperty { get; set; }

        //III - property declaration - Properties has get and set functions
        public int TestFieldProperty { 
            get{
              return testField;   
            } 
            set{
                testField = value * 2; // customized assigning of testField
            } 
        } 

    }

	class MainClass
	{
		public static void Main (string[] args)
        {
            Console.WriteLine ("Assigning properties values");
            TestClass testClassObject = new TestClass();
            //testClassObject.testField = 5; //IV - inaccessible because of private protection level
            testClassObject.TestProperty = 10; //V - assigning value to TestProperty using set method
            testClassObject.TestFieldProperty = 10; //VI - assigning testField value using TestFieldProperty

            Console.WriteLine("TestProperty: " + testClassObject.TestProperty); //VII - using get method of TestProperty
            Console.WriteLine("testField: " + testClassObject.TestFieldProperty); //VIII - suing get method of TestFieldProperty

        }
	}
}
