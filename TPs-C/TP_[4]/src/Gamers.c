#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Gamers.h"

///CONTRUCCTORES
eGamer* gamer_new()
{
	eGamer* gamer_new = (eGamer*) malloc(sizeof(eGamer));

	if(gamer_new != NULL)
	{
		gamer_new->id = 0;
		strcpy(gamer_new->nickName, " ");
		gamer_new->horasJugadas = 0;
		gamer_new->score = 0;
	}

	return gamer_new;
}

eGamer* gamer_newParametros(char* idStr,char* nickStr,char* horasJugadasStr,char* scoreStr)
{
	eGamer* newGamer = gamer_new();

	if(newGamer != NULL)
	{
		if(!(gamer_setId(newGamer,atoi(idStr))&&
		gamer_setNick(newGamer,nickStr)&&
		gamer_setHorasJugadas(newGamer,atoi(horasJugadasStr))&&
		gamer_setScore(newGamer,atoi(scoreStr))))
		{
			free(newGamer);
			newGamer = NULL;
		}
	}

	return newGamer;
}

void gamer_delete(eGamer* this)
{
	if(this != NULL)
	{
		free(this);
	}
}

/// Setters y Getters
int gamer_setId(eGamer* this,int id)
{
	int itsOk = 0;

	if(this != NULL && id >0)
	{
		this->id = id;
		itsOk=1;
	}

	return itsOk;
}

int gamer_getId(eGamer* this,int* id)
{
	int itsOk = 0;

	if(this != NULL && id != NULL)
	{
		*id = this->id;
		itsOk= 1;
	}

	return itsOk;
}

int gamer_setNick(eGamer* this,char* nick)
{
	int itsOk = 0;

	if(this != NULL && strlen(nick)> 2 && strlen(nick) <25)
	{
		strcpy(this->nickName,nick);
		itsOk = 1;
	}

	return itsOk;
}

int gamer_getNick(eGamer* this,char* nick)
{
	int itsOk = 0;

	if(this != NULL && nick != NULL)
	{
		strcpy(nick,this->nickName);
		itsOk = 1;
	}

	return itsOk;
}

int gamer_setHorasJugadas(eGamer* this,int horasJugadas)
{
	int itsOk = 0;

	if(this != NULL && horasJugadas > 0)
	{
		this->horasJugadas = horasJugadas;
		itsOk = 1;
	}

	return itsOk;
}

int gamer_getHorasJugadas(eGamer* this,int* horasJugadas)
{
	int itsOk = 0;

	if(this != NULL && horasJugadas != NULL)
	{
		*horasJugadas  = this->horasJugadas;
		itsOk = 1;
	}

	return itsOk;
}

int gamer_setScore(eGamer* this,int score)
{
	int itsOk = 0;

	if(this != NULL && score >0)
	{
		this->score = score;
		itsOk = 1;
	}

	return itsOk;
}

int gamer_getScore(eGamer* this,int* score)
{
	int itsOk = 0;

	if(this != NULL && score != NULL)
	{
	  *score = this->score;
	  itsOk = 1;
	}

	return itsOk;
}

int gamer_listGamer(eGamer* this)
{
    int itsOk = 0;
    int id;
    char nickName[25];
    int horasJugadas;
    int score;

    if(this != NULL)
    {
        if(gamer_getId(this,&id)&&
           gamer_getNick(this,nickName)&&
           gamer_getHorasJugadas(this,&horasJugadas)&&
           gamer_getScore(this, &score))
          {
              printf("%d   %-5s   %-5d  %d\n",this->id,this->nickName,this->horasJugadas,this->score);
              itsOk = 1;
          }

    }

    return itsOk;
}






