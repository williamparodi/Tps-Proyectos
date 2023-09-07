#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "utn.h"
#include "menu.h"
#include "censistas.h"
#include "direccion.h"
#include "fecha.h"

#define INACTIVO 1
#define ACTIVO 2
#define LIBERADO 3
#define VACIO 1
#define LLENO 0

int static incrementaId()
{
	static int id = 1000;
	id++;
	return id;
}

int inicializarCensista(Censista list[], int len)
{
	int retrono;
	retrono = -1;

	if(list != NULL && len >0)
	{
		for(int i=0;i<len;i++)
		{
			list[i].isEmpty =VACIO;
		}
		retrono = 0;
	}
	return retrono;
}

int modificarCensistas(Censista list[],int len,int id)
{
	int retorno;
	int index;
	int opcion;
	Censista auxList;
	retorno = -1;
	if(list != NULL && len >0 && id >0)
	{
		if(noEstaVacio(list,len))
		{
			printf("-------------------------------------------------------------------------------------------------\n");
			printf("Id   Nombre   	      Apellido      Edad      Fecha      Direccion                 Estado     	 \n");
			printf("-------------------------------------------------------------------------------------------------\n");
			mostrarSoloCensistasDeAlta(list,len);
			if(!utn_getInt(&id,"\nIngrese el id del censista a modificar:\n","Error,id incorrecto\n",1000,2000,5))
			{
				index = buscarCensistaPorId(list,len,id);
				if(index != -1)
				{
					retorno=0;
					printf("Id   Nombre   	      Apellido      Edad      Fecha      Direccion                 Estado     	 \n");
					mostrarUnCensista(list[index]);
					do
					{
						menuModificarCensista();
						if(!utn_getInt(&opcion,"Que campo desea modificar?\n",
													"Error,opcion incorrecta\n",1,5,5))
						{
							switch(opcion)
							{
							case 1:
								if(!utn_getNombreCompleto(auxList.nombre,"Ingrese el nombre nuevo:\n","Error,solo letras\n",50,5))
								{
									strcpy(list[index].nombre,auxList.nombre);
									printf("Nombre modificado\n");
								}
								else
								{
									printf("Error al modificar nombre\n");
								}
								break;
							case 2:
								if(!utn_getNombreCompleto(auxList.apellido,"Ingrese el apellido nuevo:\n","Error,solo letras\n",50,5))
								{
									strcpy(list[index].nombre,auxList.nombre);
									printf("Apellido modificado\n");
								}
								else
								{
									printf("Error al modificar\n");
								}
								break;
							case 3:
							do
							{
								menuCambioFecha();
								if(!utn_getInt(&opcion,"Eliga el campo a modificar:","Error, opcion incorrecta\n",1,5,5))
								{
									switch(opcion)
									{
									case 1:
										if(!utn_getInt(&auxList.edad,"Ingrese la edad nueva:\n",
												"Error,solo mayores de 18 años y menores de 70",18,70,5))
										{
											printf("Edad modificada\n");
										}
										break;
									case 2:
										if(!utn_getInt(&auxList.nacimiento.dia,"Ingrese el nuevo dia:\n","Error, dia invalido\n",1,31,5))
										{
											printf("Dia modificado\n");
										}
										break;
									case 3:
										if(!utn_getInt(&auxList.nacimiento.mes,"Ingrese el nuevo mes:\n","Error,mes invalido\n",1,12,5))
										{
											printf("Mes modificado\n");
										}
										break;
									case 4:
										if(!utn_getInt(&auxList.nacimiento.anio,"Ingrese el nuevo anio:\n","Error,anio invalido\n",1952,2002,5))
										{
											printf("Anio modificado\n");
										}
										break;
									default:
										break;
									}
									if(validarFecha(auxList.nacimiento.dia,auxList.nacimiento.mes,
											auxList.nacimiento.anio,auxList.edad))
									{
										list[index].nacimiento.dia= auxList.nacimiento.dia;
										list[index].nacimiento.mes=auxList.nacimiento.mes;
										list[index].nacimiento.anio=auxList.nacimiento.anio;
										list[index].edad = auxList.edad;
									}
									else
									{
										printf("La fecha de nacimiento no coincide con su edad modifique los campos\n");
										break;
									}
								}
							}while(opcion!=5);
								break;
							case 5:
								do
								{
									menuDireccion();
									if(!utn_getInt(&opcion,"Ingrese una opcion:\n","Error,opcion invalida",1,3,5))
									{
										switch(opcion)
										{
										case 1:
											if(!utn_getNombreCompleto(auxList.direCensista.calleDireccion,
													"Ingrese el nuevo nombre de la calle\n","Error solo letras\n",50,5))
											{
												strcpy(list[index].direCensista.calleDireccion,auxList.direCensista.calleDireccion);
												printf("Nombre de calle cambiada\n");
											}
											break;
										case 2:
											if(!utn_getInt(&auxList.direCensista.altura,"Ingrese altura:\n","Error al ingresar altura\n",10,20000,5))
											{
												list[index].direCensista.altura= auxList.direCensista.altura;
												printf("Altura cambiada\n");
											}
											break;
										default:
											break;
										}
									}
								}while(opcion != 3);
								break;
							case 6:
								printf("Se vuelve al menu principal\n");
								break;
							}
						}

					}while(opcion != 6);
				}
				else
				{
					printf("Id incorrecto\n");
				}
			}
		}
	}
	return retorno;
}

int buscarCensistaPorId(Censista list[], int len,int id)
{
	int retrono;
	retrono =-1;
	if(list != NULL && len > 0 && id >0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].idCensista == id && list[i].isEmpty == LLENO)
			{
				retrono = i;
				break;
			}
		}
	}
	return retrono;
}

int buscaLugarVacio(Censista list[],int len)
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

int bajaCensista(Censista list[], int len, int id)
{
	int retrono;
	int index;
	int opcion;
	retrono = -1;
	if(list != NULL && len >0 && id >0)
	{
		if(noEstaVacio(list,len))
		{
			printf("-----------------------------Baja--de--Censista--------------------------------------------------\n");
			printf("Id   Nombre   	      Apellido      Edad      Fecha      Direccion                 Estado     	 \n");
			printf("-------------------------------------------------------------------------------------------------\n");
			mostrarSoloCensistasDeAlta(list,len);
			if(!utn_getInt(&id,"\nIngrese el id del censista a borrar:\n","Error,id incorrecto\n",1000,2000,5))
			{
				index = buscarCensistaPorId(list,len,id);
				if(index != -1)
				{
					utn_getInt(&opcion,"Esta seguro que quiere borrar este censista? 1-Si o 2-No\n",
							"Error,opcion incorrecta\n",1,2,5);
					mostrarUnCensista(list[index]);
					if(opcion ==1 && list[index].estado != ACTIVO)
					{
						list[index].estado = INACTIVO;
						printf("Censista borrado\n");
						retrono=0;
					}
					else
					{
						printf("No se pudo dar de baja\n");
						retrono=1;
					}
				}
			}
		}
	}
	return retrono;
}

void mostrarUnCensista(Censista unCensista)
{
	char auxEstado[50];
	switch(unCensista.estado)
	{
		case INACTIVO:
			strcpy(auxEstado,"INACTIVO");
			break;
		case ACTIVO:
			strcpy(auxEstado,"ACTIVO");
			break;
		case LIBERADO:
			strcpy(auxEstado,"LIBERADO");
			break;
	}

	printf("%d %-15s  %-10s    %-8d  %d/%d/%d  %-8s  %-8d  %-8s\n",
			unCensista.idCensista,unCensista.nombre,
			unCensista.apellido,
			unCensista.edad,
			unCensista.nacimiento.dia,
			unCensista.nacimiento.mes,
			unCensista.nacimiento.anio,
			unCensista.direCensista.calleDireccion,
			unCensista.direCensista.altura,
			auxEstado);
}

int mostrarCensistas(Censista list[], int len)
{
	int retrono;
	retrono= -1;
	if(list != NULL && len >0)
	{
		printf("------------------------------------Censistas----------------------------------------------------\n");
		printf("Id   Nombre   	      Apellido      Edad      Fecha      Direccion                 Estado     	 \n");
		printf("-------------------------------------------------------------------------------------------------\n");
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty==LLENO)
			{
				mostrarUnCensista(list[i]);
			}
		}
		retrono=0;

	}
	return retrono;
}

int noEstaVacio(Censista list[],int len)
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

int mostrarSoloCensistasDeAlta(Censista list[],int len)
{
	int retrono;
	retrono=-1;
	if(list != NULL && len>0)
	{
		for(int i=0;i<len;i++)
		{
			if(list[i].isEmpty==LLENO)
			{
				mostrarUnCensista(list[i]);
			}
		}
		retrono=0;
	}
	return retrono;
}

int cargaForzada(Censista list[],int len,Censista listaForzada[],int lenForzado)
{
	int retorno;
	int index;
	retorno= -1;
	if(list != NULL && listaForzada != NULL && len >0 && lenForzado >0)
	{
		index=buscaLugarVacio(list, len);
		if(index != -1)
		{
			for(int i=0;i<lenForzado && i<len;i++)
			{
				list[i]= listaForzada[i];
				list[i].isEmpty = LLENO;
				mostrarUnCensista(list[i]);
			}
			retorno=0;
		}
	}
	return retorno;
}

int cargarCensista(Censista list[], int len,Fecha listaFecha[],int lenfecha,Direccion listaDire[],int lenDire)
{
	int retorno;
	int index;
	retorno=-1;
	Censista aux;
	if(list != NULL && len > 0)
		{
			index = buscaLugarVacio(list,len);
			if(index != -1)
			{
				if(!utn_getNombreCompleto(aux.nombre,"Ingrese nombre del censista:\n","Error,solo letras\n",50,5) &&
					!utn_getNombreCompleto(aux.apellido,"Ingrese apellido del censista:\n","Error,solo letras\n",50,5) &&
					!utn_getInt(&aux.edad,"Ingrese edad del censista:\n","Error, solo mayores a 18 años\n",18,150,5)&&
					!utn_getDiaMesAnio(&aux.nacimiento.dia,&aux.nacimiento.mes,&aux.nacimiento.anio,aux.edad,
							"Fecha de nacimiento\n","Error,fecha erronea",1,3000,5)&&
					!utn_getNombreCompleto(aux.direCensista.calleDireccion,"Ingrese el nombre de la calle\n","Error solo letras\n",50,5)&&
					!utn_getInt(&aux.direCensista.altura,"Ingrese altura:\n","Error al ingresar altura\n",10,20000,5))

				{
					aux.idCensista = incrementaId();
					aux.estado=LIBERADO;
					aux.isEmpty=LLENO;
					list[index] = aux;
					printf("Censista cargado\n");
					printf("-------------------------------------------------------------------------------------------------\n");
					printf("Id   Nombre   	      Apellido      Edad      Fecha      Direccion                 Estado     	 \n");
					printf("-------------------------------------------------------------------------------------------------\n");
					mostrarUnCensista(list[index]);
					retorno=0;
				}
			}
		}
	return retorno;
}



