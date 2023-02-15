  using System;
//start main
int userChoice = GetUserChoice();
do{
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}while(userChoice!= 3);
//end main


static void GetFull() {
         Random rand = new Random();
         int rows = rand.Next(3, 10);
         for (int i = 1; i <= rows; i++){
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += "O  ";
                }
                Console.WriteLine(row);
         }
    Pause();
     }
  
  static void GetPartial(){
        Random rand = new Random();
        int rows = rand.Next(3, 9);          
        for (int i = 1; i <= rows; i++){
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (rand.Next(0, 2) == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        Pause();
 }

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to see a mint condition pyramid\nEnter 2 to see a modern condition pyramid\nEnter 3 to exit");
}

static int GetUserChoice(){
    DisplayMenu();
    string userChoice= Console.ReadLine();
    if(IsValidCHoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static bool IsValidCHoice(string userInput){
    if(userInput=="1" || userInput=="2" || userInput=="3"){
        return true;
    }
    else return false;
}

static void InvalidChoice(){
     Console.WriteLine("Invalid Entry");
     Pause();
}

static void RouteEm(int userChoice){
    if(userChoice== 1){
        GetFull();
    }
    else if(userChoice==2){
        GetPartial();
    }
    else if(userChoice!=3){
        InvalidChoice();
    }
}

static void Pause(){
    Console.WriteLine("Hit any key to continue");
    Console.ReadKey();
}