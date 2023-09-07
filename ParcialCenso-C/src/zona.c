#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "zona.h"
#include "censistas.h"
#include "utn.h"
#define PENDIENTE 1
#define FINALIZADO 2
#define VACIO 1
#define LLENO 0
#define VILLA_DEL_PARQUE 1
#define PATERNAL 2
#define CABALLITO 3
#define MONSERRAT 4
#define RAMOS_MEJIA 5
#define INACTIVO 1
#define ACTIVO 2
#define LIBERADO 3

int static incrementaId()
{
	static int id = 100;
	id++;
	return id;
}

int inicializarZona(Zona list[], int len)
{
	int retorno;
	retorno = -1;

	if(list != NULL && len >0)
	{
		for(int i=0;i<len;i++)
		{
			list[i].isEmpty =VACIO;
		}
		retorno = 0;
	}
	return retorno;
}

int buscarZonaPorId(Zona list[], int len,int id)
{
	int retorno;
	retorno =-1;
	if(list != NULL && len > 0 && id >0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].idZona == id && list[i].isEmpty == LLENO)
			{
				retorno = i;
				break;
			}
		}
	}
	return retorno;
}

int buscaLugarEnZonaVacio(Zona list[],int len)
{
	int index;
	index= -1;
	if(list != NULL && len >0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty == VACIO)
			{
				index= i;
				break;
			}
		}
	}
	return index;
}

int cargarZona(Zona list[], int len,Censista responsble[],int lenCensista)
{
	int retorno;
	int index;
	retorno=-1;
	Zona aux;
	if(list != NULL && len > 0 && responsble != NULL && lenCensista >0)
	{
		index = buscaLugarEnZonaVacio(list,len);
		if(index != -1)
		{
			if(!utn_getNombreCompleto(aux.calle1,"Ingrese el nombre de la calle1(sin numeros):\n","Error,solo letras\n",50,5)&&
					!utn_getNombreCompleto(aux.calle2,"Ingrese el nombre de la calle2(sin numeros):\n","Error,solo letras\n",50,5)&&
					!utn_getNombreCompleto(aux.calle3,"Ingrese el nombre de la calle3(sin numeros):\n","Error,solo letras\n",50,5)&&
					!utn_getNombreCompleto(aux.calle4,"Ingrese el nombre de la calle4(sin numeros):\n","Error,solo letras\n",50,5)&&
					!utn_getInt(&aux.idLocalidad,"Ingrese el numero de la localidad:\n"
													"1-Villa del parque\n "
													"2-Paternal\n"
													"3-Caballito\n"
													"4-Monserrat\n "
													"5-Ramos Mejia\n",
													"Error,localidad invalida\n",1,5,5))

			{
				aux.idZona = incrementaId();
				aux.estadoZona=PENDIENTE;
				strcpy(aux.responsable.nombre,"NO ASIGNADO");
				strcpy(aux.responsable.apellido,"NO ASIGNADO");
				aux.isEmpty=LLENO;
				list[index] = aux;
				printf("Zona cargada\n");
				printf("-------------------------------------------------------------------------------------------------\n");
				printf("Id   Calles   	 		      Localidad         Estado     Nombre y Apellido Censista Responsable\n");
				printf("-------------------------------------------------------------------------------------------------\n");
				mostrarUnaZona(list[index]);
				retorno=0;
			}
		}
	}
	return retorno;
}

void mostrarUnaZona(Zona unaZona)
{
	char auxLocalidad[50];
	char auxEstado[50];
	switch(unaZona.idLocalidad)
	{
	case VILLA_DEL_PARQUE:
		strcpy(auxLocalidad,"Villa del Parque");
		break;
	case PATERNAL:
		strcpy(auxLocalidad,"Paternal");
		break;
	case CABALLITO:
		strcpy(auxLocalidad,"Caballito");
		break;
	case MONSERRAT:
		strcpy(auxLocalidad,"Monserrat");
		break;
	case RAMOS_MEJIA:
		strcpy(auxLocalidad,"Ramos Mejia");
		break;
	}
	switch(unaZona.estadoZona)
	{
	case PENDIENTE:
		strcpy(auxEstado,"PENDIENTE");
		break;
	case FINALIZADO:
		strcpy(auxEstado,"FINALIZADO");
		break;
	}

	printf("%d %s/%s/%s/%-10s %s %10s %s %s\n",
			unaZona.idZona,unaZona.calle1,
			unaZona.calle2,unaZona.calle3,unaZona.calle4,
			auxLocalidad,auxEstado,unaZona.responsable.nombre,
			unaZona.responsable.apellido);

}

int mostrarZonas(Zona list[],int len)
{
	int retrono;
	retrono= -1;
	if(list != NULL && len >0)
	{
		printf("-----------------------------------------Zonas---------------------------------------------------\n");
		printf("Id   Calles   	 		      Localidad         Estado     Nombre y Apellido Censista Responsable\n");
		printf("-------------------------------------------------------------------------------------------------\n");
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty==LLENO)
			{
				mostrarUnaZona(list[i]);
			}
		}
		retrono=0;
	}
	return retrono;
}

int mostrarZonasConCensados(Zona list[],int len)
{
	int retrono;
	retrono= -1;
	if(list != NULL && len >0)
	{
		printf("-----------------------------------------Zonas----------------------------------------------------------\n");
		printf("Id   Calles   	 		      Localidad         Estado    	      Nombre y Apellido Censista Responsable\n");
		printf("--------------------------------------------------------------------------------------------------------\n");
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty==LLENO)
			{
				mostrarUnaZona(list[i]);
				printf("\nCantidad de censados: Censados in situ:%d --"
						"Censados con formulario virtual:%d -- Censados ausentes:%d --\n",
						list[i].censadosInSitu,list[i].censadosVirtual,list[i].censadosAusentes);
				printf("-----------------------------------------------------------------------------------------------\n");
			}
		}
		retrono=0;
	}
	return retrono;
}

int asignarZona(Zona listZona[],int lenZona,Censista listCensita[],int lenCensista,int idCensista,int idZona)
{
	int retorno;
	int index;
	int indexZona;
	index=-1;
	indexZona=-1;
	retorno=-1;
	if(listZona != NULL && lenZona >0 && listCensita != NULL && lenCensista >0 && idZona >0 && idCensista>0)
	{
		mostrarSoloCensistasDeAlta(listCensita,lenCensista);
		if(!utn_getInt(&idCensista,"\nIngrese el id del censista a asignar:\n","Error,id incorrecto\n",1000,2000,5))
		{
			index = buscarCensistaPorId(listCensita,lenCensista,idCensista);
			if(index != -1 && listCensita[index].estado==LIBERADO)
			{
				mostrarZonas(listZona,lenZona);
				if(!utn_getInt(&idZona,"\nIngrese el id de la zona a asignar\n","Error,id incorrecto\n",100,500,5))
				{
					indexZona = buscarZonaPorId(listZona,lenZona,idZona);
					if(indexZona != -1 && listZona[indexZona].estadoZona != FINALIZADO && listCensita[indexZona].estado ==LIBERADO)
					{
						strcpy(listZona[indexZona].responsable.nombre,listCensita[index].nombre);
						strcpy(listZona[indexZona].responsable.apellido,listCensita[index].apellido);
						listCensita[index].estado=ACTIVO;
						listZona[indexZona].responsable.idCensista = listCensita[index].idCensista;
						retorno=0;
					}
					else
					{
						printf("La zona ya fue censada(finalizada)\n");
					}
				}
			}
			else
			{
				if(listCensita[index].estado==ACTIVO)
				{
					printf("Ya esta en actividad\n");
				}
				else
				{
					printf("Ya esta dado de Baja\n");
				}
			}
		}
	}
	return retorno;
}

int noEstaVaciaZona(Zona list[],int len)
{
	int retrono;
	retrono = 0;
	if(list != NULL && len > 0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty == LLENO)
			{
				retrono = 1;
				break;
			}
		}
	}
	return retrono;
}

int cargaDeDatosZona(Zona listZona[],int lenZona,Censista listCensista[],int lenCensista,int idCensista,int idZona)
{
	int retorno;
	int index;
	int indexZona;
	indexZona=-1;
	index=-1;
	retorno=-1;
	Zona aux;
	aux.censadosInSitu=0;
	aux.censadosVirtual=0;
	aux.censadosAusentes=0;
	if(listZona != NULL && lenZona >0 && listCensista != NULL && lenCensista >0 && idCensista >0 && idZona >0)
	{
		mostrarZonas(listZona,lenZona);
		if(!utn_getInt(&idZona,"Ingrese id Zona:\n","Error,id invalido\n",101,500,5))
		{
			indexZona=buscarZonaPorId(listZona,lenZona,idZona);
			if(indexZona!=-1 && listZona[indexZona].estadoZona==PENDIENTE)
			{
				mostrarSoloCensistasDeAlta(listCensista,lenCensista);
				if(!utn_getInt(&idCensista,"Ingrese id censista:\n","Error,id invalido\n",1001,2000,5))
				{
					index=buscarCensistaPorId(listCensista,lenCensista,idCensista);
					if(index!=-1 && listCensista[index].estado==ACTIVO &&
							listCensista[index].idCensista == listZona[indexZona].responsable.idCensista)
					{
						if(!utn_getInt(&aux.censadosInSitu,"Ingrese cantidad de censados in situ:\n","Error,dato incorrecton",0,10000,5))
						{
							listZona[indexZona].censadosInSitu=aux.censadosInSitu;
						}
						if(!utn_getInt(&aux.censadosVirtual,"Ingrese cantidad de censados virtual:\n","Error,dato incorrecto\n",0,10000,5))
						{
							listZona[indexZona].censadosVirtual=aux.censadosVirtual;
						}
						if(!utn_getInt(&aux.censadosAusentes,"Ingrese cantidad de ausentes:\n","Error,dato incorrecto\n,",0,10000,5))
						{
							listZona[indexZona].censadosAusentes= aux.censadosAusentes;
						}
						listZona[indexZona].estadoZona=FINALIZADO;
						listCensista[index].estado=LIBERADO;
						retorno=0;
					}
					else
					{
						printf("El censista no existe o no esta activo\n");
					}
				}
			}
			else
			{
				printf("Esa zona ya fue censada\n");
			}
		}
	}
	return retorno;
}

int cargaForzadaZona(Zona listZona[],int len,Zona listaForzadaZona[],int lenForzado)
{
	int retorno;
	int index;
	retorno= -1;
	if(listZona != NULL && listaForzadaZona != NULL && len >0 && lenForzado >0)
	{
		index=buscaLugarEnZonaVacio(listZona,len);
		if(index != -1)
		{
			for(int i=0;i<lenForzado && i<len;i++)
			{
				listZona[i]= listaForzadaZona[i];
				listZona[i].isEmpty = LLENO;
				listZona[i].estadoZona=PENDIENTE;
				strcpy(listZona[i].responsable.nombre,"NO ASIGNADO");
				strcpy(listZona[i].responsable.apellido,"NO ASIGNADO");
				mostrarUnaZona(listZona[i]);
			}
			retorno=0;
		}
	}
	return retorno;
}

int bajaZona(Zona list[],int len,int idZona)
{
	int retrono;
	int index;
	int opcion;
	retrono = -1;
	if(list != NULL && len >0 && idZona >0)
	{
		if(noEstaVaciaZona(list,len))
		{
			printf("-----------------------------------Baja--de--Zona--------------------------------------------------\n");
			printf("Id   Calles   	 		      Localidad         Estado    	      Nombre y Apellido Censista Responsable\n");
			printf("--------------------------------------------------------------------------------------------------------\n");
			mostrarZonas(list,len);
			if(!utn_getInt(&idZona,"\nIngrese el id de la zona a borrar:\n","Error,id incorrecto\n",100,500,5))
			{
				index = buscarZonaPorId(list,len,idZona);
				if(index != -1)
				{
					utn_getInt(&opcion,"Esta seguro que quiere borrar esta zona? 1-Si o 2-No\n",
							"Error,opcion incorrecta\n",1,2,5);
					mostrarUnaZona(list[index]);
					if(opcion ==1 && list[index].estadoZona==PENDIENTE)
					{
						list[index].estadoZona = FINALIZADO;
						printf("Zona borrado\n");
						retrono=0;
					}
					else
					{
						printf("No se pudo dar de baja ya esta finalizada\n");
						retrono=1;
					}
				}
			}
		}
	}
	return retrono;
}

