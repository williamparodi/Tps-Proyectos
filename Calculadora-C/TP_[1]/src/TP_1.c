/*
 ============================================================================
 Name        : TP_1.c
 Author      : William Parodi
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "biblioteca.h"

int main()
{
	setbuf(stdout,NULL);
    int seguir = 's';
    int operador1 = 0;
    int operador2 = 0;
    int flagOperador1 = 0;
    int flagOperador2 = 0;
    int flagCalculos = 0;
    int resultadoSuma;
    int resultadoResta;
    float resultadoDivision;
    int resultadoMultiplicacion;
    int factorialA;
    int factorialB;
    int funcionDivisionOk;
    int funcionFactorialAOk;
    int funcionFactorialBOk;



    do
    {

        switch(elegirOpcion(operador1,operador2))
        {

            case 1:
                operador1 = mostrarEntero();
                flagOperador1 = 1;
                break;
            case 2:
                if(flagOperador1 == 1)
                {
                    operador2 = mostrarEntero();
                    flagOperador2 = 1;
                }
                else
                {
                    printf("Primero ingrese el primer operando \n");
                }
                break;
            case 3:
                if(flagOperador1 == 1 && flagOperador2 == 1)
                {
                    mostrarCalculos(operador1,operador2);
                    resultadoSuma = sumarEnteros(operador1,operador2);
                    resultadoResta = restarEnteros(operador1,operador2);
                    resultadoMultiplicacion = multiplica(operador1,operador2);
                    funcionDivisionOk = dividirEnteros(operador1,operador2,&resultadoDivision);
                    funcionFactorialAOk = factorial(operador1,&factorialA);
                    funcionFactorialBOk = factorial(operador2,&factorialB);
                    flagCalculos = 1;

                }
                else
                {
                    printf("Error,Ingrese ambos operandos\n");
                }
                break;
            case 4:
                if(flagCalculos == 1)
                {
                    mostrarSuma(operador1,operador2,resultadoSuma);
                    mostrarResta(operador1,operador2,resultadoResta);
                    mostrarResultadoDivision(operador1,operador2,funcionDivisionOk,resultadoDivision);
                    mostrarMultiplicacion(operador1,operador2,resultadoMultiplicacion);
                    printf("e)");
                    mostrarFactorial(operador1,factorialA,funcionFactorialAOk);
                    printf("y ");
                    mostrarFactorial(operador2,factorialB,funcionFactorialBOk);

                }
                else
                {
                    printf("No se pueden informar los resultados sin calcular las operaciones primero, ingrese la opcion 3 para calcular \n");
                }
                break;
            case 5:
                seguir = 'n';
                break;
            default:
                printf("Opcion invalida\n");
                break;

        }


    }while(seguir == 's');



    return 0;
}





