//Program: Shapes Rectangle
//Author:  Jason Fedewa
//Date:    November 30th, 2011
//Purpose: To demonstrate file reading and writing, as well as class interaction
//TO-Do:   

#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
#include <cstdlib>

using namespace std;

//Class(s)
class Shape
{
	int sideOne;
	int sideTwo;
	int sideThree;// Used for Area in the Square
	int perimeter;
	char typeTri[12];
			
public:
	//Default contructor
	Shape()
	{
		sideOne = 0;
		sideTwo = 0;
		sideThree = 0;
		perimeter = 0;
		strcpy_s(typeTri, " ");
	}

	//Method used by the class Square to fill the Square Objects
	void getDataSq()
	{
		fstream outFileSq;
		outFileSq.open("squares.txt", ios::out|ios::app);

		cout<<"Enter the Squares Height: ";
		cin>>sideOne;
		ErrorCheck(sideOne);
		cout<<"Enter the Squares Width: ";
		cin>>sideTwo;
		ErrorCheck(sideTwo);
		sideThree = sideOne*sideTwo;//This is the formula for area
		perimeter = (sideOne+sideTwo)*2;
		
		outFileSq<<sideOne<<' '<<sideTwo<<' '<<sideThree<<' '<<perimeter<<endl;
		outFileSq.close();
	}

	void getDataTri()
	{
		fstream outFileTri;
		outFileTri.open("triangles.txt", ios::out|ios::app);

		cout<<"Enter Side 1: ";
		cin>>sideOne;
		ErrorCheck(sideOne);
		cout<<"Enter Side 2: ";
		cin>>sideTwo;
		ErrorCheck(sideTwo);
		cout<<"Enter Side 3: ";
		cin>>sideThree;
		ErrorCheck(sideThree);

		perimeter = sideOne+sideTwo+sideThree;
		
		if ((sideOne == sideTwo)&&(sideTwo == sideThree))
		{
			strcpy_s(typeTri, "equilateral");
		}
		else if((sideOne == sideTwo)||(sideTwo == sideThree)||(sideOne == sideThree))
		{
			strcpy_s(typeTri, "Isosceles");
		}
		else
		{
			strcpy_s(typeTri, "scalene");
		}
		
		outFileTri<<sideOne<<' '<<sideTwo<<' '<<sideThree<<' '<<perimeter<<' '<<typeTri<<endl;
		outFileTri.close();
	}

	//Method for printing the file data to the users screen.
	int inputToDisplay(int tempNum)
	{
		if(tempNum == 1)
		{
			system("cls");
			fstream inputFileSq;
			inputFileSq.open("squares.txt",ios::in);

			//Header line do define the columns being used.
			cout<<setiosflags(ios::left)<<setw(10)<<"Height"<<setw(13)<<"Width"<<setw(13)<<"Perimeter"<<"Area"<<endl<<endl<<setiosflags(ios::fixed|ios::showpoint);
			while(inputFileSq>>sideOne>>sideTwo>>perimeter>>sideThree)
			{
				//Formated output for the information being printed to the screen.
				cout<<setiosflags(ios::left)<<setw(10)<<sideOne<<setw(13)<<sideTwo<<setw(7)<<perimeter<<setw(7)<<setprecision(2)<<resetiosflags(ios::left)<<sideThree<<endl;
			}
			inputFileSq.close();
			cout<<endl;
		}
		else
		{
			system("cls");
			fstream inputFileSq;
			inputFileSq.open("triangles.txt",ios::in);

			//Header line do define the columns being used.
			cout<<setiosflags(ios::left)<<setw(10)<<"Side 1"<<setw(13)<<"Side 2"<<setw(10)<<"Side 3"<<setw(13)<<"Perimeter"<<setw(10)<<"Triangle Type"<<endl<<endl<<setiosflags(ios::fixed|ios::showpoint);
			while(inputFileSq>>sideOne>>sideTwo>>sideThree>>perimeter>>typeTri)
			{
				//Formated output for the information being printed to the screen.
				cout<<setiosflags(ios::left)<<setw(10)<<sideOne<<setw(13)<<sideTwo<<setw(10)<<sideThree<<setw(13)<<perimeter<<setw(10)<<setprecision(2)<<resetiosflags(ios::left)<<typeTri<<endl;
			}
			inputFileSq.close();
			cout<<endl;
		}
		return 0;
	}
	//Functions that are used external to the class. Here they are given permission
	friend int choiceCheck(int choice);
	friend int ErrorCheck(int numToPass);
};
//Prototypes

//Global Variables
int i = 0;

//Main Program
int main()
{
	char again = ' ';
	int choice = 0;

	do
	{
		cout<<"     What shape would you like to enter."<<endl<<endl;
		cout<<"Press ( 1 ) to enter a squares dimensions(2 sides): "<<endl;
		cout<<"Press ( 2 ) to enter a triangles dimensions(3 sides): "<<endl;
		cout<<"Press ( 3 ) to view previously entered shapes: "<<endl<<endl;
		cout<<"Please select a choice: ";
		cin>>choice;
		system("cls");
		choice = choiceCheck(choice);

		cout<<"Type 'y' to enter more shapes, type anything else to quit:";
		cin>>again;
		again = tolower(again);
		system("cls");
	}while(again=='y');
}

//Method for handling the users choice
int choiceCheck(int tempChoice)
{
	Shape user[50];
	char again = ' ';
	char error_ch = ' ';
	int shapeType = 0;

	while((tempChoice <= 0)||(tempChoice >= 4))
	{
		if (cin.fail())
		{
		cin.clear();
		cin>>error_ch;     //declare as a character so error has some place to go
		cout << endl << "The following value is not recognized: " << error_ch << endl;  //prints error to screen
		}
		cout<<"Please enter a valid number 1 through 3: ";
		cin>>tempChoice;
	}
	system("cls");
	if(tempChoice==1)
	{
		do
		{
			user[i].getDataSq();//Calls the getDataSq function
			cout<<"Would you like to enter another square? ";
			cin>>again;
			again = tolower(again);
			system("cls");
			i++;
		}while(again=='y');
	}
	else if(tempChoice==2)
	{
		do
		{
			user[i].getDataTri();//Calls the getDataTri function
			cout<<"Would you like to enter another triangle? ";
			cin>>again;
			again = tolower(again);
			system("cls");
			i++;
		}while(again=='y');
	}
	else 
	{
		cout<<"Which shape do you wish to see?\nPress ( 1 ) for Squares.\nPress ( 2 ) for Triangles";
		cin>>shapeType;
		while((shapeType <= 0)||(shapeType >= 3))
		{
			char error_ch = ' ';

			if (cin.fail())
			{
			cin.clear();
			cin>>error_ch;     //declare as a character so error has some place to go
			cout << endl << "The following value is not recognized: " << error_ch << endl;  //prints error to screen
			}
			cout<<"Please enter a valid number 1 through 2: ";
			cin>>shapeType;
		}
		system("cls");
		user[i].inputToDisplay(shapeType);
	}
	i++;

	return 0;
}

int ErrorCheck(int numToPass)
{
	while((numToPass <= 0)||(numToPass >= 51))
	{
		char error_ch = ' ';

		if (cin.fail())
		{
		cin.clear();
		cin>>error_ch;     //declare as a character so error has some place to go
		cout << endl << "The following value is not recognized: " << error_ch << endl;  //prints error to screen
		}
		cout<<"Please enter a valid number 1 through 50: ";
		cin>>numToPass;
	}
	system("cls");
	return  numToPass;
}