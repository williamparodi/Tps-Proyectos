#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>


int menu()
{
    int opcion;

   	printf("1. Cargar los datos de los empleados desde el archivo data.csv (modo texto)\n");
   	printf("2. Cargar los datos de los empleados desde el archivo data.bin (modo binario)\n");
    printf("3. Alta de empleado\n");
    printf("4. Modificar datos de empleado\n");
    printf("5. Baja de empleado\n");
    printf("6. Listar empleados\n");
    printf("7. Ordenar empleados\n");
    printf("8. Guardar los datos de los empleados en el archivo data.csv (modo texto)\n");
    printf("9. Guardar los datos de los empleados en el archivo data.bin (modo binario)\n");
    printf("10. Salir\n");
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





