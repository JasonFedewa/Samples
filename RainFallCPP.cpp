/* Program: Lab 5.2, Rain Fall
Author:  Jason Fedewa
Date:    November 3, 2011
Class:   CO127
Purpose: To meet all design criteria of my assignment
Tasks remaining: - 
*/

#include <iostream>
#include <string>

using namespace std;

//Prototypes
void UserInput();
double CalcRainFall();
void DisplayInfo();

//Global Variables
double rainFallTotal[13] = {0};
string months[12] = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
int i = 0;

//Main program
int main()
{
	char again = ' ';

	do
	{
		//Function calls

		UserInput();
		DisplayInfo();

		cout << "Type 'y' to run again, type 'q' to stop: ";
		cin >> again;
		system("cls");
		again = tolower(again);
	}while (again == 'y');
	return 0;
}

//Takes in the needed information to perform the needed caclulations
void UserInput()
{
	char error_ch = ' ';
	cout<<"    Welcome to the Rain Fall Calculator\n\n";
	cout<<"  You can enter a number between 1 and 108.\n";
	for(i=0;i<12;i++)
	{
		while((rainFallTotal[i]<=0)||(rainFallTotal[i]>=109))
		{
			cout<<"How much rain fall occured for "<<months[i]<<": ";
			cin>>rainFallTotal[i];
			if (cin.fail())
			{
				cin.clear();
				cin>>error_ch;     //declare as a character so error has some place to go
				cout << endl << "The following value is not recognized: " << error_ch << endl;  //prints error to screen
			} 
		}
		rainFallTotal[12]+=rainFallTotal[i];
	}
}

//Calcilates the user input
double CalcRainFall()
{
	return rainFallTotal[12]/12;
}

//Displays the calculated user input
void DisplayInfo()
{
	rainFallTotal[12]=CalcRainFall();
	cout<<"The average rain fall for the year is: "<<rainFallTotal[12];
	cout<<"\n\n";
	for(i=0;i<12;i++)
	rainFallTotal[i] = 0;
}