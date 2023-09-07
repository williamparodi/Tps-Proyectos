/*
 ============================================================================
 Name        : TP_[2].c
 Author      : William Parodi
 Version     :
 Copyright   : Your copyright notice
 Description : Trabajo Practico 2
 ============================================================================
 */
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "Inputs.h"
#include "ArrayEmployees.h"

#define LEN 2000
#define UP 1
#define DOWN 0

int main()
{

	setbuf(stdout, NULL);
    char choice = 's';
    int nextId = 999;
    char name[51];
    char lastName[51];
    float salary;
    int sector;
    int employeeCount = 0;
    float SalaryAccumulator = 0;
    int countAboveSalary = 0;
    float averageSalary;
    int optionSalaryList;
    int orderList;
    Employee list[LEN];


    if(initEmployees(list,LEN) == -1)
    {
        printf("Error\n");
    }

    do
    {

        switch(menu())
        {
            case 1:
                if(findEmpty(list,LEN)== -1)
                {
                    printf("Error, no se pudo dar el alta\n");
                }
                else
                {
                	chargeDataEmployees(&nextId,name,lastName,&salary,&sector);
                	addEmployees(list,LEN,nextId,name,lastName,salary,sector);
                	printf("Alta Exitosa!\n");
                    countEmployee(list,LEN,&employeeCount);
                }
                break;
            case 2:
                if(employeeCount == 0)
                {
                    printf("No hay empleados cargados,deberia cargar datos primero\n");
                }
                else
                {
                    if(!changeDataEmployee(list,nextId,LEN))
                    {
                        printf("No se pudo cambiar los datos del empleado\n");
                    }
                    else
                    {
                        printf("Modificacion exitosa!\n");

                    }
                }
                break;
            case 3:
                if(employeeCount == 0)
                {
                    printf("No hay empleados cargados,deberia los cargar datos primero\n");
                }
                else
                {
                   if(removeEmployee(list,nextId,LEN) == -1)
                    {
                        printf("Error, no se pudo dar de baja el id\n");
                    }
                    else
                    {
                        printf("Baja exitosa!\n");
                        employeeCount--;
                    }
                }
                break;
            case 4:
                if(employeeCount == 0)
                {
                    printf("No hay empleados cargados,deberia cargar los datos primero\n");
                }
                else
                {
                    optionSalaryList = ingresarInt("Elija una opcion : 1-Listado de empleados o 2-Informacion de Salarios totales y promedio ");

                    switch(optionSalaryList)
                    {
                        case 1:
                            orderList = order(UP,DOWN);
                            if(orderList == UP)
                            {
                               sortEmployees(list,LEN,UP);
                               printEmployees(list,LEN);
                            }
                           else
                            {
                               sortEmployees(list,LEN,DOWN);
                               printEmployees(list,LEN);
                            }
                            break;
                        case 2:
                            accumulateSalary(list,LEN,&SalaryAccumulator);
                            calculateAverageSalary(SalaryAccumulator,employeeCount,&averageSalary);
                            calculateAboveAverageSalary(list,LEN,averageSalary,&countAboveSalary);
                            printSalaryAverageTotal(SalaryAccumulator,averageSalary,countAboveSalary);
                            break;
                        default:
                            printf("Opcion invalida\n");
                            break;
                    }


                }
                break;
            case 5:
                choice = 'n';
                break;
            default:
                printf("Opcion Invalida\n");
                break;
        }


    }while(choice == 's');

    return 0;
}

