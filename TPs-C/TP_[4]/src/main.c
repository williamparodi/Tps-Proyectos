/*
    utest example : Unit test examples.
    Copyright (C) <2018>  <Mauricio Davila>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Gamers.h"
#include "Inputs.h"
#include "Controller.h"
#include "../testing/inc/main_test.h"
#include "../inc/LinkedList.h"


int main(void)
{
        /*
        startTesting(1);  // ll_newLinkedList
        startTesting(2);  // ll_len
        startTesting(3);  // getNode - test_getNode
        startTesting(4);  // addNode - test_addNode
        startTesting(5);  // ll_add
        startTesting(6);  // ll_get
        startTesting(7);  // ll_set
        startTesting(8);  // ll_remove
        startTesting(9);  // ll_clear
        startTesting(10); // ll_deleteLinkedList
        startTesting(11); // ll_indexOf
        startTesting(12); // ll_isEmpty
        startTesting(13); // ll_push
        startTesting(14); // ll_pop
        startTesting(15); // ll_contains
        startTesting(16); // ll_containsAll
        startTesting(17); // ll_subList
        startTesting(18); // ll_clone
        startTesting(19); // ll_sort */

    int option = 0;
    int nextId = 0;

    LinkedList* listaGamers = ll_newLinkedList();
    LinkedList* listaGamersClone = NULL;

    do{
        switch(menu(option))
        {
            case 1:
            	if(!controller_loadFromText("data.csv",listaGamers))
            	{
            		printf("Hubo un problema al cargar los datos\n");
            	}
            	else
            	{
            		printf("Datos cargados con exito\n");
            	}
                break;
            case 2:
            	if(!controller_loadFromBinary("data.bin",listaGamers))
            	{
            		printf("Hubo un problema al cargar los datos\n");
            	}
            	else
            	{
            		printf("Datos cargados con exito\n");
            	}
            	break;
            case 3:
            	if(!controller_addGamer(listaGamers,&nextId))
            	{
            		printf("Hubo un problema al dar el alta\n");
            	}
            	else
            	{
            		printf("Alta exitosa\n");
            		system("pause");
            	}
            	break;
            case 4:
            	if(!controller_editGamer(listaGamers))
            	{
            		printf("Hubo un problema al modificar  el Gamer\n");
            	}
            	else
            	{
            		printf("Modificacion exitosa!\n");
            	}
            	break;
            case 5:
            	if(!controller_removeGamer(listaGamers))
            	{
            		printf("Hubo un problema al borrar el Gamer\n");
            	}
            	else
            	{
            		printf("Baja exitosa!\n");
            	}
            	break;
            case 6:
            	if(!controller_ListGamer(listaGamers))
            	{
            		printf("Hubo un problema al mostrar los gamers\n");
            	}
            	else
            	{
            		printf("\n");
            	}
            	break;
            case 7:
            	controller_sortGamer(listaGamers);
            	if(!controller_ListGamer(listaGamers))
            	{
            		printf("Hubo un problema al mostrar los gamers\n");
            	}
            	else
            	{
            		printf("Ordenado exitoso!\n");
            	}
            	break;
            case 8:
            	if(!controller_saveAsText("data.csv",listaGamers))
            	{
            		printf("Hubo un problema al guardar los datos\n");
            	}
            	else
            	{
            		printf("Datos guardados con exito\n");
            	}
            	break;
            case 9:
            	if(!controller_saveAsBinary("data.bin", listaGamers))
            	{
            		printf("Hubo un problema al guardar los datos\n");
            	}
            	else
            	{
            		printf("Datos guardados con exito\n");
            	}
            	break;
            case 10:
                if(!controller_popGamer(listaGamers))
                {
                    printf("Hubo un problema al borrar los datos\n");
                }
                else
                {
                    printf("Borra con exito!\n");
                }
                break;
            case 11:
                if(!controller_pushGamer(listaGamers))
                {
                    printf("Hubo un problema a insertar los datos\n");
                }
                else
                {
                   printf("Exito al hacer push!\n");
                }
                break;
            case 12:
                listaGamersClone = controller_cloneListGamer(listaGamers);
                if(listaGamersClone != NULL)
                {
                    printf("Clonado de lista con exito!\n");
                }
                else
                {
                    printf("Hubo un problema al clonar la lista\n");
                }
                break;
            case 13:
                if(!controller_clearListGamer(listaGamers))
                {
                     printf("Hubo un problema al borrar la lista\n");
                }
                else
                {
                    printf("Lista limpia!\n");
                }
                break;
            case 14:
                if(!controller_removeListGamer(listaGamers))
                {
                    printf("Hubo un problema al borrar la lista\n");
                }
                else
                {
                    printf("Borrado con exito!\n");
                }
            case 15:
            	option = 15;
            	break;
            default:
            	printf("Opcion invalida\n");
            	break;
        }

    }while(option != 15);

    return 0;
}



































