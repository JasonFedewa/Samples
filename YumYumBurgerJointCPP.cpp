/* Program: Lab 3.1, Yum Yum Burger Joint
   Author:  Jason Fedewa
   Date:    September 29, 2011
   Class:   CO127
   Purpose: To meet all design criteria of my assignment, and to also
			error proof my application.
   Tasks remaining: -Finish error proofing my assignment.
					-Format outputs
					-work out string comparisons.
*/
#include <iostream>
#include <string.h>
using namespace std;

//Prototypes of my functions
void orderGenerator();
void orderCalc();
void recieptDisplay();

//Global Variables
int itemCheck = 0;
int orderNumber = 1;
int burger = 0;
int fry = 0;
int soda = 0;
int shake =0;
int burgerCount[3];
int fryCount[3];
int sodaCount[3];
int shakeCount[3];
char orderCheck = ' ';
char answerY = 'y';
char answerN = 'n';
double mealPrice = 0;
double tax = 0;
double totalMealPrice = 0;

int main()
{
    char again = ' ';
    do
    {
        //Functions called here
		cout<<"	   Welcome to YumYums Burger Joint \n";
		cout<<"  Home of the YumYum Burger of Awesome Yummyness. \n\n";
		
		orderGenerator();
		
		recieptDisplay();

		cout <<"Do you want to run again y or n: ";
        cin >> again;
        again = tolower(again);
        system("cls");
	}while(again != 'n');
	
    system("Pause");
    return 0;
}

void orderGenerator()
{
	while (orderCheck != 'n')
	{
	cout<<"Please place your order using our menu displayed below.\n\n";
	cout<<"Yum Yum Burger :   $  .99 \n";
	cout<<"Grease Yum Fries:  $  .79 \n";
	cout<<"Soda Yummy :       $ 1.09 \n";
	cout<<"Yummy Shake:       $ 1.79 \n\n";
	cout<<"  Please select a menu item to add to your order: \n";
	cout<<"1 for a burger, 2 for a Fry, 3 for a Soda, 4. for a Shake. \n\n";
	while((itemCheck <=0)||(itemCheck>=5))
	{
		cout<<"Press a number 1 through 4 to select the menu item you want: ";
		cin>>itemCheck;
	}
	switch(itemCheck)
	{
	case 1:
		system("cls");
		cout<<"How many Burgers do you want? ";
		cin>>burger;
		burgerCount[orderNumber]=burger+burgerCount[orderNumber];
		system("cls");
		break;
	case 2:
		system("cls");
		cout<<"How many orders of Fries do you want? ";
		cin>>fry;
		fryCount[orderNumber]=fry+fryCount[orderNumber];
		system("cls");
		break;
	case 3:
		system("cls");
		cout<<"How many Soda's do you want? ";
		cin>>soda;
		sodaCount[orderNumber]=soda+sodaCount[orderNumber];
		system("cls");
		break;
	case 4:
		system("cls");
		cout<<"How many shakes do you want? ";
		cin>>shake;
		shakeCount[orderNumber]=shake+shakeCount[orderNumber];
		system("cls");
		break;
	}
	
	itemCheck = 0;
	if (burgerCount[orderNumber] > 0)
	{
		cout<<"You have:  "<<burgerCount[orderNumber]<<" Burgers\n";
	}
	if (fryCount[orderNumber] > 0)
	{
		cout<<"You have:  "<<fryCount[orderNumber]<<" orders of frys.\n";
	}
	if (sodaCount[orderNumber] > 0)
	{
		cout<<"You have:  "<<sodaCount[orderNumber]<<" Soda's.\n";
	}
	if (shakeCount[orderNumber] > 0)
	{
		cout<<"You have:  "<<shakeCount[orderNumber]<<" Shakes.\n";
	}
	cout<<endl;
	cout <<"Would you like to add items to your order? y or n: ";
	cin>>orderCheck;
	system("cls");
	}
}

void orderCalc()
{
	//Calcs an order that is requested from the function recieptDisplay()
	mealPrice = (burgerCount[orderNumber] * .99)+(fryCount[orderNumber] * .79)+(sodaCount[orderNumber] * 1.09)+(shakeCount[orderNumber] * 1.79);
	tax = mealPrice * .06;
	totalMealPrice = mealPrice + tax;
}

void recieptDisplay()
{
	//Displays the reciept then calls orderCalc().
	system("cls");
	orderCalc();
	cout.precision(2);
	cout<<fixed;
	cout<<"You ordered: \n\n";
	if(burgerCount[orderNumber] > 0)
	{
		cout<<"  "<<burgerCount[orderNumber]<<" Yum Yum Burgers. \n";
	}
	if(fryCount[orderNumber] > 0)
	{
		cout<<"  "<<fryCount[orderNumber]<<" orders of Grease Yum Fries. \n";
	}
	if(sodaCount[orderNumber] > 0)
	{
		cout<<"  "<<sodaCount[orderNumber]<<" Soda's. \n";
	}
	if(shakeCount[orderNumber] > 0)
	{
		cout<<"  "<<shakeCount[orderNumber]<<" Shake's. \n";
	}
	cout<<endl;
	cout<<"Your subtotal is: "<<mealPrice<<" \n";
	cout<<"Your total tax is: "<<tax<<" \n";
	cout<<"Your total bill for order# "<<orderNumber<<" is: "<<totalMealPrice<<" \n\n";
	cout<<"Thank you for purchase! \n\n";
	
	orderCheck = ' ';
	orderNumber = 0;
	burger = 0;
	fry = 0;
	soda = 0;
	shake = 0;
	itemCheck = 0;
	mealPrice = 0;
	tax = 0;
	totalMealPrice = 0;
	burgerCount[orderNumber] = 0;
	fryCount[orderNumber] = 0;
	sodaCount[orderNumber] = 0;
	shakeCount[orderNumber] = 0;
}


/*
void orderEdit()
{
	//Allows a current order to have items removed.
	while((itemCheck <=0)||(itemCheck>=5))
	{
		system("cls");
		cout<<"1 for burgers, 2 for Fries, 3 for Soda's, 4. for Shake's. \n\n";
		cout<<"Which item on your order needs to be removed? \n\n";
		cout<<"You have: "<<burgerCount[orderNumber]<<" Burgers and "<<fryCount[orderNumber]<<" orders of frys.\n";
		cout<<"You have: "<<sodaCount[orderNumber]<<" Soda's and "<<shakeCount[orderNumber]<<" Shakes.\n ";
		cin>>itemCheck;
	}
		switch(itemCheck)
		{
		case 1:
			system("cls");
			cout<<"How many Burgers need to be removed? ";
			cin>>burger;
			burgerCount[orderNumber]=burger-burgerCount[orderNumber];
			break;
		case 2:
			system("cls");
			cout<<"How many orders of Fries need to be removed? ";
			cin>>fry;
			fryCount[orderNumber]=fry-fryCount[orderNumber];
			break;
		case 3:
			system("cls");
			cout<<"How many Soda's need to be removed? ";
			cin>>soda;
			sodaCount[orderNumber]=soda-sodaCount[orderNumber];
			break;
		case 4:
			system("cls");
			cout<<"How many shakes need to be removed? ";
			cin>>shake;
			shakeCount[orderNumber]=shake-shakeCount[orderNumber];
			break;
		}
	system("cls");
	cout<<"Do you need to remove any more items? 1 for yes or 2 for no: ";
	cin>>orderChk;
	*/