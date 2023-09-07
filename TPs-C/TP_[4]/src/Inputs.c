#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "Inputs.h"

int menu()
{
    int opcion;
    printf("-------------------------------\n");
    printf("  *** Lista de ProGamers  ***\n\n");
    printf("-------------------------------\n");
   	printf("1.  Cargar los datos de los Gamers desde el archivo data.csv (modo texto)\n");
   	printf("2.  Cargar los datos de los Gamers desde el archivo data.bin (modo binario)\n");
    printf("3.  Alta de Gamer\n");
    printf("4.  Modificar datos de Gamer\n");
    printf("5.  Baja de Gamer\n");
    printf("6.  Listar Gamers\n");
    printf("7.  Ordenar Gamers\n");
    printf("8.  Guardar los datos de los Gamers en el archivo data.csv (modo texto)\n");
    printf("9.  Guardar los datos de los Gamers en el archivo data.bin (modo binario)\n");
    printf("10. Borrar los datos de un Gamer(pop)\n");
    printf("11. Elegir indice e insertar datos(push)\n");
    printf("12. Clonar lista\n");
    printf("13. Limpiar lista(clear)\n");
    printf("14. Borrar lista completa(deleteLinkedList)\n");
    printf("15. Salir\n");
    printf("Ingrese Opcion: ");
    scanf("%d",&opcion);

    return opcion;
}

int ingresarInt(char mensaje[])
{
    int numeroInt;

    printf("%s",mensaje);
    scanf("%d",&numeroInt);

    return numeroInt;
}

float ingresarFloat(char mensaje[])
{
    float numeroFloat;

    printf("%s",mensaje);
    scanf("%f",&numeroFloat);

    return numeroFloat;
}

int ingresarString(char mensaje[], char info[])
{
    int todoOk = 0;

    if(mensaje != NULL && info !=NULL)
    {
        printf("%s", mensaje);
        fflush(stdin);
        gets(info);

        todoOk = 1;
    }

    return todoOk;
}

int pasarMayusculaPrimerCaracter(char string[])
{
    int todoOk = 0;
    int i = 0;

    if(string != NULL)
    {
        strlwr(string);
        string[0] = toupper(string[0]);
        while(string[i] != '\0')
        {
            if(string[i] == ' ')
            {
                string[i+1] = toupper(string[i+1]);
            }

            i++;
        }
        todoOk = 1;
    }

    return todoOk;
}

int validarMinMax(int numero,int min, int max)
{
	int todoOk = 0;

	if(numero >= min && numero <= max)
	{
		todoOk = 1;
	}

	return todoOk;
}


int validarFloatMinMax(float numero,int min,int max)
{
	int todoOk = 0;

	if(numero >=min && numero <= max)
	{
		todoOk = 1;
	}

	return todoOk;

}





