#include<iostream>
#include<cstdlib>
#include<tgmath.h>
#include<iomanip>
using namespace std;

int main()
{
    double op, y, x, h, k1, k2, k3, k4, c;
	
    system("Color 2");
    do{
        system("cls");
        cout.fixed;
        cout.precision (5);
        double Inc, Ini, Res, Lim, R, R1;
        cout<< "\n";
        cout<< "   //------------------------------------------------------------//  \n";
        cout<< "   //--   Bienvenido al Programa de ECUACIONES DIFERENCIALES   --//  \n";
        cout<< "   //------------------------------------------------------------//  \n";
        cout<< "   //--            Seleccione el método de solución            --//  \n";
        cout<< "   //------------------------------------------------------------//  \n";
        cout<< "   //--                                                        --//  \n";
        cout<< "   //--      1. Euler Mejorado                                 --//  \n";
        cout<< "   //--      2. Runge-Kuta                                     --//  \n";
        cout<< "   //--      3. Newton                                        --//  \n";
        cout<< "   //--      0. Salir                                          --//  \n";
        cout<< "   //--                                                        --//  \n";
        cout<< "   //--      Opción: ";
        cin>>op;

        if (op == 1)
        {
            system("cls");
            cout<< "\n";
            cout<< "   //------------------------------------------------------------//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //--        Bienvenido al Programa de EULER MEJORADO        --//  \n";
            cout<< "   //--              y' = 2xy y(1) = 1; y (1.5)                --//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //------------------------------------------------------------//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //--      INGRESE EL INCREMENTO\n";
            cout<< "   //--      INCREMENTO: ";
            cin>> Inc;
            y = 0;
            Ini = 1;
            Res = 1;
            Lim = 1.5;
            system ("cls");

            cout<< "\n";
            cout<< "   //------------------------------------------------------------------------------------//  \n";
            cout<< "   //--                                   RESULTADOS                                   --//  \n";
            cout<< "   //------------------------------------------------------------------------------------//  \n\n";

            for(Ini;Ini<Lim;Ini=Ini+Inc)
            {
                R = Res + (Inc * (2 * Ini * Res));
                Res = Res + Inc * (((2 * Ini * Res) + (2 * (Ini + Inc) * R)) / 2);
                y++;
                cout<< "   //--      " << "y" << y << " = " << Res << "\n";
            }
            cout<< "\n\n";
            system ("pause");
        }
        else if (op == 2)
        {
            system("cls");
            cout<< "\n";
            cout<< "   //------------------------------------------------------------//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //--          Bienvenido al Programa de RUNGE KUTA          --//  \n";
            cout<< "   //--             y' = 2xy y (1) = 1; y (1.5)                --//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //------------------------------------------------------------//  \n";
            cout<< "   //--                                                        --//  \n";
            cout<< "   //--      INGRESE EL INCREMENTO\n";
            cout<< "   //--      INCREMENTO: ";
            cin>> h;
            x = 1;
            y = 1;
			c = 0;
            Lim = 1.5;

            system ("cls");

            cout<< "\n";
            cout<< "   //------------------------------------------------------------------------------------//  \n";
            cout<< "   //--                                   RESULTADOS                                   --//  \n";
            cout<< "   //------------------------------------------------------------------------------------//  \n\n";

            for (x; x < Lim; x = x + h)
            {
				c++;
				k1 = 2 * (x) * (y);
				k2 = 2 * (x + (h / 2)) * (y + ((h / 2) * k1));
				k3 = 2 * (x + (h / 2)) * (y + ((h / 2) * k2));
				k4 = 2 * (x + h) * (y + (h * k3));
				
				y = y + (h / 6) * (k1 + (2 * k2) + (2 * k3) + k4);
				
				cout<< "   //--      " << "x" << c << " = " << x << "\n";
				cout<< "   //--      " << "y" << c << " = " << y << "\n\n";
            }
            cout<< "\n\n";
            system ("pause");
        }
        else if (op == 3)
        {
			x = 1;
			y = 8;
			system ("cls");
			cout<< "\n";
			cout<< "   //------------------------------------------------------------//  \n";
			cout<< "   //--                                                        --//  \n";
			cout<< "   //--            Bienvenido al Programa de Newton            --//  \n";
			cout<< "   //--            f(x)= x ^ 2 - 9x + 9 = 0                    --//  \n";
			cout<< "   //--                                                        --//  \n";
			cout<< "   //------------------------------------------------------------//  \n";
			cout<< "   //--            Bienvenido al Programa de Newton            --//  \n";
			cout<< "   //--                         x = 1;                           --//  \n\n";
			for (int i = 0; i < 5; i++)
			{
				x = x - (((x * x) - (9 * x) + 9)/(2 * x - 9));
				cout<< "   //--      " << "x" << x << "\n";
			}
			cout<< "\n\n";
			cout<< "   //--            Bienvenido al Programa de Newton            --//  \n";
			cout<< "   //--                         x = 8;                           --//  \n\n";
			
			for (int i = 0; i < 5; i++)
			{
				y = y - (((y * y) - (9 * y) + 9) / (2 * y - 9));
				cout<< "   //--      " << "y" << y << "\n";
			}
			system ("pause");
        }
    }while (op != 0);
    return 0;
}
