#ifndef CONTROLLER_H_INCLUDED
#define CONTROLLER_H_INCLUDED

#include "../inc/LinkedList.h"
int controller_loadFromText(char* path , LinkedList* pArrayListGamer);
int controller_loadFromBinary(char* path , LinkedList* pArrayListGamer);
int controller_addGamer(LinkedList* pArrayListGamer, int* pId);
int controller_editGamer(LinkedList* pArrayListGamer);
int controller_removeGamer(LinkedList* pArrayListGamer);
int controller_ListGamer(LinkedList* pArrayListGamer);
int controller_sortGamer(LinkedList* pArrayListGamer);
int controller_saveAsText(char* path , LinkedList* pArrayListGamer);
int controller_saveAsBinary(char* path , LinkedList* pArrayListGamer);
eGamer* controller_searchById(LinkedList* pArrayListGamer,int id, int* index);
int controller_orderByNick(void* gamer1,void* gamer2);
int controller_orderById(void* gamer1, void* gamer2);
int controller_popGamer(LinkedList* pArrayListGamer);
int controller_pushGamer(LinkedList* pArrayListGamer);
int controller_removeListGamer(LinkedList* pArrayListGamer);
int controller_clearListGamer(LinkedList* pArrayListGamer);
LinkedList* controller_cloneListGamer(LinkedList* pArrayListGamer);
#endif // CONTROLLER_H_INCLUDED
