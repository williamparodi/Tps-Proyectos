/*
 ============================================================================
 Name        : censo.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "menu.h"
#include "censistas.h"
#include "utn.h"
#include "zona.h"
#include "informes.h"
#define LEN_CENSISTA 2000
#define LEN_FORZADA 5
#define LEN_FECHA 2000
#define LEN_DIRECCION 2000
#define LEN_ZONA 500
#define LEN_ZONAFORZADA 5

int main(void)
{
	setbuf(stdout,NULL);
	int idCensista=1000;
	int idZona=100;
	int contadorCensisActivosPendiente=0;
	int opcion;
	Censista listCensista[LEN_CENSISTA];
	Fecha listaFecha[LEN_FECHA];
	Direccion listaDireccion[LEN_DIRECCION];
	Zona listaZona[LEN_ZONA];
	Censista listaForzada[LEN_FORZADA]={
					{1001,"Roberto","Bolaneos",35,{20,06,2000},{"Humerto Primo",1000},3},
					{1002,"Luis Alberto","Benitez",45,{29,03,1980},{"Psje Chimorazo",5621,},3},
					{1003,"Mariela Paula","Alvarez",19,{14,12,1950},{"Laprida",1509},3},
					{1004,"Juana","Pereyra",18,{11,12,1979},{"Zapata",166},3},
					{1005,"Alan Mauro","Ortuza",22,{11,06,1999},{"Tres Arroyos",1238},3}};
	Zona listaForzaZona[LEN_ZONAFORZADA]={
					{101,"Laprida","Solis","Cordoba","Azcuenaga",2},
					{102,"Azcuenaga","Av Corrientes","Zapata","Esmeralda",3},
					{103,"Cuba","Pacheco","Peru","Humahuaca",5},
					{104,"Libertad","Picheuta","Donato","Rosales",1},
					{105,"Santa fe","Culpina","Florida","Lavalle",4}};

	if(inicializarCensista(listCensista,LEN_CENSISTA) || inicializarZona(listaZona,LEN_ZONA))
	{
		printf("Error al inical el programa\n");
	}

	do
		{
			menuCenso();
			if(!utn_getInt(&opcion,"Ingrese una opcion:","Error,opcion invalida\n",1,13,5))
			{
				switch(opcion)
				{
					case 1:
						if(!cargarCensista(listCensista,LEN_CENSISTA,listaFecha,LEN_FECHA,listaDireccion,LEN_DIRECCION))
						{
							printf("Carga con exito\n");
						}
						else
						{
							printf("Error al cargar pasajeros\n");
						}
						break;
					case 2:
						if(noEstaVacio(listCensista,LEN_CENSISTA))
						{
							if(!modificarCensistas(listCensista,LEN_CENSISTA,idCensista))
							{
								printf("Modificacion con exito\n");
							}
							else
							{
								printf("Error al modificar\n");
							}
						}
						else
						{
							printf("Primero debe dar de alta censistas\n");
						}
						break;
					case 3:
						if(noEstaVacio(listCensista,LEN_CENSISTA))
						{
							if(!bajaCensista(listCensista,LEN_CENSISTA,idCensista))
							{
								printf("Baja con exito\n");
							}
							else
							{
								printf("Baja cancelada\n");
							}
						}
						else
						{
							printf("Primero debe dar de alta censistas\n");
						}
						break;
					case 4:
						if(!cargarZona(listaZona,LEN_ZONA,listCensista,LEN_CENSISTA))
						{
							printf("Carga con exito!\n");
						}
						else
						{
							printf("Error al cargar zona\n");
						}
						break;
					case 5:
						if(noEstaVaciaZona(listaZona,LEN_ZONA))
						{
							if(!asignarZona(listaZona,LEN_ZONA,listCensista,LEN_CENSISTA,idCensista, idZona))
							{
								printf("Zona asignada\n");
							}
							else
							{
								printf("Error al asignar zona\n");
							}
						}
						else
						{
							printf("Primero deberia cargar zona\n");
						}
						break;
					case 6:
						if(!cargaDeDatosZona(listaZona,LEN_ZONA,listCensista,LEN_CENSISTA,idCensista,idZona))
						{
							printf("Carga con exito\n");
						}
						else
						{
							printf("Error al cargar datos\n");
						}
						break;
					case 7:
						if(noEstaVaciaZona(listaZona,LEN_ZONA))
						{
							bajaZona(listaZona,LEN_ZONA,idZona);
						}
						else
						{
							printf("Primero deberia cargar zonas\n");
						}
						break;
					case 8:
						if(noEstaVacio(listCensista,LEN_CENSISTA))
						{
							mostrarCensistas(listCensista,LEN_CENSISTA);
						}
						else
						{
							printf("Primero deberia cargar censistas\n");
						}
						break;
					case 9:
						if(noEstaVaciaZona(listaZona,LEN_ZONA))
						{
							mostrarZonasConCensados(listaZona,LEN_FORZADA);
						}
						else
						{
							printf("Primero deberia cargar zonas y datos de censados\n");
						}
						break;
					case 10:
						if(!cargaForzada(listCensista,LEN_CENSISTA,listaForzada,LEN_FORZADA))
						{
							printf("Carga forzada exitosa\n");
						}
						else
						{
							printf("Error, al cargar\n");
						}
						break;
					case 11:
						if(!cargaForzadaZona(listaZona,LEN_ZONA,listaForzaZona,LEN_ZONAFORZADA))
						{
							printf("Carga forzada de zona exitosa\n");
						}
						else
						{
							printf("Error, al cargar\n");
						}
						break;
					case 12:
						printf("Informes:\n");
						printf("Informe 1:\n");
						contarCensistasActivosConPendiente(listCensista,LEN_CENSISTA,listaZona,LEN_ZONA,&contadorCensisActivosPendiente);
						printf("Cantidad de censistas activos con zona pendiente: %d\n",contadorCensisActivosPendiente);
						printf("Informes 2:\n");
						ordenarPorApellidoYNombre(listCensista,LEN_CENSISTA);
						mostrarCensistas(listCensista,LEN_CENSISTA);
						printf("Informes 3:\n");
						cantCasasAusentes(listaZona,LEN_ZONA);
						break;
					case 13:
						printf("Gracias por utilizar nuestro programa\n");
						break;
				}
			}
		}while(opcion != 13);
		return 0;
}
