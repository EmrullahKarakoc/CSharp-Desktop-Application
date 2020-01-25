// YazilimciGenclik.cpp : This file contains the 'main' function. Program execution begins and ends there.
///

/*
Author: Emrullah Karakoc
*/
#include <iostream>

using namespace std;


int main()
{


	/* 
		Girilen 3 sayý için oluþabilecek üçgen çeþidini belirleyen algoritmam
	*/
	int birinci, ikinci,ucuncu;
	cout << "Birinci Sayiyi Giriniz.......:  ";
	cin >> birinci;
	cout << endl;
	cout << "Ikinci Sayiyi Giriniz.......:  ";
	cin >> ikinci;
	cout << endl;	
	cout << "Ucuncu Sayiyi Giriniz.......:  ";
	cin >> ucuncu;
	cout << endl; 

	bool ilkkosul = (fabs(birinci-ikinci) < ucuncu) && (ucuncu < (birinci + ikinci)) ;
	bool ikincikosul = (fabs(birinci - ucuncu) < ikinci) && (ikinci < (birinci + ucuncu));
	bool ucuncukosul = (fabs(ucuncu - ikinci) < birinci) && (birinci < (ucuncu + ikinci));
	if (ilkkosul && ikincikosul && ucuncukosul)
	{
		/* Ucgen Cesidini Belirledim*/
		cout << "------------ Ucgen Olusturuldu-----------" << endl;
		if (birinci != ikinci && birinci != ucuncu && ikinci != ucuncu)
			cout << "Cesit......: Cesitkenar Ucgen" << endl;
		else if (birinci == ikinci && ikinci == ucuncu)
			cout << "Cesit......: Eskenar Ucgen" << endl;
		else if (birinci == ikinci || birinci == ucuncu || ikinci == ucuncu)
			cout << "Cesit......: Ikizkenar Ucgen" << endl;




		/* Cevre hesapladýktan sonra cevreden alan formulu ile hesapladým.  */
		int cevre = birinci + ikinci + ucuncu;
		cout << "Cevre .....: " << cevre << endl;
		int u = cevre / 2;
	   double alan = sqrt((u * (u - birinci) * (u - ikinci) * (u - ucuncu)));
	   cout << "Alan .....: " << alan << endl;
	}
	else 
	{
		cout << "------------ Ucgen Olusturulamaz !!!!-----------" << endl;
		return 1;
	}

	system("pause");
}
