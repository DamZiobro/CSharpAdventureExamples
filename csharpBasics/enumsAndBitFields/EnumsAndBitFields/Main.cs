using System;

namespace EnumsAndBitFields
{
    //I - normal enumeration
    enum Days {
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
    }

    //II - bit field enumeration
    [Flags]
    enum LEDs {
        LED_1 = 0x01,
        LED_2 = 0x02,
        LED_3 = 0x04,
        LED_1And2 = 0x03,
        ALL = 0x07,
    }

	class MainClass
	{
		public static void Main (string[] args)
        {
            //III - using normal enumeration
            Days today = Days.Saturday;
            if(today == Days.Saturday || today == Days.Sunday){
                Console.WriteLine("It is weekend...");
            }

            //IV - using bit field enumeration
            LEDs flashingLEDs = LEDs.LED_2 | LEDs.LED_3 | LEDs.LED_1;

            if((flashingLEDs & LEDs.LED_1) == LEDs.LED_1){
                Console.WriteLine("Flashing LED1");
            } 
            if((flashingLEDs & LEDs.LED_2) == LEDs.LED_2){
                Console.WriteLine("Flashing LED2");
            } 
            if((flashingLEDs & LEDs.LED_3) == LEDs.LED_3){
                Console.WriteLine("Flashing LED3");
            } 
            if((flashingLEDs & LEDs.LED_1And2) == LEDs.LED_1And2){
                Console.WriteLine("Flashing LED1And2");
            } 
            if((flashingLEDs & LEDs.ALL) == LEDs.ALL){
                Console.WriteLine("Flashing ALL LEDs");
            }   

        }	
	}
}
