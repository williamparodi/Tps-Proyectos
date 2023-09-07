#ifndef JUGADORES_H_INCLUDED
#define JUGADORES_H_INCLUDED

typedef struct
{
    int id;
    char nickName[25];
    int horasJugadas;
    int score;

}eGamer;

eGamer* gamer_new();
eGamer* gamer_newParametros(char* idStr,char* nickStr,char* horasJugadasStr,char* scoreStr);
void gamer_delete(eGamer* this);
int gamer_setId(eGamer* this,int id);
int gamer_getId(eGamer* this,int* id);
int gamer_setNick(eGamer* this,char* nick);
int gamer_getNick(eGamer* this,char* nick);
int gamer_setHorasJugadas(eGamer* this,int horasJugadas);
int gamer_getHorasJugadas(eGamer* this,int* horasJugadas);
int gamer_setScore(eGamer* this,int score);
int gamer_getScore(eGamer* this,int* sueldo);
int gamer_listGamer(eGamer* this);


#endif // JUGADORES_H_INCLUDED
