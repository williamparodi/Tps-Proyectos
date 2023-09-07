#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "LinkedList.h"
#include "Employee.h"
#include "Inputs.h"
#include "parser.h"
#include "Controller.h"

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromText(char* path , LinkedList* pArrayListEmployee)
{

	FILE* f = fopen(path,"r");

	int itsOk = 0;

	if(f != NULL && pArrayListEmployee != NULL)
	{
		if(parser_EmployeeFromText(f, pArrayListEmployee))
		{
			itsOk = 1;
		}
	}

	fclose(f);
    return itsOk;

}

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromBinary(char* path , LinkedList* pArrayListEmployee)
{

		FILE* f = fopen(path,"rb");

		int itsOk = 0;

		if(f != NULL && pArrayListEmployee != NULL)
		{
			if(parser_EmployeeFromBinary(f, pArrayListEmployee))
			{
				itsOk = 1;
			}
		}

		fclose(f);
	    return itsOk;

}

/** \brief Alta de empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_addEmployee(LinkedList* pArrayListEmployee, int* pId)
{

	Employee* auxEmployee;

	char nombre[20];
	int horasTrabajadas;
	int sueldo;
	int itsOk = 0;

	auxEmployee = employee_new();

	if(pArrayListEmployee != NULL && pId != NULL)
	{
		(*pId)++;

		ingresarString("Ingrese Nombre: ",nombre);
		pasarMayusculaPrimerCaracter(nombre);
		while(!employee_setNombre(auxEmployee, nombre))
		{
			ingresarString("Error,ingrese Nombre: ",nombre);
		}

		horasTrabajadas = ingresarInt("Ingrese cantidad de horasTrabajadas: ");

		while(!employee_setHorasTrabajadas(auxEmployee, horasTrabajadas))
		{
			horasTrabajadas = ingresarInt("Error, Ingrese cantidad de horasTrabajadas: ");
		}

		sueldo = ingresarInt("Ingrese sueldo: ");

		while(!employee_setSueldo(auxEmployee, sueldo))
		{
			sueldo = ingresarInt("Error, Ingrese sueldo: ");
		}

		auxEmployee = employee_new();

		if(auxEmployee != NULL)
		{
			if(employee_setId(auxEmployee, *pId)&&
			employee_setNombre(auxEmployee, nombre)&&
			employee_setHorasTrabajadas(auxEmployee, horasTrabajadas)&&
			employee_setSueldo(auxEmployee, sueldo))
			{
				ll_add(pArrayListEmployee,auxEmployee);
				itsOk = 1;
			}
			else
			{
				free(auxEmployee);
			}

		}

	}

	 return itsOk;
}

/** \brief Modificar datos de empleado
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_editEmployee(LinkedList* pArrayListEmployee)
{
	Employee* auxEmployee;

	int itsOk = 0;
	int index = -1;
	char choice = 's';
	int option;
	int id;
	char auxNombre[100];
	int auxHorasTrabajadas;
	int auxSueldo;


	if(pArrayListEmployee != NULL)
	{

		id = ingresarInt("Ingrese el id del empleado a modificar : ");

		auxEmployee = controller_searchById(pArrayListEmployee, id, &index);

		if(index == - 1)
		{
			printf("No se encontro ese Id\n");
		}
		else
		{
			printf("Id Empleado a modificar: %d \n",id);

			do
			{
				option = ingresarInt("Elija el campo a modificar: 1-Nombre 2-Horas Trabajadas 3-Sueldo 4-Salir ");

				while(!validarMinMax(option,1,4))
				{
					option = ingresarInt("Error, Elija el campo a modificar: 1-Nombre 2-Horas Trabajadas 3-Sueldo 4-Salir ");
				}

				switch(option)
				{

					case 1:
						ingresarString("Modifique el nombre : ", auxNombre);
						while(strlen(auxNombre) > 15)
						{
							ingresarString("Error, Ingresar nombre : ", auxNombre);
						}
						pasarMayusculaPrimerCaracter(auxNombre);
						employee_setNombre(auxEmployee, auxNombre);
						break;
					case 2:
						auxHorasTrabajadas = ingresarInt("Modifique la cantidad de horasTrabajadas: ");
						while(auxHorasTrabajadas < 0)
						{
							auxHorasTrabajadas = ingresarInt("Error, Ingrese cantidad de horasTrabajadas: ");
						}
						employee_setHorasTrabajadas(auxEmployee, auxHorasTrabajadas);
						break;
					case 3:
						auxSueldo = ingresarInt("Modifique el salario : ");
						while(auxSueldo > 0)
						{
							auxSueldo = ingresarInt("Error, Modifique el salario : ");
						}
						employee_setSueldo(auxEmployee, auxSueldo);
						break;
					case 4:
						choice = 'n';
						break;
					default:
						printf("Opcion invalida\n");
						break;
				}

			}while(choice == 's');

			if(employee_setNombre(auxEmployee,auxNombre)&&
					employee_setHorasTrabajadas(auxEmployee,auxHorasTrabajadas)&&
					employee_setSueldo(auxEmployee,auxSueldo))
			{
				itsOk = 1;
			}
			else
			{
				printf("Modificacion cancelada\n");
			}
		}
	}

	return itsOk;

}

/** \brief Baja de empleado
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_removeEmployee(LinkedList* pArrayListEmployee)
{

		int index = -1;//
		Employee* auxEmployee = NULL;
		char choice;
		int itsOk = 0;
		int id;


		if(pArrayListEmployee != NULL)
		{
			controller_ListEmployee(pArrayListEmployee);

			id = ingresarInt("Ingresa ID: ");

			while(id < 0 )
			{
				id = ingresarInt("Error ID invalido. Ingresa ID: ");

			}

			auxEmployee = controller_searchById(pArrayListEmployee,id,&index);

			if(index != -1)
			{
				printf("\n 	Borar empleado \n");
				printf("---------------------------------------\n");
				printf(" ID Nombre Horas trabajadas Sueldo      \n");
				printf("----------------------------------------\n");
				employee_listEmployee(auxEmployee);
				printf("Queres remover a este empleado? s/n: ");
				fflush(stdin);
				scanf(" %c",&choice);
				choice = tolower(choice);

				if(choice == 's')
				{
					if(ll_remove(pArrayListEmployee,index) == 0)
					{
						printf("-- Empleado removido --\n");
					}
					employee_delete(auxEmployee);
				}
				else
				{
					printf("-- No se borro el empleado--\n");
				}

				itsOk = 1;
			}

		}
		return itsOk;
}



/** \brief Listar empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_ListEmployee(LinkedList* pArrayListEmployee)
{
	int itsOk = 0;
	int len = ll_len(pArrayListEmployee);
	Employee* auxEmployee;

	if(pArrayListEmployee != NULL && len >0)
	{
		printf("-------------------------------------\n");
		printf("ID  Nombre  Horas Trabajadas  Sueldo \n");

		for(int i=0;i < len; i++)
		{
			auxEmployee = ll_get(pArrayListEmployee,i);
			employee_listEmployee(auxEmployee);
		}
		printf("\n\n");
		itsOk = 1;
	}

	return itsOk;

}

/** \brief Ordenar empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_sortEmployee(LinkedList* pArrayListEmployee)
{

		int itsOk = 0;
		int option;
		int order;

		if (pArrayListEmployee != NULL)
		{
			itsOk = 1;
			printf("Ordenar empleados\n");
			order = ingresarInt("Eliga Orden : 0 Down, 1 Up ");
			while(order < 0 || order > 1)
			{
				order = ingresarInt("Error,Orden :  0 Down, 1 Up  ");
			}

			 option= ingresarInt("Ingresar opcion: 1-Ordenar por Id, 2-Ordenar por Nombre, 3-Salir");
			while( option < 1 ||  option > 5)
			{
				 option = ingresarInt("Ingresar opcion: 1-Ordenar por Id, 2-Ordenar por Nombre, 3-Salir");
			}

			switch (option)
			{
			case 1:
				ll_sort( pArrayListEmployee, controller_orderById, order);
				break;
			case 2:
				ll_sort( pArrayListEmployee, controller_orderByName, order);
				break;
			case 3:
				printf("Ordenado exitoso !!!\n");
				break;
			default:
				printf("Opcion invalida\n");
				break;
			}
		}

		return itsOk;
	}




/** \brief Guarda los datos de los empleados en el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_saveAsText(char* path , LinkedList* pArrayListEmployee)
{
	int itsOk = -1;
	int len;
	int auxId;
	char auxNombre[25];
	int auxHorasTrabajadas;
	int auxSueldo;

	Employee* auxEmployee;

	FILE* f = fopen(path,"w");

	if(f != NULL)
	{
		len = ll_len(pArrayListEmployee);

		for(int i= 0;i<len;i++)
		{
			auxEmployee = ll_get(pArrayListEmployee,i);
			if(employee_getId(auxEmployee, &auxId)&&
						employee_getNombre(auxEmployee, auxNombre)&&
						employee_getHorasTrabajadas(auxEmployee, &auxHorasTrabajadas)&&
						employee_getSueldo(auxEmployee, &auxSueldo))
						{
							fprintf(f,"%d,%s,%d,%d\n",auxId,auxNombre,auxHorasTrabajadas,auxSueldo);
							itsOk = 1;
						}
			            else
			            {
			            	itsOk = 0;
			            }
		}
	}

    return itsOk;
}

/** \brief Guarda los datos de los empleados en el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_saveAsBinary(char* path , LinkedList* pArrayListEmployee)
{
	int itsOk;
	int len;
	int cantidad;
	int i = 0;
	Employee* auxEmployee;
	FILE* f = fopen(path,"wb");

	if(f != NULL)
	{
		len = ll_len(pArrayListEmployee);

		while(i < len)
		{
			auxEmployee = ll_get(pArrayListEmployee,i);

			if(auxEmployee != NULL)
			{
				cantidad = fwrite(auxEmployee,sizeof(Employee),1,f);
			}

			if(cantidad < 1)
			{
				itsOk = 0;
				break;
			}
			i++;
		}

		itsOk = 1;
	}

	fclose(f);
    return itsOk;
}

Employee* controller_searchById(LinkedList* pArrayListEmployee,int id, int* index)
{
	Employee* auxEmployee;
	int len = ll_len(pArrayListEmployee);
	int auxId;
	*index = -1;

	if(pArrayListEmployee != NULL && len > 0)
	{
		for(int i = 0; i < len ; i++)
		{
			auxEmployee =  ll_get(pArrayListEmployee,i);
			employee_getId(auxEmployee, &auxId);
			if(id ==auxId && auxEmployee != NULL)
			{
				(*index) = i;
				break;
			}
		}
	}
	return auxEmployee;
}

int controller_orderByName(void* employee1,void* employee2)
{
		int itsOk = 0;
		char auxName1[20];
		char auxName2[20];

		if(employee1!= NULL && employee2 != NULL)
		{
			strcpy(auxName1,((Employee*)employee1)->nombre);
			strcpy(auxName2,((Employee*)employee2)->nombre);
			itsOk = strcmp(auxName1,auxName2);
		}


		return itsOk;
}

int controller_orderById(void* employee1, void* employee2)
{
	int itsOk = 0;

	if(employee1 != NULL && employee2 != NULL)
	{
		if(((Employee*)employee1)->id > ((Employee*)employee2)->id)
		{
			itsOk = 1;
		}
		else
		{
			if(((Employee*)employee1)->id < ((Employee*)employee2)->id)
			{
				itsOk = -1;
			}
		}
	}

    return itsOk;
}

