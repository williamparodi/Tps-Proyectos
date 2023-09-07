#include <stdio.h>
#include <stdlib.h>
#include "../inc/LinkedList.h"
#include "Gamers.h"
#include "parser.h"

/** \brief Parsea los datos los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int parser_gamerFromText(FILE* pFile , LinkedList* pArrayListGamer)
{

	int cant;
	char buffer[4] [25];
	int itsOk = 0;

	eGamer* auxGamer;

	if(pFile == NULL)
	{
		printf("No se pudo guardar el archivo\n");
		exit(1);
	}

	cant = fscanf(pFile,"%[^,],%[^,],%[^,],%[^\n]\n",buffer[0],buffer[1],buffer[2],buffer[3]);/// Lectura fantasma

	while(!feof(pFile))
	{
		cant = fscanf(pFile, "%[^,],%[^,],%[^,],%[^\n]\n",buffer[0],buffer[1],buffer[2],buffer[3]);

		if(cant < 4)
		{
			break;
		}

		auxGamer = gamer_newParametros(buffer[0],buffer[1],buffer[2],buffer[3]);

		if(auxGamer != NULL)
		{
			ll_add(pArrayListGamer,auxGamer);
			itsOk = 1;
		}

	}

	fclose(pFile);

    return itsOk;
}

/** \brief Parsea los datos los datos de los empleados desde el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int parser_gamerFromBinary(FILE* pFile , LinkedList* pArrayListGamer)
{

	int itsOk = 0;
	int cantidad;
	eGamer* auxGamer = NULL;

	if(pFile != NULL)
	{
		while(!feof(pFile))
		{
			auxGamer = gamer_new();

			if(auxGamer != NULL)
			{
				cantidad = fread(auxGamer,sizeof(eGamer),1,pFile);

				if(cantidad == 1)
				{
					ll_add(pArrayListGamer,auxGamer);
					auxGamer = NULL;
					itsOk = 1;
				}
				else
				{
					if(feof(pFile))
					{
						gamer_delete(auxGamer);
						break;
					}
				}
			}

		}
	}

    return itsOk;
}
