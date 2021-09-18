using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payroll_Application
{
	
	class VariableHolderClass
	{
		public string inputname; //Used in LoginClass
		public string inputname2 = "adrian";  //Used in LoginClass
       	public string password; //Used in LoginClass
		public string password2 = "adrian5768"; //Used in LoginClass
		public int NumofTries = 5; // Number of attempts in Name & Password and Used in LoginClass
		public string Selection; // Used in everything thats needs to select or choose
		public string answer;
		public int correctNum;
		public string correctNum2;
		public int Yourscore = 0;
		public int Myscore = 0;
		public int guess;
		public string input;
		public string textToEnter1 = "Payroll System Application: 3.0.1 by Adrian";
		public string textToEnter2 = "Welcome to  Main Menu";
		public string textToEnter3 = "Welcome to Game Menu";
		public string textToEnter4 = "Welcome to Employee's Information";
		public string textToEnter5 = "Employee's tax and financial information";
		public string textToEnter6 = "Employee hourly schedules";
		public string textToEnter7 = "Payroll Records";
	}
	
	class MainClass
	{
		static void Main(string[] args)
		{
			
			VariableHolderClass VariableHolderClassGateWay = new VariableHolderClass();
			LoginClass LoginClassGateWay = new LoginClass();
			// Intro
        	Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter1.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter1));
            Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" ");
			// Login
			LoginClassGateWay.Login();
			// After failing to login 5xor exiting the system
		    Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Try again Later");
		    Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.White;
		    				
		
		}
	}
	
	class LoginClass
	{
		public void Login()
		{
			
			VariableHolderClass VariableHolderClassGateWay = new VariableHolderClass();
			MainSelectionClass MainSelectionClassGateWay = new MainSelectionClass();
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Enter the Application??");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Y for Yes or N for No: ");
				VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
				
				if (VariableHolderClassGateWay.Selection == "Y")
				{
					while(true)
					{
						if (VariableHolderClassGateWay.Selection == "N")
						{
						break;
						}
						// Insert Name & Password
						Console.Write("Your name(adrian): ");
				 	   	VariableHolderClassGateWay.inputname = Console.ReadLine();
						Console.Write("Password(adrian5768): ");
				    	VariableHolderClassGateWay.password = Console.ReadLine();
						// Number of Tries Left
						Console.WriteLine("{0} attempt(s) left", VariableHolderClassGateWay.NumofTries); VariableHolderClassGateWay.NumofTries--;
						//Number of attempts allowed
				    	if (VariableHolderClassGateWay.NumofTries < 0)
						{
							return;
						}
						// Failed to login and number of tries
						if (VariableHolderClassGateWay.inputname != VariableHolderClassGateWay.inputname2 && VariableHolderClassGateWay.password != 			VariableHolderClassGateWay.password2)
						{
							Console.ForegroundColor = ConsoleColor.Red;
				   	 		Console.WriteLine(" ");
							Console.WriteLine("Login Failed, pls try again");
			 		   		Console.ForegroundColor = ConsoleColor.White;
				    		continue;
						}
						// Successful Login
						if (VariableHolderClassGateWay.inputname == VariableHolderClassGateWay.inputname2 && VariableHolderClassGateWay.password == VariableHolderClassGateWay.password2)
						{
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine(" ");
							Console.WriteLine("Login Successful");
							Console.ForegroundColor = ConsoleColor.White;
							//Entering the system
							MainSelectionClassGateWay.MainSelection();
						}
						
						
					}
				
				}
				
				else if (VariableHolderClassGateWay.Selection == "N")
				{
					Console.WriteLine(" ");
					Console.WriteLine("Goodbye");
					Console.WriteLine(" ");
					Environment.Exit(0);
				}
				
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
				    Console.WriteLine(" ");
					Console.WriteLine("Error, Pls try again");
		            Console.WriteLine(" ");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}					
			}
			
		}
	}
	
	class MainSelectionClass
	{
		VariableHolderClass VariableHolderClassGateWay = new VariableHolderClass();
		LoginClass LoginClassGateWay = new LoginClass();
		public void MainSelection()
		{
			VariableHolderClass VariableHolderClassGateWay = new VariableHolderClass();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Welcome {0} :)", VariableHolderClassGateWay.inputname2);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter2.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter2));
			Console.WriteLine(" ");
			// Selection On Shopping Application
			
			Console.ForegroundColor = ConsoleColor.White;
			List<int> firstlist = new List<int>();
		    List<int> firstlist2 = new List<int>();
		    firstlist.Add(1);
		    firstlist.Add(2);		
		    Console.Write("There is a total of " + firstlist.Count);
		    Console.WriteLine(" available functions in Game Menu"); 
		    firstlist2.Add(1);
		    firstlist2.Add(2);
		    firstlist2.Add(3);
		    Console.Write("There is a total of " + firstlist2.Count);		
		    Console.WriteLine(" available functions in Employee's Information"); 
		    int sum = firstlist2.Count + firstlist.Count;
		    Console.WriteLine("A total of " + sum + " available functions in the whole App");
			Console.WriteLine(" ");
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Available Items: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Type G for the Game the Employee created");
			Console.WriteLine("Type E for Employee's Information");
			Console.WriteLine("Close");
			Console.WriteLine(" ");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			// Choices in the main selection
			// To enter Game Selection
			if (VariableHolderClassGateWay.Selection == "G")
			{
				GameMenu();
			}	
			// To enter Cloth selection
			else if (VariableHolderClassGateWay.Selection == "E")
			{
				EmployeeInfo();
			}
			// Closing the selection/app
			else if (VariableHolderClassGateWay.Selection == "CLOSE")
			{
				LoginClassGateWay.Login();
			}
			// reload when there is an error
			else 
			{
		        Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Try again");
		        Console.ForegroundColor = ConsoleColor.White;
				MainSelection();
			}	
		}
		public void GameMenu()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter3.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter3));
			Console.WriteLine(" ");
		    Console.ForegroundColor = ConsoleColor.White;
			// Selection of Available Games
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Available Games: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Type RPS for Rock, Paper & Scissor Game Demo");
			Console.WriteLine("Type GAN for Guess a Number Game Demo");
			Console.WriteLine("Back");
			Console.WriteLine(" ");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			
			// when RPS is selected
			if (VariableHolderClassGateWay.Selection == "RPS")
			{
				RPSGame();
			}
			// when GAN is selected
			if (VariableHolderClassGateWay.Selection == "GAN")
			{
				GANGame();
			}
			
			if (VariableHolderClassGateWay.Selection == "BACK")
			{
				MainSelection();
			}
			
			else 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" ");
				Console.WriteLine("Error, Pls try again");
		        Console.WriteLine(" ");
				Console.ForegroundColor = ConsoleColor.White;
				GameMenu();
			}
			

		}
		public void RPSGame() // Inside the RPSGame of Game Menu
		{
			Random random = new Random();
			// Intro of RPSGame
            Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Rock, Paper, Scissor Mini Game: 1.0.0 by Adrian");
			Console.ForegroundColor = ConsoleColor.White;
			// Instruction
			Console.WriteLine("Type R for rock, P for paper, S for scissor an N to stop");				
			while  (true)
			{
				//VariableHolderClassGateWay.answer
				VariableHolderClassGateWay.answer = Console.ReadLine().ToUpper();
		    	VariableHolderClassGateWay.correctNum = random.Next(1, 6);
				VariableHolderClassGateWay.correctNum2 = "No Data";		
				if (VariableHolderClassGateWay.answer == "R")
				{
					VariableHolderClassGateWay.answer = "R";
				}		
				else if (VariableHolderClassGateWay.answer == "P")
				{
					VariableHolderClassGateWay.answer = "P";
				}		
				else if (VariableHolderClassGateWay.answer == "S")
				{
					VariableHolderClassGateWay.answer = "S";
				}		
				else if (VariableHolderClassGateWay.answer == "N")
				{
					VariableHolderClassGateWay.answer = "N";
				}		
				else 
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Not in the choices, pls try again");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}		
				// VariableHolderClassGateWay.correctNum convert to VariableHolderClassGateWay.correctNum2
				if (VariableHolderClassGateWay.correctNum == 1)
				{
					VariableHolderClassGateWay.correctNum2 = "R";
				}		
				else if (VariableHolderClassGateWay.correctNum == 2)
				{
					VariableHolderClassGateWay.correctNum2 = "P";
				}	
				else if (VariableHolderClassGateWay.correctNum == 3)
				{
					VariableHolderClassGateWay.correctNum2 = "S";
				}		
				else if (VariableHolderClassGateWay.correctNum == 4)
				{
					VariableHolderClassGateWay.correctNum2 = "R";
				}		
				else if (VariableHolderClassGateWay.correctNum == 5)
				{
					VariableHolderClassGateWay.correctNum2 = "P";
				}		
				else if (VariableHolderClassGateWay.correctNum == 6)
				{
					VariableHolderClassGateWay.correctNum2 = "S";
				}		
				else if (VariableHolderClassGateWay.correctNum == 7)
				{
					VariableHolderClassGateWay.correctNum2 = "R";
				}		
				else if (VariableHolderClassGateWay.correctNum == 8)
				{
					VariableHolderClassGateWay.correctNum2 = "P";
				}		
				else if (VariableHolderClassGateWay.correctNum == 9)
				{
					VariableHolderClassGateWay.correctNum2 = "S";
				}
				//Comparing
				if ((VariableHolderClassGateWay.answer == "R" && VariableHolderClassGateWay.correctNum2 == "P"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Myscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: R, Me: P");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("You Lose!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;}
			
				if ((VariableHolderClassGateWay.answer == "R" && VariableHolderClassGateWay.correctNum2 == "S"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Yourscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: R, Me: S");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("You Won!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}			
				if ((VariableHolderClassGateWay.answer == "R" && VariableHolderClassGateWay.correctNum2 == "R"))
				{
					Console.Write("Score: ");
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: R, Me: R");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Its a Tie");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}		
				if ((VariableHolderClassGateWay.answer == "P" && VariableHolderClassGateWay.correctNum2 == "S"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Myscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: P, Me: S");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("You Lose!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
		    	}			
				if ((VariableHolderClassGateWay.answer == "P" && VariableHolderClassGateWay.correctNum2 == "R"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Yourscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: P, Me: R");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("You Won!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}			
				if ((VariableHolderClassGateWay.answer == "P" && VariableHolderClassGateWay.correctNum2 == "P"))
				{
					Console.Write("Score: ");
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: P, Me: P");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Its a Tie");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}		
				if ((VariableHolderClassGateWay.answer == "S" && VariableHolderClassGateWay.correctNum2 == "R"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Myscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: S, Me: R");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("You Lose!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}			
				if ((VariableHolderClassGateWay.answer == "S" && VariableHolderClassGateWay.correctNum2 == "P"))
				{
					Console.Write("Score: ");
					VariableHolderClassGateWay.Yourscore++;
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: S, Me: P");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("You Won!!");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}			
				if ((VariableHolderClassGateWay.answer == "S" && VariableHolderClassGateWay.correctNum2 == "S"))
				{
					Console.Write("Score: ");
					Console.WriteLine("You: {0}, Me: {1}", VariableHolderClassGateWay.Yourscore, VariableHolderClassGateWay.Myscore);
					Console.WriteLine("You: S, Me: S");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Its a Tie");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}		
				if (VariableHolderClassGateWay.answer == "N")
				{
					GameMenu();
				}			
			}
		}		
		public void GANGame() // Inside the GANGame of Game Menu
		{
		    VariableHolderClass VariableHolderClassGateWay = new VariableHolderClass();
			Random random = new Random();
			Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine("Number Guesser: Version 1.0.0 by Adrian");
		    Console.ForegroundColor = ConsoleColor.White;			
		    while (true)
			{
				VariableHolderClassGateWay.correctNum = random.Next(1, 10);
				VariableHolderClassGateWay.guess = 0;
				Console.WriteLine("guess a Number Between 1 and 10");		
				// ask useer for num
				while(VariableHolderClassGateWay.guess != VariableHolderClassGateWay.correctNum)
				{
        			VariableHolderClassGateWay.input = Console.ReadLine();			
					if(!int.TryParse(VariableHolderClassGateWay.input, out VariableHolderClassGateWay.guess))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Not a number, pls try again");
						Console.ForegroundColor = ConsoleColor.White;	
						// to continue
						continue;
					}	
			   		 // cast to int and put in guess
					VariableHolderClassGateWay.guess = Int32.Parse(VariableHolderClassGateWay.input);
					// match guess to correct num
					if(VariableHolderClassGateWay.guess != VariableHolderClassGateWay.correctNum)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Wrong number, pls try again");
						Console.ForegroundColor = ConsoleColor.White;}
					}
					if(VariableHolderClassGateWay.guess != VariableHolderClassGateWay.correctNum)
					{
						Console.WriteLine("Play Again? [Y or N]");
						//answer
						VariableHolderClassGateWay.answer = Console.ReadLine().ToUpper();
						if(VariableHolderClassGateWay.answer == "Y")
						{
							continue;	
						}
						else if(VariableHolderClassGateWay.answer == "N")
						{
							GameMenu();
						}
							else
						{
							GameMenu();
						}		
					}		
					else
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("You are CORRECT!!!");
						Console.ForegroundColor = ConsoleColor.White;		
						//play again		
						Console.WriteLine("Play Again? [Y or N]");
						//answer
						VariableHolderClassGateWay.answer = Console.ReadLine().ToUpper();
						if(VariableHolderClassGateWay.answer == "Y")
						{
							continue;	
						}
						else if(VariableHolderClassGateWay.answer == "N")
						{
							GameMenu();
						}
						else
						{
							GameMenu();
						}
					}
	
			}
		
		}
		
		

		
		public void EmployeeInfo()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter4.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter4));
			Console.WriteLine(" ");
		    Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Available Functions: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("1. Employee's tax and financial information");
			Console.WriteLine("2. Employee hourly schedules");
			Console.WriteLine("3. Payroll Records");
			Console.WriteLine("Back");
			Console.WriteLine(" ");
			Console.WriteLine("Type the number for the Functions description");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			// when choosing the Dragon and Gods
			if (VariableHolderClassGateWay.Selection == "1")
			{
				EmployeeTaxAndFinancialInformation();
			}
			
			if (VariableHolderClassGateWay.Selection == "2")
			{
				EmployeeHourlySchedules();
			}
			
			if (VariableHolderClassGateWay.Selection == "3")
			{
				PayrollRecords();
			}
			
			if (VariableHolderClassGateWay.Selection == "BACK")
			{
				MainSelection();
			}
			
			else 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" ");
				Console.WriteLine("Error, Pls try again");
		        Console.WriteLine(" ");
				Console.ForegroundColor = ConsoleColor.White;
				EmployeeInfo();
			}
		}
		
		public void EmployeeTaxAndFinancialInformation()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter5.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter5));
			Console.WriteLine(" ");
		    Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Description: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Wait for update");
			Console.WriteLine("Back");
			Console.WriteLine(" ");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			if (VariableHolderClassGateWay.Selection == "BACK")
			{
				EmployeeInfo();
			}
			
			else 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" ");
				Console.WriteLine("Error, Pls try again");
		        Console.WriteLine(" ");
				Console.ForegroundColor = ConsoleColor.White;
				EmployeeTaxAndFinancialInformation();
			}
		
		}
		
		public void EmployeeHourlySchedules()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter6.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter6));
			Console.WriteLine(" ");
		    Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Description: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Wait for update");
			Console.WriteLine("Back");
			Console.WriteLine(" ");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			if (VariableHolderClassGateWay.Selection == "BACK")
			{
				EmployeeInfo();
			}
			
			else 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" ");
				Console.WriteLine("Error, Pls try again");
		        Console.WriteLine(" ");
				Console.ForegroundColor = ConsoleColor.White;
				EmployeeHourlySchedules();
			}
		}
		
		public void PayrollRecords()
		{
						Console.ForegroundColor = ConsoleColor.Blue;
		    Console.WriteLine(" ");
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (VariableHolderClassGateWay.textToEnter7.Length / 2)) + "}", VariableHolderClassGateWay.textToEnter7));
			Console.WriteLine(" ");
		    Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Description: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Wait for update");
			Console.WriteLine("Back");
			Console.WriteLine(" ");
			Console.Write("Type Here:");
			VariableHolderClassGateWay.Selection = Console.ReadLine().ToUpper();
			if (VariableHolderClassGateWay.Selection == "BACK")
			{
				EmployeeInfo();
			}
			
			else 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" ");
				Console.WriteLine("Error, Pls try again");
		        Console.WriteLine(" ");
				Console.ForegroundColor = ConsoleColor.White;
				PayrollRecords();
			}
		}
		
		
	}
	
	
}