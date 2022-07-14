#include<iostream>
#include<cstdlib>
#include<tgmath.h>
#include<iomanip>
using namespace std;

void euler(int y,double x,double h,double k1,double k2,double k3,double k4,double c,double Inc,double Ini,double Res,double Lim,double R,double R1){
	cout << "Bienvenido a euler: "<<endl;
	
	cout<<"INCREMENTO: "; cin>>Inc; cout<<endl;
	y=0;
	Ini = 1;
	Res = 1;
	Lim = 1.5;
	
	for(Ini;Ini<Lim;Ini=Ini+Inc)
	{
		R = Res+(Inc*(2*Ini*Res));
		Res = Res+Inc*(((2*Ini*Res)+(2*(Ini+Inc)*R))/2);
		y++;
		cout<< "y" << y << " = " << Res << "\n";
	}
	cout<< "\n\n";
}
	
	
void newton(int y,double x,double h,double k1,double k2,double k3,double k4,double c,double Inc,double Ini,double Res,double Lim,double R,double R1){
	cout << "Bienvenido a newton: "<<endl;
	x=1;
	y=8;
	cout<< "\n";
	cout<< " Bienvenido al Programa de Newton \n";
	cout<< " f(x)= x^2-9x+9=0                 \n";
	cout<< " Bienvenido al Programa de Newton  \n";
	cout<< " x=1; \n\n";
	for(int i=0;i<5;i++)
	{
		x=x-(((x*x)-(9*x)+9)/(2*x-9));
		cout<< "   //--      " << "x" << x << "\n";
	}
	cout<< "\n\n";
	cout<< "   //--            Bienvenido al Programa de Newton            --//  \n";
	cout<< "   //--                         x=8;                           --//  \n\n";
	
	for(int i=0;i<5;i++)
	{
		y=y-(((y*y)-(9*y)+9)/(2*y-9));
		cout<< "y" << y << "\n";
	}
}
	void rk4(int y,double x,double h,double k1,double k2,double k3,double k4,double c,double Inc,double Ini,double Res,double Lim,double R,double R1){
		
		cout<< "Bienvenido al Programa de RUNGE KUTA   \n";
		cout<< " y' = 2xy y(1)=1; y(1.5)  \n";
		cout<< "INGRESE EL INCREMENTO\n";
		cout<< "INCREMENTO: ";
		cin>> h;
		x = 1;
		y=1;
		c=0;
		Lim = 1.5;
		
		
		cout<< "\n";
		cout<< "RESULTADOS  \n";
		
		for(x;x<Lim;x=x+h)
		{
			c++;
			k1=2*(x)*(y);
			k2=2*(x+(h/2))*(y+((h/2)*k1));
			k3=2*(x+(h/2))*(y+((h/2)*k2));
			k4=2*(x+h)*(y+(h*k3));
			
			y = y+(h/6)*(k1+(2*k2)+(2*k3)+k4);
			
			cout<< "" << "x" << c << " = " << x << "\n";
			cout<< "" << "y" << c << " = " << y << "\n\n";
		}
		cout<< "\n\n";
	}
int main(int argc, char *argv[]) {
	double y,x,h,k1,k2,k3,k4,c;
	double Inc,Ini,Res,Lim,R,R1;

	int ex,entrada;
	ex=0;

	while(ex==0){
		
		
		cout<<"Bienvenido"<<endl;
			
		cout<<"Menú"<<endl<<"1.Euler"<<endl<<"2.Newton"<<endl<<"3.Método nuevo"<<endl<<"4.salir"<<endl<<"R= ";
			
		cin>>entrada;
			
		switch(entrada){
			case 1: 
				system("cls");
				
				//metodo
				euler(Inc,Ini,Res,Lim,R,R1,y,x,h,k1,k2,k3,k4,c);
				//fin de metodo 
			break;
			case 2: 
				system("cls");
				
				//metodo
				newton(Inc,Ini,Res,Lim,R,R1,y,x,h,k1,k2,k3,k4,c);
				//fin de metodo
			break;
			case 3: 
				system("cls");
				
				rk4(Inc,Ini,Res,Lim,R,R1,y,x,h,k1,k2,k3,k4,c);
			break;
			case 4:
				system("cls");
				
				cout<<"hasta pronto";
				ex++;
			break;
				
		}
	}
	
	return 0;
}

	
