#ifndef INPUTS_H_INCLUDED
#define INPUTS_H_INCLUDED

int menu();
int ingresarInt(char mensaje[]);
float ingresarFloat(char mensaje[]);
int ingresarString(char mensaje[], char info[]);
int pasarMayusculaPrimerCaracter(char string[]);
int validarMinMax(int numero,int min, int max);
int validarFloatMinMax(float numero,int min,int max);

#endif // INPUTS_H_INCLUDED
