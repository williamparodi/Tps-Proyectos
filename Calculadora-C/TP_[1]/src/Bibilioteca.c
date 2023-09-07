#include <stdio.h>
#include <stdlib.h>
#include "biblioteca.h"

int elegirOpcion(int numero1,int numero2)
{
    int opcion;

    printf("\n   Eliga una opcion : \n\n");
    printf("1 - Ingrese primer operador A = %d\n",numero1);
    printf("2 - Ingrese segundo operador B = %d\n",numero2);
    printf("3 - Calcular todas las operaciones \n");
    printf("4 - Informar Resultados \n");
    printf("5 - Salir \n");
    scanf("%d",&opcion);

    return opcion;
}

int sumarEnteros(int numero1,int numero2)
{
    int suma;

    suma = numero1 + numero2;

    return suma;
}

int restarEnteros(int numero1,int numero2)
{
    int resta;

    resta = numero1 - numero2;

    return resta;
}

int dividirEnteros(int numero1,int numero2,float* pResultado)
{
    int todoOk = 0;

    if(pResultado != NULL && numero2 != 0)
    {
        *pResultado = (float)numero1 / numero2;
        todoOk = 1;
    }

    return todoOk;

}

int multiplica(int numero1,int numero2)
{
    int resultado;

    resultado = numero1 * numero2;

    return resultado;
}

int mostrarEntero()
{
    int numero;

    printf("Ingrese un numero: ");
    scanf("%d",&numero);

    return numero;
}

void mostrarCalculos(int numero1,int numero2)
{

    printf("a)Calcular la suma de (%d + %d) \n",numero1,numero2);
    printf("b)Calcular la resta de (%d - %d) \n",numero1,numero2);
    printf("c)Calcular la division de (%d / %d)\n",numero1,numero2);
    printf("d)Calcular la multiplicacion de (%d * %d)\n",numero1,numero2);
    printf("e)Calcular El factorial de (!%d) y EL factorial de (!%d)\n",numero1,numero2);

}

int factorial(int numero,int* pFactorial)
{
    int todoOk = 0;
    int i;

    if(pFactorial != NULL)
    {
        if(numero >= 0 && numero <13)
        {
            *pFactorial = 1;

            for(i=2;i<=numero;i++)
            {
                *pFactorial *= i;
            }

            todoOk = 1;
        }
    }
    return todoOk;
}

void mostrarSuma(int numero1, int numero2,int resultado)
{
	 printf("a)El resultado de la suma de  %d + %d es: %d\n",numero1,numero2,resultado);
}

void mostrarResta(int numero1, int numero2,int resultado)
{
	printf("b)El resultado de la resta de %d - %d es : %d\n",numero1,numero2,resultado);
}

void mostrarMultiplicacion(int numero1,int numero2,int resultado)
{
	 printf("d)El resultado de la multiplicacion de %d * %d es : %d\n",numero1,numero2,resultado);
}

void mostrarResultadoDivision(int numero1,int numero2,int funcionDivisionOk,float resultadoDivision)
{
    if(funcionDivisionOk == 1)
    {
        printf("c)El resultado de la division de %d / %d es: %.2f\n",numero1,numero2,resultadoDivision);
    }
    else
    {
        printf("c)No es posible dividir por 0\n");
    }
}

void mostrarFactorial(int numero,int factorial,int funcionFactorialOk)
{
    if(funcionFactorialOk == 1)
    {
        printf("El factorial de !%d es: %d ",numero,factorial);
    }
    else
    {
         printf("No se pudo calcular el factorial de !%d, numero fuera de rango (Rango:desde 0 a 12) ",numero);
    }
}


