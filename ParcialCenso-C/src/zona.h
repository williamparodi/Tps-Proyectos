#ifndef ZONA_H_
#define ZONA_H_
#include "censistas.h"
typedef struct
{
	int idZona;
	char calle1[51];
	char calle2[51];
	char calle3[51];
	char calle4[51];
	int idLocalidad;
	Censista responsable;
	int censadosInSitu;
	int censadosVirtual;
	int censadosAusentes;
	int estadoZona;
	int isEmpty;
}Zona;

int inicializarZona(Zona list[], int len);
int buscarZonaPorId(Zona list[], int len,int id);
int buscaLugarEnZonaVacio(Zona list[],int len);
int cargarZona(Zona list[], int len,Censista responsble[],int lenCensista);
int asignarZona(Zona listZona[],int lenZona,Censista listCensita[],int lenCensista,int idCensista,int idZona);
int noEstaVaciaZona(Zona list[],int len);
int cargaDeDatosZona(Zona listZona[],int lenZona,Censista listCensista[],int lenCensista,int idCensista,int idZona);
void mostrarUnaZona(Zona unaZona);
int mostrarZonas(Zona list[],int len);
int mostrarZonasConCensados(Zona list[],int len);
int cargaForzadaZona(Zona listZona[],int len,Zona listaForzadaZona[],int lenForzado);
int cantidadDeCensadosTotal(Zona list[],int len,int* total);
int bajaZona(Zona list[],int len,int idZona);
#endif /* ZONA_H_ */
