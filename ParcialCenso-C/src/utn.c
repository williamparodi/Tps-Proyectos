#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "utn.h"

int utn_getInt(int *pNumeroIngresado,char * mensaje,char * mensajeError,int minimo,int maximo,int reintentos)
{
	int retorno;
	int auxNumeroIngresado;
	retorno = -1;

    if(pNumeroIngresado != NULL && maximo >= minimo && reintentos >=0)
    {
        do
		{
        	printf("%s",mensaje);
			if(getInt(&auxNumeroIngresado) == 0 && auxNumeroIngresado >= minimo
					&& auxNumeroIngresado <= maximo)
			{
				*pNumeroIngresado = auxNumeroIngresado;
				retorno = 0;
				break;
			}
			else
			{
				printf("%s", mensajeError);
			}
			reintentos--;
		}while(reintentos > 0);
    }
    return retorno;
}

int getInt(int * resultado)
{
	int retorno;
	char aux[4096];
	retorno = 1;

	if(resultado != NULL &&
	   myGets(aux,sizeof(aux)) == 0 &&
	   esNumero(aux,sizeof(aux)))
	{
		retorno = 0;
		*resultado = atoi(aux);//
	}
	return retorno;
}

int esNumero(char cadena[],int limite)
{
	int retorno;
	int i;
	retorno = -1;

	if(cadena != NULL && limite >0)
	{
		retorno = 1;
		for(i=0;i<limite && cadena[i] != '\0';i++)
		{
			if(i==0 && (cadena[i] == '-' || cadena[i] == '+'))
			{
				continue;
			}
			if(cadena[i] > '9' || cadena[i] < '0')
			{
				retorno = 0;
				break;
			}
		}
	}
	return retorno;
}

int myGets(char cadena[],int len)
{
	int retorno;
	char aux[4096];
	retorno = -1;

	if(cadena != NULL && len >0)
	{
		fflush(stdin);
		if(fgets(aux,sizeof(aux),stdin) != NULL)
		{
			if(aux[strnlen(aux,sizeof(aux))-1] == '\n')
			{
				aux[strnlen(aux,sizeof(aux))-1] = '\0';
			}
			if(strnlen(aux,sizeof(aux))<= len)
			{
				strncpy(cadena,aux,len);
				retorno = 0;
			}
		}
	}
	return retorno;
}

int esLetra(char cadena[],int limite)
{
	int retorno;
	retorno = -1;
	if(cadena != NULL && limite >0)
	{
		retorno=1;
		for(int i=0;i<limite && cadena[i] !='\0';i++)
		{
			if(cadena[i] < 'A' || (cadena[i] > 'Z' && cadena[i] < 'a') || cadena[i] > 'z')
			{
				retorno = 0;
				break;
			}
		}
	}
	return retorno;
}

int getFloat(float * resultado)
{
	int retorno;
	char aux[4096];
	retorno = 1;

	if(resultado != NULL &&
	   myGets(aux,sizeof(aux)) == 0 &&
	   esFloat(aux,sizeof(aux)))
	{
		retorno = 0;
		*resultado = atof(aux);//
	}
	return retorno;
}

int esFloat(char cadena[],int limite)
{
	int retorno;
	retorno = -1;
	if(cadena != NULL && limite >0)
	{
		retorno=1;
		for(int i=0;i<limite && cadena[i] != '\0';i++)
		{
			if(i==0 && (cadena[i] == '-' || cadena[i] == '+'))
			{
				continue;
			}
			if((cadena[i] < '0' && cadena[i] != '.') || cadena[i] > '9')
			{
				retorno = 0;
				break;
			}
		}
	}
	return retorno;
}

int utn_getFloat(float *pNumeroIngresado,char * mensaje,char * mensajeError,int minimo,int maximo,int reintentos)
{
	int retorno;
	float auxNumeroIngresado;
	retorno = -1;

    if(pNumeroIngresado != NULL && maximo >= minimo && reintentos >=0)
    {
        do
		{
        	printf("%s",mensaje);
			if(getFloat(&auxNumeroIngresado) == 0 && auxNumeroIngresado >= minimo
					&& auxNumeroIngresado <= maximo)
			{
				*pNumeroIngresado = auxNumeroIngresado;
				retorno = 0;
				break;
			}
			else
			{
				printf("%s", mensajeError);
			}
			reintentos--;
		}while(reintentos > 0);
    }
    return retorno;
}

int utn_getString(char pStringIngresado[],char * mensaje,char * mensajeError,int limite,int reintentos)
{
	int retorno;
	char aux[4096];
	retorno = -1;

    if(pStringIngresado != NULL && reintentos >=0 && limite >0)
    {
        do
		{
        	printf("%s",mensaje);
			if(myGets(aux,limite) == 0 &&
					esLetra(aux,limite)==1)
			{
				strncpy(pStringIngresado,aux,limite);
				retorno = 0;
				break;
			}
			else
			{
				printf("%s", mensajeError);
			}
			reintentos--;
		}while(reintentos > 0);
    }
    return retorno;
}

int pasarMayusculaPrimerCaracter(char string[])
{
    int retorno = 0;
    int len;
    if(string != NULL)
    {
        strlwr(string);
        len= strlen(string);
        for(int i=0;i<len;i++)
        {
        	if(i==0 && string[i] != '\0')
        	{
        		string[i] = toupper(string[i]);
        	}
        	if(string[i] == ' ')
        	{
        		string[i+1] = toupper(string[i+1]);
        	}
        }
        retorno = 1;
    }
    return retorno;
}

int esLetraConEspacio(char cadena[],int limite)
{
	int retorno;
	retorno = -1;
	if(cadena != NULL && limite >0)
	{
		retorno=1;
		for(int i=0;i<limite && cadena[i] != '\0';i++)
		{
			if((cadena[i] < 'A' && cadena[i] != ' ')||
					(cadena[i] > 'Z' && cadena[i] <'a') || cadena[i] > 'z')
			{
					retorno = 0;
					break;
			}
		}
	}
	return retorno;
}

int utn_getNombreCompleto(char pStringIngresado[],char * mensaje,char * mensajeError,int limite,int reintentos)
{
	int retorno;
	char aux[4096];
	retorno = -1;

    if(pStringIngresado != NULL && reintentos >=0 && limite >0)
    {
        do
		{
        	printf("%s",mensaje);
			if(myGets(aux,limite) == 0 &&
				pasarMayusculaPrimerCaracter(aux) &&
				esLetraConEspacio(aux,limite)==1)
			{
				strncpy(pStringIngresado,aux,limite);
				retorno = 0;
				break;
			}
			else
			{
				printf("%s", mensajeError);
			}
			reintentos--;
		}while(reintentos > 0);
    }
    return retorno;
}

int esCodigoVuelo(char cadena[],int limite)
{
	int retorno;
	retorno = -1;
	if(cadena != NULL && limite >0)
	{
		retorno=1;
		for(int i=0;i<limite && cadena[i] != '\0';i++)
		{
			cadena[i] =toupper(cadena[i]);
			if((i<=2 && (cadena[i] < 'A' || cadena[i] > 'Z'))
					|| (i>=3 && (cadena[i] <'0' || cadena[i] >'9')))
			{
					retorno = 0;
					break;
			}
		}
	}
	return retorno;
}

int utn_getFlyCode(char pFlyCodeIngresado[],char * mensaje,char * mensajeError,int limite,int reintentos)
{
	int retorno;
	char aux[limite];
	retorno = -1;

	if(pFlyCodeIngresado != NULL && reintentos >=0 && limite >0)
	{
		do
		{
			printf("%s",mensaje);
			if(myGets(aux,limite) == 0 &&
					esCodigoVuelo(aux,limite)==1)
			{
				strncpy(pFlyCodeIngresado,aux,limite);
				retorno = 0;
				break;
			}
			else
			{
				printf("%s", mensajeError);
			}
			reintentos--;
		}while(reintentos > 0);
	}
	return retorno;
}

int utn_getDiaMesAnio(int* pdia,int* pMes,int* pAnio,int edad,char * mensaje,char * mensajeError,int minimo,int maximo,int reintentos)
{
	int retorno;
	int auxDia;
	int auxMes;
	int auxAnio;
	retorno = -1;

	if(pdia != NULL && pMes != NULL && pAnio != NULL && maximo >= minimo && reintentos >=0)
	{
		do
		{
			printf("%s",mensaje);
			if(!utn_getInt(&auxDia,"Ingrese el dia de nacimiento","Error,dia invalido\n",1,31,5) &&
			   !utn_getInt(&auxMes,"Ingrese el mes de nacimiento","Error,mes invalido\n",1,12,5)&&
			   !utn_getInt(&auxAnio,"Ingrese el anio de nacimiento","Error,anio invalido solo mayores de 18 y menores de 70",1952,2002,5))
			{
				if(validarFecha(auxDia,auxMes,auxAnio,edad))
				{
					*pdia = auxDia;
					*pMes = auxMes;
					*pAnio = auxAnio;
					retorno = 0;
					break;
				}
				else
				{
					printf("%s", mensajeError);
				}
			}
			reintentos--;
		}while(reintentos > 0);
	}
	return retorno;
}

int validarFecha(int dia,int mes,int anio,int edad)
{
    int todoOk = 0;
    int validarDia;
    int validarAnio;
    int edadValidada;
    int anioActual=2022;

    switch(mes)
    {
        case 4:
        case 6:
        case 9:
        case 11:
            if(dia > 30)
            {
                printf("Error,este mes solo tiene 30 dias\n");
                validarDia = 0;
            }
            else
            {
                validarDia = 1;
            }
            break;
        case 2:
            if(dia >28)
            {
                printf("Error, este mes solo tiene 28 dias\n");
                validarDia = 0;
            }
            else
            {
                validarDia = 1;
            }
            break;
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            if(dia >31)
            {
                printf("Error, este mes solo tiene 31 dias\n");
                validarDia = 0;
            }
            else
            {
                validarDia = 1;
            }
            break;
        default:
            printf("No existe el mes\n");
            validarDia = 0;
            break;
    }
    edadValidada= anioActual - anio;
    if(edadValidada == edad)
    {
    	validarAnio = 1;

    }
    else
    {
    	if(edadValidada -1 == edad && mes >= 5)
    	{
    		validarAnio = 1;
    	}
    	else
    	{
    		printf("Error,anio de nacimiento invalido\n");
    		validarAnio = 0;
    	}
    }

    if(validarDia == 1 && validarAnio == 1)
    {
        todoOk = 1;
    }
    return todoOk;
}





