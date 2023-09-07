#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include "LinkedList.h"
#include "Employee.h"

///CONTRUCTORES
Employee* employee_new()
{
	Employee* employee_new = (Employee*) malloc(sizeof(Employee));

	if(employee_new != NULL)
	{
		employee_new->id = 0;
		strcpy(employee_new->nombre, " ");
		employee_new->horasTrabajadas = 0;
		employee_new->sueldo = 0;
	}

	return employee_new;
}

Employee* employee_newParametros(char* idStr,char* nombreStr,char* horasTrabajadasStr,char* sueldoStr)
{
	Employee* newEmployee = employee_new();

	if(newEmployee != NULL)
	{
		if(!(employee_setId(newEmployee,atoi(idStr))&&
		employee_setNombre(newEmployee,nombreStr)&&
		employee_setHorasTrabajadas(newEmployee,atoi(horasTrabajadasStr))&&
		employee_setSueldo(newEmployee,atoi(sueldoStr))))
		{
			free(newEmployee);
			newEmployee = NULL;
		}
	}

	return newEmployee;
}

void employee_delete(Employee* this)
{
	if(this != NULL)
	{
		free(this);
	}
}

/// Setters y Getters
int employee_setId(Employee* this,int id)
{
	int itsOk = 0;

	if(this != NULL && id >0)
	{
		this->id = id;
		itsOk=1;
	}

	return itsOk;
}

int employee_getId(Employee* this,int* id)
{
	int itsOk = 0;

	if(this != NULL && id != NULL)
	{
		*id = this->id;
		itsOk= 1;
	}

	return itsOk;
}

int employee_setNombre(Employee* this,char* nombre)
{
	int itsOk = 0;

	if(this != NULL && strlen(nombre)> 2 && strlen(nombre) <25)
	{
		strcpy(this->nombre,nombre);
		itsOk = 1;
	}

	return itsOk;
}

int employee_getNombre(Employee* this,char* nombre)
{
	int itsOk = 0;

	if(this != NULL && nombre != NULL)
	{
		strcpy(nombre,this->nombre);
		itsOk = 1;
	}

	return itsOk;
}

int employee_setHorasTrabajadas(Employee* this,int horasTrabajadas)
{
	int itsOk = 0;

	if(this != NULL && horasTrabajadas > 0)
	{
		this->horasTrabajadas = horasTrabajadas;
		itsOk = 1;
	}

	return itsOk;
}

int employee_getHorasTrabajadas(Employee* this,int* horasTrabajadas)
{
	int itsOk = 0;

	if(this != NULL && horasTrabajadas != NULL)
	{
		*horasTrabajadas = this->horasTrabajadas;
		itsOk = 1;
	}

	return itsOk;
}

int employee_setSueldo(Employee* this,int sueldo)
{
	int itsOk = 0;

	if(this != NULL && sueldo >0)
	{
		this->sueldo = sueldo;
		itsOk = 1;
	}

	return itsOk;
}

int employee_getSueldo(Employee* this,int* sueldo)
{
	int itsOk = 0;

	if(this != NULL && sueldo != NULL)
	{
	  *sueldo = this->sueldo;
	  itsOk = 1;
	}

	return itsOk;
}

int employee_listEmployee(Employee* this)
{
    int itsOk = 0;
    int id;
    char nombre[25];
    int horasTrabajadas;
    int sueldo;

    if(this != NULL)
    {
        if(employee_getId(this,&id)&&
           employee_getNombre(this,nombre)&&
           employee_getHorasTrabajadas(this,&horasTrabajadas)&&
           employee_getSueldo(this, &sueldo))
          {
              printf("%d   %-5s   %-5d  %d\n",this->id,this->nombre,this->horasTrabajadas,this->sueldo);
              itsOk = 1;
          }

    }

    return itsOk;
}




