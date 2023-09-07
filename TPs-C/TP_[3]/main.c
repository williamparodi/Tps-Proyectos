#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Controller.h"
#include "Employee.h"
#include "Inputs.h"

/****************************************************
    Menu:
     1. Cargar los datos de los empleados desde el archivo data.csv (modo texto).
     2. Cargar los datos de los empleados desde el archivo data.bin (modo binario).
     3. Alta de empleado
     4. Modificar datos de empleado
     5. Baja de empleado
     6. Listar empleados
     7. Ordenar empleados
     8. Guardar los datos de los empleados en el archivo data.csv (modo texto).
     9. Guardar los datos de los empleados en el archivo data.bin (modo binario).
    10. Salir
*****************************************************/



int main()
{
	setbuf(stdout,NULL);
    int option = 0;
    int nextId = 0;

    LinkedList* listaEmpleados = ll_newLinkedList();


    do{
        switch(menu(option))
        {
            case 1:
            	if(!controller_loadFromText("data.csv",listaEmpleados))
            	{
            		printf("Hubo un problema al cargar los datos\n");
            	}
            	else
            	{
            		printf("Datos cargados con exito\n");
            	}
                break;
            case 2:
            	if(!controller_loadFromBinary("data.bin",listaEmpleados))
            	{
            		printf("Hubo un problema al cargar los datos\n");
            	}
            	else
            	{
            		printf("Datos cargados con exito\n");
            	}
            	break;
            case 3:
            	if(!controller_addEmployee(listaEmpleados,&nextId))
            	{
            		printf("Hubo un problema al dar el alta\n");
            	}
            	else
            	{
            		printf("Alta exitosa\n");
            	}
            	break;
            case 4:
            	if(!controller_editEmployee(listaEmpleados))
            	{
            		printf("Hubo un problema al modificar el empleado\n");
            	}
            	else
            	{
            		printf("Modificacion exitosa!\n");
            	}
            	break;
            case 5:
            	if(!controller_removeEmployee(listaEmpleados))
            	{
            		printf("Hubo un problema al borrar el empleado\n");
            	}
            	else
            	{
            		printf("Baja exitosa!\n");
            	}
            	break;
            case 6:
            	if(!controller_ListEmployee(listaEmpleados))
            	{
            		printf("Hubo un problema al mostrar los empleado\n");
            	}
            	else
            	{
            		printf("\n");
            	}
            	break;
            case 7:
            	controller_sortEmployee(listaEmpleados);
            	if(!controller_ListEmployee(listaEmpleados))
            	{
            		printf("Hubo un problema al mostrar los empleado\n");
            	}
            	else
            	{
            		printf("Ordenado exitoso!\n");
            	}
            	break;
            case 8:
            	if(!controller_saveAsText("data.csv",listaEmpleados))
            	{
            		printf("Hubo un problema al guardar los datos\n");
            	}
            	else
            	{
            		printf("Datos guardados con exito\n");
            	}
            	break;
            case 9:
            	if(!controller_saveAsBinary("data.bin", listaEmpleados))
            	{
            		printf("Hubo un problema al guardar los datos\n");
            	}
            	else
            	{
            		printf("Datos guardados con exito\n");
            	}
            	break;
            case 10:
            	option = 10;
            	break;
            default:
            	printf("Opcion invalida\n");
            	break;
        }
    }while(option != 10);

    return 0;
}

