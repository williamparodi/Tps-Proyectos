
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "inputs.h"

int menu()
{
    int opcion;

    printf("-------------------------------\n");
    printf("  *** Nomina de Empleados ***\n\n");
    printf("-------------------------------\n");
    printf("1-Alta de Empleado\n");
    printf("2-Modificar Empleado\n");
    printf("3-Baja de Empleado\n");
    printf("4-Informes de Empleados\n");
    printf("5-Salir\n");
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


int validarString(char list[])
{
    int todoOk = 0;
    if(list!= NULL)
    {
    	for (int i = 0; i < strlen(list); i++)
    	{
    		todoOk = -1;
    		if(!(isalpha(list[i])) && list[i] != ' ')
    		{
    			todoOk = 1;
    			break;
    		}
    	}

  	}

    return todoOk;
}
int getIntFloat (float* pResultado)
    {
        int retorno = -1;
        char buffer[4096];


        if (obtenerFloat(buffer, sizeof(buffer)) && esFlotante(buffer))
        {
            retorno = 0;
            *pResultado = atof(buffer);
        }
        return retorno;
    }




    int obtenerFloat(char* cadena, int longitud)
    {
        char buffer[4096];
        fflush(stdin);
        scanf("%s", buffer);
        strncpy(cadena, buffer,longitud);
        return -1;
    }



    int validarFloat(float* pResultado, char* mensaje, char* mensajeError, int minimo, int maximo, int reintentos)
    {
        int retorno = -1;
        float buffer;

        if(pResultado != NULL && mensaje != NULL && mensajeError != NULL && minimo <= maximo && reintentos >= 0)
        {
            do
            {
                printf("%s", mensaje);

                if (getIntFloat(&buffer)== 0 && buffer >= minimo && buffer <= maximo)
                {
                    *pResultado = buffer;
                    retorno = 0;
                    break;
                }
                reintentos--;
                printf("%s", mensajeError);
            }
            while (reintentos >= 0);
        }

        return retorno;
    }


    int esFlotante(char str[])
    {
        int i = 0;
        int cantidad = 0;
        while (str[i] != '\0')
        {
            if (i == 0 && str[i] == '-')
            {
                i++;
                continue;
            }
            if (str[i] == '.' && cantidad== 0)
            {
                cantidad++;
                i++;
                continue;

            }
            if (str[i] < '0' || str[i] > '9')
                return 0;
            i++;
        }
        return 1;
    }
