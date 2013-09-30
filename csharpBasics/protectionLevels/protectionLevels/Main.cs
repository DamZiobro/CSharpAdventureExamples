using System;

namespace protectionLevels
{
    class TestClass {
        private int privateInt; //I - int having private protection level
        protected int protectedInt; //II - int having protected protection level
        public int publicInt; //III - int having public protection level
        internal int internalInt; //IV - int having internal protection level
    
        //V - public function returning value of private field
        public int getPrivateInt(){
            return privateInt;
        }

        //VI - assigning value to private field using public function
        public void setPrivateInt(int setValue){
            privateInt = setValue;
        }

    };

	class MainClass
	{
		public static void Main (string[] args)
		{
            TestClass testObject = new TestClass();
            //VII
            //testObject.privateInt = 5; //impossible to assign to private field directly
            //using public set function to assign to private field 
            testObject.setPrivateInt(5);

            //VIII
            //int a = testObject.privateInt; //cannot get value of private field
            //getting value of private field using public get function 
            int a = testObject.getPrivateInt();
		}
	};
}
