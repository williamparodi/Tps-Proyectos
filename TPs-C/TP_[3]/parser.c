#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Employee.h"
#include "parser.h"

/** \brief Parsea los datos los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int parser_EmployeeFromText(FILE* pFile , LinkedList* pArrayListEmployee)
{

	int cant;
	char buffer[4] [25];
	int itsOk = 0;

	Employee* auxEmployee;

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

		auxEmployee = employee_newParametros(buffer[0],buffer[1],buffer[2],buffer[3]);

		if(auxEmployee != NULL)
		{
			ll_add(pArrayListEmployee,auxEmployee);
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
int parser_EmployeeFromBinary(FILE* pFile , LinkedList* pArrayListEmployee)
{

	int itsOk = 0;
	int cantidad;
	Employee* auxEmployee = NULL;

	if(pFile != NULL)
	{
		while(!feof(pFile))
		{
			auxEmployee = employee_new();

			if(auxEmployee != NULL)
			{
				cantidad = fread(auxEmployee,sizeof(Employee),1,pFile);

				if(cantidad == 1)
				{
					ll_add(pArrayListEmployee,auxEmployee);
					auxEmployee = NULL;
					itsOk = 1;
				}
				else
				{
					if(feof(pFile))
					{
						employee_delete(auxEmployee);
						break;
					}
				}
			}

		}
	}

    return itsOk;
}
