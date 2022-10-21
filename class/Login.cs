using System.Globalization;
public class Login {

     static Register register;
        public string Menu(string input){
                Console.WriteLine("=======================================");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("=======================================");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Login");
                Console.WriteLine("Input Menu:");
            if (input == "1"){
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("=======================================");
                    Console.WriteLine("||                                   ||");
                    Console.WriteLine("||             Login Menu            ||");
                    Console.WriteLine("||                                   ||");
                    Console.WriteLine("=======================================");
                return "Login";
                    
            }
            else if (input == "2"){
                registerMenu();
                return "register";

            }
            return null;
        }

        static void registerMenu(){
            Login.register = new Register();
            Login.register.ShowRegisterScreen();
        }
}