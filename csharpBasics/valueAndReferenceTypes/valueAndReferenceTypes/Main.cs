using System;

namespace valueAndReferenceTypes
{
    //I - Definition of test class - reference type
    class TestClass {
        private int testValue;
        public int getValue(){
            return testValue;
        } 

        public void setValue(int valueToSet){
            testValue = valueToSet;
        }
    }

    //II - definition of struct type - value type
    struct TestStruct {
        public int testValue;
    }


	class MainClass
	{
        public static void changeValuesOfClassAndStruct(TestClass testClass, TestStruct testStruct, int testInt){
            testClass.setValue(10);
            testStruct.testValue = 20;
            testInt = 30;
        }

		public static void Main (string[] args)
        {
            //III - Initialization and value assignment for different types
            TestClass testClass = new TestClass();
            TestStruct testStruct;
            int testInt;

            testClass.setValue(1);
            testStruct.testValue = 2;
            testInt = 3;

            //IV - printing current values of different objects and variables 
            Console.WriteLine("testClass.testValue is: " + testClass.getValue());
            Console.WriteLine("testStruct.testValue is: " + testStruct.testValue);
            Console.WriteLine("testInt is: " + testInt);
            Console.WriteLine("===========================");

            //V - passing variales to custom function and try to change its
            //values inside that function
            changeValuesOfClassAndStruct(testClass, testStruct, testInt);

            //VI - printing values after invoking custom function
            Console.WriteLine("testClass.testValue is: " + testClass.getValue());
            Console.WriteLine("testStruct.testValue is: " + testStruct.testValue);
            Console.WriteLine("testInt is: " + testInt);

        }
	}
}
