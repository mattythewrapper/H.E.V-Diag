using System;
using System.IO;
using System.Reflection;
using System.Media;
using System.Threading;

namespace dndidk
{
    class Program
    {

        static int userProfileCount = 3;
        static string diagDataKb = "3278 KB";
        static string userDataKb = "6498 KB";
        static string sysLogsKb = "358 KB";
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!!!!!!WARNING!!!!!!!!!!!");
            Console.WriteLine("YOU ARE ACCESSING HIGHLY RESTRICTED GOVERNEMENT INFORMATION");
            Console.WriteLine("UNAUTHORIZED ACCESS OF THIS INFORMATION SYSTEM IS HIGHLY PROHIBITED AND WILL BE MET WITH SEVERE PUNISHMENT BY THE UNITED STATES DEPARTMENT OF DEFENSE");
            Console.WriteLine("BY CONTINUING TO ACCESS THIS DATA, YOU ARE ACKNOWLEDGING THAT UNAUTHORIZED USE / MISUSE OF THIS SYSTEM IS HIGHLY PROHIBITED AND WILL RESULT IN SEVERE PENALTY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to continue...");

            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("HAZARDOUS ENVIRONMENT SUIT MANAGEMENT CONSOLE VERSION 3.1.2");
            Console.WriteLine("----------------------MAIN MENU----------------------------");
            Console.WriteLine("1. WEAPON AND MUNITIONS INVENTORY SYSTEM SELF TEST");
            Console.WriteLine("2. USER HEALTH LIFE SUPPORT SYSTEM SELF TEST");
            Console.WriteLine("3. ENVIRONMENT DETECTION SYSTEM SELF TEST");
            Console.WriteLine("4. SYSTEM RESET");
            Console.WriteLine("5. REMOTE TRACKING SYSTEM SELF TEST");
            Console.WriteLine("6. ABOUT THIS H.E.V SUIT");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    weaponSelfTest();
                    break;
                case "2":
                    lifeSupportTest();
                    break;
                case "3":
                    enviroTest();
                    break;
                case "4":
                    sysReset();
                    break;
                case "5":
                    trackingTest();
                    break;
                case "6":
                    about();
                    break;
            }

        }

        public static void weaponSelfTest()
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------WEAPON AND MUNITIONS INVENTORY SELF TEST-------------");
            Console.WriteLine("RESETTING CURRENT AMMUNITION COUNTS...");

            Assembly a = Assembly.GetExecutingAssembly();
            Stream s = a.GetManifestResourceStream("dndidk.ammo_depleted.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();

            
            Console.WriteLine("AMMUNITION COUNT RESET SUCCESSFULLY");
            Console.WriteLine("INVENTORY IN PROEGRESS...");
            Console.WriteLine("WEAPON SLOT ONE");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON SLOT TWO");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("WEAPON SLOT THREE");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON SLOT FOUR");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON SLOT FIVE");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON SLOT SIX");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON SLOT SEVEN");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAPON INVENTORY SYSTEM SELF CHECK COMPLETED, NO ERRORS DETECTED");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU...");

            Console.ReadKey();

            Main();
        }

        public static void lifeSupportTest()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------LIFE SUPPORT SYSTEMS TEST-------");
            Console.WriteLine("CHECKING ONBOARD EKG...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING POISON DETECTION SYSTEM...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING AUTOMATED MEDICINE INJECTION SYSTEM...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("! WARNING ! ONBOARD AED SYSTEM WILL BE TESTED, PLEASE DO NOT TOUCH THE H.E.V SUIT UNTIL THE TEST HAS COMPLETED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PRESS ENTER TO CONTINUE AED TESTING");
            Console.ReadKey();
            Console.WriteLine("TESTING ONBOARD AED SYSTEM");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("AED TEST COMPLETED, IT IS NOW SAFE TO TOUCH THE H.E.V SUIT");
            Thread.Sleep(2000);
            Console.WriteLine("CHECKING MEDICINE SUPPLY");
            Console.WriteLine("MORPHINE LEVELS");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING EPINEPHRINE LEVELS...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING SALINE SOLUTION LEVLS...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ONBOARD MEDICAL SYSTEMS SELF CHECK COMPLETED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU");
            Console.ReadKey();
            Main();
            
           
        }

        public static void enviroTest()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----ENVIRONMENTAL DETECTION SYSTEM SELF TEST-----");
            Console.WriteLine("CHECKING GEIGER COUNTER");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING TOXIN DECTION SYSTEM");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ENVIRONMENTAL DETECTION SYSTEM SELF TEST COMPLETED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU");
            Console.ReadKey();
            Main();
        }

        public static void sysReset()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----- H.E.V SUIT RESET -----");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING! EXECUTING THE H.E.V SYSTEM RESET WILL DELETE ALL ONBOARD DATA AND LOGS");
                Console.WriteLine("DO YOU WISH TO CONTINUE? Y/N");

                string input = Console.ReadLine();
                if(input == "Y" || input == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SYSTEM RESET CONFIRMED, STARTING RESET");
                    Console.WriteLine("CLEARING LOGS...");
                    sysLogsKb = "0 KB";
                    Thread.Sleep(1000);
                    Console.WriteLine("### CLEARING DIAGNOSTIC DATA... ###");
                    diagDataKb = "0 KB";
                    Thread.Sleep(2000);
                    Console.WriteLine("### REMOVING USER PROFILES... ###");
                    userDataKb = "0 KB";
                    Thread.Sleep(1000);
                    Console.WriteLine("REMOVING USER PROFILE: FREEMAN, GORDON");
                    Thread.Sleep(2000);
                    Console.WriteLine("REMOVING USER PROFILE: CROSS, GINA");
                    Thread.Sleep(2000);
                    Console.WriteLine("REMOVING USER PROFILE: GREEN, COLETTE");
                    userProfileCount = 0;
                    Console.WriteLine("### USER PROFILES REMOVED ###");
                    Thread.Sleep(2000);
                    Console.WriteLine("### RESETTING CURRENT CONFIGURATION ###");
                    Thread.Sleep(1000);
                    Console.WriteLine("### CONFIGURATION RESET COMPLETED ###");
                    Console.WriteLine("### REMOVING JUNK FILES ###");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SYSTEM RESET COMPLETED, PRESS ENTER TO RETURN TO THE MAIN MENU");
                    Console.ReadKey();
                    Main();
                    break;
                    
                }

                if(input == "n" || input == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SYSTEM RESET CANCELED BY USER, PRESS ENTER TO RETURN TO THE MAIN MENU");
                    Console.ReadKey();
                    Main();
                    break;
                }
                if(input != "N" || input != "n" || input != "y" || input != "Y")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT DETECTED, PLEASE ENTER A VALID INPUT");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("PRESS ENTER TO TRY AGAIN");
                    Console.ReadKey();
                    sysReset();
                    break;
                }
            }
        }

        public static void trackingTest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----- H.E.V ONBOARD TRACKING SYSTEMS SELF TEST -----");
            Console.WriteLine("CHECKING GPS TRACKING SYSTEM...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING ONBOARD MODEM...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TESTING RFID SYSTEM...");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CHECKING SATTELITE TRACKING...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TRACKING SYSTEM COMPLETED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU");
            Console.ReadKey();
            Main();
           
        }

        public static void about()
        {
            Console.Clear();
            if(userProfileCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----- ABOUT THIS H.E.V SUIT -----");
                Console.WriteLine("FIRMWARE VERSION: 1.2.7 A \n");
                Console.WriteLine("LAST DATE OF FIRMWARE UPDATE: 5-6-2003 \n");
                Console.WriteLine("HARDWARE REVISION: MARK V \n");
                Console.WriteLine("ONBOARD COMPUTER REVISION 2.4.3 B \n");
                Console.WriteLine("TOTAL ONBOARD DATA STORAGE: 4.4 GB \n");
                Console.WriteLine("CURRENT AVAILABLE STORAGE: 4.2 GB \n");
                Console.WriteLine("TOTAL USAGE TIME: 132 HOURS \n");
                Console.WriteLine("TOTAL USER PROFILE COUNT: " + userProfileCount);
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU");
                Console.ReadKey();
                Main();

                
            }
            if(userProfileCount == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----- ABOUT THIS H.E.V SUIT -----");
                Console.WriteLine("FIRMWARE VERSION: 1.2.7 A \n");
                Console.WriteLine("LAST DATE OF FIRMWARE UPDATE: 5-6-2003 \n");
                Console.WriteLine("HARDWARE REVISION: MARK V \n");
                Console.WriteLine("ONBOARD COMPUTER REVISION 2.4.3 B \n");
                Console.WriteLine("TOTAL ONBOARD DATA STORAGE: 4.4 GB \n");
                Console.WriteLine("CURRENT AVAILABLE STORAGE: 3.9 GB \n");
                Console.WriteLine("TOTAL USAGE TIME: 132 HOURS \n");
                Console.WriteLine("TOTAL USER PROFILE COUNT: " + userProfileCount + "\n");
                Console.WriteLine("USER PROFILE 1: FREEMAN, GORDON \n");
                Console.WriteLine("USER PROFILE 2: CROSS, GINA \n");
                Console.WriteLine("USER PROFILE 3: GREEN, COLETTE \n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER TO RETURN TO THE MAIN MENU");
                Console.ReadKey();
                Main();

            }
        }

    }
}
