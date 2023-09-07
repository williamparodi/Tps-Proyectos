#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "menu.h"
#include "censistas.h"
#include "utn.h"
#include "zona.h"
#include "informes.h"
#define INACTIVO 1
#define ACTIVO 2
#define LIBERADO 3
#define PENDIENTE 1
#define FINALIZADO 2
#define VILLA_DEL_PARQUE 1
#define PATERNAL 2
#define CABALLITO 3
#define MONSERRAT 4
#define RAMOS_MEJIA 5
int contarCensistasActivosConPendiente(Censista list[],int lenCensista,Zona listZona[],int lenZona,int* pContadorCensista)
{
	int retorno;
	int auxContadorCensistas=0;
	retorno=-1;
	if(list != NULL && lenCensista >0 && listZona != NULL && lenZona >0)
	{
		for(int i=0;i<lenCensista && i<lenZona;i++)
		{
			if(list[i].estado==ACTIVO && listZona[i].estadoZona==PENDIENTE)
			{
				auxContadorCensistas++;
			}
		}
		*pContadorCensista = auxContadorCensistas;
		retorno=0;
	}
	return retorno;
}

int ordenarPorApellidoYNombre(Censista list[],int len)
{
	int retorno;
	int estaOrdenado;
	Censista aux;
	retorno=-1;
	if(list != NULL && len >0)
	{
		do
		{
			estaOrdenado=1;
			len--;
			for(int i=0;i<len;i++)
			{
				if(list[i].estado==ACTIVO)
				{
					if(strcmp(list[i].apellido,list[i+1].apellido)>0)
					{
						aux = list[i];
						list[i] = list[i + 1];
						list[i + 1] = aux;
						estaOrdenado = 0;
					}
					else
					{
						if(strcmp(list[i].apellido,list[i + 1].apellido)==0
								&& (strcmp(list[i].nombre,list[i + 1].nombre)!=0))
						{
							aux = list[i];
							list[i] = list[i + 1];
							list[i + 1] = aux;
							estaOrdenado = 0;
						}
					}
				}
			}
		}while(estaOrdenado==0);
		retorno=0;
	}
	return retorno;
}

int cantCasasAusentes(Zona list[],int len)
{
	int retorno;
	int auxCantidadCasasAusentesParque=0;
	int auxCantidadCasasAusentesPaternal=0;
	int auxCantidadCasasAusentesCaballito=0;
	int auxCantidaCasasAusentesMonserrat=0;
	int auxCantidaCasasAusentesRamos=0;

	retorno=-1;
	if(list != NULL && len >0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].censadosAusentes != 0)
			{
				switch(list[i].idLocalidad)
				{
				case VILLA_DEL_PARQUE:
					auxCantidadCasasAusentesParque++;
					break;
				case PATERNAL:
					auxCantidadCasasAusentesPaternal++;
					break;
				case CABALLITO:
					auxCantidadCasasAusentesCaballito++;
					break;
				case MONSERRAT:
					auxCantidaCasasAusentesMonserrat++;
					break;
				case RAMOS_MEJIA:
					auxCantidaCasasAusentesRamos++;
					break;
				}
			}
		}

		if(auxCantidaCasasAusentesMonserrat >= auxCantidadCasasAusentesParque && auxCantidaCasasAusentesMonserrat >= auxCantidaCasasAusentesRamos &&
				auxCantidaCasasAusentesMonserrat >= auxCantidadCasasAusentesPaternal &&
				auxCantidaCasasAusentesMonserrat >= auxCantidadCasasAusentesCaballito)
		{

			printf("La localidad con mas ausentes es Moserrat con: %d\n",auxCantidaCasasAusentesMonserrat);
		}
		if(auxCantidaCasasAusentesRamos >= auxCantidadCasasAusentesCaballito && auxCantidaCasasAusentesRamos >= auxCantidadCasasAusentesParque &&
						auxCantidaCasasAusentesRamos >= auxCantidadCasasAusentesPaternal &&
						auxCantidaCasasAusentesRamos >= auxCantidaCasasAusentesMonserrat)
		{
			printf("La localidad con mas ausentes es Ramos con: %d\n",auxCantidaCasasAusentesRamos);
		}
		if(auxCantidadCasasAusentesParque >= auxCantidadCasasAusentesCaballito && auxCantidadCasasAusentesParque >= auxCantidadCasasAusentesPaternal &&
								auxCantidadCasasAusentesParque >= auxCantidaCasasAusentesMonserrat &&
								auxCantidadCasasAusentesParque >= auxCantidaCasasAusentesRamos)
				{
					printf("La localidad con mas ausentes es Villa del parque con: %d\n",auxCantidadCasasAusentesParque);
				}
		if(auxCantidadCasasAusentesPaternal >= auxCantidadCasasAusentesCaballito && auxCantidadCasasAusentesPaternal >= auxCantidadCasasAusentesParque &&
								auxCantidadCasasAusentesPaternal >= auxCantidaCasasAusentesMonserrat &&
								auxCantidadCasasAusentesPaternal >= auxCantidaCasasAusentesRamos)
				{
					printf("La localidad con mas ausentes es Paternal con: %d\n",auxCantidadCasasAusentesPaternal);
				}
		if(auxCantidadCasasAusentesCaballito >= auxCantidadCasasAusentesParque && auxCantidadCasasAusentesCaballito >= auxCantidadCasasAusentesPaternal &&
								auxCantidadCasasAusentesCaballito >= auxCantidaCasasAusentesMonserrat &&
								auxCantidadCasasAusentesCaballito >= auxCantidaCasasAusentesRamos)
				{
					printf("La localidad con mas ausentes es Caballito con: %d\n",auxCantidadCasasAusentesCaballito);
				}
		retorno=0;

	}
	return retorno;
}
