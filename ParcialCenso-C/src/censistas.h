#ifndef CENSISTAS_H_
#define CENSISTAS_H_
#include "fecha.h"
#include "direccion.h"
#include "censistas.h"
typedef struct
{
	int idCensista;
	char nombre[51];
	char apellido[51];
	int edad;
	Fecha nacimiento;
	Direccion direCensista;
	int estado;
	int isEmpty;
}Censista;

int inicializarCensista(Censista list[], int len);
int cargarCensista(Censista list[], int len,Fecha listaFecha[],int lenfecha,Direccion listaDire[],int lenDire);
int modificarCensistas(Censista list[],int len,int id);
int buscaLugarVacio(Censista list[],int len);
int buscarCensistaPorId(Censista list[], int len,int id);
int bajaCensista(Censista list[], int len, int id);
int mostrarCensistas(Censista list[], int len);
int mostrarSoloCensistasDeAlta(Censista list[],int len);
void mostrarUnCensista(Censista unCensista);
int noEstaVacio(Censista list[],int len);
int cargaForzada(Censista list[],int len,Censista listaForzada[],int lenForzado);

#endif /* CENSISTAS_H_ */
