#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "../inc/LinkedList.h"
#include "Gamers.h"
#include "Inputs.h"
#include "Parser.h"
#include "Controller.h"

/** \brief Carga los datos de los gamers desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromText(char* path , LinkedList* pArrayListGamer)
{

	FILE* f = fopen(path,"r");

	int itsOk = 0;

	if(f != NULL && pArrayListGamer != NULL)
	{
		if(parser_gamerFromText(f, pArrayListGamer))
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
int controller_loadFromBinary(char* path , LinkedList* pArrayListGamer)
{

		FILE* f = fopen(path,"rb");

		int itsOk = 0;

		if(f != NULL && pArrayListGamer != NULL)
		{
			if(parser_gamerFromBinary(f, pArrayListGamer))
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
int controller_addGamer(LinkedList* pArrayListGamer, int* pId)
{

	eGamer* auxGamer;

	char nickName[20];
	int horasJugadas;
	int score;
	int itsOk = 0;

	auxGamer = gamer_new();

	if(pArrayListGamer != NULL && pId != NULL)
	{
		(*pId)++;

		ingresarString("Ingrese Nick Name: ",nickName);

		while(!gamer_setNick(auxGamer, nickName))
		{
			ingresarString("Error,ingrese Nick Name: ",nickName);
		}

		horasJugadas = ingresarInt("Ingrese cantidad de horas Jugadas: ");

		while(!gamer_setHorasJugadas(auxGamer, horasJugadas))
		{
			horasJugadas = ingresarInt("Error, Ingrese cantidad de horas jugadas: ");
		}

		score = ingresarInt("Ingrese score: ");

		while(!gamer_setScore(auxGamer, score))
		{
			score = ingresarInt("Error, Ingrese score: ");
		}

		auxGamer = gamer_new();

		if(auxGamer != NULL)
		{
			if(gamer_setId(auxGamer, *pId)&&
			gamer_setNick(auxGamer, nickName)&&
			gamer_setHorasJugadas(auxGamer, horasJugadas)&&
			gamer_setScore(auxGamer, score))
			{
				ll_add(pArrayListGamer,auxGamer);
				itsOk = 1;
			}
			else
			{
				free(auxGamer);
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
int controller_editGamer(LinkedList* pArrayListGamer)
{
	eGamer* auxGamer;

	int itsOk = 0;
	int index = -1;
	char choice = 's';
	int option;
	int id;
	char auxNick[100];
	int auxHorasJugadas;
	int auxScore;


	if(pArrayListGamer != NULL)
	{

		id = ingresarInt("Ingrese el id del Gamer a modificar : ");

		auxGamer = controller_searchById(pArrayListGamer, id, &index);

		if(index == - 1)
		{
			printf("No se encontro ese Id\n");
		}
		else
		{
			printf("Id del Gamer a modificar: %d \n",id);

			do
			{
				option = ingresarInt("Elija el campo a modificar: 1-Nick Name 2-Horas Jugadas 3-Score 4-Salir ");

				while(!validarMinMax(option,1,4))
				{
					option = ingresarInt("Error, Elija el campo a modificar: 1-Nick Name 2-Horas Jugadas 3-Score 4-Salir ");
				}

				switch(option)
				{

					case 1:
						ingresarString("Modifique el nick name : ", auxNick);
						while(strlen(auxNick) > 15)
						{
							ingresarString("Error, Ingresar nick name : ", auxNick);
						}

						gamer_setNick(auxGamer, auxNick);
						break;
					case 2:
						auxHorasJugadas = ingresarInt("Modifique la cantidad de horas jugadas: ");
						while(auxHorasJugadas < 0)
						{
							auxHorasJugadas = ingresarInt("Error, Ingrese cantidad de horas jugadas: ");
						}
						gamer_setHorasJugadas(auxGamer, auxHorasJugadas);
						break;
					case 3:
						auxScore = ingresarInt("Modifique el Score : ");
						while(auxScore < 1000)
						{
							auxScore = ingresarInt("Error, score solamente superior de 1000, Modifique el score : ");
						}
						gamer_setScore(auxGamer, auxScore);
						break;
					case 4:
						choice = 'n';
						break;
					default:
						printf("Opcion invalida\n");
						break;
				}

			}while(choice == 's');

			if(gamer_setNick(auxGamer,auxNick)&&
                gamer_setHorasJugadas(auxGamer,auxHorasJugadas)&&
                gamer_setScore(auxGamer,auxScore))
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
int controller_removeGamer(LinkedList* pArrayListGamer)
{

		int index = -1;//
		eGamer* auxGamer = NULL;
		char choice;
		int itsOk = 0;
		int id;

        if(pArrayListGamer != NULL)
		{
			controller_ListGamer(pArrayListGamer);

			id = ingresarInt("Ingresa ID: ");

			while(id < 0 )
			{
				id = ingresarInt("Error ID invalido, Ingresa ID: ");

			}

			auxGamer = controller_searchById(pArrayListGamer,id,&index);

			if(index != -1)
			{
				printf("\n 	Borar Gamer \n");
				printf("---------------------------------------\n");
				printf(" ID Nick Name Horas Jugadas Score      \n");
				printf("----------------------------------------\n");
				gamer_listGamer(auxGamer);
				printf("Queres remover a este Gamer? s/n: ");
				fflush(stdin);
				scanf(" %c",&choice);
				choice = tolower(choice);

				if(choice == 's')
				{
					if(ll_remove(pArrayListGamer,index) == 0)
					{
						printf("-- Gamer removido --\n");
					}
					gamer_delete(auxGamer);
				}
				else
				{
					printf("-- No se borro los datos del Gamer--\n");
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
int controller_ListGamer(LinkedList* pArrayListGamer)
{
	int itsOk = 0;
	int len = ll_len(pArrayListGamer);
	eGamer* auxGamer;

	if(pArrayListGamer != NULL && len >0)
	{
		printf("-------------------------------------\n");
		printf("ID  Nick Name  Horas Jugadas  Score \n");

		for(int i=0;i < len; i++)
		{
			auxGamer = ll_get(pArrayListGamer,i);
			gamer_listGamer(auxGamer);
		}
		printf("\n\n");
		itsOk = 1;
	}

	return itsOk;

}

/** \brief Ordenar gamers
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_sortGamer(LinkedList* pArrayListGamer)
{

		int itsOk = 0;
		int option;
		int order;

		if (pArrayListGamer != NULL)
		{
			itsOk = 1;
			printf("Ordenar Gamers\n");
			order = ingresarInt("Eliga Orden : 0 Down, 1 Up ");
			while(order < 0 || order > 1)
			{
				order = ingresarInt("Error,Orden :  0 Down, 1 Up  ");
			}

			 option= ingresarInt("Ingresar opcion: 1-Ordenar por Id, 2-Ordenar por nick, 3-Salir");
			while( option < 1 ||  option > 5)
			{
				 option = ingresarInt("Ingresar opcion: 1-Ordenar por Id, 2-Ordenar por nick, 3-Salir");
			}

			switch (option)
			{
			case 1:
				ll_sort( pArrayListGamer, controller_orderById, order);
				break;
			case 2:
				ll_sort( pArrayListGamer, controller_orderByNick, order);
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
int controller_saveAsText(char* path , LinkedList* pArrayListGamer)
{
	int itsOk = -1;
	int len;
	int auxId;
	char auxNickName[25];
	int auxHorasJugadas;
	int auxScore;

	eGamer* auxGamer;

	FILE* f = fopen(path,"w");

	if(f != NULL)
	{
		len = ll_len(pArrayListGamer);

		for(int i= 0;i<len;i++)
		{
			auxGamer = ll_get(pArrayListGamer,i);
			if(gamer_getId(auxGamer, &auxId)&&
						gamer_getNick(auxGamer, auxNickName)&&
						gamer_getHorasJugadas(auxGamer, &auxHorasJugadas)&&
						gamer_getScore(auxGamer, &auxScore))
						{
							fprintf(f,"%d,%s,%d,%d\n",auxId,auxNickName,auxHorasJugadas,auxScore);
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
int controller_saveAsBinary(char* path , LinkedList* pArrayListGamer)
{
	int itsOk;
	int len;
	int cantidad;
	int i = 0;
	eGamer* auxGamer;
	FILE* f = fopen(path,"wb");

	if(f != NULL)
	{
		len = ll_len(pArrayListGamer);

		while(i < len)
		{
			auxGamer = ll_get(pArrayListGamer,i);

			if(auxGamer != NULL)
			{
				cantidad = fwrite(auxGamer,sizeof(eGamer),1,f);
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

eGamer* controller_searchById(LinkedList* pArrayListGamer,int id, int* index)
{
	eGamer* auxGamer;
	int len = ll_len(pArrayListGamer);
	int auxId;
	*index = -1;

	if(pArrayListGamer != NULL && len > 0)
	{
		for(int i = 0; i < len ; i++)
		{
			auxGamer =  ll_get(pArrayListGamer,i);
			gamer_getId(auxGamer, &auxId);
			if(id ==auxId && auxGamer != NULL)
			{
				(*index) = i;
				break;
			}
		}
	}
	return auxGamer;
}

int controller_orderByNick(void* gamer1,void* gamer2)
{
		int itsOk = 0;
		char auxNick1[20];
		char auxNick2[20];

		if(gamer1!= NULL && gamer2 != NULL)
		{
			strcpy(auxNick1,((eGamer*)gamer1)->nickName);
			strcpy(auxNick2,((eGamer*)gamer2)->nickName);
			itsOk = strcmp(auxNick1,auxNick2);
		}

        return itsOk;
}

int controller_orderById(void* gamer1, void* gamer2)
{
	int itsOk = 0;

	if(gamer1 != NULL && gamer2 != NULL)
	{
		if(((eGamer*)gamer1)->id > ((eGamer*)gamer2)->id)
		{
			itsOk = 1;
		}
		else
		{
			if(((eGamer*)gamer1)->id < ((eGamer*)gamer2)->id)
			{
				itsOk = -1;
			}
		}
	}

    return itsOk;
}

int controller_popGamer(LinkedList* pArrayListGamer)
{
    int itsOk = 0;
    int index;
    int id;
    char choice;
    eGamer* auxGamer = NULL;

    if(pArrayListGamer != NULL)
    {
        controller_ListGamer(pArrayListGamer);

        id= ingresarInt("Ingrese un Id a Remover: ");

        auxGamer = controller_searchById(pArrayListGamer,id,&index);

        if(index == -1)
        {
            printf("No existe ese id\n");
        }
        else
        {
            printf("\n 	Pop Gamer \n");
            printf("---------------------------------------\n");
            printf(" ID Nick Name Horas Jugadas Score      \n");
            printf("----------------------------------------\n");
            gamer_listGamer(auxGamer);
            printf("Queres remover a este Gamer? s/n: ");
            fflush(stdin);
            scanf("%c",&choice);
            choice = tolower(choice);
            if(choice == 's')
            {
               auxGamer = (eGamer*) ll_pop(pArrayListGamer,index);
               if(auxGamer != NULL)
               {
                   printf("-- Gamer Borrado! --\n");
                   itsOk = 1;
               }
               else
               {
                   printf("Error al borrar \n");
               }

            }
            else
            {
                printf("-- No se borro los datos del Gamer--\n");
            }

        }

    }

    return itsOk;

}

int controller_pushGamer(LinkedList* pArrayListGamer)
{
    eGamer* auxGamer = NULL;
    char nickName[50];
	int horasJugadas;
	int score;
	int itsOk;
	int index;
	int id = 0;

    auxGamer = gamer_new();

	if(pArrayListGamer != NULL)
	{
		id++;

		ingresarString("Ingrese Nick Name: ",nickName);

		while(!gamer_setNick(auxGamer, nickName))
		{
			ingresarString("Error,ingrese Nick Name: ",nickName);
		}

		horasJugadas = ingresarInt("Ingrese cantidad de horas Jugadas: ");

		while(!gamer_setHorasJugadas(auxGamer, horasJugadas))
		{
			horasJugadas = ingresarInt("Error, Ingrese cantidad de horas jugadas: ");
		}

		score = ingresarInt("Ingrese score: ");

		while(!gamer_setScore(auxGamer, score))
		{
			score = ingresarInt("Error, Ingrese score: ");
		}

        index = ingresarInt("Elija la posicion a sobreescribir\n");

		if(auxGamer != NULL)
		{
			if(gamer_setId(auxGamer,id)&&
			gamer_setNick(auxGamer, nickName)&&
			gamer_setHorasJugadas(auxGamer, horasJugadas)&&
			gamer_setScore(auxGamer, score))
			{
				if(ll_push(pArrayListGamer,index,auxGamer)== -1)
                {
                    printf("No existe esa posicion\n");
                    itsOk = 0;
                }
                else
                {
                    printf("Datos del nuevo gamer ingresados\n");
                    itsOk = 1;
                }

			}
			else
			{
				free(auxGamer);
				itsOk = -1;
			}

		}

	}

	 return itsOk;
}

int controller_removeListGamer(LinkedList* pArrayListGamer)
{
    int itsOk = -1;
    char choice;

    if(pArrayListGamer != NULL)
    {
        system("cls");
        printf("---------------------------------------\n");
        printf("\n 	Borrar Lista Pro Gamer \n");
        printf("---------------------------------------\n");
        controller_ListGamer(pArrayListGamer);
        printf("Esta seguro que quiere borrar esta lista ? s/n: ");
        fflush(stdin);
        scanf("%c",&choice);
        choice = tolower(choice);
        if(choice == 's')
        {
            if(ll_deleteLinkedList(pArrayListGamer)==0)
            {
                printf("Lista Borrada!\n");
                itsOk = 1;
            }
            else
            {
                printf("Hubo un error\n");
            }

        }
        else
        {
            printf("--Borrado de lista cancelado \n");
            itsOk = 0;
        }

    }

    return itsOk;
}

int controller_clearListGamer(LinkedList* pArrayListGamer)
{
    int itsOk = -1;
    char choice;

    if(pArrayListGamer != NULL)
    {
        system("cls");
        printf("---------------------------------------\n");
        printf("\n 	Limpiar la Lista Pro Gamer \n");
        printf("---------------------------------------\n");
        controller_ListGamer(pArrayListGamer);
        printf("Esta seguro que quiere limpiar la lista ? s/n: ");
        fflush(stdin);
        scanf("%c",&choice);
        choice = tolower(choice);
        if(choice == 's')
        {
            if(ll_isEmpty(pArrayListGamer)== 0)
            {
                if(ll_clear(pArrayListGamer)== 0)
                {
                     printf("Lista Borrada!\n");
                     itsOk = 1;
                }
                else
                {
                    printf("Ocurrio un error\n");
                }

            }
            else
            {
                printf("La lista no contiene datos a borrar\n");
            }

        }
        else
        {
            printf("--Limpieza de lista cancelada \n");
            itsOk = 0;
        }

    }

    return itsOk;
}

LinkedList* controller_cloneListGamer(LinkedList* pArrayListGamer)
{
    LinkedList* auxClone = NULL;
    char choice;
    if(pArrayListGamer != NULL)
    {
        system("cls");
        printf("------------------------------\n");
        printf("Clonar la Lista Pro Gamer \n");
        printf("------------------------------\n");
        controller_ListGamer(pArrayListGamer);
        printf("Esta seguro que quiere clonar la lista ? s/n: ");
        fflush(stdin);
        scanf("%c",&choice);
        choice = tolower(choice);
        if(choice == 's')
        {
            if(ll_isEmpty(pArrayListGamer)== 0)
            {
                auxClone = ll_clone(pArrayListGamer);
                if(auxClone != NULL)
                {
                     printf("Lista Clonada!\n");
                }

            }
            else
            {
                printf("La lista no contiene datos a clonar\n");
            }

        }
        else
        {
            printf("--Clonado de lista cancelado \n");
        }

    }

    return auxClone;
}











